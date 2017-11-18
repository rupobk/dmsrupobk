using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMSRupObk
{
    public partial class frmAttributBearbeiten : Form
    {
        public ProgParam PrgPrm = ProgParam.Erstellen();

        public frmAttributBearbeiten(string Attribut)
        {
            InitializeComponent();
            FensterAufbauen(Attribut);
        }

        private void FensterAufbauen(string Attribut)
        {
            lblKey.Enabled = false;
            lblKeyCalc.Enabled = false;
            lblName.Enabled = false;
            txtName.Enabled = false;
            btnSpeichern.Visible = false;
            btnAbbrechen.Visible = true;
            btnNeu.Visible = true;

            switch (Attribut)
            {
                case "Dokumentenart":
                    this.Text = "Dokumentenarten-Attribute bearbeiten";
                    dgAttribute.DataSource = PrgPrm.AlleDokumentenarten.OrderBy(o => o.Name).ToList();
                    dgAttribute.Columns[0].Width = 30;
                    dgAttribute.Columns[1].Width = 172;
                    break;
                case "Lieferant":
                    this.Text = "Lieferanten-Attribute bearbeiten";
                    dgAttribute.DataSource = PrgPrm.AlleLieferanten.OrderBy(o => o.Name).ToList();
                    dgAttribute.Columns[0].Width = 30;
                    dgAttribute.Columns[1].Width = 172;
                    break;
                default:
                    this.Text = "Ordner bearbeiten";
                    // eine einfache Liste kann nicht an ein Datagrid übergeben werden, dann wird nämlich die Länge jedes beinhalteten Strings angezeigt
                    // man muss eine anonymous Liste daraus machen
                    var values = from data in PrgPrm.Ordner select new { Value = data };
                    //dgAttribute.DataSource = (from data in PrgPrm.Ordner select new { Value = data }).ToList();
                    dgAttribute.DataSource = (from data in PrgPrm.Ordner
                                              orderby data
                                              select new { Value = data }).ToList();
                    dgAttribute.Columns[0].Width = 185;
                    break;
            }

            dgAttribute.RowHeadersVisible = false;
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            int key;
            switch (this.Text)
            {
                case "Dokumentenarten-Attribute bearbeiten":
                    key = (from werte in PrgPrm.AlleDokumentenarten
                           orderby werte.Key descending
                           select werte.Key).First() + 1;
                    lblKeyCalc.Text = key.ToString();
                    lblKey.Enabled = true;
                    lblKeyCalc.Enabled = true;
                    break;
                case "Lieferanten-Attribute bearbeiten":
                    key = (from werte in PrgPrm.AlleLieferanten
                           orderby werte.Key descending
                           select werte.Key).First() + 1;
                    lblKeyCalc.Text = key.ToString();
                    lblKey.Enabled = true;
                    lblKeyCalc.Enabled = true;
                    break;
                default:
                    break;
            }
            lblName.Enabled = true;
            txtName.Enabled = true;
            txtName.Focus();
            btnSpeichern.Visible = true;
            btnNeu.Visible = false;
        }

        //TODO: noch zu machen
        // fehlt noch die Funktion, dass ein neu eingegebener Eintrag automatisch beim verlassen des Formulars in der Combobox ausgewählt wird
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            bool doppelt = false;

            switch (this.Text)
            {
                case "Dokumentenarten-Attribute bearbeiten":
                    var a = from w in PrgPrm.AlleDokumentenarten
                            where w.Name.Contains(txtName.Text)
                            select w;
                    foreach (var item in a)
                    {
                        if (!string.IsNullOrEmpty(item.Name))
                            doppelt = true;
                    }
                    if (!string.IsNullOrEmpty(txtName.Text) && !doppelt)
                    {
                        PrgPrm.NeueDokumentenart(int.Parse(lblKeyCalc.Text), txtName.Text);
                        dgAttribute.DataSource = PrgPrm.AlleDokumentenarten.OrderBy(o => o.Name).ToList();
                    }
                    else
                        MessageBox.Show("Das Attribut kann nicht doppelt angelegt werden!");
                    break;
                case "Lieferanten-Attribute bearbeiten":
                    var b = from w in PrgPrm.AlleLieferanten
                            where w.Name.Contains(txtName.Text)
                            select w;
                    foreach (var item in b)
                    {
                        if (!string.IsNullOrEmpty(item.Name))
                            doppelt = true;
                    }
                    if (!string.IsNullOrEmpty(txtName.Text) && !doppelt)
                    {
                        PrgPrm.NeuerLieferant(int.Parse(lblKeyCalc.Text), txtName.Text);
                        dgAttribute.DataSource = PrgPrm.AlleLieferanten.OrderBy(o => o.Name).ToList();
                    }
                    else
                        MessageBox.Show("Das Attribut kann nicht doppelt angelegt werden!");
                    break;
                default:
                    if (!string.IsNullOrEmpty(txtName.Text) && !PrgPrm.Ordner.Contains(txtName.Text))
                    {
                        PrgPrm.NeuerOrdner(txtName.Text);
                        dgAttribute.DataSource = (from data in PrgPrm.Ordner
                                                  orderby data
                                                  select new { Value = data }).ToList();
                    }
                    else
                        MessageBox.Show("Das Attribut kann nicht doppelt angelegt werden!");
                    break;
            }
        }
    }
}
