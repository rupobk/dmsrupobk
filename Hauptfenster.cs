using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMSRupObk
{
    public partial class frmHauptfenster : Form
    {
        ProgParam PrgPrm = ProgParam.Erstellen();

        public frmHauptfenster()
        {
            InitializeComponent();
            FormularClear();
        }

        private void FormularClear()
        {
            //TODO: Vollbild einschalten u. die 2 Fenster entsprechend dimensionieren
            txtSucheAlles.Text = string.Empty;
            txtPerSuche.Text = string.Empty;
            txtVerschlagwortSuche.Text = string.Empty;
            chboVolltext.Checked = false;
            ComboboxenAufbauen();
            GridAnzeigen();
            btnBearbeiten.Enabled = false;
            btnOeffnen.Enabled = false;
            btnExport.Enabled = false;
            btnLoeschen.Enabled = false;
            pfadDaten.Text = "Dokumentenpfad = " + PrgPrm.RootVerzeichnisDok;
        }

        private void ComboboxenAufbauen()
        {
            //Leerzeile als Eintrag hinzufügen
            List<Dokumentenart> z = new List<Dokumentenart>();
            z = PrgPrm.AlleDokumentenarten;
            if (!z.Any(d => d.Key == 0))
                //TODO: Laurin fragen, warum in PprgPram.AlleDokumentenarten jene mit Key 0 angelegt ist
                z.Add(new Dokumentenart(0, ""));
            cbDokArt.DataSource = z.OrderBy(o => o.Name).ToList();
            cbDokArt.DisplayMember = "Name";
            cbDokArt.ValueMember = "Key";
            cbDokArt.SelectedIndex = 0;

            List<Dokumentenart> y = new List<Dokumentenart>();
            y = PrgPrm.AlleDokumentenarten;
            if (!y.Any(d => d.Key == 0))
                y.Add(new Dokumentenart(0, ""));
            cbLieferant.DataSource = y.OrderBy(o => o.Name).ToList();
            cbLieferant.DisplayMember = "Name";
            cbLieferant.ValueMember = "Key";
            cbLieferant.SelectedIndex = 0;
        }

        private void GridAnzeigen()
        {
            var query = (from dok in Archiv.Erstellen().alleDokumente
                         orderby dok.Archivierungsdatum descending, dok.DokID descending
                         select dok).ToList();

            //muss gemacht werden, damit die Sortierung über die Spaltenüberschriften funktioniert
            //nur bei Dataview funktioniert nämlich die Sortierung über die Spaltenüberschriften
            DataTable dt = Linq2DataTable(query);
            DataView dv = new DataView(dt);

            dgvListeDok.AutoGenerateColumns = false;
            dgvListeDok.DataSource = dv;
            dgv_id.DataPropertyName = "DokID";
            dgv_dokartkey.DataPropertyName = "DokumentenartKey";
            dgv_dokartkey.Visible = false;
            dgv_dokartname.DataPropertyName = "DokumentenartName";
            dgv_liefkey.DataPropertyName = "LieferantKey";
            dgv_liefkey.Visible = false;
            dgv_liefname.DataPropertyName = "LieferantName";
            dgv_period.DataPropertyName = "Periode";
            dgv_jahr.DataPropertyName = "Jahr";
            dgv_pfad.DataPropertyName = "Pfad";
            dgv_verschlagwort.DataPropertyName = "Verschlagwortung";
            dgv_dateiname.DataPropertyName = "Dateiname";
            dgv_AenderDat.DataPropertyName = "Aenderungsdatum";
            dgv_archdat.DataPropertyName = "Archivierungsdatum";
            dgv_statusdok.DataPropertyName = "Dokumentenstatus";

        }

        private DataTable Linq2DataTable<T>(IEnumerable<T> list)
        {
            // DataTable mit Namen aus GUID erstellen:
            DataTable dt = new DataTable(Guid.NewGuid().ToString());

            // Spaltennamen:
            PropertyInfo[] cols = null;

            // Ist das LINQ-Ergebnis null wird ein leeres DataTable 
            // zurückgegeben:
            if (list == null)
                return dt;

            // Alle Elemente der Liste durchlaufen (LINQ-Ergebnis):
            foreach (T item in list)
            {
                // Die Spaltennamen werden per Reflektion ermittelt.
                // Wird nur beim 1. Durchlauf ermittelt:
                if (cols == null)
                {
                    // Alle Spalten ermitteln:
                    cols = item.GetType().GetProperties();

                    // Spalten durchlaufen und im DataTable die Spalten erstellen:
                    foreach (PropertyInfo pi in cols)
                    {
                        // Spaltentyp:
                        Type colType = pi.PropertyType;

                        if (colType.IsGenericType &&
                            colType.GetGenericTypeDefinition() == typeof(Nullable<>))
                            colType = colType.GetGenericArguments()[0];

                        // Spalte der DataTable hinzufügen:
                        dt.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                // Zeile hinzufügen:
                DataRow dr = dt.NewRow();
                foreach (PropertyInfo pi in cols)
                    dr[pi.Name] =
                        pi.GetValue(item, null) ?? DBNull.Value;

                dt.Rows.Add(dr);
            }

            return dt;
        }

        private void dgvListeDok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)    // wenn auf Überschrift geklickt, dann nichts machen
            {
                try
                {
                    documentViewer1.LoadDocument(Path.Combine(PrgPrm.RootVerzeichnisDok,
                                                 dgvListeDok.Rows[e.RowIndex].Cells[10].Value.ToString(),
                                                 dgvListeDok.Rows[e.RowIndex].Cells[11].Value.ToString()));
                    btnBearbeiten.Enabled = true;
                    btnOeffnen.Enabled = true;
                    btnExport.Enabled = true;
                    btnLoeschen.Enabled = true;
                }
                catch (Exception)
                {
                    try
                    {
                        documentViewer1.CloseDocument();
                    }
                    catch (Exception) { }
                    btnBearbeiten.Enabled = false;
                    btnOeffnen.Enabled = false;
                    btnExport.Enabled = false;
                    btnLoeschen.Enabled = false;
                }
            }
        }

        private string DateiPfad(Dokument dok)
        {
            return Path.Combine(PrgPrm.RootVerzeichnisDok, dok.Pfad, dok.Dateiname);
        }

        private void btnOeffnen_Click(object sender, EventArgs e)
        {
            //2 Methoden, um die Werte des datagrid herauszufinden
            //1:
            //var x = dgvListeDok.CurrentCell.DataGridView.Columns[8];
            //DataGridViewRow selectedRow = dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex];
            //string pfad = selectedRow.Cells[8].Value.ToString();

            //2:
            //string datei = dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[9].Value.ToString();

            Archiv.Erstellen().alleDokumente.Find(x => x.DokID == int.Parse(dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[0].Value.ToString())).OeffneDich();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string datei, pfad;
            FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Beschreibung";
            objDialog.SelectedPath = @"C:\";       // Vorgabe Pfad (und danach der gewählte Pfad)
            DialogResult objResult = objDialog.ShowDialog(this);
            if (objResult == DialogResult.OK)
            {
                datei = dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[11].Value.ToString();
                pfad = dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[10].Value.ToString();
                File.Copy(Path.Combine(PrgPrm.RootVerzeichnisDok, pfad, datei), Path.Combine(objDialog.SelectedPath, datei));
            }
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bist du sicher?", "Rückfrage", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dokument dok = Archiv.Erstellen().alleDokumente.Find(x => x.DokID == int.Parse(dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                dok.Loeschen();
                Volltextindex vti = Volltext.Erstellen().alleVolltexte.Find(x => x.DokID == int.Parse(dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                vti.Loeschen();
            }
        }

        //TODO: noch ausgiebig zu testen
        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            //das Dokument finden kann man auf 2 Arten:
            //1.
            Dokument dok = Archiv.Erstellen().alleDokumente.Find(x => x.DokID == int.Parse(dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[0].Value.ToString()));

            //2.
            //var rec = from a in Archiv.Erstellen().alleDokumente
            //          where a.DokID == int.Parse(dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[0].Value.ToString())
            //          select a;

            //foreach (Dokument d in rec)
            //{
            //    new frmDokBearbeiten(d);
            //    break;
            //}

            // Dokumentenviewer schliessen, es könnte ja sein, dass das Dokument verschoben werden muss
            if (documentViewer1.Created)
                documentViewer1.CloseDocument();

            // Dokument bearbeiten
            frmDokBearbeiten fdb = new frmDokBearbeiten(dok);
            fdb.ShowDialog();

            // Fenster neu aufbauen
            //for (int x = 0; x < dgvListeDok.Columns.Count; x++)
            //    dgvListeDok.Columns.RemoveAt(x);
            FormularClear();
            documentViewer1.LoadDocument(Path.Combine(PrgPrm.RootVerzeichnisDok, dok.Pfad, dok.Dateiname));
            btnBearbeiten.Enabled = true;
            btnOeffnen.Enabled = true;
            btnExport.Enabled = true;
            btnLoeschen.Enabled = true;
        }

        private void dokumenteImportierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeuesDokumentHinzufuegen();
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            NeuesDokumentHinzufuegen();
        }

        private void dokumenteImportierenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DokumenteImportieren();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DokumenteImportieren();
        }

        private void frmHauptfenster_SizeChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            //MessageBox.Show("size changed");
            int breite = (int)(control.Size.Width * 0.59d);
            int hoehe = dgvListeDok.Size.Height;
            dgvListeDok.Size = new Size(breite, hoehe);

            documentViewer1.Location = new Point(dgvListeDok.Location.X + breite + 8, dgvListeDok.Location.Y);
            documentViewer1.Size = new Size((int)(control.Size.Width * 0.39d), documentViewer1.Size.Height);
        }

        private void NeuesDokumentHinzufuegen()
        {
            if (documentViewer1.Created)
                documentViewer1.CloseDocument();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
            {
                frmDokBearbeiten fdb = new frmDokBearbeiten(ofd.FileName);
                fdb.ShowDialog();
                FormularClear();
            }
        }

        private void DokumenteImportieren()
        {
            DirectoryInfo ParentDirectory = new DirectoryInfo(Path.Combine(PrgPrm.RootVerzeichnisDok, PrgPrm.ImportVerzeichnisDok));
            if (ParentDirectory.GetFiles().Length != 0)
                if (documentViewer1.Created)
                    documentViewer1.CloseDocument();

            foreach (FileInfo f in ParentDirectory.GetFiles())
            {
                frmDokBearbeiten fdb = new frmDokBearbeiten(f.Name);
                //todo: fehlt noch den ocr-button zu aktivieren
                fdb.ShowDialog();
                if (fdb.BearbeitungAbgebrochen)
                    break;
                FormularClear();
            }
        }

        private void frmHauptfenster_Load(object sender, EventArgs e)
        {
            // auf Vollbild schalten u. die Innenteile richtig dimensionieren
            //this.FormBorderStyle = FormBorderStyle.None; // Rahmen ausblenden
            //this.TopMost = true; // Formular ganz im Vordergrund, also auch vor der Taskleiste anzeigen
            this.Bounds = Screen.PrimaryScreen.Bounds; // Formulargröße auf Größe des Bildschirms festlegen
            this.dgvListeDok.Size = new Size(925, dgvListeDok.Height);
            this.documentViewer1.Location = new Point(935, documentViewer1.Location.Y);
            this.documentViewer1.Size = new Size(this.Width - 935, dgvListeDok.Height);
        }
    }
}
