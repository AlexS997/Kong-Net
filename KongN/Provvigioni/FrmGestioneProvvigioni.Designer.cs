namespace KongN.Provvigioni
{
    partial class FrmGestioneProvvigioni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestioneProvvigioni));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFatture = new System.Windows.Forms.DataGridView();
            this.lblConteggioProvvigioni = new System.Windows.Forms.Label();
            this.btnStampa = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnCancellaRiga = new System.Windows.Forms.Button();
            this.lblAgenteNome = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAgente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAgente = new System.Windows.Forms.Label();
            this.txtAgente = new System.Windows.Forms.TextBox();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.dtpStart = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpEnd = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(586, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Fatture Pagabili";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(564, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Fatture NON Pagate";
            // 
            // dgvFatture
            // 
            this.dgvFatture.AllowUserToAddRows = false;
            this.dgvFatture.AllowUserToDeleteRows = false;
            this.dgvFatture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFatture.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFatture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFatture.Location = new System.Drawing.Point(61, 435);
            this.dgvFatture.Name = "dgvFatture";
            this.dgvFatture.ReadOnly = true;
            this.dgvFatture.RowHeadersWidth = 62;
            this.dgvFatture.Size = new System.Drawing.Size(1202, 152);
            this.dgvFatture.TabIndex = 29;
            this.dgvFatture.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvFatture_RowPrePaint);
            // 
            // lblConteggioProvvigioni
            // 
            this.lblConteggioProvvigioni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConteggioProvvigioni.AutoSize = true;
            this.lblConteggioProvvigioni.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteggioProvvigioni.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblConteggioProvvigioni.Location = new System.Drawing.Point(814, 614);
            this.lblConteggioProvvigioni.Name = "lblConteggioProvvigioni";
            this.lblConteggioProvvigioni.Size = new System.Drawing.Size(182, 23);
            this.lblConteggioProvvigioni.TabIndex = 28;
            this.lblConteggioProvvigioni.Text = "Conteggio Provvigioni:";
            // 
            // btnStampa
            // 
            this.btnStampa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStampa.Location = new System.Drawing.Point(216, 612);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(71, 28);
            this.btnStampa.TabIndex = 27;
            this.btnStampa.Text = "Stampa";
            this.btnStampa.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.Location = new System.Drawing.Point(399, 612);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(71, 28);
            this.btnSalva.TabIndex = 26;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Visible = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnCancellaRiga
            // 
            this.btnCancellaRiga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancellaRiga.Location = new System.Drawing.Point(293, 612);
            this.btnCancellaRiga.Name = "btnCancellaRiga";
            this.btnCancellaRiga.Size = new System.Drawing.Size(100, 28);
            this.btnCancellaRiga.TabIndex = 25;
            this.btnCancellaRiga.Text = "Cancella Riga";
            this.btnCancellaRiga.UseVisualStyleBackColor = true;
            this.btnCancellaRiga.Click += new System.EventHandler(this.btnCancellaRiga_Click);
            // 
            // lblAgenteNome
            // 
            this.lblAgenteNome.AutoSize = true;
            this.lblAgenteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAgenteNome.Location = new System.Drawing.Point(340, 21);
            this.lblAgenteNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgenteNome.Name = "lblAgenteNome";
            this.lblAgenteNome.Size = new System.Drawing.Size(0, 20);
            this.lblAgenteNome.TabIndex = 24;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(62, 65);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.Size = new System.Drawing.Size(1202, 328);
            this.dgv.TabIndex = 23;
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // btnAgente
            // 
            this.btnAgente.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgente.Location = new System.Drawing.Point(282, 19);
            this.btnAgente.Name = "btnAgente";
            this.btnAgente.Size = new System.Drawing.Size(44, 25);
            this.btnAgente.TabIndex = 22;
            this.btnAgente.Text = "...";
            this.btnAgente.UseVisualStyleBackColor = true;
            this.btnAgente.Click += new System.EventHandler(this.btnAgente_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(1077, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "A Data";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(877, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Da Data";
            // 
            // lblAgente
            // 
            this.lblAgente.AutoSize = true;
            this.lblAgente.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAgente.Location = new System.Drawing.Point(67, 22);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(53, 18);
            this.lblAgente.TabIndex = 17;
            this.lblAgente.Text = "Agente";
            // 
            // txtAgente
            // 
            this.txtAgente.AcceptsTab = true;
            this.txtAgente.Location = new System.Drawing.Point(126, 21);
            this.txtAgente.Name = "txtAgente";
            this.txtAgente.ReadOnly = true;
            this.txtAgente.Size = new System.Drawing.Size(150, 20);
            this.txtAgente.TabIndex = 16;
            // 
            // btnEstrai
            // 
            this.btnEstrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstrai.Location = new System.Drawing.Point(61, 612);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(71, 28);
            this.btnEstrai.TabIndex = 15;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(1167, 612);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(96, 28);
            this.btnEsci.TabIndex = 14;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStart.DateTimeIcon = null;
            this.dtpStart.Location = new System.Drawing.Point(938, 20);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(115, 21);
            this.dtpStart.TabIndex = 32;
            this.dtpStart.ToolTipText = "";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.DateTimeIcon = null;
            this.dtpEnd.Location = new System.Drawing.Point(1131, 20);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(115, 21);
            this.dtpEnd.TabIndex = 33;
            this.dtpEnd.ToolTipText = "";
            // 
            // FrmGestioneProvvigioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1305, 658);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvFatture);
            this.Controls.Add(this.lblConteggioProvvigioni);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnCancellaRiga);
            this.Controls.Add(this.lblAgenteNome);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnAgente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAgente);
            this.Controls.Add(this.txtAgente);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1321, 697);
            this.Name = "FrmGestioneProvvigioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Provvigioni";
            this.Load += new System.EventHandler(this.FrmGestioneProvvigioni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFatture;
        private System.Windows.Forms.Label lblConteggioProvvigioni;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCancellaRiga;
        private System.Windows.Forms.Label lblAgenteNome;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAgente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAgente;
        private System.Windows.Forms.TextBox txtAgente;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Button btnEsci;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpStart;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpEnd;
    }
}