namespace KongN.Controlli
{
    partial class FrmContrattiNONRinnovati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContrattiNONRinnovati));
            this.rbuMancataFatturazione = new System.Windows.Forms.RadioButton();
            this.rbuNonRinnovati = new System.Windows.Forms.RadioButton();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnStampa = new System.Windows.Forms.Button();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // rbuMancataFatturazione
            // 
            this.rbuMancataFatturazione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbuMancataFatturazione.AutoSize = true;
            this.rbuMancataFatturazione.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbuMancataFatturazione.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rbuMancataFatturazione.Location = new System.Drawing.Point(337, 465);
            this.rbuMancataFatturazione.Name = "rbuMancataFatturazione";
            this.rbuMancataFatturazione.Size = new System.Drawing.Size(160, 22);
            this.rbuMancataFatturazione.TabIndex = 13;
            this.rbuMancataFatturazione.Text = "Mancata Fatturazione";
            this.rbuMancataFatturazione.UseVisualStyleBackColor = true;
            // 
            // rbuNonRinnovati
            // 
            this.rbuNonRinnovati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbuNonRinnovati.AutoSize = true;
            this.rbuNonRinnovati.Checked = true;
            this.rbuNonRinnovati.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbuNonRinnovati.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rbuNonRinnovati.Location = new System.Drawing.Point(205, 465);
            this.rbuNonRinnovati.Name = "rbuNonRinnovati";
            this.rbuNonRinnovati.Size = new System.Drawing.Size(114, 22);
            this.rbuNonRinnovati.TabIndex = 14;
            this.rbuNonRinnovati.TabStop = true;
            this.rbuNonRinnovati.Text = "Non Rinnovati";
            this.rbuNonRinnovati.UseVisualStyleBackColor = true;
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRecord.Location = new System.Drawing.Point(578, 466);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(184, 23);
            this.lblRecord.TabIndex = 12;
            this.lblRecord.Text = "Record estratti :";
            // 
            // btnStampa
            // 
            this.btnStampa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStampa.Location = new System.Drawing.Point(105, 461);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(75, 30);
            this.btnStampa.TabIndex = 9;
            this.btnStampa.Text = "Stampa";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // btnEstrai
            // 
            this.btnEstrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstrai.Location = new System.Drawing.Point(21, 461);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(75, 30);
            this.btnEstrai.TabIndex = 10;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(820, 461);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 11;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // Grid
            // 
            this.Grid.AccessibleName = "Table";
            this.Grid.AllowEditing = false;
            this.Grid.AllowFiltering = true;
            this.Grid.AllowResizingColumns = true;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.Grid.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Top;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Margin = new System.Windows.Forms.Padding(0);
            this.Grid.Name = "Grid";
            this.Grid.ShowBusyIndicator = true;
            this.Grid.ShowGroupDropArea = true;
            this.Grid.Size = new System.Drawing.Size(920, 435);
            this.Grid.TabIndex = 15;
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // FrmContrattiNONRinnovati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(920, 514);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.rbuMancataFatturazione);
            this.Controls.Add(this.rbuNonRinnovati);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(936, 553);
            this.Name = "FrmContrattiNONRinnovati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contratti NON Rinnovati";
            this.Load += new System.EventHandler(this.FrmContrattiNONRinnovati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbuMancataFatturazione;
        private System.Windows.Forms.RadioButton rbuNonRinnovati;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Button btnEsci;
        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
    }
}