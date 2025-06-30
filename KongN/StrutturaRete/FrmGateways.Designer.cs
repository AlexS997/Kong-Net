namespace KongN.StrutturaRete
{
    partial class FrmGateways
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
            System.Windows.Forms.Label iDGatewayLabel;
            System.Windows.Forms.Label gATEWAYLabel;
            System.Windows.Forms.Label descrizioneLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label idFonteLabel;
            System.Windows.Forms.Label latitudineLabel;
            System.Windows.Forms.Label longitudineLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGateways));
            this.nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsGateways = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.iDGatewayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gATEWAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFonteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLong = new System.Windows.Forms.NumericUpDown();
            this.numLat = new System.Windows.Forms.NumericUpDown();
            this.chkTutti = new System.Windows.Forms.CheckBox();
            this.btnVediMappa = new System.Windows.Forms.Button();
            this.cboIdFonte = new System.Windows.Forms.ComboBox();
            this.txtIDGateway = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            iDGatewayLabel = new System.Windows.Forms.Label();
            gATEWAYLabel = new System.Windows.Forms.Label();
            descrizioneLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            idFonteLabel = new System.Windows.Forms.Label();
            latitudineLabel = new System.Windows.Forms.Label();
            longitudineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGateways)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLat)).BeginInit();
            this.SuspendLayout();
            // 
            // iDGatewayLabel
            // 
            iDGatewayLabel.AutoSize = true;
            iDGatewayLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDGatewayLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iDGatewayLabel.Location = new System.Drawing.Point(22, 52);
            iDGatewayLabel.Name = "iDGatewayLabel";
            iDGatewayLabel.Size = new System.Drawing.Size(83, 18);
            iDGatewayLabel.TabIndex = 1;
            iDGatewayLabel.Text = "iD Gateway:";
            // 
            // gATEWAYLabel
            // 
            gATEWAYLabel.AutoSize = true;
            gATEWAYLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gATEWAYLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            gATEWAYLabel.Location = new System.Drawing.Point(22, 82);
            gATEWAYLabel.Name = "gATEWAYLabel";
            gATEWAYLabel.Size = new System.Drawing.Size(72, 18);
            gATEWAYLabel.TabIndex = 3;
            gATEWAYLabel.Text = "GATEWAY:";
            // 
            // descrizioneLabel
            // 
            descrizioneLabel.AutoSize = true;
            descrizioneLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descrizioneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            descrizioneLabel.Location = new System.Drawing.Point(22, 115);
            descrizioneLabel.Name = "descrizioneLabel";
            descrizioneLabel.Size = new System.Drawing.Size(84, 18);
            descrizioneLabel.TabIndex = 5;
            descrizioneLabel.Text = "Descrizione:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noteLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            noteLabel.Location = new System.Drawing.Point(437, 58);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(43, 18);
            noteLabel.TabIndex = 13;
            noteLabel.Text = "Note:";
            // 
            // idFonteLabel
            // 
            idFonteLabel.AutoSize = true;
            idFonteLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idFonteLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            idFonteLabel.Location = new System.Drawing.Point(22, 148);
            idFonteLabel.Name = "idFonteLabel";
            idFonteLabel.Size = new System.Drawing.Size(63, 18);
            idFonteLabel.TabIndex = 14;
            idFonteLabel.Text = "id Fonte:";
            // 
            // latitudineLabel
            // 
            latitudineLabel.AutoSize = true;
            latitudineLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            latitudineLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            latitudineLabel.Location = new System.Drawing.Point(22, 179);
            latitudineLabel.Name = "latitudineLabel";
            latitudineLabel.Size = new System.Drawing.Size(75, 18);
            latitudineLabel.TabIndex = 15;
            latitudineLabel.Text = "Latitudine:";
            // 
            // longitudineLabel
            // 
            longitudineLabel.AutoSize = true;
            longitudineLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            longitudineLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            longitudineLabel.Location = new System.Drawing.Point(22, 216);
            longitudineLabel.Name = "longitudineLabel";
            longitudineLabel.Size = new System.Drawing.Size(86, 18);
            longitudineLabel.TabIndex = 16;
            longitudineLabel.Text = "Longitudine:";
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
            this.nav.BindingSource = this.bsGateways;
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
            this.btnPrint,
            this.btnClose});
            this.nav.Location = new System.Drawing.Point(0, 0);
            this.nav.MoveFirstItem = this.btnFirst;
            this.nav.MoveLastItem = this.btnLast;
            this.nav.MoveNextItem = this.btnNext;
            this.nav.MovePreviousItem = this.btnPreviews;
            this.nav.Name = "nav";
            this.nav.PositionItem = this.bindingNavigatorPositionItem;
            this.nav.Size = new System.Drawing.Size(845, 27);
            this.nav.TabIndex = 0;
            // 
            // bsGateways
            // 
            this.bsGateways.DataSource = typeof(KongN.ClassiTabelle._2_gateways);
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
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDGatewayDataGridViewTextBoxColumn,
            this.gATEWAYDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.idFonteDataGridViewTextBoxColumn,
            this.latitudineDataGridViewTextBoxColumn,
            this.longitudineDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsGateways;
            this.dgv.Location = new System.Drawing.Point(0, 348);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(845, 270);
            this.dgv.TabIndex = 17;
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // iDGatewayDataGridViewTextBoxColumn
            // 
            this.iDGatewayDataGridViewTextBoxColumn.DataPropertyName = "iDGateway";
            this.iDGatewayDataGridViewTextBoxColumn.HeaderText = "iDGateway";
            this.iDGatewayDataGridViewTextBoxColumn.Name = "iDGatewayDataGridViewTextBoxColumn";
            this.iDGatewayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gATEWAYDataGridViewTextBoxColumn
            // 
            this.gATEWAYDataGridViewTextBoxColumn.DataPropertyName = "GATEWAY";
            this.gATEWAYDataGridViewTextBoxColumn.HeaderText = "GATEWAY";
            this.gATEWAYDataGridViewTextBoxColumn.Name = "gATEWAYDataGridViewTextBoxColumn";
            this.gATEWAYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            this.descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idFonteDataGridViewTextBoxColumn
            // 
            this.idFonteDataGridViewTextBoxColumn.DataPropertyName = "idFonte";
            this.idFonteDataGridViewTextBoxColumn.HeaderText = "idFonte";
            this.idFonteDataGridViewTextBoxColumn.Name = "idFonteDataGridViewTextBoxColumn";
            this.idFonteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // latitudineDataGridViewTextBoxColumn
            // 
            this.latitudineDataGridViewTextBoxColumn.DataPropertyName = "Latitudine";
            this.latitudineDataGridViewTextBoxColumn.HeaderText = "Latitudine";
            this.latitudineDataGridViewTextBoxColumn.Name = "latitudineDataGridViewTextBoxColumn";
            this.latitudineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // longitudineDataGridViewTextBoxColumn
            // 
            this.longitudineDataGridViewTextBoxColumn.DataPropertyName = "Longitudine";
            this.longitudineDataGridViewTextBoxColumn.HeaderText = "Longitudine";
            this.longitudineDataGridViewTextBoxColumn.Name = "longitudineDataGridViewTextBoxColumn";
            this.longitudineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numLong
            // 
            this.numLong.DecimalPlaces = 6;
            this.numLong.Location = new System.Drawing.Point(119, 216);
            this.numLong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numLong.Name = "numLong";
            this.numLong.Size = new System.Drawing.Size(91, 20);
            this.numLong.TabIndex = 9;
            this.numLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numLat
            // 
            this.numLat.DecimalPlaces = 6;
            this.numLat.Location = new System.Drawing.Point(120, 181);
            this.numLat.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numLat.Name = "numLat";
            this.numLat.Size = new System.Drawing.Size(90, 20);
            this.numLat.TabIndex = 8;
            this.numLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkTutti
            // 
            this.chkTutti.AutoSize = true;
            this.chkTutti.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTutti.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkTutti.Location = new System.Drawing.Point(115, 271);
            this.chkTutti.Name = "chkTutti";
            this.chkTutti.Size = new System.Drawing.Size(97, 22);
            this.chkTutti.TabIndex = 12;
            this.chkTutti.Text = "Tutti i Punti";
            this.chkTutti.UseVisualStyleBackColor = true;
            // 
            // btnVediMappa
            // 
            this.btnVediMappa.Location = new System.Drawing.Point(23, 271);
            this.btnVediMappa.Name = "btnVediMappa";
            this.btnVediMappa.Size = new System.Drawing.Size(75, 23);
            this.btnVediMappa.TabIndex = 11;
            this.btnVediMappa.Text = "Vedi Mappa";
            this.btnVediMappa.UseVisualStyleBackColor = true;
            this.btnVediMappa.Click += new System.EventHandler(this.btnVediMappa_Click);
            // 
            // cboIdFonte
            // 
            this.cboIdFonte.DisplayMember = "FONTE";
            this.cboIdFonte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdFonte.FormattingEnabled = true;
            this.cboIdFonte.Location = new System.Drawing.Point(119, 146);
            this.cboIdFonte.Name = "cboIdFonte";
            this.cboIdFonte.Size = new System.Drawing.Size(121, 21);
            this.cboIdFonte.TabIndex = 7;
            this.cboIdFonte.ValueMember = "iDFonte";
            // 
            // txtIDGateway
            // 
            this.txtIDGateway.Location = new System.Drawing.Point(119, 50);
            this.txtIDGateway.Name = "txtIDGateway";
            this.txtIDGateway.ReadOnly = true;
            this.txtIDGateway.Size = new System.Drawing.Size(100, 20);
            this.txtIDGateway.TabIndex = 2;
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(119, 81);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(298, 20);
            this.txtGateway.TabIndex = 4;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(119, 114);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(298, 20);
            this.txtDescrizione.TabIndex = 6;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(490, 56);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(325, 268);
            this.txtNote.TabIndex = 10;
            // 
            // FrmGateways
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(845, 618);
            this.Controls.Add(this.numLong);
            this.Controls.Add(this.numLat);
            this.Controls.Add(this.chkTutti);
            this.Controls.Add(this.btnVediMappa);
            this.Controls.Add(this.cboIdFonte);
            this.Controls.Add(iDGatewayLabel);
            this.Controls.Add(this.txtIDGateway);
            this.Controls.Add(gATEWAYLabel);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(descrizioneLabel);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(idFonteLabel);
            this.Controls.Add(latitudineLabel);
            this.Controls.Add(longitudineLabel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(861, 657);
            this.Name = "FrmGateways";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gateways";
            this.Load += new System.EventHandler(this.FrmGateways_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGateways)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLat)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource bsGateways;
        private System.Windows.Forms.NumericUpDown numLong;
        private System.Windows.Forms.NumericUpDown numLat;
        private System.Windows.Forms.CheckBox chkTutti;
        private System.Windows.Forms.Button btnVediMappa;
        private System.Windows.Forms.ComboBox cboIdFonte;
        private System.Windows.Forms.TextBox txtIDGateway;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGatewayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gATEWAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFonteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudineDataGridViewTextBoxColumn;
    }
}