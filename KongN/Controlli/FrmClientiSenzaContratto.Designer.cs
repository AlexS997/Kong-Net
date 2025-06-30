namespace KongN.Controlli
{
    partial class FrmClientiSenzaContratto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientiSenzaContratto));
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblGiallo = new System.Windows.Forms.Label();
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnStampa = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
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
            this.Grid.Size = new System.Drawing.Size(824, 438);
            this.Grid.Style.CellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Grid.TabIndex = 9;
            this.Grid.QueryCellStyle += new Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventHandler(this.Grid_QueryCellStyle);
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // btnEstrai
            // 
            this.btnEstrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstrai.Location = new System.Drawing.Point(27, 577);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(75, 30);
            this.btnEstrai.TabIndex = 10;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // lblVerde
            // 
            this.lblVerde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVerde.AutoSize = true;
            this.lblVerde.BackColor = System.Drawing.Color.LightGreen;
            this.lblVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerde.Location = new System.Drawing.Point(203, 482);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(229, 16);
            this.lblVerde.TabIndex = 25;
            this.lblVerde.Text = "Clienti con Profilo non Corrispondente";
            // 
            // lblGiallo
            // 
            this.lblGiallo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGiallo.AutoSize = true;
            this.lblGiallo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblGiallo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiallo.Location = new System.Drawing.Point(26, 482);
            this.lblGiallo.Name = "lblGiallo";
            this.lblGiallo.Size = new System.Drawing.Size(138, 16);
            this.lblGiallo.TabIndex = 26;
            this.lblGiallo.Text = "Clienti senza Contratto";
            // 
            // Bar
            // 
            this.Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bar.Location = new System.Drawing.Point(0, 438);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(824, 23);
            this.Bar.TabIndex = 24;
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRecord.Location = new System.Drawing.Point(458, 479);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(209, 25);
            this.lblRecord.TabIndex = 22;
            this.lblRecord.Text = "Record estratti :";
            // 
            // btnStampa
            // 
            this.btnStampa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStampa.Location = new System.Drawing.Point(122, 577);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(75, 30);
            this.btnStampa.TabIndex = 21;
            this.btnStampa.Text = "Stampa";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(725, 577);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 27;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label.Location = new System.Drawing.Point(219, 550);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(464, 85);
            this.label.TabIndex = 28;
            this.label.Text = "Help";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmClientiSenzaContratto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(824, 637);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblGiallo);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(840, 676);
            this.Name = "FrmClientiSenzaContratto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienti Senza Contratto";
            this.Load += new System.EventHandler(this.FrmClientiSenzaContratto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblGiallo;
        private System.Windows.Forms.ProgressBar Bar;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Label label;
    }
}