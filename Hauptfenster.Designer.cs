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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Gnostice.Documents.FormatterSettings formatterSettings2 = new Gnostice.Documents.FormatterSettings();
            Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings spreadSheetFormatterSettings2 = new Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings3 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins3 = new Gnostice.Documents.Margins();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions3 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.Spreadsheet.SheetOptions sheetOptions4 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            Gnostice.Documents.TXTFormatterSettings txtFormatterSettings2 = new Gnostice.Documents.TXTFormatterSettings();
            Gnostice.Documents.PageSettings pageSettings4 = new Gnostice.Documents.PageSettings();
            Gnostice.Documents.Margins margins4 = new Gnostice.Documents.Margins();
            Gnostice.Graphics.RenderingSettings renderingSettings2 = new Gnostice.Graphics.RenderingSettings();
            Gnostice.Graphics.ImageRenderingSettings imageRenderingSettings2 = new Gnostice.Graphics.ImageRenderingSettings();
            Gnostice.Graphics.LineArtRenderingSettings lineArtRenderingSettings2 = new Gnostice.Graphics.LineArtRenderingSettings();
            Gnostice.Graphics.ResolutionSettings resolutionSettings2 = new Gnostice.Graphics.ResolutionSettings();
            Gnostice.Graphics.TextRenderingSettings textRenderingSettings2 = new Gnostice.Graphics.TextRenderingSettings();
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
            this.dgv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_dokartkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_dokartname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_liefkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_liefname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_verschlagwort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_jahr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_archdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_AenderDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_pfad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_dateiname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_statusdok = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuStrip1.Size = new System.Drawing.Size(1523, 24);
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
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suche:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSucheAlles
            // 
            this.txtSucheAlles.Location = new System.Drawing.Point(62, 27);
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
            this.btnSuche.Location = new System.Drawing.Point(924, -69);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(44, 23);
            this.btnSuche.TabIndex = 6;
            this.btnSuche.Text = "ok";
            this.btnSuche.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(51, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 20);
            this.txtID.TabIndex = 13;
            // 
            // cbDokArt
            // 
            this.cbDokArt.DropDownWidth = 140;
            this.cbDokArt.FormattingEnabled = true;
            this.cbDokArt.Location = new System.Drawing.Point(102, 57);
            this.cbDokArt.Name = "cbDokArt";
            this.cbDokArt.Size = new System.Drawing.Size(136, 21);
            this.cbDokArt.TabIndex = 10;
            // 
            // cbLieferant
            // 
            this.cbLieferant.DropDownWidth = 140;
            this.cbLieferant.FormattingEnabled = true;
            this.cbLieferant.Location = new System.Drawing.Point(242, 57);
            this.cbLieferant.Name = "cbLieferant";
            this.cbLieferant.Size = new System.Drawing.Size(145, 21);
            this.cbLieferant.TabIndex = 10;
            // 
            // txtVerschlagwortSuche
            // 
            this.txtVerschlagwortSuche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVerschlagwortSuche.Location = new System.Drawing.Point(392, 57);
            this.txtVerschlagwortSuche.Name = "txtVerschlagwortSuche";
            this.txtVerschlagwortSuche.Size = new System.Drawing.Size(245, 20);
            this.txtVerschlagwortSuche.TabIndex = 7;
            // 
            // txtPerSuche
            // 
            this.txtPerSuche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPerSuche.Location = new System.Drawing.Point(641, 57);
            this.txtPerSuche.Name = "txtPerSuche";
            this.txtPerSuche.Size = new System.Drawing.Size(95, 20);
            this.txtPerSuche.TabIndex = 9;
            // 
            // txtPeriode
            // 
            this.txtPeriode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeriode.Location = new System.Drawing.Point(742, 57);
            this.txtPeriode.Name = "txtPeriode";
            this.txtPeriode.Size = new System.Drawing.Size(33, 20);
            this.txtPeriode.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(781, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(74, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(859, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 16;
            // 
            // dgvListeDok
            // 
            this.dgvListeDok.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvListeDok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_id,
            this.dgv_dokartkey,
            this.dgv_dokartname,
            this.dgv_liefkey,
            this.dgv_liefname,
            this.dgv_verschlagwort,
            this.dgv_period,
            this.dgv_jahr,
            this.dgv_archdat,
            this.dgv_AenderDat,
            this.dgv_pfad,
            this.dgv_dateiname,
            this.dgv_statusdok});
            this.dgvListeDok.Location = new System.Drawing.Point(8, 84);
            this.dgvListeDok.Name = "dgvListeDok";
            this.dgvListeDok.Size = new System.Drawing.Size(927, 561);
            this.dgvListeDok.TabIndex = 5;
            this.dgvListeDok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeDok_CellClick);
            // 
            // dgv_id
            // 
            this.dgv_id.HeaderText = "ID";
            this.dgv_id.Name = "dgv_id";
            this.dgv_id.ReadOnly = true;
            this.dgv_id.Width = 50;
            // 
            // dgv_dokartkey
            // 
            this.dgv_dokartkey.HeaderText = "DokArt-Key";
            this.dgv_dokartkey.Name = "dgv_dokartkey";
            this.dgv_dokartkey.ReadOnly = true;
            this.dgv_dokartkey.Visible = false;
            this.dgv_dokartkey.Width = 50;
            // 
            // dgv_dokartname
            // 
            this.dgv_dokartname.HeaderText = "Dokumentenart";
            this.dgv_dokartname.Name = "dgv_dokartname";
            this.dgv_dokartname.ReadOnly = true;
            this.dgv_dokartname.Width = 140;
            // 
            // dgv_liefkey
            // 
            this.dgv_liefkey.HeaderText = "Lief-Key";
            this.dgv_liefkey.Name = "dgv_liefkey";
            this.dgv_liefkey.ReadOnly = true;
            this.dgv_liefkey.Visible = false;
            this.dgv_liefkey.Width = 50;
            // 
            // dgv_liefname
            // 
            this.dgv_liefname.HeaderText = "Lieferant";
            this.dgv_liefname.Name = "dgv_liefname";
            this.dgv_liefname.ReadOnly = true;
            this.dgv_liefname.Width = 150;
            // 
            // dgv_verschlagwort
            // 
            this.dgv_verschlagwort.HeaderText = "Verschlagwortung";
            this.dgv_verschlagwort.Name = "dgv_verschlagwort";
            this.dgv_verschlagwort.ReadOnly = true;
            this.dgv_verschlagwort.Width = 250;
            // 
            // dgv_period
            // 
            this.dgv_period.HeaderText = "Periode";
            this.dgv_period.Name = "dgv_period";
            this.dgv_period.ReadOnly = true;
            // 
            // dgv_jahr
            // 
            this.dgv_jahr.HeaderText = "Jahr";
            this.dgv_jahr.Name = "dgv_jahr";
            this.dgv_jahr.ReadOnly = true;
            this.dgv_jahr.Width = 40;
            // 
            // dgv_archdat
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dgv_archdat.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_archdat.HeaderText = "Arch. Datum";
            this.dgv_archdat.Name = "dgv_archdat";
            this.dgv_archdat.ReadOnly = true;
            this.dgv_archdat.Width = 80;
            // 
            // dgv_AenderDat
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dgv_AenderDat.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_AenderDat.HeaderText = "Änder.Datum";
            this.dgv_AenderDat.Name = "dgv_AenderDat";
            this.dgv_AenderDat.ReadOnly = true;
            this.dgv_AenderDat.Width = 80;
            // 
            // dgv_pfad
            // 
            this.dgv_pfad.HeaderText = "Pfad";
            this.dgv_pfad.Name = "dgv_pfad";
            this.dgv_pfad.ReadOnly = true;
            this.dgv_pfad.Width = 150;
            // 
            // dgv_dateiname
            // 
            this.dgv_dateiname.HeaderText = "Dateiname";
            this.dgv_dateiname.Name = "dgv_dateiname";
            this.dgv_dateiname.ReadOnly = true;
            this.dgv_dateiname.Width = 120;
            // 
            // dgv_statusdok
            // 
            this.dgv_statusdok.HeaderText = "Dok Status";
            this.dgv_statusdok.Name = "dgv_statusdok";
            this.dgv_statusdok.ReadOnly = true;
            this.dgv_statusdok.Width = 50;
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
            this.documentViewer1.Location = new System.Drawing.Point(942, 84);
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
            spreadSheetFormatterSettings2.FormattingMode = Gnostice.DOM.FormattingMode.PreferDocumentSettings;
            spreadSheetFormatterSettings2.PageOrder = Gnostice.Documents.Spreadsheet.LayoutDirection.BackwardN;
            pageSettings3.Height = 11.6929F;
            margins3.Bottom = 1F;
            margins3.Footer = 0F;
            margins3.Header = 0F;
            margins3.Left = 1F;
            margins3.Right = 1F;
            margins3.Top = 1F;
            pageSettings3.Margin = margins3;
            pageSettings3.Orientation = Gnostice.Graphics.Orientation.Portrait;
            pageSettings3.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings3.Width = 8.2677F;
            spreadSheetFormatterSettings2.PageSettings = pageSettings3;
            sheetOptions3.Print = false;
            sheetOptions3.View = true;
            spreadSheetFormatterSettings2.ShowGridlines = sheetOptions3;
            sheetOptions4.Print = false;
            sheetOptions4.View = true;
            spreadSheetFormatterSettings2.ShowHeadings = sheetOptions4;
            formatterSettings2.SpreadSheet = spreadSheetFormatterSettings2;
            txtFormatterSettings2.Font = new System.Drawing.Font("Calibri", 12F);
            pageSettings4.Height = 11.6929F;
            margins4.Bottom = 1F;
            margins4.Footer = 0F;
            margins4.Header = 0F;
            margins4.Left = 1F;
            margins4.Right = 1F;
            margins4.Top = 1F;
            pageSettings4.Margin = margins4;
            pageSettings4.Orientation = Gnostice.Graphics.Orientation.Portrait;
            pageSettings4.PageSize = Gnostice.Documents.PageSize.A4;
            pageSettings4.Width = 8.2677F;
            txtFormatterSettings2.PageSettings = pageSettings4;
            formatterSettings2.TXT = txtFormatterSettings2;
            this.documentViewer1.Preferences.FormatterSettings = formatterSettings2;
            this.documentViewer1.Preferences.KeyNavigation = true;
            imageRenderingSettings2.CompositingMode = Gnostice.Graphics.CompositingMode.SourceOver;
            imageRenderingSettings2.CompositingQuality = Gnostice.Graphics.CompositingQuality.Default;
            imageRenderingSettings2.InterpolationMode = Gnostice.Graphics.InterpolationMode.NearestNeighbor;
            imageRenderingSettings2.PixelOffsetMode = Gnostice.Graphics.PixelOffsetMode.HighQuality;
            renderingSettings2.Image = imageRenderingSettings2;
            lineArtRenderingSettings2.SmoothingMode = Gnostice.Graphics.SmoothingMode.AntiAlias;
            renderingSettings2.LineArt = lineArtRenderingSettings2;
            resolutionSettings2.DpiX = 96F;
            resolutionSettings2.DpiY = 96F;
            resolutionSettings2.ResolutionMode = Gnostice.Graphics.ResolutionMode.UseSource;
            renderingSettings2.Resolution = resolutionSettings2;
            textRenderingSettings2.TextContrast = 3;
            textRenderingSettings2.TextRenderingHint = Gnostice.Graphics.TextRenderingHint.AntiAlias;
            renderingSettings2.Text = textRenderingSettings2;
            this.documentViewer1.Preferences.RenderingSettings = renderingSettings2;
            this.documentViewer1.Preferences.Units = Gnostice.Graphics.MeasurementUnit.Inches;
            this.documentViewer1.Size = new System.Drawing.Size(573, 561);
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
            this.ClientSize = new System.Drawing.Size(1523, 659);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_dokartkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_dokartname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_liefkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_liefname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_verschlagwort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_period;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_jahr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_archdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_AenderDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_pfad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_dateiname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_statusdok;
    }
}