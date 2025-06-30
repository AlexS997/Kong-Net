namespace KongN.Voip
{
    partial class FrmDettagliInserimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDettagliInserimento));
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnEsci = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblPercorso = new System.Windows.Forms.Label();
            this.btnElabora = new System.Windows.Forms.Button();
            this.btnImportaExcel = new System.Windows.Forms.Button();
            this.btnScegli = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.btnImporta = new System.Windows.Forms.Button();
            this.Bar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
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
            this.Grid.Size = new System.Drawing.Size(1044, 438);
            this.Grid.Style.CellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Grid.TabIndex = 0;
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(945, 534);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 10;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRecord.Location = new System.Drawing.Point(811, 481);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(209, 25);
            this.lblRecord.TabIndex = 3;
            this.lblRecord.Text = "Record estratti :";
            // 
            // lblPercorso
            // 
            this.lblPercorso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPercorso.AutoSize = true;
            this.lblPercorso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercorso.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPercorso.Location = new System.Drawing.Point(25, 483);
            this.lblPercorso.Name = "lblPercorso";
            this.lblPercorso.Size = new System.Drawing.Size(62, 16);
            this.lblPercorso.TabIndex = 2;
            this.lblPercorso.Text = "Percorso";
            // 
            // btnElabora
            // 
            this.btnElabora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElabora.Location = new System.Drawing.Point(246, 533);
            this.btnElabora.Name = "btnElabora";
            this.btnElabora.Size = new System.Drawing.Size(78, 30);
            this.btnElabora.TabIndex = 6;
            this.btnElabora.Text = "Elabora";
            this.btnElabora.UseVisualStyleBackColor = true;
            this.btnElabora.Click += new System.EventHandler(this.btnElabora_Click);
            // 
            // btnImportaExcel
            // 
            this.btnImportaExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportaExcel.Location = new System.Drawing.Point(137, 533);
            this.btnImportaExcel.Name = "btnImportaExcel";
            this.btnImportaExcel.Size = new System.Drawing.Size(103, 30);
            this.btnImportaExcel.TabIndex = 5;
            this.btnImportaExcel.Text = "Importa File Excel";
            this.btnImportaExcel.UseVisualStyleBackColor = true;
            this.btnImportaExcel.Click += new System.EventHandler(this.btnImportaExcel_Click);
            // 
            // btnScegli
            // 
            this.btnScegli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScegli.Location = new System.Drawing.Point(28, 533);
            this.btnScegli.Name = "btnScegli";
            this.btnScegli.Size = new System.Drawing.Size(103, 30);
            this.btnScegli.TabIndex = 4;
            this.btnScegli.Text = "Scegli File Excel";
            this.btnScegli.UseVisualStyleBackColor = true;
            this.btnScegli.Click += new System.EventHandler(this.btnScegli_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.Location = new System.Drawing.Point(330, 533);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 30);
            this.btnSalva.TabIndex = 7;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnCalcola
            // 
            this.btnCalcola.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalcola.Location = new System.Drawing.Point(598, 533);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(75, 30);
            this.btnCalcola.TabIndex = 8;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // btnImporta
            // 
            this.btnImporta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImporta.Location = new System.Drawing.Point(679, 533);
            this.btnImporta.Name = "btnImporta";
            this.btnImporta.Size = new System.Drawing.Size(75, 30);
            this.btnImporta.TabIndex = 9;
            this.btnImporta.Text = "Importa";
            this.btnImporta.UseVisualStyleBackColor = true;
            this.btnImporta.Click += new System.EventHandler(this.btnImporta_Click);
            // 
            // Bar
            // 
            this.Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bar.Location = new System.Drawing.Point(0, 438);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(1044, 23);
            this.Bar.TabIndex = 1;
            // 
            // FrmDettagliInserimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1044, 583);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.btnElabora);
            this.Controls.Add(this.btnImportaExcel);
            this.Controls.Add(this.btnScegli);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.btnImporta);
            this.Controls.Add(this.lblPercorso);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1060, 622);
            this.Name = "FrmDettagliInserimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserimento Dettagli";
            this.Load += new System.EventHandler(this.FrmDettagliInserimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblPercorso;
        private System.Windows.Forms.Button btnElabora;
        private System.Windows.Forms.Button btnImportaExcel;
        private System.Windows.Forms.Button btnScegli;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Button btnImporta;
        private System.Windows.Forms.ProgressBar Bar;
    }
}