namespace KongN.Varie
{
    partial class FormAttendere
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
            this.gradientLabelAttenderePrego = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.SuspendLayout();
            // 
            // gradientLabelAttenderePrego
            // 
            this.gradientLabelAttenderePrego.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabelAttenderePrego.BeforeTouchSize = new System.Drawing.Size(414, 86);
            this.gradientLabelAttenderePrego.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabelAttenderePrego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientLabelAttenderePrego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabelAttenderePrego.Location = new System.Drawing.Point(0, 0);
            this.gradientLabelAttenderePrego.Name = "gradientLabelAttenderePrego";
            this.gradientLabelAttenderePrego.Size = new System.Drawing.Size(414, 86);
            this.gradientLabelAttenderePrego.TabIndex = 0;
            this.gradientLabelAttenderePrego.Text = "Attendere Prego..........";
            this.gradientLabelAttenderePrego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAttendere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 86);
            this.ControlBox = false;
            this.Controls.Add(this.gradientLabelAttenderePrego);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAttendere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendere";
            this.Load += new System.EventHandler(this.FormAttendere_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabelAttenderePrego;
    }
}