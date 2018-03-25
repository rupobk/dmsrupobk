using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IronOcr;
using System.Reflection;
using Gnostice.Documents;
using Gnostice.Documents.Controls.WinForms;
using System.Globalization;

namespace DMSRupObk
{
    public partial class frmDokBearbeiten : Form
    {
        private string pfadOrgDatei;
        private string neuerDateiname;
        private string zielPfad;
        private string extension;
        public ProgParam PrgPrm = ProgParam.Erstellen();
        public enum MomentanerDokumentenStatus { undefiniert, neuesDokument, inBearbeitung, importiert }
        public MomentanerDokumentenStatus DokStatus = MomentanerDokumentenStatus.undefiniert;
        public Dokument tmpDok;
        public bool BearbeitungAbgebrochen { get; set; } = false;

        public frmDokBearbeiten()
        {
            DokStatus = MomentanerDokumentenStatus.neuesDokument;
            InitializeComponent();
            FormularClear();
            FelderInitialisieren(DokStatus);
            this.ShowDialog();
        }

        /// Konstruktor der für bestehende Dokumente aufgerufen wird
        public frmDokBearbeiten(Dokument dok) //: this()    //this ruft Hauptkonstruktor auf u. wird für bestehende Dok. aufgerufen
        {
            DokStatus = MomentanerDokumentenStatus.inBearbeitung;
            InitializeComponent();
            FormularClear();
            FelderInitialisieren(DokStatus);
            FelderZuweisen(dok);
            tmpDok = dok;
            this.ShowDialog();
            this.Close();
        }

        /// Konstruktor der für zu importierende Dokumente aufgerufen wird
        public frmDokBearbeiten(string datei)
        {
            DokStatus = MomentanerDokumentenStatus.importiert;
            InitializeComponent();
            FormularClear();
            FelderInitialisieren(DokStatus);
            pfadOrgDatei = Path.Combine(PrgPrm.RootVerzeichnisDok, PrgPrm.ImportVerzeichnisDok, datei);
            documentViewer1.LoadDocument(pfadOrgDatei);
            this.ShowDialog();
            this.Close();
        }

        private void FelderZuweisen(Dokument dok)
        {
            lblDokID.Text = dok.DokID.ToString();
            txtVerschlagwort.Text = dok.Verschlagwortung;
            txtPeriode.Text = dok.Periode;
            txtJahr.Text = dok.Jahr.ToString();
            txtDateiname.Text = dok.Dateiname;
            dtpArchivierung.Text = dok.Archivierungsdatum.ToString("dd.MM.yyyy");
            dtpAenderung.Text = dok.Aenderungsdatum.ToString("dd.MM.yyyy");

            ComboboxenAufbauen();

            // Relativen Index des Eintrages in der sortierten Combobox suchen
            int x = 0;
            foreach (Dokumentenart da in cbDokArt.Items)
            {
                if (da.Key == dok.DokumentenartKey)
                    break;
                else
                    x++;
            }
            cbDokArt.SelectedIndex = x;

            x = 0;
            foreach (Lieferant li in cbLieferant.Items)
            {
                if (li.Key == dok.LieferantKey)
                    break;
                else
                    x++;
            }
            cbLieferant.SelectedIndex = x;

            cbZielpfad.SelectedIndex = cbZielpfad.Items.IndexOf(dok.Pfad);
            cbDokArt.Text = dok.Dokumentenstatus;

            string pfad = Path.Combine(PrgPrm.RootVerzeichnisDok, dok.Pfad, dok.Dateiname);
            documentViewer1.LoadDocument(pfad);

            btnSpeichern.Enabled = true;
            btnOCRScan.Enabled = true;
            btnLaden.Enabled = true;
            btnClear.Enabled = true;

            tableLayoutPanelLinks.Enabled = true;
        }

