namespace KongN.Voip
{
    partial class FrmTrasferimentoStorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrasferimentoStorico));
            this.btnTrasferisci = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.lblDataMassimaDiTrasferimento = new System.Windows.Forms.Label();
            this.dtpTrasferimento = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.SuspendLayout();
            // 
            // btnTrasferisci
            // 
            this.btnTrasferisci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrasferisci.Location = new System.Drawing.Point(27, 138);
            this.btnTrasferisci.Name = "btnTrasferisci";
            this.btnTrasferisci.Size = new System.Drawing.Size(78, 30);
            this.btnTrasferisci.TabIndex = 31;
            this.btnTrasferisci.Text = "Trasferisci";
            this.btnTrasferisci.UseVisualStyleBackColor = true;
            this.btnTrasferisci.Click += new System.EventHandler(this.btnTrasferisci_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(329, 138);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 30;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // lblDataMassimaDiTrasferimento
            // 
            this.lblDataMassimaDiTrasferimento.AutoSize = true;
            this.lblDataMassimaDiTrasferimento.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataMassimaDiTrasferimento.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDataMassimaDiTrasferimento.Location = new System.Drawing.Point(24, 66);
            this.lblDataMassimaDiTrasferimento.Name = "lblDataMassimaDiTrasferimento";
            this.lblDataMassimaDiTrasferimento.Size = new System.Drawing.Size(197, 18);
            this.lblDataMassimaDiTrasferimento.TabIndex = 33;
            this.lblDataMassimaDiTrasferimento.Text = "Data massima di trasferimento";
            // 
            // dtpTrasferimento
            // 
            this.dtpTrasferimento.DateTimeIcon = null;
            this.dtpTrasferimento.Location = new System.Drawing.Point(238, 66);
            this.dtpTrasferimento.Name = "dtpTrasferimento";
            this.dtpTrasferimento.Size = new System.Drawing.Size(114, 21);
            this.dtpTrasferimento.TabIndex = 34;
            this.dtpTrasferimento.ToolTipText = "";
            // 
            // FrmTrasferimentoStorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(429, 191);
            this.Controls.Add(this.dtpTrasferimento);
            this.Controls.Add(this.lblDataMassimaDiTrasferimento);
            this.Controls.Add(this.btnTrasferisci);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(445, 230);
            this.MinimumSize = new System.Drawing.Size(445, 230);
            this.Name = "FrmTrasferimentoStorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trasferimento Storico delle Chiamate";
            this.Load += new System.EventHandler(this.FrmTrasferimentoStorico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrasferisci;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Label lblDataMassimaDiTrasferimento;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpTrasferimento;
    }
}