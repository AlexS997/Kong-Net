namespace KongN.Controlli
{
    partial class FrmAggiornaSpesePostali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAggiornaSpesePostali));
            this.lblSpesePostali = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSpesePostali
            // 
            this.lblSpesePostali.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSpesePostali.AutoSize = true;
            this.lblSpesePostali.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpesePostali.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSpesePostali.Location = new System.Drawing.Point(315, 117);
            this.lblSpesePostali.Name = "lblSpesePostali";
            this.lblSpesePostali.Size = new System.Drawing.Size(98, 19);
            this.lblSpesePostali.TabIndex = 4;
            this.lblSpesePostali.Text = "Spese Postali";
            // 
            // num
            // 
            this.num.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.num.DecimalPlaces = 2;
            this.num.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(425, 115);
            this.num.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(120, 26);
            this.num.TabIndex = 0;
            this.num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEsegui
            // 
            this.btnEsegui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEsegui.Location = new System.Drawing.Point(26, 110);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(75, 33);
            this.btnEsegui.TabIndex = 1;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(775, 110);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 33);
            this.btnEsci.TabIndex = 2;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label.Location = new System.Drawing.Point(12, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(849, 59);
            this.label.TabIndex = 29;
            this.label.Text = "Help";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAggiornaSpesePostali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(873, 162);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblSpesePostali);
            this.Controls.Add(this.num);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(889, 201);
            this.MinimumSize = new System.Drawing.Size(559, 201);
            this.Name = "FrmAggiornaSpesePostali";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiorna Spese Postali";
            this.Load += new System.EventHandler(this.FrmAggiornaSpesePostali_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpesePostali;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Label label;
    }
}