        private void FormularClear()
        {
            lblDokID.Text = string.Empty;
            cbDokArt.DataSource = null;
            cbLieferant.DataSource = null;
            cbStatus.DataSource = null;
            cbZielpfad.DataSource = null;
            dtpArchivierung.Text = string.Empty;
            dtpAenderung.Text = string.Empty;
            txtDateiname.Text = string.Empty;
            txtJahr.Text = string.Empty;
            txtPeriode.Text = string.Empty;
            txtVerschlagwort.Text = string.Empty;
            txtVolltext.Text = string.Empty;
            tableLayoutPanelLinks.Enabled = false;
        }

        private void FelderInitialisieren(MomentanerDokumentenStatus DokStatus)
        {
            if (DokStatus == MomentanerDokumentenStatus.neuesDokument || DokStatus == MomentanerDokumentenStatus.importiert)
                lblDokID.Text = PrgPrm.DokIDGenerieren().ToString();

            ComboboxenAufbauen();
            txtPeriode.Text = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString();
            txtJahr.Text = DateTime.Today.Year.ToString();
            btnOCRScan.Enabled = false;
            cbStatus.SelectedIndex = 0;
            tableLayoutPanelLinks.Enabled = true;
            dtpArchivierung.Value = DateTime.Now;
            dtpAenderung.Value = DateTime.Now;
        }

        private void ComboboxenAufbauen()
        {
            //cbDokArt.DataSource = PrgPrm.AlleDokumentenarten.OrderBy(o => o.Name).ToList();
            cbDokArt.DataSource = PrgPrm.AlleDokumentenarten;
            cbDokArt.DisplayMember = "Name";
            cbDokArt.ValueMember = "Key";
            //cbLieferant.SelectedIndex = 5;

            cbLieferant.DataSource = PrgPrm.AlleLieferanten.OrderBy(o => o.Name).ToList();
            cbLieferant.DisplayMember = "Name";
            cbLieferant.ValueMember = "Key";
            //cbLieferant.SelectedIndex = 0;

            PrgPrm.Ordner.Sort();
            cbZielpfad.DataSource = PrgPrm.Ordner;
            //cbLieferant.SelectedIndex = 0;

            cbStatus.DataSource = PrgPrm.Dokumentenstatus;
            cbDokArt.SelectedIndex = 1;
        }

        private void btnLaden_Click(object sender, EventArgs e)
        {
            DateiLaden();
        }

        private bool DateiLaden()
        // Macht Filedialog u. zeigt Dokument hinterher an falls Dokument gewählt
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
            {
                pfadOrgDatei = ofd.FileName;
                zielPfad = PrgPrm.RootVerzeichnisDok + cbZielpfad.SelectedValue;
                extension = Path.GetExtension(ofd.SafeFileName);
                btnOCRScan.Enabled = true;
                txtVolltext.Text = "";
                Cursor = Cursors.WaitCursor;
                try
                {
                    documentViewer1.LoadDocument(pfadOrgDatei);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
                return true;
            }
            else
            {
                btnOCRScan.Enabled = false;
                return false;
            }
        }

        private void btnOCRScan_Click(object sender, EventArgs e)
        {
            if (File.Exists(pfadOrgDatei))
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                    var Ocr = new AutoOcr();
                    var Result = Ocr.ReadPdf(pfadOrgDatei);
                    txtVolltext.Text = Result.Text;
                    btnOCRScan.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kann die OCR-Erkennung nicht durchführen. Fehler:" + ex.Message + "\nProgramm wird beendet ...");
                    Environment.Exit(1);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
            else
                MessageBox.Show("Noch keine Datei zum archivieren gewählt!", "Fehler!");
        }

