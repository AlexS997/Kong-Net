namespace KongN.Controlli
{
    partial class FrmPartiteAperte
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartiteAperte));
            this.gbxParametri = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpStart = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.txtCodiceCliente = new System.Windows.Forms.TextBox();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDaData = new System.Windows.Forms.Label();
            this.chkEsclusi = new System.Windows.Forms.CheckBox();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnStampa = new System.Windows.Forms.Button();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbxParametri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxParametri
            // 
            this.gbxParametri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxParametri.Controls.Add(this.dtpEnd);
            this.gbxParametri.Controls.Add(this.dtpStart);
            this.gbxParametri.Controls.Add(this.txtCodiceCliente);
            this.gbxParametri.Controls.Add(this.btnPulisci);
            this.gbxParametri.Controls.Add(this.btnCliente);
            this.gbxParametri.Controls.Add(this.txtCliente);
            this.gbxParametri.Controls.Add(this.label2);
            this.gbxParametri.Controls.Add(this.label1);
            this.gbxParametri.Controls.Add(this.lblDaData);
            this.gbxParametri.Controls.Add(this.chkEsclusi);
            this.gbxParametri.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxParametri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxParametri.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbxParametri.Location = new System.Drawing.Point(0, 10);
            this.gbxParametri.Margin = new System.Windows.Forms.Padding(0);
            this.gbxParametri.Name = "gbxParametri";
            this.gbxParametri.Size = new System.Drawing.Size(840, 139);
            this.gbxParametri.TabIndex = 1;
            this.gbxParametri.TabStop = false;
            this.gbxParametri.Text = "Parametri";
            // 
            // dtpEnd
            // 
            this.dtpEnd.DateTimeIcon = null;
            this.dtpEnd.Location = new System.Drawing.Point(79, 82);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(120, 21);
            this.dtpEnd.TabIndex = 8;
            this.dtpEnd.ToolTipText = "";
            this.dtpEnd.DropDownClosed += new System.EventHandler(this.dtpEnd_DropDownClosed);
            // 
            // dtpStart
            // 
            this.dtpStart.DateTimeIcon = null;
            this.dtpStart.Location = new System.Drawing.Point(79, 42);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(120, 21);
            this.dtpStart.TabIndex = 7;
            this.dtpStart.ToolTipText = "";
            // 
            // txtCodiceCliente
            // 
            this.txtCodiceCliente.Location = new System.Drawing.Point(315, 81);
            this.txtCodiceCliente.Name = "txtCodiceCliente";
            this.txtCodiceCliente.ReadOnly = true;
            this.txtCodiceCliente.Size = new System.Drawing.Size(100, 22);
            this.txtCodiceCliente.TabIndex = 6;
            // 
            // btnPulisci
            // 
            this.btnPulisci.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPulisci.Location = new System.Drawing.Point(421, 78);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(65, 28);
            this.btnPulisci.TabIndex = 5;
            this.btnPulisci.Text = "Pulisci";
            this.toolTip.SetToolTip(this.btnPulisci, "Pulisci i Campi");
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(775, 37);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(40, 28);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "...";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(315, 40);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCliente.Size = new System.Drawing.Size(454, 22);
            this.txtCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "A Data";
            // 
            // lblDaData
            // 
            this.lblDaData.AutoSize = true;
            this.lblDaData.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaData.Location = new System.Drawing.Point(18, 42);
            this.lblDaData.Name = "lblDaData";
            this.lblDaData.Size = new System.Drawing.Size(55, 18);
            this.lblDaData.TabIndex = 3;
            this.lblDaData.Text = "Da Data";
            // 
            // chkEsclusi
            // 
            this.chkEsclusi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEsclusi.Location = new System.Drawing.Point(508, 76);
            this.chkEsclusi.Name = "chkEsclusi";
            this.chkEsclusi.Size = new System.Drawing.Size(300, 32);
            this.chkEsclusi.TabIndex = 0;
            this.chkEsclusi.Text = "Anche Clienti Esclusi dallo Scadenzario";
            this.chkEsclusi.UseVisualStyleBackColor = true;
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRecord.Location = new System.Drawing.Point(517, 640);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(184, 23);
            this.lblRecord.TabIndex = 7;
            this.lblRecord.Text = "Record estratti:";
            // 
            // btnStampa
            // 
            this.btnStampa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStampa.Location = new System.Drawing.Point(107, 636);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(75, 30);
            this.btnStampa.TabIndex = 4;
            this.btnStampa.Text = "Stampa";
            this.btnStampa.UseVisualStyleBackColor = true;
            // 
            // btnEstrai
            // 
            this.btnEstrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstrai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEstrai.Location = new System.Drawing.Point(16, 636);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(75, 30);
            this.btnEstrai.TabIndex = 5;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = false;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(751, 636);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 6;
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
            this.Grid.Location = new System.Drawing.Point(0, 149);
            this.Grid.Margin = new System.Windows.Forms.Padding(0);
            this.Grid.Name = "Grid";
            this.Grid.ShowBusyIndicator = true;
            this.Grid.ShowGroupDropArea = true;
            this.Grid.Size = new System.Drawing.Size(840, 462);
            this.Grid.Style.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.Grid.Style.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.TabIndex = 8;
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // FrmPartiteAperte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(840, 682);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.gbxParametri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(856, 721);
            this.Name = "FrmPartiteAperte";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partite Aperte";
            this.Load += new System.EventHandler(this.FrmPartiteAperte_Load);
            this.gbxParametri.ResumeLayout(false);
            this.gbxParametri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxParametri;
        private System.Windows.Forms.TextBox txtCodiceCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaData;
        private System.Windows.Forms.CheckBox chkEsclusi;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Button btnEsci;
        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnPulisci;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpStart;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpEnd;
    }
}