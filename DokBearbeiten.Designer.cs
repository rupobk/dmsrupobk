namespace DMSRupObk
{
    partial class frmDokBearbeiten
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
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerHauptfenster = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelLinks = new System.Windows.Forms.TableLayoutPanel();
            this.lblDokArt = new System.Windows.Forms.Label();
            this.lblDokID = new System.Windows.Forms.Label();
            this.lblGuid2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblVolltext = new System.Windows.Forms.Label();
            this.txtVolltext = new System.Windows.Forms.RichTextBox();
            this.txtDateiname = new System.Windows.Forms.TextBox();
            this.lblAenderDatum = new System.Windows.Forms.Label();
            this.lblArchivierDatum = new System.Windows.Forms.Label();
            this.lblDateiname = new System.Windows.Forms.Label();
            this.btnDokuartBearbeiten = new System.Windows.Forms.Button();
            this.btnOCRScan = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblZielpfad = new System.Windows.Forms.Label();
            this.btnZielpfadBearbeiten = new System.Windows.Forms.Button();
            this.lblLieferant = new System.Windows.Forms.Label();
            this.btnLiefBearbeiten = new System.Windows.Forms.Button();
            this.txtVerschlagwort = new System.Windows.Forms.TextBox();
            this.lblVerschlagwort = new System.Windows.Forms.Label();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.txtPeriode = new System.Windows.Forms.TextBox();
            this.lblJahr = new System.Windows.Forms.Label();
            this.btnLaden = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPeriodSyntax = new System.Windows.Forms.Label();
            this.dtpArchivierung = new System.Windows.Forms.DateTimePicker();
            this.dtpAenderung = new System.Windows.Forms.DateTimePicker();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.txtAbbrechen = new System.Windows.Forms.Button();
            this.lblOrgDateiname = new System.Windows.Forms.Label();
            this.documentViewer1 = new Gnostice.Documents.Controls.WinForms.DocumentViewer();
            this.cbDokArt = new DMSRupObk.SearchableComboBox();
            this.cbZielpfad = new DMSRupObk.SearchableComboBox();
            this.cbStatus = new DMSRupObk.SearchableComboBox();
            this.cbLieferant = new DMSRupObk.SearchableComboBox();
            this.txtJahr = new DMSRupObk.NumTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHauptfenster)).BeginInit();
            this.splitContainerHauptfenster.Panel1.SuspendLayout();
            this.splitContainerHauptfenster.Panel2.SuspendLayout();
            this.splitContainerHauptfenster.SuspendLayout();
            this.tableLayoutPanelLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.hinzufügenToolStripMenuItem.Text = "Datei";
            // 
            // splitContainerHauptfenster
            // 
            this.splitContainerHauptfenster.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainerHauptfenster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerHauptfenster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHauptfenster.Location = new System.Drawing.Point(0, 24);
            this.splitContainerHauptfenster.Name = "splitContainerHauptfenster";
            // 
            // splitContainerHauptfenster.Panel1
            // 
            this.splitContainerHauptfenster.Panel1.Controls.Add(this.tableLayoutPanelLinks);
            this.splitContainerHauptfenster.Panel1MinSize = 510;
            // 
            // splitContainerHauptfenster.Panel2
            // 
            this.splitContainerHauptfenster.Panel2.Controls.Add(this.documentViewer1);
            this.splitContainerHauptfenster.Size = new System.Drawing.Size(1229, 736);
            this.splitContainerHauptfenster.SplitterDistance = 510;
            this.splitContainerHauptfenster.TabIndex = 0;
            // 
            // tableLayoutPanelLinks
            // 
            this.tableLayoutPanelLinks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelLinks.ColumnCount = 6;
            this.tableLayoutPanelLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanelLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanelLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanelLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanelLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanelLinks.Controls.Add(this.lblDokArt, 0, 2);
            this.tableLayoutPanelLinks.Controls.Add(this.lblDokID, 1, 1);
            this.tableLayoutPanelLinks.Controls.Add(this.lblGuid2, 0, 1);
            this.tableLayoutPanelLinks.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanelLinks.Controls.Add(this.cbDokArt, 1, 2);
            this.tableLayoutPanelLinks.Controls.Add(this.lblVolltext, 0, 12);
            this.tableLayoutPanelLinks.Controls.Add(this.txtVolltext, 1, 12);
            this.tableLayoutPanelLinks.Controls.Add(this.txtDateiname, 1, 9);
            this.tableLayoutPanelLinks.Controls.Add(this.lblAenderDatum, 0, 11);
            this.tableLayoutPanelLinks.Controls.Add(this.lblArchivierDatum, 0, 10);
            this.tableLayoutPanelLinks.Controls.Add(this.lblDateiname, 0, 9);
            this.tableLayoutPanelLinks.Controls.Add(this.btnDokuartBearbeiten, 4, 2);
            this.tableLayoutPanelLinks.Controls.Add(this.btnOCRScan, 1, 23);
            this.tableLayoutPanelLinks.Controls.Add(this.lblStatus, 0, 8);
            this.tableLayoutPanelLinks.Controls.Add(this.lblZielpfad, 0, 3);
            this.tableLayoutPanelLinks.Controls.Add(this.cbZielpfad, 1, 3);
            this.tableLayoutPanelLinks.Controls.Add(this.btnZielpfadBearbeiten, 4, 3);
            this.tableLayoutPanelLinks.Controls.Add(this.cbStatus, 1, 8);
            this.tableLayoutPanelLinks.Controls.Add(this.lblLieferant, 0, 5);
            this.tableLayoutPanelLinks.Controls.Add(this.cbLieferant, 1, 5);
            this.tableLayoutPanelLinks.Controls.Add(this.btnLiefBearbeiten, 4, 5);
            this.tableLayoutPanelLinks.Controls.Add(this.txtVerschlagwort, 1, 4);
            this.tableLayoutPanelLinks.Controls.Add(this.lblVerschlagwort, 0, 4);
            this.tableLayoutPanelLinks.Controls.Add(this.lblPeriode, 0, 6);
            this.tableLayoutPanelLinks.Controls.Add(this.txtPeriode, 1, 6);
            this.tableLayoutPanelLinks.Controls.Add(this.txtJahr, 1, 7);
            this.tableLayoutPanelLinks.Controls.Add(this.lblJahr, 0, 7);
            this.tableLayoutPanelLinks.Controls.Add(this.btnLaden, 0, 23);
            this.tableLayoutPanelLinks.Controls.Add(this.btnClear, 2, 23);
            this.tableLayoutPanelLinks.Controls.Add(this.lblPeriodSyntax, 2, 6);
            this.tableLayoutPanelLinks.Controls.Add(this.dtpArchivierung, 1, 10);
            this.tableLayoutPanelLinks.Controls.Add(this.dtpAenderung, 1, 11);
            this.tableLayoutPanelLinks.Controls.Add(this.btnSpeichern, 3, 22);
            this.tableLayoutPanelLinks.Controls.Add(this.txtAbbrechen, 4, 23);
            this.tableLayoutPanelLinks.Controls.Add(this.lblOrgDateiname, 3, 9);
            this.tableLayoutPanelLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLinks.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLinks.Name = "tableLayoutPanelLinks";
            this.tableLayoutPanelLinks.RowCount = 24;
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanelLinks.Size = new System.Drawing.Size(506, 732);
            this.tableLayoutPanelLinks.TabIndex = 0;
            this.tableLayoutPanelLinks.SizeChanged += new System.EventHandler(this.tableLayoutPanelLinks_SizeChanged);
            // 
            // lblDokArt
            // 
            this.lblDokArt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDokArt.AutoSize = true;
            this.lblDokArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDokArt.Location = new System.Drawing.Point(23, 66);
            this.lblDokArt.Name = "lblDokArt";
            this.lblDokArt.Size = new System.Drawing.Size(90, 13);
            this.lblDokArt.TabIndex = 1;
            this.lblDokArt.Text = "Dokumentenart: *";
            // 
            // lblDokID
            // 
            this.lblDokID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDokID.AutoSize = true;
            this.tableLayoutPanelLinks.SetColumnSpan(this.lblDokID, 3);
            this.lblDokID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDokID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDokID.Location = new System.Drawing.Point(119, 37);
            this.lblDokID.Name = "lblDokID";
            this.lblDokID.Size = new System.Drawing.Size(108, 13);
            this.lblDokID.TabIndex = 10;
            this.lblDokID.Text = "Fortlaufende Nummer";
            this.lblDokID.Enter += new System.EventHandler(this.lblDokID_Enter);
            // 
            // lblGuid2
            // 
            this.lblGuid2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGuid2.AutoSize = true;
            this.lblGuid2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGuid2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGuid2.Location = new System.Drawing.Point(66, 37);
            this.lblGuid2.Name = "lblGuid2";
            this.lblGuid2.Size = new System.Drawing.Size(47, 13);
            this.lblGuid2.TabIndex = 1;
            this.lblGuid2.Text = "DokID:  ";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.tableLayoutPanelLinks.SetColumnSpan(this.label12, 5);
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(176, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Verschlagwortung";
            // 
            // lblVolltext
            // 
            this.lblVolltext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVolltext.AutoSize = true;
            this.lblVolltext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVolltext.Location = new System.Drawing.Point(38, 356);
            this.lblVolltext.Name = "lblVolltext";
            this.lblVolltext.Size = new System.Drawing.Size(75, 13);
            this.lblVolltext.TabIndex = 1;
            this.lblVolltext.Text = "Volltextindex:  ";
            // 
            // txtVolltext
            // 
            this.tableLayoutPanelLinks.SetColumnSpan(this.txtVolltext, 5);
            this.txtVolltext.Location = new System.Drawing.Point(118, 350);
            this.txtVolltext.Margin = new System.Windows.Forms.Padding(2);
            this.txtVolltext.Name = "txtVolltext";
            this.tableLayoutPanelLinks.SetRowSpan(this.txtVolltext, 9);
            this.txtVolltext.Size = new System.Drawing.Size(379, 257);
            this.txtVolltext.TabIndex = 120;
            this.txtVolltext.Text = "";
            // 
            // txtDateiname
            // 
            this.txtDateiname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelLinks.SetColumnSpan(this.txtDateiname, 2);
            this.txtDateiname.Location = new System.Drawing.Point(119, 265);
            this.txtDateiname.Name = "txtDateiname";
            this.txtDateiname.Size = new System.Drawing.Size(150, 20);
            this.txtDateiname.TabIndex = 90;
            // 
            // lblAenderDatum
            // 
            this.lblAenderDatum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAenderDatum.AutoSize = true;
            this.lblAenderDatum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAenderDatum.Location = new System.Drawing.Point(16, 327);
            this.lblAenderDatum.Name = "lblAenderDatum";
            this.lblAenderDatum.Size = new System.Drawing.Size(97, 13);
            this.lblAenderDatum.TabIndex = 1;
            this.lblAenderDatum.Text = "Datum Änderung: *";
            // 
            // lblArchivierDatum
            // 
            this.lblArchivierDatum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblArchivierDatum.AutoSize = true;
            this.lblArchivierDatum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblArchivierDatum.Location = new System.Drawing.Point(3, 298);
            this.lblArchivierDatum.Name = "lblArchivierDatum";
            this.lblArchivierDatum.Size = new System.Drawing.Size(110, 13);
            this.lblArchivierDatum.TabIndex = 1;
            this.lblArchivierDatum.Text = "Datum Archivierung: *";
            // 
            // lblDateiname
            // 
            this.lblDateiname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateiname.AutoSize = true;
            this.lblDateiname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateiname.Location = new System.Drawing.Point(5, 269);
            this.lblDateiname.Name = "lblDateiname";
            this.lblDateiname.Size = new System.Drawing.Size(108, 13);
            this.lblDateiname.TabIndex = 1;
            this.lblDateiname.Text = "Dateiname org/neu:  ";
            // 
            // btnDokuartBearbeiten
            // 
            this.btnDokuartBearbeiten.Location = new System.Drawing.Point(435, 60);
            this.btnDokuartBearbeiten.Margin = new System.Windows.Forms.Padding(2);
            this.btnDokuartBearbeiten.Name = "btnDokuartBearbeiten";
            this.btnDokuartBearbeiten.Size = new System.Drawing.Size(68, 25);
            this.btnDokuartBearbeiten.TabIndex = 180;
            this.btnDokuartBearbeiten.Text = "Bearbeiten";
            this.btnDokuartBearbeiten.UseVisualStyleBackColor = true;
            this.btnDokuartBearbeiten.Click += new System.EventHandler(this.btnDokuartBearbeiten_Click);
            // 
            // btnOCRScan
            // 
            this.btnOCRScan.Location = new System.Drawing.Point(118, 669);
            this.btnOCRScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnOCRScan.Name = "btnOCRScan";
            this.btnOCRScan.Size = new System.Drawing.Size(74, 27);
            this.btnOCRScan.TabIndex = 160;
            this.btnOCRScan.Text = "OCR-Scan";
            this.btnOCRScan.UseVisualStyleBackColor = true;
            this.btnOCRScan.Click += new System.EventHandler(this.btnOCRScan_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStatus.AutoSize = true;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Location = new System.Drawing.Point(66, 240);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: *";
            // 
            // lblZielpfad
            // 
            this.lblZielpfad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblZielpfad.AutoSize = true;
            this.lblZielpfad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblZielpfad.Location = new System.Drawing.Point(58, 95);
            this.lblZielpfad.Name = "lblZielpfad";
            this.lblZielpfad.Size = new System.Drawing.Size(55, 13);
            this.lblZielpfad.TabIndex = 1;
            this.lblZielpfad.Text = "Zielpfad: *";
            // 
            // btnZielpfadBearbeiten
            // 
            this.btnZielpfadBearbeiten.Location = new System.Drawing.Point(435, 89);
            this.btnZielpfadBearbeiten.Margin = new System.Windows.Forms.Padding(2);
            this.btnZielpfadBearbeiten.Name = "btnZielpfadBearbeiten";
            this.btnZielpfadBearbeiten.Size = new System.Drawing.Size(68, 25);
            this.btnZielpfadBearbeiten.TabIndex = 190;
            this.btnZielpfadBearbeiten.Text = "Bearbeiten";
            this.btnZielpfadBearbeiten.UseVisualStyleBackColor = true;
            this.btnZielpfadBearbeiten.Click += new System.EventHandler(this.btnZielpfadBearbeiten_Click);
            // 
            // lblLieferant
            // 
            this.lblLieferant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLieferant.AutoSize = true;
            this.lblLieferant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLieferant.Location = new System.Drawing.Point(56, 153);
            this.lblLieferant.Name = "lblLieferant";
            this.lblLieferant.Size = new System.Drawing.Size(57, 13);
            this.lblLieferant.TabIndex = 1;
            this.lblLieferant.Text = "Lieferant:  ";
            // 
            // btnLiefBearbeiten
            // 
            this.btnLiefBearbeiten.Location = new System.Drawing.Point(435, 147);
            this.btnLiefBearbeiten.Margin = new System.Windows.Forms.Padding(2);
            this.btnLiefBearbeiten.Name = "btnLiefBearbeiten";
            this.btnLiefBearbeiten.Size = new System.Drawing.Size(68, 25);
            this.btnLiefBearbeiten.TabIndex = 200;
            this.btnLiefBearbeiten.Text = "Bearbeiten";
            this.btnLiefBearbeiten.UseVisualStyleBackColor = true;
            this.btnLiefBearbeiten.Click += new System.EventHandler(this.btnLiefBearbeiten_Click);
            // 
            // txtVerschlagwort
            // 
            this.txtVerschlagwort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelLinks.SetColumnSpan(this.txtVerschlagwort, 5);
            this.txtVerschlagwort.Location = new System.Drawing.Point(119, 120);
            this.txtVerschlagwort.Name = "txtVerschlagwort";
            this.txtVerschlagwort.Size = new System.Drawing.Size(384, 20);
            this.txtVerschlagwort.TabIndex = 40;
            // 
            // lblVerschlagwort
            // 
            this.lblVerschlagwort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVerschlagwort.AutoSize = true;
            this.lblVerschlagwort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVerschlagwort.Location = new System.Drawing.Point(11, 124);
            this.lblVerschlagwort.Name = "lblVerschlagwort";
            this.lblVerschlagwort.Size = new System.Drawing.Size(102, 13);
            this.lblVerschlagwort.TabIndex = 1;
            this.lblVerschlagwort.Text = "Verschlagwortung: *";
            // 
            // lblPeriode
            // 
            this.lblPeriode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPeriode.Location = new System.Drawing.Point(61, 182);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(52, 13);
            this.lblPeriode.TabIndex = 1;
            this.lblPeriode.Text = "Periode:  ";
            // 
            // txtPeriode
            // 
            this.txtPeriode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPeriode.Location = new System.Drawing.Point(119, 178);
            this.txtPeriode.Name = "txtPeriode";
            this.txtPeriode.Size = new System.Drawing.Size(150, 20);
            this.txtPeriode.TabIndex = 60;
            // 
            // lblJahr
            // 
            this.lblJahr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblJahr.AutoSize = true;
            this.lblJahr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJahr.Location = new System.Drawing.Point(76, 211);
            this.lblJahr.Name = "lblJahr";
            this.lblJahr.Size = new System.Drawing.Size(37, 13);
            this.lblJahr.TabIndex = 1;
            this.lblJahr.Text = "Jahr: *";
            // 
            // btnLaden
            // 
            this.btnLaden.Location = new System.Drawing.Point(2, 669);
            this.btnLaden.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaden.Name = "btnLaden";
            this.btnLaden.Size = new System.Drawing.Size(98, 25);
            this.btnLaden.TabIndex = 170;
            this.btnLaden.Text = "Datei neu laden";
            this.btnLaden.UseVisualStyleBackColor = true;
            this.btnLaden.Click += new System.EventHandler(this.btnLaden_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(275, 669);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 27);
            this.btnClear.TabIndex = 150;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPeriodSyntax
            // 
            this.lblPeriodSyntax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPeriodSyntax.AutoSize = true;
            this.tableLayoutPanelLinks.SetColumnSpan(this.lblPeriodSyntax, 3);
            this.lblPeriodSyntax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPeriodSyntax.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPeriodSyntax.Location = new System.Drawing.Point(276, 182);
            this.lblPeriodSyntax.Name = "lblPeriodSyntax";
            this.lblPeriodSyntax.Size = new System.Drawing.Size(213, 13);
            this.lblPeriodSyntax.TabIndex = 1000;
            this.lblPeriodSyntax.Text = "Syntax: YYYYMM od. YYYYMM-YYYYMM  ";
            // 
            // dtpArchivierung
            // 
            this.dtpArchivierung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpArchivierung.CustomFormat = "dd.MM.yyyy";
            this.dtpArchivierung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArchivierung.Location = new System.Drawing.Point(118, 294);
            this.dtpArchivierung.Margin = new System.Windows.Forms.Padding(2);
            this.dtpArchivierung.Name = "dtpArchivierung";
            this.dtpArchivierung.Size = new System.Drawing.Size(100, 20);
            this.dtpArchivierung.TabIndex = 100;
            // 
            // dtpAenderung
            // 
            this.dtpAenderung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpAenderung.CustomFormat = "dd.MM.yyyy";
            this.dtpAenderung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAenderung.Location = new System.Drawing.Point(118, 323);
            this.dtpAenderung.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAenderung.Name = "dtpAenderung";
            this.dtpAenderung.Size = new System.Drawing.Size(100, 20);
            this.dtpAenderung.TabIndex = 110;
            // 
            // btnSpeichern
            // 
            this.tableLayoutPanelLinks.SetColumnSpan(this.btnSpeichern, 2);
            this.btnSpeichern.Location = new System.Drawing.Point(364, 640);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(139, 25);
            this.btnSpeichern.TabIndex = 130;
            this.btnSpeichern.Text = "Speichern u. schließen";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // txtAbbrechen
            // 
            this.txtAbbrechen.Location = new System.Drawing.Point(435, 669);
            this.txtAbbrechen.Margin = new System.Windows.Forms.Padding(2);
            this.txtAbbrechen.Name = "txtAbbrechen";
            this.txtAbbrechen.Size = new System.Drawing.Size(68, 27);
            this.txtAbbrechen.TabIndex = 140;
            this.txtAbbrechen.Text = "Abbrechen";
            this.txtAbbrechen.UseVisualStyleBackColor = true;
            this.txtAbbrechen.Click += new System.EventHandler(this.txtAbbrechen_Click);
            // 
            // lblOrgDateiname
            // 
            this.lblOrgDateiname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrgDateiname.AutoSize = true;
            this.tableLayoutPanelLinks.SetColumnSpan(this.lblOrgDateiname, 2);
            this.lblOrgDateiname.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgDateiname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOrgDateiname.Location = new System.Drawing.Point(365, 271);
            this.lblOrgDateiname.Name = "lblOrgDateiname";
            this.lblOrgDateiname.Size = new System.Drawing.Size(0, 9);
            this.lblOrgDateiname.TabIndex = 1001;
            this.lblOrgDateiname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // documentViewer1
            // 
            this.documentViewer1.AutoScroll = true;
            this.documentViewer1.AutoSize = true;
            this.documentViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.documentViewer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.documentViewer1.BorderWidth = 10;
            this.documentViewer1.CurrentPage = 0;
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.HScrollBar.LargeChange = 40;
            this.documentViewer1.HScrollBar.SmallChange = 20;
            this.documentViewer1.HScrollBar.Value = 0;
            this.documentViewer1.HScrollBar.Visibility = Gnostice.Documents.Controls.WinForms.ScrollBarVisibility.Always;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
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
            this.documentViewer1.Size = new System.Drawing.Size(711, 732);
            this.documentViewer1.TabIndex = 0;
            this.documentViewer1.VScrollBar.LargeChange = 40;
            this.documentViewer1.VScrollBar.SmallChange = 20;
            this.documentViewer1.VScrollBar.Value = 0;
            this.documentViewer1.VScrollBar.Visibility = Gnostice.Documents.Controls.WinForms.ScrollBarVisibility.Auto;
            this.documentViewer1.Zoom.ZoomMode = Gnostice.Documents.Controls.WinForms.ZoomMode.FitPage;
            this.documentViewer1.Zoom.ZoomPercent = 100D;
            // 
            // cbDokArt
            // 
            this.cbDokArt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDokArt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDokArt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanelLinks.SetColumnSpan(this.cbDokArt, 2);
            this.cbDokArt.FormattingEnabled = true;
            this.cbDokArt.Location = new System.Drawing.Point(118, 62);
            this.cbDokArt.Margin = new System.Windows.Forms.Padding(2);
            this.cbDokArt.Name = "cbDokArt";
            this.cbDokArt.Size = new System.Drawing.Size(151, 21);
            this.cbDokArt.TabIndex = 20;
            // 
            // cbZielpfad
            // 
            this.cbZielpfad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbZielpfad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbZielpfad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanelLinks.SetColumnSpan(this.cbZielpfad, 3);
            this.cbZielpfad.FormattingEnabled = true;
            this.cbZielpfad.Location = new System.Drawing.Point(118, 91);
            this.cbZielpfad.Margin = new System.Windows.Forms.Padding(2);
            this.cbZielpfad.Name = "cbZielpfad";
            this.cbZielpfad.Size = new System.Drawing.Size(250, 21);
            this.cbZielpfad.TabIndex = 30;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanelLinks.SetColumnSpan(this.cbStatus, 2);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(118, 236);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(151, 21);
            this.cbStatus.TabIndex = 80;
            // 
            // cbLieferant
            // 
            this.cbLieferant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbLieferant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLieferant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanelLinks.SetColumnSpan(this.cbLieferant, 2);
            this.cbLieferant.FormattingEnabled = true;
            this.cbLieferant.Location = new System.Drawing.Point(118, 149);
            this.cbLieferant.Margin = new System.Windows.Forms.Padding(2);
            this.cbLieferant.Name = "cbLieferant";
            this.cbLieferant.Size = new System.Drawing.Size(151, 21);
            this.cbLieferant.TabIndex = 50;
            // 
            // txtJahr
            // 
            this.txtJahr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtJahr.Location = new System.Drawing.Point(119, 207);
            this.txtJahr.Name = "txtJahr";
            this.txtJahr.Size = new System.Drawing.Size(48, 20);
            this.txtJahr.TabIndex = 70;
            // 
            // frmDokBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1229, 760);
            this.Controls.Add(this.splitContainerHauptfenster);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDokBearbeiten";
            this.Text = "Dokumente bearbeiten";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerHauptfenster.Panel1.ResumeLayout(false);
            this.splitContainerHauptfenster.Panel2.ResumeLayout(false);
            this.splitContainerHauptfenster.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHauptfenster)).EndInit();
            this.splitContainerHauptfenster.ResumeLayout(false);
            this.tableLayoutPanelLinks.ResumeLayout(false);
            this.tableLayoutPanelLinks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainerHauptfenster;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLinks;
        private System.Windows.Forms.Label lblDokID;
        private System.Windows.Forms.Label lblDokArt;
        private System.Windows.Forms.Label lblLieferant;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.Label lblVerschlagwort;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDateiname;
        private System.Windows.Forms.Label lblArchivierDatum;
        private System.Windows.Forms.Label lblAenderDatum;
        private System.Windows.Forms.Label lblJahr;
        private System.Windows.Forms.Label lblVolltext;
        private System.Windows.Forms.TextBox txtPeriode;
        private System.Windows.Forms.TextBox txtVerschlagwort;
        private System.Windows.Forms.TextBox txtDateiname;
        private NumTextBox txtJahr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblGuid2;
        private System.Windows.Forms.Button txtAbbrechen;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.RichTextBox txtVolltext;
        private SearchableComboBox cbDokArt;
        private SearchableComboBox cbLieferant;
        private SearchableComboBox cbStatus;
        private System.Windows.Forms.Button btnLaden;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.Label lblZielpfad;
        private SearchableComboBox cbZielpfad;
        private System.Windows.Forms.Button btnOCRScan;
        private Gnostice.Documents.Controls.WinForms.DocumentViewer documentViewer1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDokuartBearbeiten;
        private System.Windows.Forms.Button btnLiefBearbeiten;
        private System.Windows.Forms.Button btnZielpfadBearbeiten;
        private System.Windows.Forms.Label lblPeriodSyntax;
        private System.Windows.Forms.DateTimePicker dtpArchivierung;
        private System.Windows.Forms.DateTimePicker dtpAenderung;
        private System.Windows.Forms.Label lblOrgDateiname;
    }
}