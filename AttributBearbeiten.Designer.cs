namespace DMSRupObk
{
    partial class frmAttributBearbeiten
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
            this.lblKey = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnNeu = new System.Windows.Forms.Button();
            this.dgAttribute = new System.Windows.Forms.DataGridView();
            this.lblKeyCalc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAttribute)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(10, 537);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(28, 13);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Key:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(46, 563);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 563);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(243, 467);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 5;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(243, 496);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.btnAbbrechen.TabIndex = 6;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(243, 438);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(75, 23);
            this.btnNeu.TabIndex = 7;
            this.btnNeu.Text = "Hinzufügen";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // dgAttribute
            // 
            this.dgAttribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAttribute.Location = new System.Drawing.Point(13, 13);
            this.dgAttribute.Name = "dgAttribute";
            this.dgAttribute.Size = new System.Drawing.Size(205, 506);
            this.dgAttribute.TabIndex = 8;
            // 
            // lblKeyCalc
            // 
            this.lblKeyCalc.AutoSize = true;
            this.lblKeyCalc.Location = new System.Drawing.Point(43, 537);
            this.lblKeyCalc.Name = "lblKeyCalc";
            this.lblKeyCalc.Size = new System.Drawing.Size(35, 13);
            this.lblKeyCalc.TabIndex = 9;
            this.lblKeyCalc.Text = "lblKey";
            // 
            // frmAttributBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 595);
            this.Controls.Add(this.lblKeyCalc);
            this.Controls.Add(this.dgAttribute);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblKey);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAttributBearbeiten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttributBearbeiten";
            ((System.ComponentModel.ISupportInitialize)(this.dgAttribute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.DataGridView dgAttribute;
        private System.Windows.Forms.Label lblKeyCalc;
    }
}