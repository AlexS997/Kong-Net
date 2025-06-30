namespace KongN.StrutturaRete
{
    partial class FrmAlbero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlbero));
            this.gbx = new System.Windows.Forms.GroupBox();
            this.lblClienti = new System.Windows.Forms.Label();
            this.lblPannelli = new System.Windows.Forms.Label();
            this.lblPonti = new System.Windows.Forms.Label();
            this.lblClientiSenza = new System.Windows.Forms.Label();
            this.lblPannelliSenza = new System.Windows.Forms.Label();
            this.lblPontiSenza = new System.Windows.Forms.Label();
            this.lblGatewaySenza = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblFornitori = new System.Windows.Forms.Label();
            this.lblDoppioClickPerRichiamareLaMaschera = new System.Windows.Forms.Label();
            this.btnEsci = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.chkAncheClienti = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitter = new System.Windows.Forms.Splitter();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.lblClienti);
            this.gbx.Controls.Add(this.lblPannelli);
            this.gbx.Controls.Add(this.lblPonti);
            this.gbx.Controls.Add(this.lblClientiSenza);
            this.gbx.Controls.Add(this.lblPannelliSenza);
            this.gbx.Controls.Add(this.lblPontiSenza);
            this.gbx.Controls.Add(this.lblGatewaySenza);
            this.gbx.Controls.Add(this.lblGateway);
            this.gbx.Controls.Add(this.lblFornitori);
            this.gbx.Location = new System.Drawing.Point(12, 147);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(226, 349);
            this.gbx.TabIndex = 14;
            this.gbx.TabStop = false;
            // 
            // lblClienti
            // 
            this.lblClienti.AutoSize = true;
            this.lblClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienti.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblClienti.Location = new System.Drawing.Point(7, 294);
            this.lblClienti.Name = "lblClienti";
            this.lblClienti.Size = new System.Drawing.Size(50, 16);
            this.lblClienti.TabIndex = 0;
            this.lblClienti.Text = "Clienti";
            // 
            // lblPannelli
            // 
            this.lblPannelli.AutoSize = true;
            this.lblPannelli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPannelli.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPannelli.Location = new System.Drawing.Point(7, 210);
            this.lblPannelli.Name = "lblPannelli";
            this.lblPannelli.Size = new System.Drawing.Size(63, 16);
            this.lblPannelli.TabIndex = 0;
            this.lblPannelli.Text = "Pannelli";
            // 
            // lblPonti
            // 
            this.lblPonti.AutoSize = true;
            this.lblPonti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonti.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPonti.Location = new System.Drawing.Point(7, 124);
            this.lblPonti.Name = "lblPonti";
            this.lblPonti.Size = new System.Drawing.Size(42, 16);
            this.lblPonti.TabIndex = 0;
            this.lblPonti.Text = "Ponti";
            // 
            // lblClientiSenza
            // 
            this.lblClientiSenza.AutoSize = true;
            this.lblClientiSenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientiSenza.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblClientiSenza.Location = new System.Drawing.Point(7, 319);
            this.lblClientiSenza.Name = "lblClientiSenza";
            this.lblClientiSenza.Size = new System.Drawing.Size(155, 16);
            this.lblClientiSenza.TabIndex = 0;
            this.lblClientiSenza.Text = "Clienti senza Pannelli";
            // 
            // lblPannelliSenza
            // 
            this.lblPannelliSenza.AutoSize = true;
            this.lblPannelliSenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPannelliSenza.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblPannelliSenza.Location = new System.Drawing.Point(7, 238);
            this.lblPannelliSenza.Name = "lblPannelliSenza";
            this.lblPannelliSenza.Size = new System.Drawing.Size(147, 16);
            this.lblPannelliSenza.TabIndex = 0;
            this.lblPannelliSenza.Text = "Pannelli senza Ponti";
            // 
            // lblPontiSenza
            // 
            this.lblPontiSenza.AutoSize = true;
            this.lblPontiSenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontiSenza.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblPontiSenza.Location = new System.Drawing.Point(7, 153);
            this.lblPontiSenza.Name = "lblPontiSenza";
            this.lblPontiSenza.Size = new System.Drawing.Size(142, 16);
            this.lblPontiSenza.TabIndex = 0;
            this.lblPontiSenza.Text = "Ponti senza Gatway";
            // 
            // lblGatewaySenza
            // 
            this.lblGatewaySenza.AutoSize = true;
            this.lblGatewaySenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGatewaySenza.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblGatewaySenza.Location = new System.Drawing.Point(7, 70);
            this.lblGatewaySenza.Name = "lblGatewaySenza";
            this.lblGatewaySenza.Size = new System.Drawing.Size(173, 16);
            this.lblGatewaySenza.TabIndex = 0;
            this.lblGatewaySenza.Text = "Gateway senza Fornitori";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateway.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblGateway.Location = new System.Drawing.Point(7, 43);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(67, 16);
            this.lblGateway.TabIndex = 0;
            this.lblGateway.Text = "Gateway";
            // 
            // lblFornitori
            // 
            this.lblFornitori.AutoSize = true;
            this.lblFornitori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornitori.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFornitori.Location = new System.Drawing.Point(7, 16);
            this.lblFornitori.Name = "lblFornitori";
            this.lblFornitori.Size = new System.Drawing.Size(64, 16);
            this.lblFornitori.TabIndex = 0;
            this.lblFornitori.Text = "Fornitori";
            // 
            // lblDoppioClickPerRichiamareLaMaschera
            // 
            this.lblDoppioClickPerRichiamareLaMaschera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoppioClickPerRichiamareLaMaschera.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDoppioClickPerRichiamareLaMaschera.Location = new System.Drawing.Point(9, 499);
            this.lblDoppioClickPerRichiamareLaMaschera.Name = "lblDoppioClickPerRichiamareLaMaschera";
            this.lblDoppioClickPerRichiamareLaMaschera.Size = new System.Drawing.Size(112, 60);
            this.lblDoppioClickPerRichiamareLaMaschera.TabIndex = 13;
            this.lblDoppioClickPerRichiamareLaMaschera.Text = "Doppio Click per richiamare la Maschera.";
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(13, 570);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(88, 23);
            this.btnEsci.TabIndex = 9;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Location = new System.Drawing.Point(13, 77);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(87, 23);
            this.btnChiudi.TabIndex = 10;
            this.btnChiudi.Text = "Chiudi Albero";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Location = new System.Drawing.Point(13, 106);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(88, 23);
            this.btnStampa.TabIndex = 11;
            this.btnStampa.Text = "Stampa";
            this.btnStampa.UseVisualStyleBackColor = true;
            // 
            // btnEstrai
            // 
            this.btnEstrai.Location = new System.Drawing.Point(13, 48);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(88, 23);
            this.btnEstrai.TabIndex = 12;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.btnEstrai_Click);
            // 
            // chkAncheClienti
            // 
            this.chkAncheClienti.AutoSize = true;
            this.chkAncheClienti.Checked = true;
            this.chkAncheClienti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAncheClienti.Location = new System.Drawing.Point(13, 14);
            this.chkAncheClienti.Name = "chkAncheClienti";
            this.chkAncheClienti.Size = new System.Drawing.Size(88, 17);
            this.chkAncheClienti.TabIndex = 8;
            this.chkAncheClienti.Text = "Anche Clienti";
            this.chkAncheClienti.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(244, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(1079, 620);
            this.treeView1.TabIndex = 7;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(244, 620);
            this.splitter.TabIndex = 6;
            this.splitter.TabStop = false;
            // 
            // FrmAlbero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1323, 620);
            this.Controls.Add(this.gbx);
            this.Controls.Add(this.lblDoppioClickPerRichiamareLaMaschera);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.chkAncheClienti);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.splitter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlbero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albero della Rete";
            this.Load += new System.EventHandler(this.FrmAlbero_Load);
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.Label lblClienti;
        private System.Windows.Forms.Label lblPannelli;
        private System.Windows.Forms.Label lblPonti;
        private System.Windows.Forms.Label lblClientiSenza;
        private System.Windows.Forms.Label lblPannelliSenza;
        private System.Windows.Forms.Label lblPontiSenza;
        private System.Windows.Forms.Label lblGatewaySenza;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblFornitori;
        private System.Windows.Forms.Label lblDoppioClickPerRichiamareLaMaschera;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.CheckBox chkAncheClienti;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Splitter splitter;
    }
}