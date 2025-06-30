namespace KongN.Voip
{
    partial class FrmAutomatismiVoiP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutomatismiVoiP));
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.lblLunghezza = new System.Windows.Forms.Label();
            this.numPrefisso = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPrefisso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.Location = new System.Drawing.Point(35, 112);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 30);
            this.btnSalva.TabIndex = 21;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(579, 112);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 22;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // lblLunghezza
            // 
            this.lblLunghezza.AutoSize = true;
            this.lblLunghezza.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunghezza.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLunghezza.Location = new System.Drawing.Point(32, 51);
            this.lblLunghezza.Name = "lblLunghezza";
            this.lblLunghezza.Size = new System.Drawing.Size(349, 18);
            this.lblLunghezza.TabIndex = 24;
            this.lblLunghezza.Text = "Lunghezza del Prefisso per il Controllo Normalizzazione";
            // 
            // numPrefisso
            // 
            this.numPrefisso.Location = new System.Drawing.Point(392, 50);
            this.numPrefisso.Name = "numPrefisso";
            this.numPrefisso.Size = new System.Drawing.Size(88, 20);
            this.numPrefisso.TabIndex = 23;
            this.numPrefisso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmAutomatismiVoiP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(679, 167);
            this.Controls.Add(this.lblLunghezza);
            this.Controls.Add(this.numPrefisso);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(695, 206);
            this.MinimumSize = new System.Drawing.Size(695, 206);
            this.Name = "FrmAutomatismiVoiP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatismi VoiP";
            this.Load += new System.EventHandler(this.FrmAutomatismiVoiP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrefisso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Label lblLunghezza;
        private System.Windows.Forms.NumericUpDown numPrefisso;
    }
}