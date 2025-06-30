using FastReport.Preview;

namespace KongN.Stampa
{
    partial class FormStampa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStampa));
            this.previewControl = new FastReport.Preview.PreviewControl();
            this.SuspendLayout();
            // 
            // previewControl
            // 
            this.previewControl.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.previewControl.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.previewControl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.previewControl.Buttons = ((FastReport.PreviewButtons)((((((((((((FastReport.PreviewButtons.Print | FastReport.PreviewButtons.Save) 
            | FastReport.PreviewButtons.Email) 
            | FastReport.PreviewButtons.Find) 
            | FastReport.PreviewButtons.Zoom) 
            | FastReport.PreviewButtons.Outline) 
            | FastReport.PreviewButtons.PageSetup) 
            | FastReport.PreviewButtons.Watermark) 
            | FastReport.PreviewButtons.Navigator) 
            | FastReport.PreviewButtons.Close) 
            | FastReport.PreviewButtons.CopyPage) 
            | FastReport.PreviewButtons.DeletePage)));
            this.previewControl.ControlHScrollBarHeight = null;
            this.previewControl.ControlVScrollBarWidth = null;
            this.previewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewControl.Exports = ((FastReport.PreviewExports)((((((((((((((((((((((((FastReport.PreviewExports.PDFExport | FastReport.PreviewExports.RTFExport) 
            | FastReport.PreviewExports.HTMLExport) 
            | FastReport.PreviewExports.MHTExport) 
            | FastReport.PreviewExports.XMLExport) 
            | FastReport.PreviewExports.Excel2007Export) 
            | FastReport.PreviewExports.Excel2003Document) 
            | FastReport.PreviewExports.Word2007Export) 
            | FastReport.PreviewExports.PowerPoint2007Export) 
            | FastReport.PreviewExports.ODSExport) 
            | FastReport.PreviewExports.ODTExport) 
            | FastReport.PreviewExports.XPSExport) 
            | FastReport.PreviewExports.CSVExport) 
            | FastReport.PreviewExports.DBFExport) 
            | FastReport.PreviewExports.TextExport) 
            | FastReport.PreviewExports.ZplExport) 
            | FastReport.PreviewExports.ImageExport) 
            | FastReport.PreviewExports.XAMLExport) 
            | FastReport.PreviewExports.SVGExport) 
            | FastReport.PreviewExports.PPMLExport) 
            | FastReport.PreviewExports.PSExport) 
            | FastReport.PreviewExports.JsonExport) 
            | FastReport.PreviewExports.LaTeXExport) 
            | FastReport.PreviewExports.DxfExport)));
            this.previewControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.previewControl.Location = new System.Drawing.Point(0, 0);
            this.previewControl.Name = "previewControl";
            this.previewControl.OutlineExpand = true;
            this.previewControl.OutlineWidth = 150;
            this.previewControl.PageOffset = new System.Drawing.Point(10, 10);
            this.previewControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.previewControl.SaveInitialDirectory = null;
            this.previewControl.Size = new System.Drawing.Size(1010, 523);
            this.previewControl.TabIndex = 0;
            // 
            // Stampa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 523);
            this.Controls.Add(this.previewControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stampa";
            this.Text = "Stampa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private FastReport.Preview.PreviewControl previewControl;
    }
}