        //TODO: ist noch zu testen!
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (FelderPruefungOk())
            {
                if (DokStatus == MomentanerDokumentenStatus.neuesDokument || DokStatus == MomentanerDokumentenStatus.importiert)
                // Dokument wurde neu erstellt u. ist damit neu zu speichern
                {
                    int DokID = int.Parse(lblDokID.Text);
                    int LiefKey = 0;
                    string LiefName = "";
                    if (!string.IsNullOrEmpty(cbLieferant.Text))
                    {
                        LiefKey = (int)cbLieferant.SelectedValue;
                        LiefName = cbLieferant.Text;
                    }

                    string Per = "";
                    if (!string.IsNullOrEmpty(txtPeriode.Text))
                        Per = txtPeriode.Text;

                    // Dokumentenviewer schliessen, damit das Dokument verschoben werden kann
                    if (documentViewer1.Created)
                        documentViewer1.CloseDocument();

                    Dokument dok = new Dokument(DokID, (int)cbDokArt.SelectedValue, cbDokArt.Text, cbZielpfad.Text, neuerDateiname, extension,
                                                txtVerschlagwort.Text, int.Parse(txtJahr.Text), cbStatus.Text, dtpArchivierung.Value,
                                                dtpAenderung.Value, LiefKey, LiefName, Per);

                    if (!string.IsNullOrEmpty(txtVolltext.Text))
                    {
                        Volltextindex vti = new Volltextindex(DokID, txtVolltext.Text, cbZielpfad.Text, neuerDateiname, extension);
                        Volltext.Erstellen().Speichern();
                    }

                    PrgPrm.AnzahlArchivierteDokumente++;
                    FileInfo fi = new FileInfo(pfadOrgDatei);
                    PrgPrm.DokDatengroesseInKB += Convert.ToDecimal(fi.Length / 1024d);

                    FileInfo fi2 = new FileInfo(Volltext.PfadJsonVolltext);
                    PrgPrm.VolltextDatengroesseInKB = Convert.ToDecimal(fi2.Length / 1024d);

                    // verschiebt Dokument in richtigen Ordner -> Pfad setzen 
                    string zielpfad = Path.Combine(PrgPrm.RootVerzeichnisDok, dok.Pfad, dok.Dateiname);
                    File.Move(pfadOrgDatei, zielpfad);

                    Archiv.Erstellen().Speichern();
                    PrgPrm.Schreiben();
                }
                else
                // Dokument wurde editiert, Änderungen prüfen u. speichern
                {
                    // Dokumentenviewer schliessen, damit das Dokument verschoben werden kann
                    if (documentViewer1.Created)
                        documentViewer1.CloseDocument();
                    tmpDok.DokumentenartKey = (int)cbDokArt.SelectedValue;
                    tmpDok.DokumentenartName = cbDokArt.Text;
                    tmpDok.LieferantKey = (int)cbLieferant.SelectedValue;
                    tmpDok.LieferantName = cbLieferant.Text;
                    tmpDok.Verschlagwortung = txtVerschlagwort.Text;
                    tmpDok.Periode = txtPeriode.Text;
                    tmpDok.Jahr = int.Parse(txtJahr.Text);
                    tmpDok.Aenderungsdatum = DateTime.Today;

                    // Wenn sich Dokumentenpfad geändert hat, dann Dokument dort hin verschieben
                    if (tmpDok.Pfad != cbZielpfad.Text || tmpDok.Dateiname != txtDateiname.Text)
                    {
                        try
                        {
                            File.Move(Path.Combine(PrgPrm.RootVerzeichnisDok, tmpDok.Pfad, tmpDok.Dateiname),
                                      Path.Combine(PrgPrm.RootVerzeichnisDok, cbZielpfad.Text, tmpDok.Dateiname));
                            tmpDok.Pfad = cbZielpfad.Text;
                            tmpDok.Dateiname = txtDateiname.Text;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Kann Dokument nicht verschieben. Fehler:" + ex.Message + "\nProgramm wird beendet ...");
                            Environment.Exit(1);
                        }
                    }

                    List<Dokument> alledok = Archiv.Erstellen().alleDokumente;
                    var index = alledok.FindIndex(c => c.DokID == tmpDok.DokID);
                    alledok[index] = tmpDok;
                    Archiv.Erstellen().Speichern();

                    //Todo: noch zu machen
                    // alleRechnungen aktualisieren
                }
                this.Close();
            }
        }

