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
            txtSucheAlles.Text = string.Empty;
            txtPerSuche.Text = string.Empty;
            txtVerschlagwortSuche.Text = string.Empty;
            chboVolltext.Checked = false;
            ComboboxenAufbauen();
            GridInitialisieren();
            btnBearbeiten.Enabled = false;
            btnOeffnen.Enabled = false;
            btnExport.Enabled = false;
            btnLoeschen.Enabled = false;
        }

        private void ComboboxenAufbauen()
        {
            //Leerzeile als Eintrag hinzufügen
            List<Dokumentenart> x = new List<Dokumentenart>();
            x = PrgPrm.AlleDokumentenarten;
            x.Add(new Dokumentenart(0, ""));
            cbDokArt.DataSource = x.OrderBy(o => o.Name).ToList();
            cbDokArt.DisplayMember = "Name";
            cbDokArt.ValueMember = "Key";
            cbDokArt.SelectedIndex = 0;

            List<Dokumentenart> y = new List<Dokumentenart>();
            y = PrgPrm.AlleDokumentenarten;
            y.Add(new Dokumentenart(0, ""));
            cbLieferant.DataSource = y.OrderBy(o => o.Name).ToList();
            cbLieferant.DisplayMember = "Name";
            cbLieferant.ValueMember = "Key";
            cbLieferant.SelectedIndex = 0;
        }

        private void GridInitialisieren()
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

            if (dgvListeDok.ColumnCount == 0)
            {
                //public int DokID { get; set; }
                //public string Pfad { get; set; }
                //public string Dateiname { get; set; }
                //public string Dateityp { get; set; }
                //public DateTime Archivierungsdatum { get; set; }
                //public DateTime Aenderungsdatum { get; set; }
                //public int Jahr { get; set; }
                //public string Periode { get; set; }
                //public int DokumentenartKey { get; set; }
                //public string DokumentenartName { get; set; }
                //public int LieferantKey { get; set; }
                //public string LieferantName { get; set; }
                //public string Verschlagwortung { get; set; }
                //public string Dokumentenstatus { get; set; }

                //ID
                DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                col1.DataPropertyName = "DokID";
                col1.HeaderText = "ID";
                col1.Name = "DokID";
                col1.Width = 50;
                col1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                dgvListeDok.Columns.Add(col1);

                // Dokumentenart
                DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
                col2.DataPropertyName = "DokumentenartName";
                col2.HeaderText = "Dokum.art";
                col2.Name = "DokumentenartName";
                col2.Width = 140;
                col2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                dgvListeDok.Columns.Add(col2);

                // Lieferant
                DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
                col3.DataPropertyName = "LieferantName";
                col3.HeaderText = "Lieferant";
                col3.Name = "LieferantName";
                col3.Width = 150;
                col3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                dgvListeDok.Columns.Add(col3);

                // Verschlagwortung
                DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
                col4.DataPropertyName = "Verschlagwortung";
                col4.HeaderText = "Verschlagwortung";
                col4.Name = "Verschlagwortung";
                col4.Width = 250;
                col4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                dgvListeDok.Columns.Add(col4);

                // Periode
                DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
                col5.DataPropertyName = "Periode";
                col5.HeaderText = "Periode";
                col5.Name = "Periode";
                col5.Width = 100;
                col5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                dgvListeDok.Columns.Add(col5);

                // Jahr
                DataGridViewColumn col6 = new DataGridViewTextBoxColumn();
                col6.DataPropertyName = "Jahr";
                col6.HeaderText = "Jahr";
                col6.Name = "Jahr";
                col6.Width = 40;
                col6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                dgvListeDok.Columns.Add(col6);

                // Archivierungsdatum
                DataGridViewColumn col7 = new DataGridViewTextBoxColumn();
                col7.DataPropertyName = "Archivierungsdatum";
                col7.HeaderText = "Arch.Datum";
                col7.Name = "Archivierungsdatum";
                col7.DefaultCellStyle.Format = "dd.MM.yyyy";
                col7.Width = 80;
                col7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                dgvListeDok.Columns.Add(col7);

                // Änderungsdatum
                DataGridViewColumn col8 = new DataGridViewTextBoxColumn();
                col8.DataPropertyName = "Aenderungsdatum";
                col8.HeaderText = "Änderdatum";
                col8.Name = "Aenderungsdatum";
                col8.DefaultCellStyle.Format = "dd.MM.yyyy";
                col8.Width = 80;
                col8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
                dgvListeDok.Columns.Add(col8);

                // Pfad
                DataGridViewColumn col9 = new DataGridViewTextBoxColumn();
                col9.DataPropertyName = "Pfad";
                col9.Visible = false;
                dgvListeDok.Columns.Add(col9);

                // Dateiname
                DataGridViewColumn col10 = new DataGridViewTextBoxColumn();
                col10.DataPropertyName = "Dateiname";
                col10.Visible = false;
                dgvListeDok.Columns.Add(col10);
            }

            // Sortierung einstellen
            //dgvListeDok.Sort(col1, ListSortDirection.Ascending);
            //dgvListeDok.rowh
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
                                                 dgvListeDok.Rows[e.RowIndex].Cells[8].Value.ToString(),
                                                 dgvListeDok.Rows[e.RowIndex].Cells[9].Value.ToString()));
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

        private void dgvListeDok_RowHeaderDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }

        private string DateiPfad(Dokument dok)
        {
            return Path.Combine(PrgPrm.RootVerzeichnisDok, dok.Pfad, dok.Dateiname);
        }

        private void btnOeffnen_Click(object sender, EventArgs e)
        {
            //2 Methoden, um die Werte des datagrid herauszufinden
            //1:
            var x = dgvListeDok.CurrentCell.DataGridView.Columns[8];
            DataGridViewRow selectedRow = dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex];
            string pfad = selectedRow.Cells[8].Value.ToString();

            //2:
            string datei = dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[9].Value.ToString();

            System.Diagnostics.Process.Start(Path.Combine(PrgPrm.RootVerzeichnisDok, pfad, datei));
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
                datei = dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[9].Value.ToString();
                pfad = dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[8].Value.ToString();
                File.Copy(Path.Combine(PrgPrm.RootVerzeichnisDok, pfad, datei), Path.Combine(objDialog.SelectedPath, datei));
            }
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bist du sicher?", "Rückfrage", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Archiv.Erstellen().Loeschen(dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Volltext.Erstellen().Loeschen(dgvListeDok.Rows[dgvListeDok.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }
        }

        //TODO: noch zu programmieren
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
            new frmDokBearbeiten(dok);

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
    }
}
