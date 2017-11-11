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

        private string DateiPfad(Dokument dok)
        {
            return Path.Combine(PrgPrm.RootVerzeichnisDok, dok.Pfad, dok.Dateiname);
        }

        private void dgvListeDok_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)    // wenn auf Überschrift geklickt, dann nichts machen
            {
                MessageBox.Show(e.RowIndex.ToString());
            }
        }

        private void dgvListeDok_RowHeaderDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                MessageBox.Show(e.RowIndex.ToString());
        }

    }
}
