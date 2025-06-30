namespace KongN.Agenda
{
    partial class FrmAgendaMaschera
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
            System.Windows.Forms.Label lblDenom;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label codiceKingLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendaMaschera));
            this.btnEsci = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtDenom = new System.Windows.Forms.TextBox();
            this.dtpInserimento = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpInizio = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpFine = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.chkRegistrazione = new System.Windows.Forms.CheckBox();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.chkConcluso = new System.Windows.Forms.CheckBox();
            this.lblGenerato = new System.Windows.Forms.Label();
            lblDenom = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            codiceKingLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(846, 349);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 36);
            this.btnEsci.TabIndex = 25;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.Location = new System.Drawing.Point(30, 349);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 36);
            this.btnSalva.TabIndex = 26;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // lblDenom
            // 
            lblDenom.AutoSize = true;
            lblDenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDenom.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            lblDenom.Location = new System.Drawing.Point(33, 91);
            lblDenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDenom.Name = "lblDenom";
            lblDenom.Size = new System.Drawing.Size(62, 19);
            lblDenom.TabIndex = 28;
            lblDenom.Text = "Denom:";
            // 
            // txtDenom
            // 
            this.txtDenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenom.Location = new System.Drawing.Point(112, 83);
            this.txtDenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtDenom.Name = "txtDenom";
            this.txtDenom.Size = new System.Drawing.Size(313, 27);
            this.txtDenom.TabIndex = 27;
            // 
            // dtpInserimento
            // 
            this.dtpInserimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpInserimento.DateTimeIcon = null;
            this.dtpInserimento.Location = new System.Drawing.Point(180, 292);
            this.dtpInserimento.Name = "dtpInserimento";
            this.dtpInserimento.Size = new System.Drawing.Size(128, 25);
            this.dtpInserimento.TabIndex = 29;
            this.dtpInserimento.ToolTipText = "";
            // 
            // dtpInizio
            // 
            this.dtpInizio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpInizio.DateTimeIcon = null;
            this.dtpInizio.Location = new System.Drawing.Point(437, 292);
            this.dtpInizio.Name = "dtpInizio";
            this.dtpInizio.Size = new System.Drawing.Size(128, 25);
            this.dtpInizio.TabIndex = 30;
            this.dtpInizio.ToolTipText = "";
            // 
            // dtpFine
            // 
            this.dtpFine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFine.DateTimeIcon = null;
            this.dtpFine.Location = new System.Drawing.Point(689, 290);
            this.dtpFine.Name = "dtpFine";
            this.dtpFine.Size = new System.Drawing.Size(128, 25);
            this.dtpFine.TabIndex = 31;
            this.dtpFine.ToolTipText = "";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label1.Location = new System.Drawing.Point(33, 295);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 19);
            label1.TabIndex = 32;
            label1.Text = "Data Inserimento:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label2.Location = new System.Drawing.Point(340, 295);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 19);
            label2.TabIndex = 33;
            label2.Text = "Data Inizio:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label3.Location = new System.Drawing.Point(601, 293);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 19);
            label3.TabIndex = 34;
            label3.Text = "Data Fine:";
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCliente.Location = new System.Drawing.Point(318, 176);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(32, 27);
            this.btnCliente.TabIndex = 36;
            this.btnCliente.Text = "...";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // codiceKingLabel
            // 
            codiceKingLabel.AutoSize = true;
            codiceKingLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codiceKingLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            codiceKingLabel.Location = new System.Drawing.Point(33, 179);
            codiceKingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codiceKingLabel.Name = "codiceKingLabel";
            codiceKingLabel.Size = new System.Drawing.Size(109, 19);
            codiceKingLabel.TabIndex = 37;
            codiceKingLabel.Text = "Codice Cliente:";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCli.Location = new System.Drawing.Point(180, 176);
            this.txtCodCli.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(128, 27);
            this.txtCodCli.TabIndex = 35;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noteLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            noteLabel.Location = new System.Drawing.Point(506, 17);
            noteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(90, 19);
            noteLabel.TabIndex = 39;
            noteLabel.Text = "Descrizione:";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescrizione.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrizione.Location = new System.Drawing.Point(507, 41);
            this.txtDescrizione.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(414, 220);
            this.txtDescrizione.TabIndex = 38;
            // 
            // chkRegistrazione
            // 
            this.chkRegistrazione.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRegistrazione.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRegistrazione.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkRegistrazione.Location = new System.Drawing.Point(32, 133);
            this.chkRegistrazione.Margin = new System.Windows.Forms.Padding(2);
            this.chkRegistrazione.Name = "chkRegistrazione";
            this.chkRegistrazione.Size = new System.Drawing.Size(184, 24);
            this.chkRegistrazione.TabIndex = 40;
            this.chkRegistrazione.Text = "Registrazione Interna:";
            this.chkRegistrazione.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label4.Location = new System.Drawing.Point(33, 44);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 19);
            label4.TabIndex = 42;
            label4.Text = "Titolo:";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitolo.Location = new System.Drawing.Point(112, 41);
            this.txtTitolo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(313, 27);
            this.txtTitolo.TabIndex = 41;
            // 
            // chkConcluso
            // 
            this.chkConcluso.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkConcluso.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConcluso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkConcluso.Location = new System.Drawing.Point(262, 133);
            this.chkConcluso.Margin = new System.Windows.Forms.Padding(2);
            this.chkConcluso.Name = "chkConcluso";
            this.chkConcluso.Size = new System.Drawing.Size(163, 24);
            this.chkConcluso.TabIndex = 43;
            this.chkConcluso.Text = "Evento Concluso:";
            this.chkConcluso.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label5.Location = new System.Drawing.Point(33, 229);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(99, 19);
            label5.TabIndex = 44;
            label5.Text = "Generato Da:";
            // 
            // lblGenerato
            // 
            this.lblGenerato.AutoSize = true;
            this.lblGenerato.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerato.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblGenerato.Location = new System.Drawing.Point(176, 229);
            this.lblGenerato.Name = "lblGenerato";
            this.lblGenerato.Size = new System.Drawing.Size(0, 19);
            this.lblGenerato.TabIndex = 45;
            // 
            // FrmAgendaMaschera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(950, 406);
            this.Controls.Add(this.lblGenerato);
            this.Controls.Add(label5);
            this.Controls.Add(this.chkConcluso);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.chkRegistrazione);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(codiceKingLabel);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dtpFine);
            this.Controls.Add(this.dtpInizio);
            this.Controls.Add(this.dtpInserimento);
            this.Controls.Add(lblDenom);
            this.Controls.Add(this.txtDenom);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(966, 445);
            this.Name = "FrmAgendaMaschera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Dettaglio";
            this.Load += new System.EventHandler(this.FrmAgendaMaschera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox txtDenom;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpInserimento;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpInizio;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpFine;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.CheckBox chkRegistrazione;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.CheckBox chkConcluso;
        private System.Windows.Forms.Label lblGenerato;
    }
}