namespace KongN.Azioni
{
    partial class FrmMessaggiInCoda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessaggiInCoda));
            this.btnCancella = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.numData = new System.Windows.Forms.NumericUpDown();
            this.btnCambiaData = new System.Windows.Forms.Button();
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancella
            // 
            this.btnCancella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancella.Location = new System.Drawing.Point(29, 396);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(75, 30);
            this.btnCancella.TabIndex = 21;
            this.btnCancella.Text = "Cancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(698, 396);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 22;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRecord.Location = new System.Drawing.Point(496, 401);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(184, 23);
            this.lblRecord.TabIndex = 45;
            this.lblRecord.Text = "Record estratti:";
            // 
            // numData
            // 
            this.numData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numData.Location = new System.Drawing.Point(354, 401);
            this.numData.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numData.Name = "numData";
            this.numData.Size = new System.Drawing.Size(120, 20);
            this.numData.TabIndex = 47;
            this.numData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCambiaData
            // 
            this.btnCambiaData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCambiaData.Location = new System.Drawing.Point(232, 401);
            this.btnCambiaData.Name = "btnCambiaData";
            this.btnCambiaData.Size = new System.Drawing.Size(105, 23);
            this.btnCambiaData.TabIndex = 46;
            this.btnCambiaData.Text = "Cambia Data";
            this.btnCambiaData.UseVisualStyleBackColor = true;
            this.btnCambiaData.Click += new System.EventHandler(this.btnCambiaData_Click);
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
            this.Grid.Size = new System.Drawing.Size(800, 366);
            this.Grid.TabIndex = 48;
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // FrmMessaggiInCoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.numData);
            this.Controls.Add(this.btnCambiaData);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmMessaggiInCoda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messaggi In Coda";
            this.Load += new System.EventHandler(this.FrmMessaggiInCoda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.NumericUpDown numData;
        private System.Windows.Forms.Button btnCambiaData;
        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
    }
}