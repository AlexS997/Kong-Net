namespace KongN.Controlli
{
    partial class FrmSpesePostali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpesePostali));
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.chkSelezionaTutto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDaData = new System.Windows.Forms.Label();
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnFatture = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.dtpStart = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpEnd = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Grid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.Grid.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Top;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Margin = new System.Windows.Forms.Padding(0);
            this.Grid.Name = "Grid";
            this.Grid.ShowBusyIndicator = true;
            this.Grid.ShowGroupDropArea = true;
            this.Grid.Size = new System.Drawing.Size(795, 438);
            this.Grid.TabIndex = 12;
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            this.Grid.CellClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.Grid_CellClick);
            // 
            // chkSelezionaTutto
            // 
            this.chkSelezionaTutto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSelezionaTutto.AutoSize = true;
            this.chkSelezionaTutto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelezionaTutto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkSelezionaTutto.Location = new System.Drawing.Point(16, 555);
            this.chkSelezionaTutto.Name = "chkSelezionaTutto";
            this.chkSelezionaTutto.Size = new System.Drawing.Size(122, 22);
            this.chkSelezionaTutto.TabIndex = 39;
            this.chkSelezionaTutto.Text = "Seleziona Tutto";
            this.chkSelezionaTutto.UseVisualStyleBackColor = true;
            this.chkSelezionaTutto.CheckedChanged += new System.EventHandler(this.chkSelezionaTutto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "A Data";
            // 
            // lblDaData
            // 
            this.lblDaData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDaData.AutoSize = true;
            this.lblDaData.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaData.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDaData.Location = new System.Drawing.Point(12, 461);
            this.lblDaData.Name = "lblDaData";
            this.lblDaData.Size = new System.Drawing.Size(55, 18);
            this.lblDaData.TabIndex = 38;
            this.lblDaData.Text = "Da Data";
            // 
            // Bar
            // 
            this.Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bar.Location = new System.Drawing.Point(500, 591);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(195, 23);
            this.Bar.TabIndex = 34;
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(496, 552);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(184, 23);
            this.lblRecord.TabIndex = 33;
            this.lblRecord.Text = "Record estratti :";
            // 
            // btnFatture
            // 
            this.btnFatture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFatture.Location = new System.Drawing.Point(186, 588);
            this.btnFatture.Name = "btnFatture";
            this.btnFatture.Size = new System.Drawing.Size(118, 30);
            this.btnFatture.TabIndex = 29;
            this.btnFatture.Text = "Modifica le Fatture";
            this.btnFatture.UseVisualStyleBackColor = true;
            this.btnFatture.Click += new System.EventHandler(this.btnFatture_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(96, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "Stampa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEstrai
            // 
            this.btnEstrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstrai.BackColor = System.Drawing.SystemColors.Window;
            this.btnEstrai.Location = new System.Drawing.Point(15, 588);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(75, 30);
            this.btnEstrai.TabIndex = 31;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = false;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(701, 588);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 32;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpStart.DateTimeIcon = null;
            this.dtpStart.Location = new System.Drawing.Point(74, 459);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(121, 21);
            this.dtpStart.TabIndex = 40;
            this.dtpStart.ToolTipText = "";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEnd.DateTimeIcon = null;
            this.dtpEnd.Location = new System.Drawing.Point(74, 493);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(121, 21);
            this.dtpEnd.TabIndex = 41;
            this.dtpEnd.ToolTipText = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(442, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Se Selezionata é vero la fattura ha già le spese inserite.";
            // 
            // FrmSpesePostali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(795, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.chkSelezionaTutto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDaData);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnFatture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(811, 675);
            this.Name = "FrmSpesePostali";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spese Postali";
            this.Load += new System.EventHandler(this.FrmSpesePostali_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
        private System.Windows.Forms.CheckBox chkSelezionaTutto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaData;
        private System.Windows.Forms.ProgressBar Bar;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnFatture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Button btnEsci;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpStart;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpEnd;
        private System.Windows.Forms.Label label2;
    }
}