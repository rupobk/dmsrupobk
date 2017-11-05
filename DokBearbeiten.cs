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

        public frmDokBearbeiten()
        {
            InitializeComponent();
            FormularClear();
        }

        /// Konstruktor der für bestehende Dokumente aufgerufen wird
        public frmDokBearbeiten(Dokument dok) : this()    //this ruft Hauptkonstruktor auf u. wird für bestehende Dok. aufgerufen
        {
            FelderZuweisen(dok);
        }

        //TODO: muss noch gemacht werden
        private void FelderZuweisen(Dokument dok)
        {
            /// Wenn ein bestehendes Dokument geöffnet wird, dann Felder zuweisen u. Dokument anzeigen
            //
            //
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

        private void FelderInitialisieren()
        {
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
            cbDokArt.DataSource = PrgPrm.AlleDokumentenarten.OrderBy(o => o.Name).ToList();
            cbDokArt.DisplayMember = "Name";
            cbDokArt.ValueMember = "Key";
            cbDokArt.SelectedIndex = 9;

            cbLieferant.DataSource = PrgPrm.AlleLieferanten.OrderBy(o => o.Name).ToList();
            cbLieferant.DisplayMember = "Name";
            cbLieferant.ValueMember = "Key";
            cbLieferant.SelectedIndex = 0;

            PrgPrm.Ordner.Sort();
            cbZielpfad.DataSource = PrgPrm.Ordner;
            cbLieferant.SelectedIndex = 11;

            cbStatus.DataSource = PrgPrm.Dokumentenstatus;
            cbDokArt.SelectedIndex = 1;
        }

        private void btnLaden_Click(object sender, EventArgs e)
        {
            DateiLaden();
        }

        private void DateiLaden()
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
            }
            else
                btnOCRScan.Enabled = false;
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
                int DokID = int.Parse(lblDokID.Text);
                //DateTime dt1 = DateTime.Parse(txtArchivierDatum.Text);
                //DateTime dt2 = DateTime.Parse(txtAenderDatum.Text);
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
                                            dtpAenderung.Value, LiefKey, LiefName, Per, pfadOrgDatei);

                if (!string.IsNullOrEmpty(txtVolltext.Text))
                {
                    Volltextindex vti = new Volltextindex(DokID, txtVolltext.Text, cbZielpfad.Text, neuerDateiname, extension);
                }

                FormularClear();
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
                neuerDateiname = PrgPrm.NeuerDateiname() + extension;
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
            FelderInitialisieren();
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
            new frmAttributBearbeiten("Dokumentenart").ShowDialog();
            cbDokArt.DataSource = PrgPrm.AlleDokumentenarten.OrderBy(o => o.Name).ToList();
        }

        private void btnZielpfadBearbeiten_Click(object sender, EventArgs e)
        {
            new frmAttributBearbeiten("Ordner").ShowDialog();
            PrgPrm.Ordner.Sort();
            cbZielpfad.DataSource = PrgPrm.Ordner;
        }

        private void btnLiefBearbeiten_Click(object sender, EventArgs e)
        {
            new frmAttributBearbeiten("Lieferant").ShowDialog();
            cbLieferant.DataSource = PrgPrm.AlleLieferanten.OrderBy(o => o.Name).ToList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormularClear();
        }

        private void txtAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TODO: ist noch zu machen!
        private void importierenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
