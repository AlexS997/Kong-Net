namespace KongN.SMS
{
    partial class FrmSmsSingolo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSmsSingolo));
            this.btnFattureAperte = new System.Windows.Forms.Button();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.btnPreleva = new System.Windows.Forms.Button();
            this.btnPredefinito = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.inseritilbl = new System.Windows.Forms.Label();
            this.Rimanentilbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodiceCliente = new System.Windows.Forms.Label();
            this.lblDenom = new System.Windows.Forms.Label();
            this.txtTipoMessaggio = new System.Windows.Forms.TextBox();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFattureAperte
            // 
            this.btnFattureAperte.Location = new System.Drawing.Point(46, 197);
            this.btnFattureAperte.Name = "btnFattureAperte";
            this.btnFattureAperte.Size = new System.Drawing.Size(75, 50);
            this.btnFattureAperte.TabIndex = 6;
            this.btnFattureAperte.Text = "Preleva Fatture Aperte";
            this.btnFattureAperte.UseVisualStyleBackColor = true;
            this.btnFattureAperte.Click += new System.EventHandler(this.btnFattureAperte_Click);
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(46, 253);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(75, 38);
            this.btnPulisci.TabIndex = 7;
            this.btnPulisci.Text = "Pulisci Messaggio";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // btnPreleva
            // 
            this.btnPreleva.Location = new System.Drawing.Point(46, 153);
            this.btnPreleva.Name = "btnPreleva";
            this.btnPreleva.Size = new System.Drawing.Size(75, 38);
            this.btnPreleva.TabIndex = 5;
            this.btnPreleva.Text = "Preleva Saldo";
            this.btnPreleva.UseVisualStyleBackColor = true;
            this.btnPreleva.Click += new System.EventHandler(this.btnPreleva_Click);
            // 
            // btnPredefinito
            // 
            this.btnPredefinito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPredefinito.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredefinito.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPredefinito.Location = new System.Drawing.Point(437, 28);
            this.btnPredefinito.Name = "btnPredefinito";
            this.btnPredefinito.Size = new System.Drawing.Size(29, 23);
            this.btnPredefinito.TabIndex = 2;
            this.btnPredefinito.Text = "...";
            this.btnPredefinito.UseVisualStyleBackColor = true;
            this.btnPredefinito.Click += new System.EventHandler(this.btnPredefinito_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerca.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCerca.Location = new System.Drawing.Point(249, 31);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(29, 23);
            this.btnCerca.TabIndex = 1;
            this.btnCerca.Text = "...";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // inseritilbl
            // 
            this.inseritilbl.AutoSize = true;
            this.inseritilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inseritilbl.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.inseritilbl.Location = new System.Drawing.Point(100, 302);
            this.inseritilbl.Name = "inseritilbl";
            this.inseritilbl.Size = new System.Drawing.Size(15, 16);
            this.inseritilbl.TabIndex = 17;
            this.inseritilbl.Text = "0";
            // 
            // Rimanentilbl
            // 
            this.Rimanentilbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rimanentilbl.AutoSize = true;
            this.Rimanentilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rimanentilbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.Rimanentilbl.Location = new System.Drawing.Point(520, 302);
            this.Rimanentilbl.Name = "Rimanentilbl";
            this.Rimanentilbl.Size = new System.Drawing.Size(15, 16);
            this.Rimanentilbl.TabIndex = 16;
            this.Rimanentilbl.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(305, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo Messaggio";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Max 320 Caratteri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(61, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Messaggio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(28, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numero Telefono";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(303, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Messaggio Predefinito";
            // 
            // lblCodiceCliente
            // 
            this.lblCodiceCliente.AutoSize = true;
            this.lblCodiceCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodiceCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCodiceCliente.Location = new System.Drawing.Point(28, 34);
            this.lblCodiceCliente.Name = "lblCodiceCliente";
            this.lblCodiceCliente.Size = new System.Drawing.Size(85, 15);
            this.lblCodiceCliente.TabIndex = 10;
            this.lblCodiceCliente.Text = "Codice Cliente";
            // 
            // lblDenom
            // 
            this.lblDenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDenom.AutoSize = true;
            this.lblDenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenom.Location = new System.Drawing.Point(119, 386);
            this.lblDenom.Name = "lblDenom";
            this.lblDenom.Size = new System.Drawing.Size(39, 16);
            this.lblDenom.TabIndex = 9;
            this.lblDenom.Text = "XXXX";
            // 
            // txtTipoMessaggio
            // 
            this.txtTipoMessaggio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoMessaggio.Location = new System.Drawing.Point(402, 76);
            this.txtTipoMessaggio.Name = "txtTipoMessaggio";
            this.txtTipoMessaggio.ReadOnly = true;
            this.txtTipoMessaggio.Size = new System.Drawing.Size(158, 20);
            this.txtTipoMessaggio.TabIndex = 4;
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessaggio.Location = new System.Drawing.Point(137, 129);
            this.txtMessaggio.MaxLength = 320;
            this.txtMessaggio.Multiline = true;
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(368, 189);
            this.txtMessaggio.TabIndex = 8;
            this.txtMessaggio.TextChanged += new System.EventHandler(this.txtMessaggio_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(140, 76);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(159, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(140, 31);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // btnInvia
            // 
            this.btnInvia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInvia.Location = new System.Drawing.Point(31, 383);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 18;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(472, 383);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 19;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // FrmSmsSingolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(578, 432);
            this.Controls.Add(this.btnFattureAperte);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.btnPreleva);
            this.Controls.Add(this.btnPredefinito);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.inseritilbl);
            this.Controls.Add(this.Rimanentilbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCodiceCliente);
            this.Controls.Add(this.lblDenom);
            this.Controls.Add(this.txtTipoMessaggio);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.btnEsci);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(594, 471);
            this.Name = "FrmSmsSingolo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sms Singolo";
            this.Load += new System.EventHandler(this.FrmSmsSingolo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFattureAperte;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.Button btnPreleva;
        private System.Windows.Forms.Button btnPredefinito;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Label inseritilbl;
        private System.Windows.Forms.Label Rimanentilbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCodiceCliente;
        private System.Windows.Forms.Label lblDenom;
        private System.Windows.Forms.TextBox txtTipoMessaggio;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button btnEsci;
    }
}