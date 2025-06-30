namespace KongN.Voip
{
    partial class FrmNormalizzazione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNormalizzazione));
            this.btnEsci = new System.Windows.Forms.Button();
            this.btnElabora = new System.Windows.Forms.Button();
            this.rbuStoricoChiamate = new System.Windows.Forms.RadioButton();
            this.rbuChiamate = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEsci
            // 
            this.btnEsci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsci.Location = new System.Drawing.Point(699, 129);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 30);
            this.btnEsci.TabIndex = 28;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnElabora
            // 
            this.btnElabora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElabora.Location = new System.Drawing.Point(26, 129);
            this.btnElabora.Name = "btnElabora";
            this.btnElabora.Size = new System.Drawing.Size(75, 30);
            this.btnElabora.TabIndex = 29;
            this.btnElabora.Text = "Elabora";
            this.btnElabora.UseVisualStyleBackColor = true;
            this.btnElabora.Click += new System.EventHandler(this.btnElabora_Click);
            // 
            // rbuStoricoChiamate
            // 
            this.rbuStoricoChiamate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbuStoricoChiamate.AutoSize = true;
            this.rbuStoricoChiamate.Location = new System.Drawing.Point(667, 65);
            this.rbuStoricoChiamate.Name = "rbuStoricoChiamate";
            this.rbuStoricoChiamate.Size = new System.Drawing.Size(105, 17);
            this.rbuStoricoChiamate.TabIndex = 30;
            this.rbuStoricoChiamate.Text = "Storico Chiamate";
            this.rbuStoricoChiamate.UseVisualStyleBackColor = true;
            // 
            // rbuChiamate
            // 
            this.rbuChiamate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbuChiamate.AutoSize = true;
            this.rbuChiamate.Checked = true;
            this.rbuChiamate.Location = new System.Drawing.Point(667, 38);
            this.rbuChiamate.Name = "rbuChiamate";
            this.rbuChiamate.Size = new System.Drawing.Size(69, 17);
            this.rbuChiamate.TabIndex = 31;
            this.rbuChiamate.TabStop = true;
            this.rbuChiamate.Text = "Chiamate";
            this.rbuChiamate.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label.Location = new System.Drawing.Point(125, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(445, 85);
            this.label.TabIndex = 33;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmNormalizzazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 177);
            this.Controls.Add(this.label);
            this.Controls.Add(this.rbuStoricoChiamate);
            this.Controls.Add(this.rbuChiamate);
            this.Controls.Add(this.btnElabora);
            this.Controls.Add(this.btnEsci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 216);
            this.MinimumSize = new System.Drawing.Size(816, 216);
            this.Name = "FrmNormalizzazione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normalizzazione";
            this.Load += new System.EventHandler(this.FrmNormalizzazione_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Button btnElabora;
        private System.Windows.Forms.RadioButton rbuStoricoChiamate;
        private System.Windows.Forms.RadioButton rbuChiamate;
        private System.Windows.Forms.Label label;
    }
}