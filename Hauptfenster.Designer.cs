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
            this.splitContainerHauptfenster = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSucheAlles = new System.Windows.Forms.TextBox();
            this.cbVolltext = new System.Windows.Forms.CheckBox();
            this.btnSuche = new System.Windows.Forms.Button();
            this.txtDokArtSuche = new System.Windows.Forms.TextBox();
            this.txtVerschlagwortSuche = new System.Windows.Forms.TextBox();
            this.txtLiefSuche = new System.Windows.Forms.TextBox();
            this.txtPerSuche = new System.Windows.Forms.TextBox();
            this.dgvListeDok = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelRechts = new System.Windows.Forms.FlowLayoutPanel();
            this.dokumenteImportierenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.splitContainerHauptfenster.SplitterDistance = 744;
            this.splitContainerHauptfenster.TabIndex = 1;
            // 
            // flowLayoutPanelLinks
            // 
            this.flowLayoutPanelLinks.AutoScroll = true;
            this.flowLayoutPanelLinks.AutoSize = true;
            this.flowLayoutPanelLinks.Controls.Add(this.label1);
            this.flowLayoutPanelLinks.Controls.Add(this.txtSucheAlles);
            this.flowLayoutPanelLinks.Controls.Add(this.cbVolltext);
            this.flowLayoutPanelLinks.Controls.Add(this.btnSuche);
            this.flowLayoutPanelLinks.Controls.Add(this.txtDokArtSuche);
            this.flowLayoutPanelLinks.Controls.Add(this.txtVerschlagwortSuche);
            this.flowLayoutPanelLinks.Controls.Add(this.txtLiefSuche);
            this.flowLayoutPanelLinks.Controls.Add(this.txtPerSuche);
            this.flowLayoutPanelLinks.Controls.Add(this.dgvListeDok);
            this.flowLayoutPanelLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelLinks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelLinks.Name = "flowLayoutPanelLinks";
            this.flowLayoutPanelLinks.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelLinks.Size = new System.Drawing.Size(740, 822);
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
            this.txtSucheAlles.Size = new System.Drawing.Size(503, 20);
            this.txtSucheAlles.TabIndex = 2;
            // 
            // cbVolltext
            // 
            this.cbVolltext.AutoSize = true;
            this.cbVolltext.Location = new System.Drawing.Point(575, 13);
            this.cbVolltext.Name = "cbVolltext";
            this.cbVolltext.Size = new System.Drawing.Size(60, 17);
            this.cbVolltext.TabIndex = 0;
            this.cbVolltext.Text = "Volltext";
            this.cbVolltext.UseVisualStyleBackColor = true;
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(641, 13);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(29, 23);
            this.btnSuche.TabIndex = 6;
            this.btnSuche.Text = "ok";
            this.btnSuche.UseVisualStyleBackColor = true;
            // 
            // txtDokArtSuche
            // 
            this.txtDokArtSuche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDokArtSuche.Location = new System.Drawing.Point(13, 42);
            this.txtDokArtSuche.Name = "txtDokArtSuche";
            this.txtDokArtSuche.Size = new System.Drawing.Size(109, 20);
            this.txtDokArtSuche.TabIndex = 4;
            // 
            // txtVerschlagwortSuche
            // 
            this.txtVerschlagwortSuche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVerschlagwortSuche.Location = new System.Drawing.Point(128, 42);
            this.txtVerschlagwortSuche.Name = "txtVerschlagwortSuche";
            this.txtVerschlagwortSuche.Size = new System.Drawing.Size(236, 20);
            this.txtVerschlagwortSuche.TabIndex = 7;
            // 
            // txtLiefSuche
            // 
            this.txtLiefSuche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLiefSuche.Location = new System.Drawing.Point(370, 42);
            this.txtLiefSuche.Name = "txtLiefSuche";
            this.txtLiefSuche.Size = new System.Drawing.Size(100, 20);
            this.txtLiefSuche.TabIndex = 8;
            // 
            // txtPerSuche
            // 
            this.txtPerSuche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPerSuche.Location = new System.Drawing.Point(476, 42);
            this.txtPerSuche.Name = "txtPerSuche";
            this.txtPerSuche.Size = new System.Drawing.Size(100, 20);
            this.txtPerSuche.TabIndex = 9;
            // 
            // dgvListeDok
            // 
            this.dgvListeDok.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvListeDok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDok.Location = new System.Drawing.Point(13, 68);
            this.dgvListeDok.Name = "dgvListeDok";
            this.dgvListeDok.Size = new System.Drawing.Size(709, 747);
            this.dgvListeDok.TabIndex = 5;
            // 
            // flowLayoutPanelRechts
            // 
            this.flowLayoutPanelRechts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRechts.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelRechts.Name = "flowLayoutPanelRechts";
            this.flowLayoutPanelRechts.Size = new System.Drawing.Size(882, 822);
            this.flowLayoutPanelRechts.TabIndex = 0;
            // 
            // dokumenteImportierenToolStripMenuItem1
            // 
            this.dokumenteImportierenToolStripMenuItem1.Name = "dokumenteImportierenToolStripMenuItem1";
            this.dokumenteImportierenToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.dokumenteImportierenToolStripMenuItem1.Text = "Dokumente importieren";
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
        private System.Windows.Forms.CheckBox cbVolltext;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRechts;
        private System.Windows.Forms.TextBox txtDokArtSuche;
        private System.Windows.Forms.DataGridView dgvListeDok;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.TextBox txtVerschlagwortSuche;
        private System.Windows.Forms.TextBox txtLiefSuche;
        private System.Windows.Forms.TextBox txtPerSuche;
        private System.Windows.Forms.ToolStripMenuItem dokumentHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumenteImportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumenteImportierenToolStripMenuItem1;
    }
}