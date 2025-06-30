namespace KongN
{
    partial class vLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vLogin));
            this.pLeft = new System.Windows.Forms.Panel();
            this.lblImg = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAttendere = new System.Windows.Forms.Label();
            this.lblDimenticata = new System.Windows.Forms.LinkLabel();
            this.lblEye = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pLeft.Controls.Add(this.lblImg);
            this.pLeft.Controls.Add(this.lblClose);
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(444, 171);
            this.pLeft.TabIndex = 0;
            // 
            // lblImg
            // 
            this.lblImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImg.Image = global::KongN.Properties.Resources.kong;
            this.lblImg.Location = new System.Drawing.Point(165, 20);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(117, 114);
            this.lblImg.TabIndex = 0;
            this.lblImg.Text = "Kong";
            this.lblImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClose.Location = new System.Drawing.Point(411, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(21, 20);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblAttendere);
            this.panel1.Controls.Add(this.lblDimenticata);
            this.panel1.Controls.Add(this.lblEye);
            this.panel1.Controls.Add(this.pLeft);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 514);
            this.panel1.TabIndex = 1;
            // 
            // lblAttendere
            // 
            this.lblAttendere.AutoSize = true;
            this.lblAttendere.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendere.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAttendere.Location = new System.Drawing.Point(125, 485);
            this.lblAttendere.Name = "lblAttendere";
            this.lblAttendere.Size = new System.Drawing.Size(178, 19);
            this.lblAttendere.TabIndex = 10;
            this.lblAttendere.Text = "Attendere Prego................";
            // 
            // lblDimenticata
            // 
            this.lblDimenticata.AutoSize = true;
            this.lblDimenticata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDimenticata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimenticata.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDimenticata.Location = new System.Drawing.Point(140, 455);
            this.lblDimenticata.Name = "lblDimenticata";
            this.lblDimenticata.Size = new System.Drawing.Size(160, 19);
            this.lblDimenticata.TabIndex = 9;
            this.lblDimenticata.TabStop = true;
            this.lblDimenticata.Text = "Password Dimenticata";
            this.lblDimenticata.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDimenticata_LinkClicked);
            // 
            // lblEye
            // 
            this.lblEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEye.Image = global::KongN.Properties.Resources.eye_open;
            this.lblEye.Location = new System.Drawing.Point(361, 332);
            this.lblEye.Name = "lblEye";
            this.lblEye.Size = new System.Drawing.Size(26, 23);
            this.lblEye.TabIndex = 7;
            this.lblEye.Click += new System.EventHandler(this.lblEye_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(183, 400);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPassword.Location = new System.Drawing.Point(100, 306);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUser.Location = new System.Drawing.Point(100, 240);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 19);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(101, 331);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(254, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(100, 265);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(255, 26);
            this.txtUser.TabIndex = 0;
            // 
            // vLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 513);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vLogin";
            this.Load += new System.EventHandler(this.vLogin_Load);
            this.pLeft.ResumeLayout(false);
            this.pLeft.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Label lblEye;
        private System.Windows.Forms.LinkLabel lblDimenticata;
        private System.Windows.Forms.Label lblAttendere;
    }
}