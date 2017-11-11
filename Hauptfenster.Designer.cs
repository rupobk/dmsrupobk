namespace DMSRupObk
{
    partial class frmHauptfenster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dokumentHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumenteImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumenteImportierenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerHauptfenster = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSucheAlles = new System.Windows.Forms.TextBox();
            this.chboVolltext = new System.Windows.Forms.CheckBox();
            this.btnSuche = new System.Windows.Forms.Button();
            this.cbDokArt = new System.Windows.Forms.ComboBox();
            this.txtVerschlagwortSuche = new System.Windows.Forms.TextBox();
            this.txtPerSuche = new System.Windows.Forms.TextBox();
            this.dgvListeDok = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelRechts = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbLieferant = new System.Windows.Forms.ComboBox();
            this.txtPeriode = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHauptfenster)).BeginInit();
            this.splitContainerHauptfenster.Panel1.SuspendLayout();
            this.splitContainerHauptfenster.Panel2.SuspendLayout();
            this.splitContainerHauptfenster.SuspendLayout();
            this.flowLayoutPanelLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDok)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentHinzufügenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dokumentHinzufügenToolStripMenuItem
            // 
            this.dokumentHinzufügenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumenteImportierenToolStripMenuItem,
            this.dokumenteImportierenToolStripMenuItem1});
            this.dokumentHinzufügenToolStripMenuItem.Name = "dokumentHinzufügenToolStripMenuItem";
            this.dokumentHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.dokumentHinzufügenToolStripMenuItem.Text = "Dokumente";
            // 
            // dokumenteImportierenToolStripMenuItem
            // 
            this.dokumenteImportierenToolStripMenuItem.Name = "dokumenteImportierenToolStripMenuItem";
            this.dokumenteImportierenToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.dokumenteImportierenToolStripMenuItem.Text = "Dokumente hinzufügen";
            // 
            // dokumenteImportierenToolStripMenuItem1
            // 
            this.dokumenteImportierenToolStripMenuItem1.Name = "dokumenteImportierenToolStripMenuItem1";
            this.dokumenteImportierenToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.dokumenteImportierenToolStripMenuItem1.Text = "Dokumente importieren";
            // 
            // splitContainerHauptfenster
            // 
            this.splitContainerHauptfenster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerHauptfenster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHauptfenster.Location = new System.Drawing.Point(0, 24);
            this.splitContainerHauptfenster.Name = "splitContainerHauptfenster";
            // 
            // splitContainerHauptfenster.Panel1
            // 
            this.splitContainerHauptfenster.Panel1.Controls.Add(this.flowLayoutPanelLinks);
            // 
            // splitContainerHauptfenster.Panel2
            // 
            this.splitContainerHauptfenster.Panel2.Controls.Add(this.flowLayoutPanelRechts);
            this.splitContainerHauptfenster.Size = new System.Drawing.Size(1634, 826);
            this.splitContainerHauptfenster.SplitterDistance = 1009;
            this.splitContainerHauptfenster.TabIndex = 1;
            // 
            // flowLayoutPanelLinks
            // 
            this.flowLayoutPanelLinks.AutoScroll = true;
            this.flowLayoutPanelLinks.AutoSize = true;
            this.flowLayoutPanelLinks.Controls.Add(this.label1);
            this.flowLayoutPanelLinks.Controls.Add(this.txtSucheAlles);
            this.flowLayoutPanelLinks.Controls.Add(this.chboVolltext);
            this.flowLayoutPanelLinks.Controls.Add(this.btnSuche);
            this.flowLayoutPanelLinks.Controls.Add(this.textBox1);
            this.flowLayoutPanelLinks.Controls.Add(this.txtID);
            this.flowLayoutPanelLinks.Controls.Add(this.cbDokArt);
            this.flowLayoutPanelLinks.Controls.Add(this.cbLieferant);
            this.flowLayoutPanelLinks.Controls.Add(this.txtVerschlagwortSuche);
            this.flowLayoutPanelLinks.Controls.Add(this.txtPerSuche);
            this.flowLayoutPanelLinks.Controls.Add(this.txtPeriode);
            this.flowLayoutPanelLinks.Controls.Add(this.textBox3);
            this.flowLayoutPanelLinks.Controls.Add(this.textBox2);
            this.flowLayoutPanelLinks.Controls.Add(this.dgvListeDok);
            this.flowLayoutPanelLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelLinks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelLinks.Name = "flowLayoutPanelLinks";
            this.flowLayoutPanelLinks.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelLinks.Size = new System.Drawing.Size(1005, 822);
            this.flowLayoutPanelLinks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suche:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSucheAlles
            // 
            this.txtSucheAlles.Location = new System.Drawing.Point(66, 13);
            this.txtSucheAlles.Name = "txtSucheAlles";
            this.txtSucheAlles.Size = new System.Drawing.Size(787, 20);
            this.txtSucheAlles.TabIndex = 2;
            // 
            // chboVolltext
            // 
            this.chboVolltext.AutoSize = true;
            this.chboVolltext.Location = new System.Drawing.Point(859, 13);
            this.chboVolltext.Name = "chboVolltext";
            this.chboVolltext.Size = new System.Drawing.Size(60, 17);
            this.chboVolltext.TabIndex = 0;
            this.chboVolltext.Text = "Volltext";
            this.chboVolltext.UseVisualStyleBackColor = true;
            // 
            // btnSuche
            // 
            this.btnSuche.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSuche.Location = new System.Drawing.Point(925, 13);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(44, 23);
            this.btnSuche.TabIndex = 6;
            this.btnSuche.Text = "ok";
            this.btnSuche.UseVisualStyleBackColor = true;
            // 
            // cbDokArt
            // 
            this.cbDokArt.DropDownWidth = 140;
            this.cbDokArt.FormattingEnabled = true;
            this.cbDokArt.Location = new System.Drawing.Point(107, 42);
            this.cbDokArt.Name = "cbDokArt";
            this.cbDokArt.Size = new System.Drawing.Size(136, 21);
            this.cbDokArt.TabIndex = 10;
            // 
            // txtVerschlagwortSuche
            // 
            this.txtVerschlagwortSuche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVerschlagwortSuche.Location = new System.Drawing.Point(400, 42);
            this.txtVerschlagwortSuche.Name = "txtVerschlagwortSuche";
            this.txtVerschlagwortSuche.Size = new System.Drawing.Size(243, 20);
            this.txtVerschlagwortSuche.TabIndex = 7;
            // 
            // txtPerSuche
            // 
            this.txtPerSuche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPerSuche.Location = new System.Drawing.Point(649, 42);
            this.txtPerSuche.Name = "txtPerSuche";
            this.txtPerSuche.Size = new System.Drawing.Size(93, 20);
            this.txtPerSuche.TabIndex = 9;
            // 
            // dgvListeDok
            // 
            this.dgvListeDok.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvListeDok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDok.Location = new System.Drawing.Point(13, 69);
            this.dgvListeDok.Name = "dgvListeDok";
            this.dgvListeDok.Size = new System.Drawing.Size(978, 747);
            this.dgvListeDok.TabIndex = 5;
            this.dgvListeDok.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeDok_CellCont​entDoubleClick);
            this.dgvListeDok.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListeDok_RowHeaderDoubleClick);
            // 
            // flowLayoutPanelRechts
            // 
            this.flowLayoutPanelRechts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRechts.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelRechts.Name = "flowLayoutPanelRechts";
            this.flowLayoutPanelRechts.Size = new System.Drawing.Size(617, 822);
            this.flowLayoutPanelRechts.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(13, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(55, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 20);
            this.txtID.TabIndex = 13;
            // 
            // cbLieferant
            // 
            this.cbLieferant.DropDownWidth = 140;
            this.cbLieferant.FormattingEnabled = true;
            this.cbLieferant.Location = new System.Drawing.Point(249, 42);
            this.cbLieferant.Name = "cbLieferant";
            this.cbLieferant.Size = new System.Drawing.Size(145, 21);
            this.cbLieferant.TabIndex = 10;
            // 
            // txtPeriode
            // 
            this.txtPeriode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeriode.Location = new System.Drawing.Point(748, 42);
            this.txtPeriode.Name = "txtPeriode";
            this.txtPeriode.Size = new System.Drawing.Size(33, 20);
            this.txtPeriode.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(787, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(867, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 16;
            // 
            // frmHauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 850);
            this.Controls.Add(this.splitContainerHauptfenster);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHauptfenster";
            this.Text = "DMS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerHauptfenster.Panel1.ResumeLayout(false);
            this.splitContainerHauptfenster.Panel1.PerformLayout();
            this.splitContainerHauptfenster.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHauptfenster)).EndInit();
            this.splitContainerHauptfenster.ResumeLayout(false);
            this.flowLayoutPanelLinks.ResumeLayout(false);
            this.flowLayoutPanelLinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainerHauptfenster;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSucheAlles;
        private System.Windows.Forms.CheckBox chboVolltext;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRechts;
        private System.Windows.Forms.DataGridView dgvListeDok;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.TextBox txtVerschlagwortSuche;
        private System.Windows.Forms.TextBox txtPerSuche;
        private System.Windows.Forms.ToolStripMenuItem dokumentHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumenteImportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumenteImportierenToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbDokArt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbLieferant;
        private System.Windows.Forms.TextBox txtPeriode;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}