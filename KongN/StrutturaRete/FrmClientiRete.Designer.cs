namespace KongN.StrutturaRete
{
    partial class FrmClientiRete
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
            System.Windows.Forms.Label actualProfileLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label codCliLabel;
            System.Windows.Forms.Label denomLabel;
            System.Windows.Forms.Label lacationLabel;
            System.Windows.Forms.Label latitudineLabel;
            System.Windows.Forms.Label longitudineLabel;
            System.Windows.Forms.Label noteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientiRete));
            this.nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsClienti = new System.Windows.Forms.BindingSource(this.components);
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDpannelliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualProfileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLong = new System.Windows.Forms.NumericUpDown();
            this.numLat = new System.Windows.Forms.NumericUpDown();
            this.chkTutti = new System.Windows.Forms.CheckBox();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnVediMappa = new System.Windows.Forms.Button();
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.txtActualProfile = new System.Windows.Forms.TextBox();
            this.txtiD = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.txtDenom = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            actualProfileLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            codCliLabel = new System.Windows.Forms.Label();
            denomLabel = new System.Windows.Forms.Label();
            lacationLabel = new System.Windows.Forms.Label();
            latitudineLabel = new System.Windows.Forms.Label();
            longitudineLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLat)).BeginInit();
            this.SuspendLayout();
            // 
            // actualProfileLabel
            // 
            actualProfileLabel.AutoSize = true;
            actualProfileLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            actualProfileLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            actualProfileLabel.Location = new System.Drawing.Point(21, 189);
            actualProfileLabel.Name = "actualProfileLabel";
            actualProfileLabel.Size = new System.Drawing.Size(95, 18);
            actualProfileLabel.TabIndex = 23;
            actualProfileLabel.Text = "Actual Profile:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iDLabel.Location = new System.Drawing.Point(21, 41);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 18);
            iDLabel.TabIndex = 15;
            iDLabel.Text = "iD:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            usernameLabel.Location = new System.Drawing.Point(21, 67);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(76, 18);
            usernameLabel.TabIndex = 16;
            usernameLabel.Text = "Username:";
            // 
            // codCliLabel
            // 
            codCliLabel.AutoSize = true;
            codCliLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codCliLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            codCliLabel.Location = new System.Drawing.Point(21, 95);
            codCliLabel.Name = "codCliLabel";
            codCliLabel.Size = new System.Drawing.Size(55, 18);
            codCliLabel.TabIndex = 17;
            codCliLabel.Text = "Cod Cli:";
            // 
            // denomLabel
            // 
            denomLabel.AutoSize = true;
            denomLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            denomLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            denomLabel.Location = new System.Drawing.Point(21, 130);
            denomLabel.Name = "denomLabel";
            denomLabel.Size = new System.Drawing.Size(57, 18);
            denomLabel.TabIndex = 18;
            denomLabel.Text = "Denom:";
            // 
            // lacationLabel
            // 
            lacationLabel.AutoSize = true;
            lacationLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lacationLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            lacationLabel.Location = new System.Drawing.Point(21, 159);
            lacationLabel.Name = "lacationLabel";
            lacationLabel.Size = new System.Drawing.Size(64, 18);
            lacationLabel.TabIndex = 19;
            lacationLabel.Text = "Location:";
            // 
            // latitudineLabel
            // 
            latitudineLabel.AutoSize = true;
            latitudineLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            latitudineLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            latitudineLabel.Location = new System.Drawing.Point(21, 222);
            latitudineLabel.Name = "latitudineLabel";
            latitudineLabel.Size = new System.Drawing.Size(75, 18);
            latitudineLabel.TabIndex = 20;
            latitudineLabel.Text = "Latitudine:";
            // 
            // longitudineLabel
            // 
            longitudineLabel.AutoSize = true;
            longitudineLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            longitudineLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            longitudineLabel.Location = new System.Drawing.Point(21, 248);
            longitudineLabel.Name = "longitudineLabel";
            longitudineLabel.Size = new System.Drawing.Size(86, 18);
            longitudineLabel.TabIndex = 21;
            longitudineLabel.Text = "Longitudine:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noteLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            noteLabel.Location = new System.Drawing.Point(536, 44);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(43, 18);
            noteLabel.TabIndex = 22;
            noteLabel.Text = "Note:";
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
            this.nav.BindingSource = this.bsClienti;
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
            this.nav.Size = new System.Drawing.Size(855, 27);
            this.nav.TabIndex = 0;
            // 
            // bsClienti
            // 
            this.bsClienti.DataSource = typeof(KongN.ClassiTabelle._5_Clientirete);
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
            this.btnEsclusione.Click += new System.EventHandler(this.btnEsclusione_Click);
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
            this.iDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.codCliDataGridViewTextBoxColumn,
            this.denomDataGridViewTextBoxColumn,
            this.iDpannelliDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.actualProfileDataGridViewTextBoxColumn,
            this.latitudineDataGridViewTextBoxColumn,
            this.longitudineDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsClienti;
            this.dgv.Location = new System.Drawing.Point(0, 292);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(855, 288);
            this.dgv.TabIndex = 14;
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "iD";
            this.iDDataGridViewTextBoxColumn.HeaderText = "iD";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codCliDataGridViewTextBoxColumn
            // 
            this.codCliDataGridViewTextBoxColumn.DataPropertyName = "CodCli";
            this.codCliDataGridViewTextBoxColumn.HeaderText = "CodCli";
            this.codCliDataGridViewTextBoxColumn.Name = "codCliDataGridViewTextBoxColumn";
            this.codCliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denomDataGridViewTextBoxColumn
            // 
            this.denomDataGridViewTextBoxColumn.DataPropertyName = "Denom";
            this.denomDataGridViewTextBoxColumn.HeaderText = "Denom";
            this.denomDataGridViewTextBoxColumn.Name = "denomDataGridViewTextBoxColumn";
            this.denomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDpannelliDataGridViewTextBoxColumn
            // 
            this.iDpannelliDataGridViewTextBoxColumn.DataPropertyName = "iDpannelli";
            this.iDpannelliDataGridViewTextBoxColumn.HeaderText = "iDpannelli";
            this.iDpannelliDataGridViewTextBoxColumn.Name = "iDpannelliDataGridViewTextBoxColumn";
            this.iDpannelliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actualProfileDataGridViewTextBoxColumn
            // 
            this.actualProfileDataGridViewTextBoxColumn.DataPropertyName = "ActualProfile";
            this.actualProfileDataGridViewTextBoxColumn.HeaderText = "ActualProfile";
            this.actualProfileDataGridViewTextBoxColumn.Name = "actualProfileDataGridViewTextBoxColumn";
            this.actualProfileDataGridViewTextBoxColumn.ReadOnly = true;
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
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numLong
            // 
            this.numLong.DecimalPlaces = 6;
            this.numLong.Location = new System.Drawing.Point(135, 248);
            this.numLong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numLong.Name = "numLong";
            this.numLong.Size = new System.Drawing.Size(100, 20);
            this.numLong.TabIndex = 10;
            this.numLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numLat
            // 
            this.numLat.DecimalPlaces = 6;
            this.numLat.Location = new System.Drawing.Point(135, 220);
            this.numLat.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numLat.Name = "numLat";
            this.numLat.Size = new System.Drawing.Size(100, 20);
            this.numLat.TabIndex = 9;
            this.numLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkTutti
            // 
            this.chkTutti.AutoSize = true;
            this.chkTutti.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTutti.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkTutti.Location = new System.Drawing.Point(422, 248);
            this.chkTutti.Name = "chkTutti";
            this.chkTutti.Size = new System.Drawing.Size(97, 22);
            this.chkTutti.TabIndex = 13;
            this.chkTutti.Text = "Tutti i Punti";
            this.chkTutti.UseVisualStyleBackColor = true;
            // 
            // btnPulisci
            // 
            this.btnPulisci.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPulisci.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPulisci.Location = new System.Drawing.Point(299, 92);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(107, 26);
            this.btnPulisci.TabIndex = 5;
            this.btnPulisci.Text = "Pulisci Cliente";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCliente.Location = new System.Drawing.Point(251, 94);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(42, 23);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.Text = "...";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVediMappa
            // 
            this.btnVediMappa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVediMappa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVediMappa.Location = new System.Drawing.Point(306, 246);
            this.btnVediMappa.Name = "btnVediMappa";
            this.btnVediMappa.Size = new System.Drawing.Size(93, 26);
            this.btnVediMappa.TabIndex = 12;
            this.btnVediMappa.Text = "Vedi Mappa";
            this.btnVediMappa.UseVisualStyleBackColor = true;
            this.btnVediMappa.Click += new System.EventHandler(this.btnVediMappa_Click);
            // 
            // Bar
            // 
            this.Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bar.Location = new System.Drawing.Point(613, 257);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(191, 23);
            this.Bar.TabIndex = 24;
            // 
            // txtActualProfile
            // 
            this.txtActualProfile.Location = new System.Drawing.Point(135, 186);
            this.txtActualProfile.Name = "txtActualProfile";
            this.txtActualProfile.Size = new System.Drawing.Size(384, 20);
            this.txtActualProfile.TabIndex = 8;
            // 
            // txtiD
            // 
            this.txtiD.Location = new System.Drawing.Point(135, 38);
            this.txtiD.Name = "txtiD";
            this.txtiD.ReadOnly = true;
            this.txtiD.Size = new System.Drawing.Size(100, 20);
            this.txtiD.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(135, 64);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(384, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(135, 95);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.ReadOnly = true;
            this.txtCodCli.Size = new System.Drawing.Size(100, 20);
            this.txtCodCli.TabIndex = 3;
            // 
            // txtDenom
            // 
            this.txtDenom.Location = new System.Drawing.Point(135, 127);
            this.txtDenom.Name = "txtDenom";
            this.txtDenom.ReadOnly = true;
            this.txtDenom.Size = new System.Drawing.Size(384, 20);
            this.txtDenom.TabIndex = 6;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(587, 41);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(243, 203);
            this.txtNote.TabIndex = 11;
            // 
            // cboLoc
            // 
            this.cboLoc.DisplayMember = "GATEWAY";
            this.cboLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Location = new System.Drawing.Point(136, 156);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(383, 21);
            this.cboLoc.TabIndex = 7;
            this.cboLoc.ValueMember = "iDGateway";
            // 
            // FrmClientiRete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(855, 580);
            this.Controls.Add(this.cboLoc);
            this.Controls.Add(this.numLong);
            this.Controls.Add(this.numLat);
            this.Controls.Add(this.chkTutti);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnVediMappa);
            this.Controls.Add(this.Bar);
            this.Controls.Add(actualProfileLabel);
            this.Controls.Add(this.txtActualProfile);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtiD);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(codCliLabel);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(denomLabel);
            this.Controls.Add(this.txtDenom);
            this.Controls.Add(lacationLabel);
            this.Controls.Add(latitudineLabel);
            this.Controls.Add(longitudineLabel);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(871, 612);
            this.Name = "FrmClientiRete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienti della Rete";
            this.Load += new System.EventHandler(this.FrmClientiRete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClienti)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numLong;
        private System.Windows.Forms.NumericUpDown numLat;
        private System.Windows.Forms.CheckBox chkTutti;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVediMappa;
        private System.Windows.Forms.ProgressBar Bar;
        private System.Windows.Forms.TextBox txtActualProfile;
        private System.Windows.Forms.TextBox txtiD;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.TextBox txtDenom;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.BindingSource bsClienti;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpannelliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualProfileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboLoc;
        private System.Windows.Forms.ToolStripButton btnEsclusione;
    }
}