        private bool FelderPruefungOk()
        {
            // auf Pflichtfelder leer kontrollieren
            if (string.IsNullOrEmpty(cbDokArt.Text) || string.IsNullOrEmpty(cbZielpfad.Text) || string.IsNullOrEmpty(txtVerschlagwort.Text) ||
                string.IsNullOrEmpty(txtJahr.Text) || string.IsNullOrEmpty(cbStatus.Text))
            {
                MessageBox.Show("Die Pflichteingabefelder sind nicht alle gefüllt!");
                if (string.IsNullOrEmpty(cbDokArt.Text))
                    cbDokArt.Focus();
                else if (string.IsNullOrEmpty(cbZielpfad.Text))
                    cbZielpfad.Focus();
                else if (string.IsNullOrEmpty(txtVerschlagwort.Text))
                    txtVerschlagwort.Focus();
                else if (string.IsNullOrEmpty(txtJahr.Text))
                    txtJahr.Focus();
                else
                    cbStatus.Focus();

                return false;
            }

            // auf Inhalte der Felder kontrollieren
            if (!int.TryParse(txtJahr.Text, out int jj) || jj < 2000 || jj > 2099)
            {
                MessageBox.Show("Feld Jahr bitte richtig füllen");
                txtJahr.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDateiname.Text))
                neuerDateiname = PrgPrm.NeuerDateiname(lblDokID.Text) + extension;
            else
            {
                if (txtDateiname.Text.IndexOf(".") > 0)
                    neuerDateiname = txtDateiname.Text;
                else
                    neuerDateiname = txtDateiname.Text + extension;
            }
            return true;
        }

        private void hinzufügenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FelderInitialisieren(DokStatus);
            DateiLaden();
            if (!File.Exists(pfadOrgDatei))
            {
                FormularClear();
            }
            else
                cbDokArt.Focus();
        }

        private void lblDokID_Enter(object sender, EventArgs e)
        {
            lblDokID.Text = PrgPrm.DokIDGenerieren().ToString();
        }

        //TODO: ist noch auszutesten!
        private void btnDokuartBearbeiten_Click(object sender, EventArgs e)
        {
            frmAttributBearbeiten x = new frmAttributBearbeiten("Dokumentenart");
            x.ShowDialog();

            cbDokArt.DataSource = PrgPrm.AlleDokumentenarten.OrderBy(o => o.Name).ToList();
            // Relativen Index des Eintrages in der sortierten Combobox suchen
            int y = 0;
            foreach (Dokumentenart da in cbDokArt.Items)
            {
                if (da.Key == x.NeuerKey)
                    break;
                else
                    y++;
            }
            cbDokArt.SelectedIndex = y;
        }

        //TODO: ist noch auszutesten!
        private void btnZielpfadBearbeiten_Click(object sender, EventArgs e)
        {
            frmAttributBearbeiten t = new frmAttributBearbeiten("Ordner");
            t.ShowDialog();
            PrgPrm.Ordner.Sort();
            cbZielpfad.DataSource = PrgPrm.Ordner;
            cbZielpfad.SelectedIndex = cbZielpfad.Items.IndexOf(t.NeuerOrdner);
        }

        //TODO: ist noch auszutesten!
        private void btnLiefBearbeiten_Click(object sender, EventArgs e)
        {
            frmAttributBearbeiten t = new frmAttributBearbeiten("Lieferant");
            t.ShowDialog();

            cbLieferant.DataSource = PrgPrm.AlleLieferanten.OrderBy(o => o.Name).ToList();
            int x = 0;
            foreach (Lieferant li in cbLieferant.Items)
            {
                if (li.Key == t.NeuerKey)
                    break;
                else
                    x++;
            }
            cbLieferant.SelectedIndex = x;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormularClear();
        }

        private void txtAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
            BearbeitungAbgebrochen = true;
        }

        private void tableLayoutPanelLinks_SizeChanged(object sender, EventArgs e)
        {
            if (tableLayoutPanelLinks.Size.Width > 520)
            {
                splitContainerHauptfenster.SplitterDistance = 520;
            }
        }
    }
}
