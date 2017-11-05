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
            this.splitContainerHauptfenster = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dgvDokumente = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelRechts = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHauptfenster)).BeginInit();
            this.splitContainerHauptfenster.Panel1.SuspendLayout();
            this.splitContainerHauptfenster.Panel2.SuspendLayout();
            this.splitContainerHauptfenster.SuspendLayout();
            this.flowLayoutPanelLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumente)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1475, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.splitContainerHauptfenster.Size = new System.Drawing.Size(1475, 785);
            this.splitContainerHauptfenster.SplitterDistance = 695;
            this.splitContainerHauptfenster.TabIndex = 1;
            // 
            // flowLayoutPanelLinks
            // 
            this.flowLayoutPanelLinks.AutoScroll = true;
            this.flowLayoutPanelLinks.Controls.Add(this.label1);
            this.flowLayoutPanelLinks.Controls.Add(this.textBox1);
            this.flowLayoutPanelLinks.Controls.Add(this.checkBox1);
            this.flowLayoutPanelLinks.Controls.Add(this.dgvDokumente);
            this.flowLayoutPanelLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelLinks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelLinks.Name = "flowLayoutPanelLinks";
            this.flowLayoutPanelLinks.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelLinks.Size = new System.Drawing.Size(691, 781);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(395, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Volltext";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dgvDokumente
            // 
            this.dgvDokumente.AllowUserToOrderColumns = true;
            this.dgvDokumente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDokumente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDokumente.Location = new System.Drawing.Point(13, 39);
            this.dgvDokumente.Name = "dgvDokumente";
            this.dgvDokumente.Size = new System.Drawing.Size(670, 734);
            this.dgvDokumente.TabIndex = 3;
            // 
            // flowLayoutPanelRechts
            // 
            this.flowLayoutPanelRechts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRechts.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelRechts.Name = "flowLayoutPanelRechts";
            this.flowLayoutPanelRechts.Size = new System.Drawing.Size(772, 781);
            this.flowLayoutPanelRechts.TabIndex = 0;
            // 
            // frmHauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 809);
            this.Controls.Add(this.splitContainerHauptfenster);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHauptfenster";
            this.Text = "DMS";
            this.splitContainerHauptfenster.Panel1.ResumeLayout(false);
            this.splitContainerHauptfenster.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHauptfenster)).EndInit();
            this.splitContainerHauptfenster.ResumeLayout(false);
            this.flowLayoutPanelLinks.ResumeLayout(false);
            this.flowLayoutPanelLinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainerHauptfenster;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRechts;
        private System.Windows.Forms.DataGridView dgvDokumente;
    }
}