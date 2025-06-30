namespace KongN.Contratti
{
    partial class FrmRateContratto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRateContratto));
            this.btnEsci = new System.Windows.Forms.Button();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.gbxParametri = new System.Windows.Forms.GroupBox();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.lblTipoContratto = new System.Windows.Forms.Label();
            this.lblContratto = new System.Windows.Forms.Label();
            this.lblDenom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.gbxParametri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(929, 605);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(96, 42);
            this.btnEsci.TabIndex = 7;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnCalcola
            // 
            this.btnCalcola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalcola.Location = new System.Drawing.Point(24, 605);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(96, 42);
            this.btnCalcola.TabIndex = 9;
            this.btnCalcola.Text = "Calcola Rate";
            this.btnCalcola.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.Location = new System.Drawing.Point(135, 605);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(96, 42);
            this.btnSalva.TabIndex = 10;
            this.btnSalva.Text = "Salva Rate";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // btnElimina
            // 
            this.btnElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElimina.Location = new System.Drawing.Point(246, 605);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(96, 42);
            this.btnElimina.TabIndex = 11;
            this.btnElimina.Text = "Elimina Riga";
            this.btnElimina.UseVisualStyleBackColor = true;
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
            this.Grid.Location = new System.Drawing.Point(0, 129);
            this.Grid.Name = "Grid";
            this.Grid.ShowBusyIndicator = true;
            this.Grid.ShowGroupDropArea = true;
            this.Grid.Size = new System.Drawing.Size(1050, 436);
            this.Grid.TabIndex = 12;
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // gbxParametri
            // 
            this.gbxParametri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxParametri.Controls.Add(this.dtp);
            this.gbxParametri.Controls.Add(this.lblDenom);
            this.gbxParametri.Controls.Add(this.lblCodCli);
            this.gbxParametri.Controls.Add(this.lblTipoContratto);
            this.gbxParametri.Controls.Add(this.lblContratto);
            this.gbxParametri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxParametri.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbxParametri.Location = new System.Drawing.Point(0, 9);
            this.gbxParametri.Margin = new System.Windows.Forms.Padding(0);
            this.gbxParametri.Name = "gbxParametri";
            this.gbxParametri.Size = new System.Drawing.Size(1050, 120);
            this.gbxParametri.TabIndex = 13;
            this.gbxParametri.TabStop = false;
            this.gbxParametri.Text = "Dati Contratto";
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCli.Location = new System.Drawing.Point(251, 33);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(102, 18);
            this.lblCodCli.TabIndex = 3;
            this.lblCodCli.Text = "Codice Cliente:";
            // 
            // lblTipoContratto
            // 
            this.lblTipoContratto.AutoSize = true;
            this.lblTipoContratto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoContratto.Location = new System.Drawing.Point(22, 76);
            this.lblTipoContratto.Name = "lblTipoContratto";
            this.lblTipoContratto.Size = new System.Drawing.Size(101, 18);
            this.lblTipoContratto.TabIndex = 3;
            this.lblTipoContratto.Text = "Tipo Contratto:";
            // 
            // lblContratto
            // 
            this.lblContratto.AutoSize = true;
            this.lblContratto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratto.Location = new System.Drawing.Point(22, 35);
            this.lblContratto.Name = "lblContratto";
            this.lblContratto.Size = new System.Drawing.Size(71, 18);
            this.lblContratto.TabIndex = 3;
            this.lblContratto.Text = "Contratto:";
            // 
            // lblDenom
            // 
            this.lblDenom.AutoSize = true;
            this.lblDenom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenom.Location = new System.Drawing.Point(251, 76);
            this.lblDenom.Name = "lblDenom";
            this.lblDenom.Size = new System.Drawing.Size(110, 18);
            this.lblDenom.TabIndex = 4;
            this.lblDenom.Text = "Denominazione:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(362, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Attenzione!! Il Programma non controlla l\'esattezza di quanto inserito manualment" +
    "e.";
            // 
            // dtp
            // 
            this.dtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtp.DateTimeIcon = null;
            this.dtp.Location = new System.Drawing.Point(904, 73);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(121, 21);
            this.dtp.TabIndex = 41;
            this.dtp.ToolTipText = "";
            // 
            // FrmRateContratto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1050, 671);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbxParametri);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRateContratto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rate Contratto";
            this.Load += new System.EventHandler(this.FrmRateContratto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.gbxParametri.ResumeLayout(false);
            this.gbxParametri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnElimina;
        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
        private System.Windows.Forms.GroupBox gbxParametri;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.Label lblTipoContratto;
        private System.Windows.Forms.Label lblContratto;
        private System.Windows.Forms.Label lblDenom;
        private System.Windows.Forms.Label label2;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtp;
    }
}