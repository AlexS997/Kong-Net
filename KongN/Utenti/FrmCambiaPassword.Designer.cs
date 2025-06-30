namespace KongN.Utenti
{
    partial class FrmCambiaPassword
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
            System.Windows.Forms.Label lblPassword;
            System.Windows.Forms.Label lblConferma;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiaPassword));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfermaPassword = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.lblEye = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            lblConferma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            lblPassword.Location = new System.Drawing.Point(16, 37);
            lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(78, 19);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // lblConferma
            // 
            lblConferma.AutoSize = true;
            lblConferma.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblConferma.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            lblConferma.Location = new System.Drawing.Point(16, 86);
            lblConferma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblConferma.Name = "lblConferma";
            lblConferma.Size = new System.Drawing.Size(148, 19);
            lblConferma.TabIndex = 3;
            lblConferma.Text = "Conferma Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(184, 34);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(248, 27);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Tag = "Cliente";
            // 
            // txtConfermaPassword
            // 
            this.txtConfermaPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfermaPassword.Location = new System.Drawing.Point(184, 83);
            this.txtConfermaPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfermaPassword.Name = "txtConfermaPassword";
            this.txtConfermaPassword.PasswordChar = '*';
            this.txtConfermaPassword.Size = new System.Drawing.Size(248, 27);
            this.txtConfermaPassword.TabIndex = 5;
            this.txtConfermaPassword.Tag = "Cliente";
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalva.Location = new System.Drawing.Point(20, 158);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(70, 27);
            this.btnSalva.TabIndex = 13;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnulla.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAnnulla.Location = new System.Drawing.Point(381, 158);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(70, 27);
            this.btnAnnulla.TabIndex = 14;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // lblEye
            // 
            this.lblEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEye.Image = global::KongN.Properties.Resources.eye_open;
            this.lblEye.Location = new System.Drawing.Point(441, 36);
            this.lblEye.Name = "lblEye";
            this.lblEye.Size = new System.Drawing.Size(26, 23);
            this.lblEye.TabIndex = 15;
            this.lblEye.Click += new System.EventHandler(this.lblEye_Click);
            // 
            // FrmCambiaPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(481, 203);
            this.Controls.Add(this.lblEye);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtConfermaPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(lblConferma);
            this.Controls.Add(lblPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(569, 242);
            this.MinimumSize = new System.Drawing.Size(497, 242);
            this.Name = "FrmCambiaPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambia Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCambiaPassword_FormClosed);
            this.Load += new System.EventHandler(this.FrmCambiaPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfermaPassword;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Label lblEye;
    }
}