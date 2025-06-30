namespace KongN.Provvigioni
{
    partial class FrmControlloFatture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlloFatture));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDaData = new System.Windows.Forms.Label();
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnEsci = new System.Windows.Forms.Button();
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.dtpStart = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpEnd = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnEstrai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(128, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "A Data";
            // 
            // lblDaData
            // 
            this.lblDaData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDaData.AutoSize = true;
            this.lblDaData.BackColor = System.Drawing.SystemColors.Window;
            this.lblDaData.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaData.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDaData.Location = new System.Drawing.Point(128, 538);
            this.lblDaData.Name = "lblDaData";
            this.lblDaData.Size = new System.Drawing.Size(55, 18);
            this.lblDaData.TabIndex = 41;
            this.lblDaData.Text = "Da Data";
            // 
            // Bar
            // 
            this.Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bar.Location = new System.Drawing.Point(0, 506);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(800, 23);
            this.Bar.TabIndex = 37;
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRecord.Location = new System.Drawing.Point(467, 558);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(202, 23);
            this.lblRecord.TabIndex = 36;
            this.lblRecord.Text = "Record estratti :";
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(699, 554);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 35;
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
            this.Grid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.Grid.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Top;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.ShowBusyIndicator = true;
            this.Grid.ShowGroupDropArea = true;
            this.Grid.Size = new System.Drawing.Size(800, 506);
            this.Grid.TabIndex = 42;
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpStart.DateTimeIcon = null;
            this.dtpStart.Location = new System.Drawing.Point(190, 537);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(115, 21);
            this.dtpStart.TabIndex = 43;
            this.dtpStart.ToolTipText = "";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEnd.DateTimeIcon = null;
            this.dtpEnd.Location = new System.Drawing.Point(190, 579);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(115, 21);
            this.dtpEnd.TabIndex = 44;
            this.dtpEnd.ToolTipText = "";
            // 
            // btnEstrai
            // 
            this.btnEstrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstrai.Location = new System.Drawing.Point(28, 556);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(71, 28);
            this.btnEstrai.TabIndex = 45;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // FrmControlloFatture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDaData);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 663);
            this.Name = "FrmControlloFatture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controllo Fatture con Agente";
            this.Load += new System.EventHandler(this.FrmControlloFatture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaData;
        private System.Windows.Forms.ProgressBar Bar;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnEsci;
        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpStart;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpEnd;
        private System.Windows.Forms.Button btnEstrai;
    }
}