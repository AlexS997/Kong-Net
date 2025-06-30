namespace KongN.Profili
{
    partial class FrmProfiliUtenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfiliUtenti));
            this.btnProfiliDiretti = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            this.btnPreleva = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProfiliDiretti
            // 
            this.btnProfiliDiretti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProfiliDiretti.Location = new System.Drawing.Point(19, 577);
            this.btnProfiliDiretti.Name = "btnProfiliDiretti";
            this.btnProfiliDiretti.Size = new System.Drawing.Size(96, 42);
            this.btnProfiliDiretti.TabIndex = 8;
            this.btnProfiliDiretti.Text = "Profili";
            this.btnProfiliDiretti.UseVisualStyleBackColor = true;
            this.btnProfiliDiretti.Click += new System.EventHandler(this.btnProfiliDiretti_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.Location = new System.Drawing.Point(121, 577);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(96, 42);
            this.btnSalva.TabIndex = 7;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStampa.Location = new System.Drawing.Point(715, 577);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(96, 42);
            this.btnStampa.TabIndex = 4;
            this.btnStampa.Text = "Stampa";
            this.btnStampa.UseVisualStyleBackColor = true;
            // 
            // btnPreleva
            // 
            this.btnPreleva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreleva.Location = new System.Drawing.Point(613, 577);
            this.btnPreleva.Name = "btnPreleva";
            this.btnPreleva.Size = new System.Drawing.Size(96, 42);
            this.btnPreleva.TabIndex = 5;
            this.btnPreleva.Text = "Preleva";
            this.btnPreleva.UseVisualStyleBackColor = true;
            this.btnPreleva.Visible = false;
            this.btnPreleva.Click += new System.EventHandler(this.btnPreleva_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(819, 577);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(96, 42);
            this.btnEsci.TabIndex = 6;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click_1);
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
            this.Grid.Size = new System.Drawing.Size(934, 556);
            this.Grid.TabIndex = 9;
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // FrmProfiliUtenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(934, 638);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnProfiliDiretti);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnPreleva);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 677);
            this.Name = "FrmProfiliUtenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profili Utenti";
            this.Load += new System.EventHandler(this.FrmProfiliUtenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfiliDiretti;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button btnPreleva;
        private System.Windows.Forms.Button btnEsci;
        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
    }
}