﻿namespace DMSRupObk
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
            Gnostice.Documents.FormatterSettings formatterSettings1 = new Gnostice.Documents.FormatterSettings();
            Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings spreadSheetFormatterSettings1 = new Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings1 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins1 = new Gnostice.Documents.Margins();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions1 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions2 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.TXTFormatterSettings txtFormatterSettings1 = new Gnostice.Documents.TXTFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings2 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins2 = new Gnostice.Documents.Margins();
            Gnostice.Graphics.RenderingSettings renderingSettings1 = new Gnostice.Graphics.RenderingSettings();
            Gnostice.Graphics.ImageRenderingSettings imageRenderingSettings1 = new Gnostice.Graphics.ImageRenderingSettings();
            Gnostice.Graphics.LineArtRenderingSettings lineArtRenderingSettings1 = new Gnostice.Graphics.LineArtRenderingSettings();
            Gnostice.Graphics.ResolutionSettings resolutionSettings1 = new Gnostice.Graphics.ResolutionSettings();
            Gnostice.Graphics.TextRenderingSettings textRenderingSettings1 = new Gnostice.Graphics.TextRenderingSettings();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dokumentHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumenteImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumenteImportierenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSucheAlles = new System.Windows.Forms.TextBox();
            this.chboVolltext = new System.Windows.Forms.CheckBox();
            this.btnSuche = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbDokArt = new System.Windows.Forms.ComboBox();
            this.cbLieferant = new System.Windows.Forms.ComboBox();
            this.txtVerschlagwortSuche = new System.Windows.Forms.TextBox();
            this.txtPerSuche = new System.Windows.Forms.TextBox();
            this.txtPeriode = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvListeDok = new System.Windows.Forms.DataGridView();
            this.btnOeffnen = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.documentViewer1 = new Gnostice.Documents.Controls.WinForms.DocumentViewer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDok)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentHinzufügenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1678, 24);
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suche:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSucheAlles
            // 
            this.txtSucheAlles.Location = new System.Drawing.Point(65, 27);
            this.txtSucheAlles.Name = "txtSucheAlles";
            this.txtSucheAlles.Size = new System.Drawing.Size(787, 20);
            this.txtSucheAlles.TabIndex = 2;
            // 
            // chboVolltext
            // 
            this.chboVolltext.AutoSize = true;
            this.chboVolltext.Location = new System.Drawing.Point(858, 27);
            this.chboVolltext.Name = "chboVolltext";
            this.chboVolltext.Size = new System.Drawing.Size(60, 17);
            this.chboVolltext.TabIndex = 0;
            this.chboVolltext.Text = "Volltext";
            this.chboVolltext.UseVisualStyleBackColor = true;
            // 
            // btnSuche
            // 
            this.btnSuche.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSuche.Location = new System.Drawing.Point(924, 27);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(44, 23);
            this.btnSuche.TabIndex = 6;
            this.btnSuche.Text = "ok";
            this.btnSuche.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(65, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 20);
            this.txtID.TabIndex = 13;
            // 
            // cbDokArt
            // 
            this.cbDokArt.DropDownWidth = 140;
            this.cbDokArt.FormattingEnabled = true;
            this.cbDokArt.Location = new System.Drawing.Point(117, 57);
            this.cbDokArt.Name = "cbDokArt";
            this.cbDokArt.Size = new System.Drawing.Size(136, 21);
            this.cbDokArt.TabIndex = 10;
            // 
            // cbLieferant
            // 
            this.cbLieferant.DropDownWidth = 140;
            this.cbLieferant.FormattingEnabled = true;
            this.cbLieferant.Location = new System.Drawing.Point(259, 57);
            this.cbLieferant.Name = "cbLieferant";
            this.cbLieferant.Size = new System.Drawing.Size(145, 21);
            this.cbLieferant.TabIndex = 10;
            // 
            // txtVerschlagwortSuche
            // 
            this.txtVerschlagwortSuche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVerschlagwortSuche.Location = new System.Drawing.Point(432, 57);
            this.txtVerschlagwortSuche.Name = "txtVerschlagwortSuche";
            this.txtVerschlagwortSuche.Size = new System.Drawing.Size(243, 20);
            this.txtVerschlagwortSuche.TabIndex = 7;
            // 
            // txtPerSuche
            // 
            this.txtPerSuche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPerSuche.Location = new System.Drawing.Point(681, 57);
            this.txtPerSuche.Name = "txtPerSuche";
            this.txtPerSuche.Size = new System.Drawing.Size(93, 20);
            this.txtPerSuche.TabIndex = 9;
            // 
            // txtPeriode
            // 
            this.txtPeriode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeriode.Location = new System.Drawing.Point(780, 57);
            this.txtPeriode.Name = "txtPeriode";
            this.txtPeriode.Size = new System.Drawing.Size(33, 20);
            this.txtPeriode.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(819, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(899, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 16;
            // 
            // dgvListeDok
            // 
            this.dgvListeDok.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvListeDok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDok.Location = new System.Drawing.Point(15, 91);
            this.dgvListeDok.Name = "dgvListeDok";
            this.dgvListeDok.Size = new System.Drawing.Size(978, 747);
            this.dgvListeDok.TabIndex = 5;
            this.dgvListeDok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeDok_CellClick);
            this.dgvListeDok.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListeDok_RowHeaderDoubleClick);
            // 
            // btnOeffnen
            // 
            this.btnOeffnen.Location = new System.Drawing.Point(1269, 27);
            this.btnOeffnen.Name = "btnOeffnen";
            this.btnOeffnen.Size = new System.Drawing.Size(75, 23);
            this.btnOeffnen.TabIndex = 4;
            this.btnOeffnen.Text = "Öffnen";
            this.btnOeffnen.UseVisualStyleBackColor = true;
            this.btnOeffnen.Click += new System.EventHandler(this.btnOeffnen_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1188, 27);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Exportieren";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(1107, 27);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnLoeschen.TabIndex = 2;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(1026, 27);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(75, 23);
            this.btnBearbeiten.TabIndex = 1;
            this.btnBearbeiten.Text = "Bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            this.btnBearbeiten.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // documentViewer1
            // 
            this.documentViewer1.AutoScroll = true;
            this.documentViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.documentViewer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.documentViewer1.BorderWidth = 10;
            this.documentViewer1.CurrentPage = 0;
            this.documentViewer1.HScrollBar.LargeChange = 40;
            this.documentViewer1.HScrollBar.SmallChange = 20;
            this.documentViewer1.HScrollBar.Value = 0;
            this.documentViewer1.HScrollBar.Visibility = Gnostice.Documents.Controls.WinForms.ScrollBarVisibility.Always;
            this.documentViewer1.Location = new System.Drawing.Point(1000, 58);
            this.documentViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.documentViewer1.Name = "documentViewer1";
            // 
            // 
            // 
            this.documentViewer1.NavigationPane.ActivePage = null;
            this.documentViewer1.NavigationPane.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.NavigationPane.Name = "";
            this.documentViewer1.NavigationPane.TabIndex = 0;
            this.documentViewer1.NavigationPane.Visibility = Gnostice.Documents.Controls.WinForms.Visibility.Auto;
            this.documentViewer1.NavigationPane.WidthPercentage = 20;
            this.documentViewer1.PageLayout = null;
            this.documentViewer1.PageRotation = Gnostice.Documents.Controls.WinForms.RotationAngle.Zero;
            spreadSheetFormatterSettings1.FormattingMode = Gnostice.DOM.FormattingMode.PreferDocumentSettings;
            spreadSheetFormatterSettings1.PageOrder = Gnostice.Documents.Spreadsheet.LayoutDirection.BackwardN;
            pageSettings1.Height = 11.6929F;
            margins1.Bottom = 1F;
            margins1.Footer = 0F;
            margins1.Header = 0F;
            margins1.Left = 1F;
            margins1.Right = 1F;
            margins1.Top = 1F;
            pageSettings1.Margin = margins1;
            pageSettings1.Orientation = Gnostice.Graphics.Orientation.Portrait;
            pageSettings1.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings1.Width = 8.2677F;
            spreadSheetFormatterSettings1.PageSettings = pageSettings1;
            sheetOptions1.Print = false;
            sheetOptions1.View = true;
            spreadSheetFormatterSettings1.ShowGridlines = sheetOptions1;
            sheetOptions2.Print = false;
            sheetOptions2.View = true;
            spreadSheetFormatterSettings1.ShowHeadings = sheetOptions2;
            formatterSettings1.SpreadSheet = spreadSheetFormatterSettings1;
            txtFormatterSettings1.Font = new System.Drawing.Font("Calibri", 12F);
            pageSettings2.Height = 11.6929F;
            margins2.Bottom = 1F;
            margins2.Footer = 0F;
            margins2.Header = 0F;
            margins2.Left = 1F;
            margins2.Right = 1F;
            margins2.Top = 1F;
            pageSettings2.Margin = margins2;
            pageSettings2.Orientation = Gnostice.Graphics.Orientation.Portrait;
            pageSettings2.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings2.Width = 8.2677F;
            txtFormatterSettings1.PageSettings = pageSettings2;
            formatterSettings1.TXT = txtFormatterSettings1;
            this.documentViewer1.Preferences.FormatterSettings = formatterSettings1;
            this.documentViewer1.Preferences.KeyNavigation = true;
            imageRenderingSettings1.CompositingMode = Gnostice.Graphics.CompositingMode.SourceOver;
            imageRenderingSettings1.CompositingQuality = Gnostice.Graphics.CompositingQuality.Default;
            imageRenderingSettings1.InterpolationMode = Gnostice.Graphics.InterpolationMode.NearestNeighbor;
            imageRenderingSettings1.PixelOffsetMode = Gnostice.Graphics.PixelOffsetMode.HighQuality;
            renderingSettings1.Image = imageRenderingSettings1;
            lineArtRenderingSettings1.SmoothingMode = Gnostice.Graphics.SmoothingMode.AntiAlias;
            renderingSettings1.LineArt = lineArtRenderingSettings1;
            resolutionSettings1.DpiX = 96F;
            resolutionSettings1.DpiY = 96F;
            resolutionSettings1.ResolutionMode = Gnostice.Graphics.ResolutionMode.UseSource;
            renderingSettings1.Resolution = resolutionSettings1;
            textRenderingSettings1.TextContrast = 3;
            textRenderingSettings1.TextRenderingHint = Gnostice.Graphics.TextRenderingHint.AntiAlias;
            renderingSettings1.Text = textRenderingSettings1;
            this.documentViewer1.Preferences.RenderingSettings = renderingSettings1;
            this.documentViewer1.Preferences.Units = Gnostice.Graphics.MeasurementUnit.Inches;
            this.documentViewer1.Size = new System.Drawing.Size(665, 780);
            this.documentViewer1.TabIndex = 17;
            this.documentViewer1.VScrollBar.LargeChange = 40;
            this.documentViewer1.VScrollBar.SmallChange = 20;
            this.documentViewer1.VScrollBar.Value = 0;
            this.documentViewer1.VScrollBar.Visibility = Gnostice.Documents.Controls.WinForms.ScrollBarVisibility.Auto;
            this.documentViewer1.Zoom.ZoomMode = Gnostice.Documents.Controls.WinForms.ZoomMode.FitPage;
            this.documentViewer1.Zoom.ZoomPercent = 100D;
            // 
            // frmHauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 850);
            this.Controls.Add(this.documentViewer1);
            this.Controls.Add(this.btnOeffnen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.cbDokArt);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnSuche);
            this.Controls.Add(this.cbLieferant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVerschlagwortSuche);
            this.Controls.Add(this.txtPerSuche);
            this.Controls.Add(this.txtSucheAlles);
            this.Controls.Add(this.txtPeriode);
            this.Controls.Add(this.chboVolltext);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvListeDok);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHauptfenster";
            this.Text = "DMS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSucheAlles;
        private System.Windows.Forms.CheckBox chboVolltext;
        private System.Windows.Forms.DataGridView dgvListeDok;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.TextBox txtVerschlagwortSuche;
        private System.Windows.Forms.TextBox txtPerSuche;
        private System.Windows.Forms.ToolStripMenuItem dokumentHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumenteImportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumenteImportierenToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbDokArt;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbLieferant;
        private System.Windows.Forms.TextBox txtPeriode;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnOeffnen;
        private System.Windows.Forms.Button btnExport;
        private Gnostice.Documents.Controls.WinForms.DocumentViewer documentViewer1;
    }
}