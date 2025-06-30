namespace KongN.Profili
{
    partial class FrmProfiliUtentiKing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfiliUtentiKing));
            this.gbx = new System.Windows.Forms.GroupBox();
            this.chkSoloErrati = new System.Windows.Forms.CheckBox();
            this.rbuUsermanager = new System.Windows.Forms.RadioButton();
            this.rbuKing = new System.Windows.Forms.RadioButton();
            this.btnPreleva = new System.Windows.Forms.Button();
            this.btnEstraiDaKing = new System.Windows.Forms.Button();
            this.chkAncheDisdetti = new System.Windows.Forms.CheckBox();
            this.btnEsci = new System.Windows.Forms.Button();
            this.Grid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnStampa = new System.Windows.Forms.Button();
            this.gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx
            // 
            this.gbx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbx.Controls.Add(this.chkSoloErrati);
            this.gbx.Controls.Add(this.rbuUsermanager);
            this.gbx.Controls.Add(this.rbuKing);
            this.gbx.Controls.Add(this.btnPreleva);
            this.gbx.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbx.Location = new System.Drawing.Point(311, 532);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(475, 97);
            this.gbx.TabIndex = 3;
            this.gbx.TabStop = false;
            this.gbx.Text = "Tipo di Stampa";
            // 
            // chkSoloErrati
            // 
            this.chkSoloErrati.AutoSize = true;
            this.chkSoloErrati.Checked = true;
            this.chkSoloErrati.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoloErrati.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoloErrati.Location = new System.Drawing.Point(346, 23);
            this.chkSoloErrati.Name = "chkSoloErrati";
            this.chkSoloErrati.Size = new System.Drawing.Size(90, 22);
            this.chkSoloErrati.TabIndex = 2;
            this.chkSoloErrati.Text = "Solo Errati";
            this.chkSoloErrati.UseVisualStyleBackColor = true;
            // 
            // rbuUsermanager
            // 
            this.rbuUsermanager.AutoSize = true;
            this.rbuUsermanager.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbuUsermanager.Location = new System.Drawing.Point(16, 59);
            this.rbuUsermanager.Name = "rbuUsermanager";
            this.rbuUsermanager.Size = new System.Drawing.Size(282, 22);
            this.rbuUsermanager.TabIndex = 1;
            this.rbuUsermanager.Text = "Profili  Usermanager che non sono in King";
            this.rbuUsermanager.UseVisualStyleBackColor = true;
            // 
            // rbuKing
            // 
            this.rbuKing.AutoSize = true;
            this.rbuKing.Checked = true;
            this.rbuKing.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbuKing.Location = new System.Drawing.Point(16, 26);
            this.rbuKing.Name = "rbuKing";
            this.rbuKing.Size = new System.Drawing.Size(190, 22);
            this.rbuKing.TabIndex = 0;
            this.rbuKing.TabStop = true;
            this.rbuKing.Text = "Profili King e Usermanager";
            this.rbuKing.UseVisualStyleBackColor = true;
            // 
            // btnPreleva
            // 
            this.btnPreleva.Location = new System.Drawing.Point(346, 55);
            this.btnPreleva.Name = "btnPreleva";
            this.btnPreleva.Size = new System.Drawing.Size(79, 30);
            this.btnPreleva.TabIndex = 4;
            this.btnPreleva.Text = "Preleva";
            this.btnPreleva.UseVisualStyleBackColor = true;
            this.btnPreleva.Click += new System.EventHandler(this.btnPreleva_Click);
            // 
            // btnEstraiDaKing
            // 
            this.btnEstraiDaKing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEstraiDaKing.Location = new System.Drawing.Point(26, 570);
            this.btnEstraiDaKing.Name = "btnEstraiDaKing";
            this.btnEstraiDaKing.Size = new System.Drawing.Size(121, 32);
            this.btnEstraiDaKing.TabIndex = 1;
            this.btnEstraiDaKing.Text = "Preleva da King";
            this.btnEstraiDaKing.UseVisualStyleBackColor = true;
            this.btnEstraiDaKing.Click += new System.EventHandler(this.btnEstraiDaKing_Click);
            // 
            // chkAncheDisdetti
            // 
            this.chkAncheDisdetti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAncheDisdetti.AutoSize = true;
            this.chkAncheDisdetti.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAncheDisdetti.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkAncheDisdetti.Location = new System.Drawing.Point(167, 575);
            this.chkAncheDisdetti.Name = "chkAncheDisdetti";
            this.chkAncheDisdetti.Size = new System.Drawing.Size(117, 22);
            this.chkAncheDisdetti.TabIndex = 2;
            this.chkAncheDisdetti.Text = "Anche Disdetti";
            this.chkAncheDisdetti.UseVisualStyleBackColor = true;
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(933, 588);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(79, 30);
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
            this.Grid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.Grid.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Top;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.ShowBusyIndicator = true;
            this.Grid.ShowGroupDropArea = true;
            this.Grid.Size = new System.Drawing.Size(1046, 514);
            this.Grid.TabIndex = 0;
            this.Grid.QueryCellStyle += new Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventHandler(this.Grid_QueryCellStyle);
            this.Grid.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.Grid_QueryRowStyle);
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRecord.Location = new System.Drawing.Point(827, 548);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(189, 23);
            this.lblRecord.TabIndex = 37;
            this.lblRecord.Text = "Record estratti :";
            // 
            // btnStampa
            // 
            this.btnStampa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStampa.Location = new System.Drawing.Point(831, 588);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(79, 30);
            this.btnStampa.TabIndex = 38;
            this.btnStampa.Text = "Stampa";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // FrmProfiliUtentiKing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1046, 640);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.gbx);
            this.Controls.Add(this.btnEstraiDaKing);
            this.Controls.Add(this.chkAncheDisdetti);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1062, 679);
            this.Name = "FrmProfiliUtentiKing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profili Utenti King";
            this.Load += new System.EventHandler(this.FrmProfiliUtentiKing_Load);
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.CheckBox chkSoloErrati;
        private System.Windows.Forms.RadioButton rbuUsermanager;
        private System.Windows.Forms.RadioButton rbuKing;
        private System.Windows.Forms.Button btnEstraiDaKing;
        private System.Windows.Forms.CheckBox chkAncheDisdetti;
        private System.Windows.Forms.Button btnPreleva;
        private System.Windows.Forms.Button btnEsci;
        private Syncfusion.WinForms.DataGrid.SfDataGrid Grid;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnStampa;
    }
}