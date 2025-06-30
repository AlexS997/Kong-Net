namespace KongN.Apparati
{
    partial class FrmAbilitazioneApparati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbilitazioneApparati));
            this.lblRicorda = new System.Windows.Forms.Label();
            this.btnDisabilita = new System.Windows.Forms.Button();
            this.btnAbilita = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.dgvUtenti = new System.Windows.Forms.DataGridView();
            this.dgvUtentiAbilitati = new System.Windows.Forms.DataGridView();
            this.lblModifiche = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtentiAbilitati)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRicorda
            // 
            this.lblRicorda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRicorda.AutoSize = true;
            this.lblRicorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRicorda.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRicorda.Location = new System.Drawing.Point(120, 408);
            this.lblRicorda.Name = "lblRicorda";
            this.lblRicorda.Size = new System.Drawing.Size(296, 16);
            this.lblRicorda.TabIndex = 8;
            this.lblRicorda.Text = "Ricordati di salvare quando hai terminato.";
            // 
            // btnDisabilita
            // 
            this.btnDisabilita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisabilita.Location = new System.Drawing.Point(437, 367);
            this.btnDisabilita.Name = "btnDisabilita";
            this.btnDisabilita.Size = new System.Drawing.Size(67, 23);
            this.btnDisabilita.TabIndex = 6;
            this.btnDisabilita.Text = "Disabilita";
            this.btnDisabilita.UseVisualStyleBackColor = true;
            this.btnDisabilita.Click += new System.EventHandler(this.btnDisabilita_Click);
            // 
            // btnAbilita
            // 
            this.btnAbilita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbilita.Location = new System.Drawing.Point(24, 367);
            this.btnAbilita.Name = "btnAbilita";
            this.btnAbilita.Size = new System.Drawing.Size(67, 23);
            this.btnAbilita.TabIndex = 7;
            this.btnAbilita.Text = "Abilita";
            this.btnAbilita.UseVisualStyleBackColor = true;
            this.btnAbilita.Click += new System.EventHandler(this.btnAbilita_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.Location = new System.Drawing.Point(24, 405);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 4;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(437, 405);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 5;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // dgvUtenti
            // 
            this.dgvUtenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUtenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtenti.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtenti.Location = new System.Drawing.Point(24, 30);
            this.dgvUtenti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUtenti.Name = "dgvUtenti";
            this.dgvUtenti.ReadOnly = true;
            this.dgvUtenti.RowHeadersWidth = 51;
            this.dgvUtenti.RowTemplate.Height = 24;
            this.dgvUtenti.Size = new System.Drawing.Size(185, 283);
            this.dgvUtenti.TabIndex = 45;
            this.dgvUtenti.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvUtenti_RowPrePaint);
            // 
            // dgvUtentiAbilitati
            // 
            this.dgvUtentiAbilitati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUtentiAbilitati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtentiAbilitati.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUtentiAbilitati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtentiAbilitati.Location = new System.Drawing.Point(327, 30);
            this.dgvUtentiAbilitati.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUtentiAbilitati.Name = "dgvUtentiAbilitati";
            this.dgvUtentiAbilitati.ReadOnly = true;
            this.dgvUtentiAbilitati.RowHeadersWidth = 51;
            this.dgvUtentiAbilitati.RowTemplate.Height = 24;
            this.dgvUtentiAbilitati.Size = new System.Drawing.Size(185, 283);
            this.dgvUtentiAbilitati.TabIndex = 46;
            this.dgvUtentiAbilitati.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvUtentiAbilitati_RowPrePaint);
            // 
            // lblModifiche
            // 
            this.lblModifiche.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblModifiche.AutoSize = true;
            this.lblModifiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifiche.ForeColor = System.Drawing.Color.Green;
            this.lblModifiche.Location = new System.Drawing.Point(199, 333);
            this.lblModifiche.Name = "lblModifiche";
            this.lblModifiche.Size = new System.Drawing.Size(133, 16);
            this.lblModifiche.TabIndex = 47;
            this.lblModifiche.Text = "Modifiche salvate!";
            // 
            // FrmAbilitazioneApparati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(554, 449);
            this.Controls.Add(this.lblModifiche);
            this.Controls.Add(this.dgvUtentiAbilitati);
            this.Controls.Add(this.dgvUtenti);
            this.Controls.Add(this.lblRicorda);
            this.Controls.Add(this.btnDisabilita);
            this.Controls.Add(this.btnAbilita);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(671, 488);
            this.MinimumSize = new System.Drawing.Size(570, 488);
            this.Name = "FrmAbilitazioneApparati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abilitazione Utenti Apparati";
            this.Load += new System.EventHandler(this.FrmAbilitazioneApparati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtentiAbilitati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRicorda;
        private System.Windows.Forms.Button btnDisabilita;
        private System.Windows.Forms.Button btnAbilita;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.DataGridView dgvUtenti;
        private System.Windows.Forms.DataGridView dgvUtentiAbilitati;
        private System.Windows.Forms.Label lblModifiche;
    }
}