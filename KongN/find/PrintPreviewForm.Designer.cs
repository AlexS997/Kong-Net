#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Windows.Forms.PdfViewer;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGridConverter;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using KongN.Find;
namespace Printing
{
    partial class PrintPreviewForm
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings2 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings2 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPreviewForm));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings2 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pdfDocumentView1 = new Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCurrentPageIndex = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblTotalPageCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.cmbCurrentZoomLevel = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FitPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.FitWidth = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnGoToFirstPage = new System.Windows.Forms.ToolStripButton();
            this.btnGoToPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.btnGoToNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnGoToLastPage = new System.Windows.Forms.ToolStripButton();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfDocumentView1
            // 
            this.pdfDocumentView1.AutoScroll = true;
            this.pdfDocumentView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pdfDocumentView1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            this.pdfDocumentView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfDocumentView1.EnableContextMenu = true;
            this.pdfDocumentView1.HorizontalScrollOffset = 0;
            this.pdfDocumentView1.IsTextSearchEnabled = true;
            this.pdfDocumentView1.IsTextSelectionEnabled = true;
            this.pdfDocumentView1.Location = new System.Drawing.Point(0, 27);
            messageBoxSettings2.EnableNotification = true;
            this.pdfDocumentView1.MessageBoxSettings = messageBoxSettings2;
            this.pdfDocumentView1.MinimumZoomPercentage = 50;
            this.pdfDocumentView1.Name = "pdfDocumentView1";
            this.pdfDocumentView1.PageBorderThickness = 1;
            pdfViewerPrinterSettings2.Copies = 1;
            pdfViewerPrinterSettings2.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings2.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings2.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings2.PrintLocation")));
            pdfViewerPrinterSettings2.ShowPrintStatusDialog = true;
            this.pdfDocumentView1.PrinterSettings = pdfViewerPrinterSettings2;
            this.pdfDocumentView1.ReferencePath = null;
            this.pdfDocumentView1.ScrollDisplacementValue = 0;
            this.pdfDocumentView1.ShowHorizontalScrollBar = true;
            this.pdfDocumentView1.ShowVerticalScrollBar = true;
            this.pdfDocumentView1.Size = new System.Drawing.Size(284, 235);
            this.pdfDocumentView1.SpaceBetweenPages = 8;
            this.pdfDocumentView1.TabIndex = 3;
            textSearchSettings2.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings2.HighlightAllInstance = true;
            textSearchSettings2.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pdfDocumentView1.TextSearchSettings = textSearchSettings2;
            this.pdfDocumentView1.ThemeName = "Default";
            this.pdfDocumentView1.VerticalScrollOffset = 0;
            this.pdfDocumentView1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            this.pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.toolStripSeparator1,
            this.btnGoToFirstPage,
            this.btnGoToPreviousPage,
            this.txtCurrentPageIndex,
            this.toolStripLabel1,
            this.lblTotalPageCount,
            this.btnGoToNextPage,
            this.btnGoToLastPage,
            this.toolStripButton3,
            this.btnZoomIn,
            this.btnZoomOut,
            this.cmbCurrentZoomLevel,
            this.toolStripSeparator3,
            this.FitPage,
            this.toolStripSeparator5,
            this.FitWidth});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // txtCurrentPageIndex
            // 
            this.txtCurrentPageIndex.Name = "txtCurrentPageIndex";
            this.txtCurrentPageIndex.Size = new System.Drawing.Size(30, 27);
            this.txtCurrentPageIndex.Text = "1";
            this.txtCurrentPageIndex.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentPageIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrentPageIndex_KeyDown);
            this.txtCurrentPageIndex.Click += new System.EventHandler(this.txtCurrentPageIndex_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 24);
            this.toolStripLabel1.Text = "/";
            // 
            // lblTotalPageCount
            // 
            this.lblTotalPageCount.Name = "lblTotalPageCount";
            this.lblTotalPageCount.Size = new System.Drawing.Size(25, 24);
            this.lblTotalPageCount.Text = "100";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = global::KongN.Properties.Resources.ZoomIn;
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 24);
            this.btnZoomOut.Text = "Zoom IN";
            this.btnZoomOut.ToolTipText = "Zoom IN";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // cmbCurrentZoomLevel
            // 
            this.cmbCurrentZoomLevel.Items.AddRange(new object[] {
            "50%",
            "75%",
            "100%",
            "125%",
            "150%",
            "200%",
            "400%"});
            this.cmbCurrentZoomLevel.Name = "cmbCurrentZoomLevel";
            this.cmbCurrentZoomLevel.Size = new System.Drawing.Size(75, 23);
            this.cmbCurrentZoomLevel.Text = "100%";
            this.cmbCurrentZoomLevel.SelectedIndexChanged += new System.EventHandler(this.cmbCurrentZoomLevel_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // FitPage
            // 
            this.FitPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FitPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FitPage.Name = "FitPage";
            this.FitPage.Size = new System.Drawing.Size(23, 4);
            this.FitPage.Text = "Fit Page";
            this.FitPage.Click += new System.EventHandler(this.FitPage_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // FitWidth
            // 
            this.FitWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FitWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FitWidth.Name = "FitWidth";
            this.FitWidth.Size = new System.Drawing.Size(23, 4);
            this.FitWidth.Text = "Fit Width";
            this.FitWidth.Click += new System.EventHandler(this.FitWidth_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = global::KongN.Properties.Resources.Print1;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 24);
            this.btnPrint.Text = "Click per Stampare.";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnGoToFirstPage
            // 
            this.btnGoToFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoToFirstPage.Image = global::KongN.Properties.Resources.ArrowDoubleLeft;
            this.btnGoToFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToFirstPage.Name = "btnGoToFirstPage";
            this.btnGoToFirstPage.Size = new System.Drawing.Size(23, 24);
            this.btnGoToFirstPage.Text = "Prima Pagina";
            this.btnGoToFirstPage.ToolTipText = "Prima Pagina";
            this.btnGoToFirstPage.Click += new System.EventHandler(this.btnGoToFirstPage_Click);
            // 
            // btnGoToPreviousPage
            // 
            this.btnGoToPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoToPreviousPage.Image = global::KongN.Properties.Resources.ArrowLeft1;
            this.btnGoToPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToPreviousPage.Name = "btnGoToPreviousPage";
            this.btnGoToPreviousPage.Size = new System.Drawing.Size(23, 24);
            this.btnGoToPreviousPage.Text = "Pagina Precedente";
            this.btnGoToPreviousPage.ToolTipText = "Pagina Precedente";
            this.btnGoToPreviousPage.Click += new System.EventHandler(this.btnGoToPreviousPage_Click);
            // 
            // btnGoToNextPage
            // 
            this.btnGoToNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoToNextPage.Image = global::KongN.Properties.Resources.ArrowRight;
            this.btnGoToNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToNextPage.Name = "btnGoToNextPage";
            this.btnGoToNextPage.Size = new System.Drawing.Size(23, 24);
            this.btnGoToNextPage.Text = "Pagina Successiva";
            this.btnGoToNextPage.ToolTipText = "Pagina Successiva";
            this.btnGoToNextPage.Click += new System.EventHandler(this.btnGoToNextPage_Click);
            // 
            // btnGoToLastPage
            // 
            this.btnGoToLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoToLastPage.Image = global::KongN.Properties.Resources.AroowDoubleRight;
            this.btnGoToLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToLastPage.Name = "btnGoToLastPage";
            this.btnGoToLastPage.Size = new System.Drawing.Size(23, 24);
            this.btnGoToLastPage.Text = "Ultima Pagina";
            this.btnGoToLastPage.ToolTipText = "Ultima Pagina";
            this.btnGoToLastPage.Click += new System.EventHandler(this.btnGoToLastPage_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = global::KongN.Properties.Resources.ZoomOut;
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 24);
            this.btnZoomIn.Text = "Zoom OUT";
            this.btnZoomIn.ToolTipText = "Zoom OUT";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // PrintPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pdfDocumentView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PrintPreviewForm";
            this.ShowIcon = false;
            this.Text = "Print Preview Dialog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrintPreviewForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       private void LoadDocumentToPdfViewer()
        {

            //Create Memory Stream to save pdfdocument.
            MemoryStream pdfstream = new MemoryStream();

            //Intialize the PdfDocument
            PdfDocument pdfDoc = new PdfDocument();

            PdfExportingOptions options = new PdfExportingOptions();
            options.FitAllColumnsInOnePage = true;

            ////Convert grid into PDF document
            pdfDoc = dataGrid.ExportToPdf(options);

            //Save the PDF file
            pdfDoc.Save(pdfstream);

            //Load the pdfstream to pdfDocumentView
            pdfDocumentView1.Load(pdfstream);

            lblTotalPageCount.Text = pdfDocumentView1.PageCount.ToString();
            EnablePagination();
            pageTimer.Tick += pageTimer_Tick;
            pageTimer.Start();

        }

        #endregion
        private System.Windows.Forms.ToolTip Tooltip;
        private Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView pdfDocumentView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGoToFirstPage;
        private System.Windows.Forms.ToolStripButton btnGoToPreviousPage;
        private System.Windows.Forms.ToolStripTextBox txtCurrentPageIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblTotalPageCount;
        private System.Windows.Forms.ToolStripButton btnGoToNextPage;
        private System.Windows.Forms.ToolStripButton btnGoToLastPage;
        private System.Windows.Forms.ToolStripComboBox cmbCurrentZoomLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripButton3;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton FitPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton FitWidth;
        internal SfDataGrid dataGrid;
    }
}