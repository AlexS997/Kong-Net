namespace KongN.Voip
{
    partial class FrmGestioneChiamate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestioneChiamate));
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.rbuStoricoChiamate = new System.Windows.Forms.RadioButton();
            this.rbuChiamate = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.btnTrasferimento = new System.Windows.Forms.Button();
            this.dtp = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.lblData = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.groupBox.SuspendLayout();
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
            this.Grid.Size = new System.Drawing.Size(884, 435);
            this.Grid.TabIndex = 0;
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRecord.Location = new System.Drawing.Point(381, 516);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(202, 23);
            this.lblRecord.TabIndex = 7;
            this.lblRecord.Text = "Record estratti :";
            // 
            // btnEstrai
            // 
            this.btnEstrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstrai.Location = new System.Drawing.Point(12, 527);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(75, 30);
            this.btnEstrai.TabIndex = 2;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(797, 527);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 8;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // rbuStoricoChiamate
            // 
            this.rbuStoricoChiamate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbuStoricoChiamate.AutoSize = true;
            this.rbuStoricoChiamate.Location = new System.Drawing.Point(385, 484);
            this.rbuStoricoChiamate.Name = "rbuStoricoChiamate";
            this.rbuStoricoChiamate.Size = new System.Drawing.Size(105, 17);
            this.rbuStoricoChiamate.TabIndex = 4;
            this.rbuStoricoChiamate.Text = "Storico Chiamate";
            this.rbuStoricoChiamate.UseVisualStyleBackColor = true;
            // 
            // rbuChiamate
            // 
            this.rbuChiamate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbuChiamate.AutoSize = true;
            this.rbuChiamate.Checked = true;
            this.rbuChiamate.Location = new System.Drawing.Point(385, 452);
            this.rbuChiamate.Name = "rbuChiamate";
            this.rbuChiamate.Size = new System.Drawing.Size(69, 17);
            this.rbuChiamate.TabIndex = 3;
            this.rbuChiamate.TabStop = true;
            this.rbuChiamate.Text = "Chiamate";
            this.rbuChiamate.UseVisualStyleBackColor = true;
            this.rbuChiamate.CheckedChanged += new System.EventHandler(this.rbuChiamate_CheckedChanged);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label.Location = new System.Drawing.Point(125, 451);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(237, 106);
            this.label.TabIndex = 1;
            this.label.Text = "Help";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrasferimento
            // 
            this.btnTrasferimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrasferimento.Location = new System.Drawing.Point(6, 13);
            this.btnTrasferimento.Name = "btnTrasferimento";
            this.btnTrasferimento.Size = new System.Drawing.Size(156, 30);
            this.btnTrasferimento.TabIndex = 5;
            this.btnTrasferimento.Text = "Trasferimento a Storico";
            this.btnTrasferimento.UseVisualStyleBackColor = true;
            this.btnTrasferimento.Click += new System.EventHandler(this.btnDettaglio_Click);
            // 
            // dtp
            // 
            this.dtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp.DateTimeIcon = null;
            this.dtp.Location = new System.Drawing.Point(6, 89);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(107, 21);
            this.dtp.TabIndex = 6;
            this.dtp.ToolTipText = "";
            this.dtp.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.dtp_ValueChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(7, 59);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(119, 13);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data sino a cui traferire ";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.btnTrasferimento);
            this.groupBox.Controls.Add(this.dtp);
            this.groupBox.Controls.Add(this.lblData);
            this.groupBox.Location = new System.Drawing.Point(620, 438);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(171, 119);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            // 
            // FrmGestioneChiamate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 566);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.rbuStoricoChiamate);
            this.Controls.Add(this.rbuChiamate);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 605);
            this.Name = "FrmGestioneChiamate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Chiamate";
            this.Load += new System.EventHandler(this.FrmGestioneChiamate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.RadioButton rbuStoricoChiamate;
        private System.Windows.Forms.RadioButton rbuChiamate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnTrasferimento;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtp;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox groupBox;
    }
}