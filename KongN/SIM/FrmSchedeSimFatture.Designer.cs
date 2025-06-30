namespace KongN.SIM
{
    partial class FrmSchedeSimFatture
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iDSchedaLabel;
            System.Windows.Forms.Label numeroFatturaLabel;
            System.Windows.Forms.Label dataFatturaLabel;
            System.Windows.Forms.Label importoLabel;
            System.Windows.Forms.Label periodoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSchedeSimFatture));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.numeroFatturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFatturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFattureSIM = new System.Windows.Forms.BindingSource(this.components);
            this.nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPreviews = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnEsclusione = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdScheda = new System.Windows.Forms.TextBox();
            this.txtNumeroFattura = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.dtpDataFattura = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.numImporto = new System.Windows.Forms.NumericUpDown();
            iDLabel = new System.Windows.Forms.Label();
            iDSchedaLabel = new System.Windows.Forms.Label();
            numeroFatturaLabel = new System.Windows.Forms.Label();
            dataFatturaLabel = new System.Windows.Forms.Label();
            importoLabel = new System.Windows.Forms.Label();
            periodoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFattureSIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImporto)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iDLabel.Location = new System.Drawing.Point(23, 60);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 18);
            iDLabel.TabIndex = 8;
            iDLabel.Text = "iD:";
            // 
            // iDSchedaLabel
            // 
            iDSchedaLabel.AutoSize = true;
            iDSchedaLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDSchedaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iDSchedaLabel.Location = new System.Drawing.Point(23, 90);
            iDSchedaLabel.Name = "iDSchedaLabel";
            iDSchedaLabel.Size = new System.Drawing.Size(72, 18);
            iDSchedaLabel.TabIndex = 9;
            iDSchedaLabel.Text = "iD Scheda:";
            // 
            // numeroFatturaLabel
            // 
            numeroFatturaLabel.AutoSize = true;
            numeroFatturaLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroFatturaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            numeroFatturaLabel.Location = new System.Drawing.Point(23, 120);
            numeroFatturaLabel.Name = "numeroFatturaLabel";
            numeroFatturaLabel.Size = new System.Drawing.Size(110, 18);
            numeroFatturaLabel.TabIndex = 10;
            numeroFatturaLabel.Text = "Numero Fattura:";
            // 
            // dataFatturaLabel
            // 
            dataFatturaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataFatturaLabel.AutoSize = true;
            dataFatturaLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataFatturaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataFatturaLabel.Location = new System.Drawing.Point(383, 66);
            dataFatturaLabel.Name = "dataFatturaLabel";
            dataFatturaLabel.Size = new System.Drawing.Size(87, 18);
            dataFatturaLabel.TabIndex = 11;
            dataFatturaLabel.Text = "Data Fattura:";
            // 
            // importoLabel
            // 
            importoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            importoLabel.AutoSize = true;
            importoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            importoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            importoLabel.Location = new System.Drawing.Point(383, 94);
            importoLabel.Name = "importoLabel";
            importoLabel.Size = new System.Drawing.Size(62, 18);
            importoLabel.TabIndex = 12;
            importoLabel.Text = "Importo:";
            // 
            // periodoLabel
            // 
            periodoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            periodoLabel.AutoSize = true;
            periodoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            periodoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            periodoLabel.Location = new System.Drawing.Point(383, 120);
            periodoLabel.Name = "periodoLabel";
            periodoLabel.Size = new System.Drawing.Size(61, 18);
            periodoLabel.TabIndex = 13;
            periodoLabel.Text = "Periodo:";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 32;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroFatturaDataGridViewTextBoxColumn,
            this.dataFatturaDataGridViewTextBoxColumn,
            this.importoDataGridViewTextBoxColumn,
            this.periodoDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsFattureSIM;
            this.dgv.Location = new System.Drawing.Point(0, 188);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(696, 400);
            this.dgv.TabIndex = 7;
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // numeroFatturaDataGridViewTextBoxColumn
            // 
            this.numeroFatturaDataGridViewTextBoxColumn.DataPropertyName = "NumeroFattura";
            this.numeroFatturaDataGridViewTextBoxColumn.HeaderText = "NumeroFattura";
            this.numeroFatturaDataGridViewTextBoxColumn.Name = "numeroFatturaDataGridViewTextBoxColumn";
            this.numeroFatturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFatturaDataGridViewTextBoxColumn
            // 
            this.dataFatturaDataGridViewTextBoxColumn.DataPropertyName = "DataFattura";
            this.dataFatturaDataGridViewTextBoxColumn.HeaderText = "DataFattura";
            this.dataFatturaDataGridViewTextBoxColumn.Name = "dataFatturaDataGridViewTextBoxColumn";
            this.dataFatturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importoDataGridViewTextBoxColumn
            // 
            this.importoDataGridViewTextBoxColumn.DataPropertyName = "Importo";
            this.importoDataGridViewTextBoxColumn.HeaderText = "Importo";
            this.importoDataGridViewTextBoxColumn.Name = "importoDataGridViewTextBoxColumn";
            this.importoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodoDataGridViewTextBoxColumn
            // 
            this.periodoDataGridViewTextBoxColumn.DataPropertyName = "Periodo";
            this.periodoDataGridViewTextBoxColumn.HeaderText = "Periodo";
            this.periodoDataGridViewTextBoxColumn.Name = "periodoDataGridViewTextBoxColumn";
            this.periodoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsFattureSIM
            // 
            this.bsFattureSIM.DataSource = typeof(KongN.ClassiTabelle.SchedeSimFatture);
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
            this.nav.BindingSource = this.bsFattureSIM;
            this.nav.CountItem = this.bindingNavigatorCountItem;
            this.nav.DeleteItem = null;
            this.nav.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.nav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirst,
            this.btnPreviews,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.btnNext,
            this.btnLast,
            this.bindingNavigatorSeparator2,
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnSearch,
            this.btnSave,
            this.btnUndo,
            this.btnRefresh,
            this.btnEsclusione,
            this.btnPrint,
            this.btnClose});
            this.nav.Location = new System.Drawing.Point(0, 0);
            this.nav.MoveFirstItem = this.btnFirst;
            this.nav.MoveLastItem = this.btnLast;
            this.nav.MoveNextItem = this.btnNext;
            this.nav.MovePreviousItem = this.btnPreviews;
            this.nav.Name = "nav";
            this.nav.PositionItem = this.bindingNavigatorPositionItem;
            this.nav.Size = new System.Drawing.Size(696, 27);
            this.nav.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // btnFirst
            // 
            this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.RightToLeftAutoMirrorImage = true;
            this.btnFirst.Size = new System.Drawing.Size(24, 24);
            this.btnFirst.Text = "Sposta in prima posizione";
            // 
            // btnPreviews
            // 
            this.btnPreviews.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviews.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviews.Image")));
            this.btnPreviews.Name = "btnPreviews";
            this.btnPreviews.RightToLeftAutoMirrorImage = true;
            this.btnPreviews.Size = new System.Drawing.Size(24, 24);
            this.btnPreviews.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Name = "btnNext";
            this.btnNext.RightToLeftAutoMirrorImage = true;
            this.btnNext.Size = new System.Drawing.Size(24, 24);
            this.btnNext.Text = "Sposta avanti";
            // 
            // btnLast
            // 
            this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Name = "btnLast";
            this.btnLast.RightToLeftAutoMirrorImage = true;
            this.btnLast.Size = new System.Drawing.Size(24, 24);
            this.btnLast.Text = "Sposta in ultima posizione";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAdd.Text = "Aggiungi nuovo";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::KongN.Properties.Resources.Modify;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(24, 24);
            this.btnEdit.ToolTipText = "Modifica";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = global::KongN.Properties.Resources.Search;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 24);
            this.btnSearch.Text = "Search";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::KongN.Properties.Resources.check;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 24);
            this.btnSave.Text = "toolStripButton1";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = global::KongN.Properties.Resources.Annulla;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(24, 24);
            this.btnUndo.ToolTipText = "Annulla";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::KongN.Properties.Resources.Refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEsclusione
            // 
            this.btnEsclusione.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEsclusione.Image = global::KongN.Properties.Resources.file;
            this.btnEsclusione.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEsclusione.Name = "btnEsclusione";
            this.btnEsclusione.Size = new System.Drawing.Size(24, 24);
            this.btnEsclusione.Text = "toolStripButton1";
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = global::KongN.Properties.Resources.Print1;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(24, 24);
            this.btnPrint.Text = "Stampa";
            this.btnPrint.ToolTipText = "Stampa";
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(24, 24);
            this.btnDelete.Text = "Elimina";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = global::KongN.Properties.Resources.Exit__2_;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.Text = "toolStripButton1";
            this.btnClose.ToolTipText = "Chiudi la Maschera";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(153, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(60, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtIdScheda
            // 
            this.txtIdScheda.Location = new System.Drawing.Point(153, 87);
            this.txtIdScheda.Name = "txtIdScheda";
            this.txtIdScheda.ReadOnly = true;
            this.txtIdScheda.Size = new System.Drawing.Size(60, 20);
            this.txtIdScheda.TabIndex = 2;
            // 
            // txtNumeroFattura
            // 
            this.txtNumeroFattura.Location = new System.Drawing.Point(153, 117);
            this.txtNumeroFattura.Name = "txtNumeroFattura";
            this.txtNumeroFattura.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroFattura.TabIndex = 3;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriodo.Location = new System.Drawing.Point(472, 117);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(200, 20);
            this.txtPeriodo.TabIndex = 6;
            // 
            // dtpDataFattura
            // 
            this.dtpDataFattura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataFattura.DateTimeIcon = null;
            this.dtpDataFattura.Location = new System.Drawing.Point(472, 64);
            this.dtpDataFattura.Name = "dtpDataFattura";
            this.dtpDataFattura.Size = new System.Drawing.Size(130, 21);
            this.dtpDataFattura.TabIndex = 4;
            this.dtpDataFattura.ToolTipText = "";
            // 
            // numImporto
            // 
            this.numImporto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numImporto.DecimalPlaces = 2;
            this.numImporto.Location = new System.Drawing.Point(472, 92);
            this.numImporto.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numImporto.Name = "numImporto";
            this.numImporto.Size = new System.Drawing.Size(91, 20);
            this.numImporto.TabIndex = 5;
            this.numImporto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmSchedeSimFatture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(696, 588);
            this.Controls.Add(this.numImporto);
            this.Controls.Add(this.dtpDataFattura);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(iDSchedaLabel);
            this.Controls.Add(this.txtIdScheda);
            this.Controls.Add(numeroFatturaLabel);
            this.Controls.Add(this.txtNumeroFattura);
            this.Controls.Add(dataFatturaLabel);
            this.Controls.Add(importoLabel);
            this.Controls.Add(periodoLabel);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(712, 627);
            this.Name = "FrmSchedeSimFatture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schede Sim Fatture";
            this.Load += new System.EventHandler(this.FrmSchedeSimFatture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFattureSIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImporto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingNavigator nav;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPreviews;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnEsclusione;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdScheda;
        private System.Windows.Forms.TextBox txtNumeroFattura;
        private System.Windows.Forms.TextBox txtPeriodo;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpDataFattura;
        private System.Windows.Forms.BindingSource bsFattureSIM;
        private System.Windows.Forms.NumericUpDown numImporto;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFatturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFatturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoDataGridViewTextBoxColumn;
    }
}