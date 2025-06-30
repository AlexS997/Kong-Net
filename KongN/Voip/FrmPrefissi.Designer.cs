namespace KongN.Voip
{
    partial class FrmPrefissi
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
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label iDNazioneLabel;
            System.Windows.Forms.Label statoLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label prefissoLabel;
            System.Windows.Forms.Label scattoLabel;
            System.Windows.Forms.Label iDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrefissi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsPrefissi = new System.Windows.Forms.BindingSource(this.components);
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.statoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefissoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scattoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipoDescrizione = new System.Windows.Forms.Label();
            this.txtStato = new System.Windows.Forms.TextBox();
            this.numCosto = new System.Windows.Forms.NumericUpDown();
            this.txtPrefisso = new System.Windows.Forms.TextBox();
            this.numScatto = new System.Windows.Forms.NumericUpDown();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdNazione = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            tipoLabel = new System.Windows.Forms.Label();
            iDNazioneLabel = new System.Windows.Forms.Label();
            statoLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            prefissoLabel = new System.Windows.Forms.Label();
            scattoLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrefissi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScatto)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            tipoLabel.Location = new System.Drawing.Point(18, 116);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(39, 18);
            tipoLabel.TabIndex = 15;
            tipoLabel.Text = "Tipo:";
            // 
            // iDNazioneLabel
            // 
            iDNazioneLabel.AutoSize = true;
            iDNazioneLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDNazioneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iDNazioneLabel.Location = new System.Drawing.Point(18, 149);
            iDNazioneLabel.Name = "iDNazioneLabel";
            iDNazioneLabel.Size = new System.Drawing.Size(78, 18);
            iDNazioneLabel.TabIndex = 14;
            iDNazioneLabel.Text = "Id Nazione:";
            // 
            // statoLabel
            // 
            statoLabel.AutoSize = true;
            statoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            statoLabel.Location = new System.Drawing.Point(18, 87);
            statoLabel.Name = "statoLabel";
            statoLabel.Size = new System.Drawing.Size(44, 18);
            statoLabel.TabIndex = 9;
            statoLabel.Text = "Stato:";
            // 
            // costoLabel
            // 
            costoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            costoLabel.AutoSize = true;
            costoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            costoLabel.Location = new System.Drawing.Point(500, 69);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(47, 18);
            costoLabel.TabIndex = 10;
            costoLabel.Text = "Costo:";
            // 
            // prefissoLabel
            // 
            prefissoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            prefissoLabel.AutoSize = true;
            prefissoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prefissoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            prefissoLabel.Location = new System.Drawing.Point(500, 98);
            prefissoLabel.Name = "prefissoLabel";
            prefissoLabel.Size = new System.Drawing.Size(61, 18);
            prefissoLabel.TabIndex = 11;
            prefissoLabel.Text = "Prefisso:";
            // 
            // scattoLabel
            // 
            scattoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            scattoLabel.AutoSize = true;
            scattoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scattoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            scattoLabel.Location = new System.Drawing.Point(500, 137);
            scattoLabel.Name = "scattoLabel";
            scattoLabel.Size = new System.Drawing.Size(50, 18);
            scattoLabel.TabIndex = 12;
            scattoLabel.Text = "Scatto:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iDLabel.Location = new System.Drawing.Point(18, 59);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(24, 18);
            iDLabel.TabIndex = 13;
            iDLabel.Text = "Id:";
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
            this.nav.BindingSource = this.bsPrefissi;
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
            this.nav.Size = new System.Drawing.Size(743, 27);
            this.nav.TabIndex = 0;
            // 
            // bsPrefissi
            // 
            this.bsPrefissi.DataSource = typeof(KongN.ClassiTabelle.VoIPprefissi);
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
            this.statoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.prefissoDataGridViewTextBoxColumn,
            this.scattoDataGridViewTextBoxColumn,
            this.iDNazioneDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsPrefissi;
            this.dgv.Location = new System.Drawing.Point(0, 204);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(743, 248);
            this.dgv.TabIndex = 17;
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // statoDataGridViewTextBoxColumn
            // 
            this.statoDataGridViewTextBoxColumn.DataPropertyName = "stato";
            this.statoDataGridViewTextBoxColumn.HeaderText = "stato";
            this.statoDataGridViewTextBoxColumn.Name = "statoDataGridViewTextBoxColumn";
            this.statoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prefissoDataGridViewTextBoxColumn
            // 
            this.prefissoDataGridViewTextBoxColumn.DataPropertyName = "prefisso";
            this.prefissoDataGridViewTextBoxColumn.HeaderText = "prefisso";
            this.prefissoDataGridViewTextBoxColumn.Name = "prefissoDataGridViewTextBoxColumn";
            this.prefissoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scattoDataGridViewTextBoxColumn
            // 
            this.scattoDataGridViewTextBoxColumn.DataPropertyName = "scatto";
            this.scattoDataGridViewTextBoxColumn.HeaderText = "scatto";
            this.scattoDataGridViewTextBoxColumn.Name = "scattoDataGridViewTextBoxColumn";
            this.scattoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDNazioneDataGridViewTextBoxColumn
            // 
            this.iDNazioneDataGridViewTextBoxColumn.DataPropertyName = "iDNazione";
            this.iDNazioneDataGridViewTextBoxColumn.HeaderText = "iDNazione";
            this.iDNazioneDataGridViewTextBoxColumn.Name = "iDNazioneDataGridViewTextBoxColumn";
            this.iDNazioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(141, 116);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(65, 20);
            this.txtTipo.TabIndex = 3;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // lblTipoDescrizione
            // 
            this.lblTipoDescrizione.AutoSize = true;
            this.lblTipoDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDescrizione.ForeColor = System.Drawing.Color.Blue;
            this.lblTipoDescrizione.Location = new System.Drawing.Point(212, 117);
            this.lblTipoDescrizione.Name = "lblTipoDescrizione";
            this.lblTipoDescrizione.Size = new System.Drawing.Size(106, 16);
            this.lblTipoDescrizione.TabIndex = 16;
            this.lblTipoDescrizione.Text = "TipoDescrizione";
            // 
            // txtStato
            // 
            this.txtStato.Location = new System.Drawing.Point(141, 84);
            this.txtStato.Name = "txtStato";
            this.txtStato.Size = new System.Drawing.Size(199, 20);
            this.txtStato.TabIndex = 2;
            // 
            // numCosto
            // 
            this.numCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCosto.DecimalPlaces = 4;
            this.numCosto.Location = new System.Drawing.Point(568, 68);
            this.numCosto.Name = "numCosto";
            this.numCosto.Size = new System.Drawing.Size(120, 20);
            this.numCosto.TabIndex = 6;
            this.numCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrefisso
            // 
            this.txtPrefisso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrefisso.Location = new System.Drawing.Point(568, 98);
            this.txtPrefisso.Name = "txtPrefisso";
            this.txtPrefisso.Size = new System.Drawing.Size(120, 20);
            this.txtPrefisso.TabIndex = 7;
            // 
            // numScatto
            // 
            this.numScatto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numScatto.DecimalPlaces = 4;
            this.numScatto.Location = new System.Drawing.Point(568, 136);
            this.numScatto.Name = "numScatto";
            this.numScatto.Size = new System.Drawing.Size(120, 20);
            this.numScatto.TabIndex = 8;
            this.numScatto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(141, 52);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtIdNazione
            // 
            this.txtIdNazione.Location = new System.Drawing.Point(141, 149);
            this.txtIdNazione.Name = "txtIdNazione";
            this.txtIdNazione.Size = new System.Drawing.Size(120, 20);
            this.txtIdNazione.TabIndex = 4;
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCliente.Location = new System.Drawing.Point(271, 148);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(42, 23);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "...";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // FrmPrefissi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(743, 452);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.txtIdNazione);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipoDescrizione);
            this.Controls.Add(iDNazioneLabel);
            this.Controls.Add(statoLabel);
            this.Controls.Add(this.txtStato);
            this.Controls.Add(costoLabel);
            this.Controls.Add(this.numCosto);
            this.Controls.Add(prefissoLabel);
            this.Controls.Add(this.txtPrefisso);
            this.Controls.Add(scattoLabel);
            this.Controls.Add(this.numScatto);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(759, 491);
            this.Name = "FrmPrefissi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prefissi Telefonici";
            this.Load += new System.EventHandler(this.FrmPrefissi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrefissi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScatto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource bsPrefissi;
        private System.Windows.Forms.DataGridViewTextBoxColumn statoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefissoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scattoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipoDescrizione;
        private System.Windows.Forms.TextBox txtStato;
        private System.Windows.Forms.NumericUpDown numCosto;
        private System.Windows.Forms.TextBox txtPrefisso;
        private System.Windows.Forms.NumericUpDown numScatto;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdNazione;
        private System.Windows.Forms.Button btnCliente;
    }
}