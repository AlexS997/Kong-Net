namespace KongN.StrutturaRete
{
    partial class FrmPonti
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
            System.Windows.Forms.Label iDPontiLabel;
            System.Windows.Forms.Label ponteLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label idGatewayLabel;
            System.Windows.Forms.Label idPontePadreLabel;
            System.Windows.Forms.Label dipendenzaLabel;
            System.Windows.Forms.Label latitudineLabel;
            System.Windows.Forms.Label longitudineLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPonti));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.iDPontiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGatewayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPontePadreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dipendenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPonti = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.numLong = new System.Windows.Forms.NumericUpDown();
            this.numLat = new System.Windows.Forms.NumericUpDown();
            this.chkTutti = new System.Windows.Forms.CheckBox();
            this.txtIdPontePadre = new System.Windows.Forms.TextBox();
            this.btnVediMappa = new System.Windows.Forms.Button();
            this.lblDescrizionePontePadre = new System.Windows.Forms.Label();
            this.btnPulisciPadre = new System.Windows.Forms.Button();
            this.btnPadre = new System.Windows.Forms.Button();
            this.txtiDPonti = new System.Windows.Forms.TextBox();
            this.txtPonte = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboIdGateway = new System.Windows.Forms.ComboBox();
            this.txtDipendenza = new System.Windows.Forms.TextBox();
            iDPontiLabel = new System.Windows.Forms.Label();
            ponteLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            idGatewayLabel = new System.Windows.Forms.Label();
            idPontePadreLabel = new System.Windows.Forms.Label();
            dipendenzaLabel = new System.Windows.Forms.Label();
            latitudineLabel = new System.Windows.Forms.Label();
            longitudineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPonti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLat)).BeginInit();
            this.SuspendLayout();
            // 
            // iDPontiLabel
            // 
            iDPontiLabel.AutoSize = true;
            iDPontiLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDPontiLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iDPontiLabel.Location = new System.Drawing.Point(21, 46);
            iDPontiLabel.Name = "iDPontiLabel";
            iDPontiLabel.Size = new System.Drawing.Size(65, 18);
            iDPontiLabel.TabIndex = 1;
            iDPontiLabel.Text = "iD Ponte:";
            // 
            // ponteLabel
            // 
            ponteLabel.AutoSize = true;
            ponteLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ponteLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            ponteLabel.Location = new System.Drawing.Point(21, 79);
            ponteLabel.Name = "ponteLabel";
            ponteLabel.Size = new System.Drawing.Size(49, 18);
            ponteLabel.TabIndex = 3;
            ponteLabel.Text = "Ponte:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noteLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            noteLabel.Location = new System.Drawing.Point(555, 49);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(43, 18);
            noteLabel.TabIndex = 12;
            noteLabel.Text = "Note:";
            // 
            // idGatewayLabel
            // 
            idGatewayLabel.AutoSize = true;
            idGatewayLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idGatewayLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            idGatewayLabel.Location = new System.Drawing.Point(21, 114);
            idGatewayLabel.Name = "idGatewayLabel";
            idGatewayLabel.Size = new System.Drawing.Size(82, 18);
            idGatewayLabel.TabIndex = 14;
            idGatewayLabel.Text = "id Gateway:";
            // 
            // idPontePadreLabel
            // 
            idPontePadreLabel.AutoSize = true;
            idPontePadreLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPontePadreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            idPontePadreLabel.Location = new System.Drawing.Point(21, 150);
            idPontePadreLabel.Name = "idPontePadreLabel";
            idPontePadreLabel.Size = new System.Drawing.Size(103, 18);
            idPontePadreLabel.TabIndex = 15;
            idPontePadreLabel.Text = "id Ponte Padre:";
            // 
            // dipendenzaLabel
            // 
            dipendenzaLabel.AutoSize = true;
            dipendenzaLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dipendenzaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dipendenzaLabel.Location = new System.Drawing.Point(21, 213);
            dipendenzaLabel.Name = "dipendenzaLabel";
            dipendenzaLabel.Size = new System.Drawing.Size(86, 18);
            dipendenzaLabel.TabIndex = 16;
            dipendenzaLabel.Text = "Dipendenza:";
            // 
            // latitudineLabel
            // 
            latitudineLabel.AutoSize = true;
            latitudineLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            latitudineLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            latitudineLabel.Location = new System.Drawing.Point(21, 246);
            latitudineLabel.Name = "latitudineLabel";
            latitudineLabel.Size = new System.Drawing.Size(75, 18);
            latitudineLabel.TabIndex = 17;
            latitudineLabel.Text = "Latitudine:";
            // 
            // longitudineLabel
            // 
            longitudineLabel.AutoSize = true;
            longitudineLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            longitudineLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            longitudineLabel.Location = new System.Drawing.Point(21, 279);
            longitudineLabel.Name = "longitudineLabel";
            longitudineLabel.Size = new System.Drawing.Size(86, 18);
            longitudineLabel.TabIndex = 18;
            longitudineLabel.Text = "Longitudine:";
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
            this.iDPontiDataGridViewTextBoxColumn,
            this.ponteDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.idGatewayDataGridViewTextBoxColumn,
            this.idPontePadreDataGridViewTextBoxColumn,
            this.dipendenzaDataGridViewTextBoxColumn,
            this.latitudineDataGridViewTextBoxColumn,
            this.longitudineDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsPonti;
            this.dgv.Location = new System.Drawing.Point(0, 320);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(876, 283);
            this.dgv.TabIndex = 22;
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // iDPontiDataGridViewTextBoxColumn
            // 
            this.iDPontiDataGridViewTextBoxColumn.DataPropertyName = "iDPonti";
            this.iDPontiDataGridViewTextBoxColumn.HeaderText = "iDPonti";
            this.iDPontiDataGridViewTextBoxColumn.Name = "iDPontiDataGridViewTextBoxColumn";
            this.iDPontiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ponteDataGridViewTextBoxColumn
            // 
            this.ponteDataGridViewTextBoxColumn.DataPropertyName = "Ponte";
            this.ponteDataGridViewTextBoxColumn.HeaderText = "Ponte";
            this.ponteDataGridViewTextBoxColumn.Name = "ponteDataGridViewTextBoxColumn";
            this.ponteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idGatewayDataGridViewTextBoxColumn
            // 
            this.idGatewayDataGridViewTextBoxColumn.DataPropertyName = "idGateway";
            this.idGatewayDataGridViewTextBoxColumn.HeaderText = "idGateway";
            this.idGatewayDataGridViewTextBoxColumn.Name = "idGatewayDataGridViewTextBoxColumn";
            this.idGatewayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPontePadreDataGridViewTextBoxColumn
            // 
            this.idPontePadreDataGridViewTextBoxColumn.DataPropertyName = "idPontePadre";
            this.idPontePadreDataGridViewTextBoxColumn.HeaderText = "idPontePadre";
            this.idPontePadreDataGridViewTextBoxColumn.Name = "idPontePadreDataGridViewTextBoxColumn";
            this.idPontePadreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dipendenzaDataGridViewTextBoxColumn
            // 
            this.dipendenzaDataGridViewTextBoxColumn.DataPropertyName = "Dipendenza";
            this.dipendenzaDataGridViewTextBoxColumn.HeaderText = "Dipendenza";
            this.dipendenzaDataGridViewTextBoxColumn.Name = "dipendenzaDataGridViewTextBoxColumn";
            this.dipendenzaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bsPonti
            // 
            this.bsPonti.DataSource = typeof(KongN.ClassiTabelle._3_ponti);
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
            this.nav.BindingSource = this.bsPonti;
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
            this.nav.Size = new System.Drawing.Size(876, 27);
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
            // numLong
            // 
            this.numLong.DecimalPlaces = 6;
            this.numLong.Location = new System.Drawing.Point(141, 279);
            this.numLong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numLong.Name = "numLong";
            this.numLong.Size = new System.Drawing.Size(100, 20);
            this.numLong.TabIndex = 11;
            this.numLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numLat
            // 
            this.numLat.DecimalPlaces = 6;
            this.numLat.Location = new System.Drawing.Point(141, 244);
            this.numLat.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numLat.Name = "numLat";
            this.numLat.Size = new System.Drawing.Size(100, 20);
            this.numLat.TabIndex = 10;
            this.numLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkTutti
            // 
            this.chkTutti.AutoSize = true;
            this.chkTutti.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTutti.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkTutti.Location = new System.Drawing.Point(405, 277);
            this.chkTutti.Name = "chkTutti";
            this.chkTutti.Size = new System.Drawing.Size(97, 22);
            this.chkTutti.TabIndex = 21;
            this.chkTutti.Text = "Tutti i Punti";
            this.chkTutti.UseVisualStyleBackColor = true;
            // 
            // txtIdPontePadre
            // 
            this.txtIdPontePadre.Location = new System.Drawing.Point(141, 147);
            this.txtIdPontePadre.Name = "txtIdPontePadre";
            this.txtIdPontePadre.ReadOnly = true;
            this.txtIdPontePadre.Size = new System.Drawing.Size(100, 20);
            this.txtIdPontePadre.TabIndex = 6;
            // 
            // btnVediMappa
            // 
            this.btnVediMappa.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVediMappa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVediMappa.Location = new System.Drawing.Point(291, 275);
            this.btnVediMappa.Name = "btnVediMappa";
            this.btnVediMappa.Size = new System.Drawing.Size(94, 26);
            this.btnVediMappa.TabIndex = 20;
            this.btnVediMappa.Text = "Vedi Mappa";
            this.btnVediMappa.UseVisualStyleBackColor = true;
            this.btnVediMappa.Click += new System.EventHandler(this.btnVediMappa_Click);
            // 
            // lblDescrizionePontePadre
            // 
            this.lblDescrizionePontePadre.AutoSize = true;
            this.lblDescrizionePontePadre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrizionePontePadre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDescrizionePontePadre.Location = new System.Drawing.Point(310, 149);
            this.lblDescrizionePontePadre.Name = "lblDescrizionePontePadre";
            this.lblDescrizionePontePadre.Size = new System.Drawing.Size(133, 18);
            this.lblDescrizionePontePadre.TabIndex = 19;
            this.lblDescrizionePontePadre.Text = "Nessun Ponte Padre";
            // 
            // btnPulisciPadre
            // 
            this.btnPulisciPadre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPulisciPadre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPulisciPadre.Location = new System.Drawing.Point(140, 172);
            this.btnPulisciPadre.Name = "btnPulisciPadre";
            this.btnPulisciPadre.Size = new System.Drawing.Size(101, 26);
            this.btnPulisciPadre.TabIndex = 8;
            this.btnPulisciPadre.Text = "Pulisci Ponte";
            this.btnPulisciPadre.UseVisualStyleBackColor = true;
            this.btnPulisciPadre.Click += new System.EventHandler(this.btnPulisciPadre_Click);
            // 
            // btnPadre
            // 
            this.btnPadre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPadre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPadre.Location = new System.Drawing.Point(256, 146);
            this.btnPadre.Name = "btnPadre";
            this.btnPadre.Size = new System.Drawing.Size(48, 23);
            this.btnPadre.TabIndex = 7;
            this.btnPadre.Text = "...";
            this.btnPadre.UseVisualStyleBackColor = true;
            this.btnPadre.Click += new System.EventHandler(this.btnPadre_Click);
            // 
            // txtiDPonti
            // 
            this.txtiDPonti.Location = new System.Drawing.Point(140, 43);
            this.txtiDPonti.Name = "txtiDPonti";
            this.txtiDPonti.Size = new System.Drawing.Size(121, 20);
            this.txtiDPonti.TabIndex = 2;
            // 
            // txtPonte
            // 
            this.txtPonte.Location = new System.Drawing.Point(140, 76);
            this.txtPonte.Name = "txtPonte";
            this.txtPonte.Size = new System.Drawing.Size(359, 20);
            this.txtPonte.TabIndex = 4;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(606, 46);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(248, 208);
            this.txtNote.TabIndex = 13;
            // 
            // cboIdGateway
            // 
            this.cboIdGateway.DisplayMember = "GATEWAY";
            this.cboIdGateway.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdGateway.FormattingEnabled = true;
            this.cboIdGateway.Location = new System.Drawing.Point(140, 111);
            this.cboIdGateway.Name = "cboIdGateway";
            this.cboIdGateway.Size = new System.Drawing.Size(121, 21);
            this.cboIdGateway.TabIndex = 5;
            this.cboIdGateway.ValueMember = "iDGateway";
            // 
            // txtDipendenza
            // 
            this.txtDipendenza.Location = new System.Drawing.Point(140, 210);
            this.txtDipendenza.Name = "txtDipendenza";
            this.txtDipendenza.Size = new System.Drawing.Size(359, 20);
            this.txtDipendenza.TabIndex = 9;
            // 
            // FrmPonti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(876, 603);
            this.Controls.Add(this.numLong);
            this.Controls.Add(this.numLat);
            this.Controls.Add(this.chkTutti);
            this.Controls.Add(this.txtIdPontePadre);
            this.Controls.Add(this.btnVediMappa);
            this.Controls.Add(this.lblDescrizionePontePadre);
            this.Controls.Add(this.btnPulisciPadre);
            this.Controls.Add(this.btnPadre);
            this.Controls.Add(iDPontiLabel);
            this.Controls.Add(this.txtiDPonti);
            this.Controls.Add(ponteLabel);
            this.Controls.Add(this.txtPonte);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(idGatewayLabel);
            this.Controls.Add(this.cboIdGateway);
            this.Controls.Add(idPontePadreLabel);
            this.Controls.Add(dipendenzaLabel);
            this.Controls.Add(this.txtDipendenza);
            this.Controls.Add(latitudineLabel);
            this.Controls.Add(longitudineLabel);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(892, 642);
            this.Name = "FrmPonti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponti";
            this.Load += new System.EventHandler(this.FrmPonti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPonti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLat)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.NumericUpDown numLong;
        private System.Windows.Forms.NumericUpDown numLat;
        private System.Windows.Forms.CheckBox chkTutti;
        private System.Windows.Forms.TextBox txtIdPontePadre;
        private System.Windows.Forms.Button btnVediMappa;
        private System.Windows.Forms.Label lblDescrizionePontePadre;
        private System.Windows.Forms.Button btnPulisciPadre;
        private System.Windows.Forms.Button btnPadre;
        private System.Windows.Forms.TextBox txtiDPonti;
        private System.Windows.Forms.TextBox txtPonte;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboIdGateway;
        private System.Windows.Forms.TextBox txtDipendenza;
        private System.Windows.Forms.BindingSource bsPonti;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPontiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGatewayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPontePadreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dipendenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudineDataGridViewTextBoxColumn;
    }
}