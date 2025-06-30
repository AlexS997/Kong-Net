namespace KongN.StrutturaRete
{
    partial class FrmMappa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMappa));
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.btnEsci = new System.Windows.Forms.Button();
            this.lblTastoDestroPerPrendereIlPunto = new System.Windows.Forms.Label();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnRiporta = new System.Windows.Forms.Button();
            this.lblTipoDiMappa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.lblLatitudine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.lblGateway = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.splitter = new System.Windows.Forms.Splitter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picGateway = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGateway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx1
            // 
            this.gbx1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx1.Controls.Add(this.btnEsci);
            this.gbx1.Controls.Add(this.lblTastoDestroPerPrendereIlPunto);
            this.gbx1.Controls.Add(this.pictureBox3);
            this.gbx1.Controls.Add(this.btnPulisci);
            this.gbx1.Controls.Add(this.cboTipo);
            this.gbx1.Controls.Add(this.btnRiporta);
            this.gbx1.Controls.Add(this.lblTipoDiMappa);
            this.gbx1.Controls.Add(this.label3);
            this.gbx1.Controls.Add(this.label4);
            this.gbx1.Controls.Add(this.txtLat);
            this.gbx1.Controls.Add(this.picGateway);
            this.gbx1.Controls.Add(this.lblLatitudine);
            this.gbx1.Controls.Add(this.label1);
            this.gbx1.Controls.Add(this.txtLong);
            this.gbx1.Controls.Add(this.pictureBox1);
            this.gbx1.Controls.Add(this.lblGateway);
            this.gbx1.Location = new System.Drawing.Point(1837, 0);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(211, 828);
            this.gbx1.TabIndex = 37;
            this.gbx1.TabStop = false;
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEsci.Location = new System.Drawing.Point(56, 788);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(100, 23);
            this.btnEsci.TabIndex = 32;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // lblTastoDestroPerPrendereIlPunto
            // 
            this.lblTastoDestroPerPrendereIlPunto.AutoSize = true;
            this.lblTastoDestroPerPrendereIlPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTastoDestroPerPrendereIlPunto.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTastoDestroPerPrendereIlPunto.Location = new System.Drawing.Point(3, 722);
            this.lblTastoDestroPerPrendereIlPunto.Name = "lblTastoDestroPerPrendereIlPunto";
            this.lblTastoDestroPerPrendereIlPunto.Size = new System.Drawing.Size(204, 13);
            this.lblTastoDestroPerPrendereIlPunto.TabIndex = 23;
            this.lblTastoDestroPerPrendereIlPunto.Text = "Tasto destro per prendere il punto.";
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(56, 694);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(100, 23);
            this.btnPulisci.TabIndex = 18;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Maps",
            "Satellite",
            "Ibrida",
            "Terrestre"});
            this.cboTipo.Location = new System.Drawing.Point(48, 47);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 24;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // btnRiporta
            // 
            this.btnRiporta.Location = new System.Drawing.Point(56, 665);
            this.btnRiporta.Name = "btnRiporta";
            this.btnRiporta.Size = new System.Drawing.Size(100, 23);
            this.btnRiporta.TabIndex = 18;
            this.btnRiporta.Text = "Riporta Punto";
            this.btnRiporta.UseVisualStyleBackColor = true;
            this.btnRiporta.Click += new System.EventHandler(this.btnRiporta_Click);
            // 
            // lblTipoDiMappa
            // 
            this.lblTipoDiMappa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDiMappa.Location = new System.Drawing.Point(49, 21);
            this.lblTipoDiMappa.Name = "lblTipoDiMappa";
            this.lblTipoDiMappa.Size = new System.Drawing.Size(120, 23);
            this.lblTipoDiMappa.TabIndex = 25;
            this.lblTipoDiMappa.Text = "Tipo di Mappa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Longitudine";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(51, 474);
            this.txtLat.Name = "txtLat";
            this.txtLat.ReadOnly = true;
            this.txtLat.Size = new System.Drawing.Size(100, 20);
            this.txtLat.TabIndex = 20;
            // 
            // lblLatitudine
            // 
            this.lblLatitudine.AutoSize = true;
            this.lblLatitudine.Location = new System.Drawing.Point(76, 503);
            this.lblLatitudine.Name = "lblLatitudine";
            this.lblLatitudine.Size = new System.Drawing.Size(53, 13);
            this.lblLatitudine.TabIndex = 22;
            this.lblLatitudine.Text = "Latitudine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ponte";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(51, 528);
            this.txtLong.Name = "txtLong";
            this.txtLong.ReadOnly = true;
            this.txtLong.Size = new System.Drawing.Size(100, 20);
            this.txtLong.TabIndex = 19;
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateway.Location = new System.Drawing.Point(46, 124);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(60, 16);
            this.lblGateway.TabIndex = 31;
            this.lblGateway.Text = "Gateway";
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1831, 828);
            this.map.TabIndex = 36;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(1149, 828);
            this.splitter.TabIndex = 35;
            this.splitter.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KongN.Properties.Resources.gps_10577701;
            this.pictureBox3.Location = new System.Drawing.Point(124, 274);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // picGateway
            // 
            this.picGateway.Image = global::KongN.Properties.Resources.red_pushpin;
            this.picGateway.Location = new System.Drawing.Point(124, 90);
            this.picGateway.Name = "picGateway";
            this.picGateway.Size = new System.Drawing.Size(47, 50);
            this.picGateway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGateway.TabIndex = 28;
            this.picGateway.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KongN.Properties.Resources.blue_pushpin;
            this.pictureBox1.Location = new System.Drawing.Point(124, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMappa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(2048, 828);
            this.Controls.Add(this.gbx1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMappa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mappa Punti della Rete";
            this.Load += new System.EventHandler(this.FrmMappa_Load);
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGateway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Label lblTastoDestroPerPrendereIlPunto;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnRiporta;
        private System.Windows.Forms.Label lblTipoDiMappa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.PictureBox picGateway;
        private System.Windows.Forms.Label lblLatitudine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGateway;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Splitter splitter;
    }
}