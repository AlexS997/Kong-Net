namespace KongN.Voip
{
    partial class FrmListaChiamate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaChiamate));
            this.btnEstrai = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblContratto = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpEnd = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstrai
            // 
            this.btnEstrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstrai.Location = new System.Drawing.Point(32, 511);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(75, 30);
            this.btnEstrai.TabIndex = 4;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(928, 511);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 5;
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
            this.Grid.Location = new System.Drawing.Point(0, 59);
            this.Grid.Margin = new System.Windows.Forms.Padding(0);
            this.Grid.Name = "Grid";
            this.Grid.ShowBusyIndicator = true;
            this.Grid.ShowGroupDropArea = true;
            this.Grid.Size = new System.Drawing.Size(1039, 425);
            this.Grid.TabIndex = 6;
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // lblContratto
            // 
            this.lblContratto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContratto.AutoSize = true;
            this.lblContratto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblContratto.Location = new System.Drawing.Point(908, 23);
            this.lblContratto.Name = "lblContratto";
            this.lblContratto.Size = new System.Drawing.Size(67, 18);
            this.lblContratto.TabIndex = 9;
            this.lblContratto.Text = "Contratto";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtCodCli.Location = new System.Drawing.Point(742, 23);
            this.txtCodCli.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.ReadOnly = true;
            this.txtCodCli.Size = new System.Drawing.Size(93, 21);
            this.txtCodCli.TabIndex = 2;
            // 
            // btnCliente
            // 
            this.btnCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCliente.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCliente.Location = new System.Drawing.Point(842, 21);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(32, 24);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "...";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(637, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codice Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Periodo :";
            // 
            // dtpStart
            // 
            this.dtpStart.DateTimeIcon = null;
            this.dtpStart.Location = new System.Drawing.Point(90, 20);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(110, 21);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.ToolTipText = "";
            // 
            // dtpEnd
            // 
            this.dtpEnd.DateTimeIcon = null;
            this.dtpEnd.Location = new System.Drawing.Point(216, 20);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(110, 21);
            this.dtpEnd.TabIndex = 1;
            this.dtpEnd.ToolTipText = "";
            // 
            // FrmListaChiamate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1039, 565);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblContratto);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1055, 604);
            this.Name = "FrmListaChiamate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Chiamate per Cliente";
            this.Load += new System.EventHandler(this.FrmListaChiamate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Button btnEsci;
        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
        private System.Windows.Forms.Label lblContratto;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpStart;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpEnd;
    }
}