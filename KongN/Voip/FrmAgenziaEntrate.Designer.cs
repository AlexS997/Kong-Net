namespace KongN.Voip
{
    partial class FrmAgenziaEntrate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenziaEntrate));
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.bpbBox = new System.Windows.Forms.GroupBox();
            this.bntCrea = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAnnoDaEstrarre = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.btnElabora = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.bpbBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
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
            this.Grid.Location = new System.Drawing.Point(0, 122);
            this.Grid.Margin = new System.Windows.Forms.Padding(0);
            this.Grid.Name = "Grid";
            this.Grid.ShowBusyIndicator = true;
            this.Grid.ShowGroupDropArea = true;
            this.Grid.Size = new System.Drawing.Size(924, 369);
            this.Grid.TabIndex = 18;
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // bpbBox
            // 
            this.bpbBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bpbBox.Controls.Add(this.bntCrea);
            this.bpbBox.Controls.Add(this.btnPath);
            this.bpbBox.Controls.Add(this.textBox1);
            this.bpbBox.Location = new System.Drawing.Point(353, 22);
            this.bpbBox.Name = "bpbBox";
            this.bpbBox.Size = new System.Drawing.Size(545, 79);
            this.bpbBox.TabIndex = 21;
            this.bpbBox.TabStop = false;
            this.bpbBox.Text = "SALVATAGGIO FILE";
            // 
            // bntCrea
            // 
            this.bntCrea.Location = new System.Drawing.Point(449, 23);
            this.bntCrea.Name = "bntCrea";
            this.bntCrea.Size = new System.Drawing.Size(71, 37);
            this.bntCrea.TabIndex = 5;
            this.bntCrea.Text = "Crea";
            this.bntCrea.UseVisualStyleBackColor = true;
            this.bntCrea.Click += new System.EventHandler(this.bntCrea_Click);
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPath.Location = new System.Drawing.Point(344, 31);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(44, 23);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = " ...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.bntPath_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblAnnoDaEstrarre
            // 
            this.lblAnnoDaEstrarre.AutoSize = true;
            this.lblAnnoDaEstrarre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnoDaEstrarre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAnnoDaEstrarre.Location = new System.Drawing.Point(21, 51);
            this.lblAnnoDaEstrarre.Name = "lblAnnoDaEstrarre";
            this.lblAnnoDaEstrarre.Size = new System.Drawing.Size(110, 18);
            this.lblAnnoDaEstrarre.TabIndex = 20;
            this.lblAnnoDaEstrarre.Text = "Anno da Estrarre";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(140, 49);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(89, 22);
            this.numericUpDown.TabIndex = 19;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEstrai
            // 
            this.btnEstrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstrai.Location = new System.Drawing.Point(23, 518);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(75, 30);
            this.btnEstrai.TabIndex = 22;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(821, 518);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 23;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnElabora
            // 
            this.btnElabora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElabora.Location = new System.Drawing.Point(112, 518);
            this.btnElabora.Name = "btnElabora";
            this.btnElabora.Size = new System.Drawing.Size(75, 30);
            this.btnElabora.TabIndex = 24;
            this.btnElabora.Text = "Elabora";
            this.btnElabora.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLog.Location = new System.Drawing.Point(202, 518);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 30);
            this.btnLog.TabIndex = 25;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // FrmAgenziaEntrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(924, 571);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnElabora);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.bpbBox);
            this.Controls.Add(this.lblAnnoDaEstrarre);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(940, 610);
            this.Name = "FrmAgenziaEntrate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creazione File per Agenzia Entrate";
            this.Load += new System.EventHandler(this.FrmAgenziaEntrate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.bpbBox.ResumeLayout(false);
            this.bpbBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
        private System.Windows.Forms.GroupBox bpbBox;
        private System.Windows.Forms.Button bntCrea;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAnnoDaEstrarre;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Button btnElabora;
        private System.Windows.Forms.Button btnLog;
    }
}