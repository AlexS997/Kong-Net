namespace KongN.StrutturaRete
{
    partial class FrmPannelli
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
            System.Windows.Forms.Label iDPannelliLabel;
            System.Windows.Forms.Label pANNELLOLabel;
            System.Windows.Forms.Label pONTELabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label idPontiLabel;
            System.Windows.Forms.Label aperturaLabel;
            System.Windows.Forms.Label distanzaLabel;
            System.Windows.Forms.Label direzioneLabel;
            System.Windows.Forms.Label tecnologiaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPannelli));
            this.nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsPannelli = new System.Windows.Forms.BindingSource(this.components);
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
            this.iDPannelliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pONTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pANNELLODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPontiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direzioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecnologiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTecnologia = new System.Windows.Forms.ComboBox();
            this.txtIDPannelli = new System.Windows.Forms.TextBox();
            this.txtPANNELLO = new System.Windows.Forms.TextBox();
            this.txtPONTE = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboIdPonti = new System.Windows.Forms.ComboBox();
            this.numApertura = new System.Windows.Forms.NumericUpDown();
            this.numDistanza = new System.Windows.Forms.NumericUpDown();
            this.numDirezione = new System.Windows.Forms.NumericUpDown();
            iDPannelliLabel = new System.Windows.Forms.Label();
            pANNELLOLabel = new System.Windows.Forms.Label();
            pONTELabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            idPontiLabel = new System.Windows.Forms.Label();
            aperturaLabel = new System.Windows.Forms.Label();
            distanzaLabel = new System.Windows.Forms.Label();
            direzioneLabel = new System.Windows.Forms.Label();
            tecnologiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPannelli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numApertura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDirezione)).BeginInit();
            this.SuspendLayout();
            // 
            // iDPannelliLabel
            // 
            iDPannelliLabel.AutoSize = true;
            iDPannelliLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDPannelliLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iDPannelliLabel.Location = new System.Drawing.Point(25, 52);
            iDPannelliLabel.Name = "iDPannelliLabel";
            iDPannelliLabel.Size = new System.Drawing.Size(79, 18);
            iDPannelliLabel.TabIndex = 1;
            iDPannelliLabel.Text = "iD Pannelli:";
            // 
            // pANNELLOLabel
            // 
            pANNELLOLabel.AutoSize = true;
            pANNELLOLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pANNELLOLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            pANNELLOLabel.Location = new System.Drawing.Point(25, 85);
            pANNELLOLabel.Name = "pANNELLOLabel";
            pANNELLOLabel.Size = new System.Drawing.Size(77, 18);
            pANNELLOLabel.TabIndex = 3;
            pANNELLOLabel.Text = "PANNELLO:";
            // 
            // pONTELabel
            // 
            pONTELabel.AutoSize = true;
            pONTELabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pONTELabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            pONTELabel.Location = new System.Drawing.Point(25, 117);
            pONTELabel.Name = "pONTELabel";
            pONTELabel.Size = new System.Drawing.Size(54, 18);
            pONTELabel.TabIndex = 5;
            pONTELabel.Text = "PONTE:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noteLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            noteLabel.Location = new System.Drawing.Point(439, 52);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(43, 18);
            noteLabel.TabIndex = 12;
            noteLabel.Text = "Note:";
            // 
            // idPontiLabel
            // 
            idPontiLabel.AutoSize = true;
            idPontiLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPontiLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            idPontiLabel.Location = new System.Drawing.Point(25, 150);
            idPontiLabel.Name = "idPontiLabel";
            idPontiLabel.Size = new System.Drawing.Size(60, 18);
            idPontiLabel.TabIndex = 14;
            idPontiLabel.Text = "id Ponti:";
            // 
            // aperturaLabel
            // 
            aperturaLabel.AutoSize = true;
            aperturaLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aperturaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            aperturaLabel.Location = new System.Drawing.Point(25, 181);
            aperturaLabel.Name = "aperturaLabel";
            aperturaLabel.Size = new System.Drawing.Size(67, 18);
            aperturaLabel.TabIndex = 15;
            aperturaLabel.Text = "Apertura:";
            // 
            // distanzaLabel
            // 
            distanzaLabel.AutoSize = true;
            distanzaLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            distanzaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            distanzaLabel.Location = new System.Drawing.Point(25, 214);
            distanzaLabel.Name = "distanzaLabel";
            distanzaLabel.Size = new System.Drawing.Size(64, 18);
            distanzaLabel.TabIndex = 16;
            distanzaLabel.Text = "Distanza:";
            // 
            // direzioneLabel
            // 
            direzioneLabel.AutoSize = true;
            direzioneLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direzioneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            direzioneLabel.Location = new System.Drawing.Point(25, 248);
            direzioneLabel.Name = "direzioneLabel";
            direzioneLabel.Size = new System.Drawing.Size(72, 18);
            direzioneLabel.TabIndex = 17;
            direzioneLabel.Text = "Direzione:";
            // 
            // tecnologiaLabel
            // 
            tecnologiaLabel.AutoSize = true;
            tecnologiaLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tecnologiaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            tecnologiaLabel.Location = new System.Drawing.Point(25, 283);
            tecnologiaLabel.Name = "tecnologiaLabel";
            tecnologiaLabel.Size = new System.Drawing.Size(78, 18);
            tecnologiaLabel.TabIndex = 18;
            tecnologiaLabel.Text = "Tecnologia:";
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
            this.nav.BindingSource = this.bsPannelli;
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
            this.nav.Size = new System.Drawing.Size(757, 27);
            this.nav.TabIndex = 0;
            // 
            // bsPannelli
            // 
            this.bsPannelli.DataSource = typeof(KongN.ClassiTabelle._4_pannelli);
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
            this.iDPannelliDataGridViewTextBoxColumn,
            this.pONTEDataGridViewTextBoxColumn,
            this.pANNELLODataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.idPontiDataGridViewTextBoxColumn,
            this.aperturaDataGridViewTextBoxColumn,
            this.distanzaDataGridViewTextBoxColumn,
            this.direzioneDataGridViewTextBoxColumn,
            this.tecnologiaDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsPannelli;
            this.dgv.Location = new System.Drawing.Point(0, 344);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(757, 283);
            this.dgv.TabIndex = 19;
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // iDPannelliDataGridViewTextBoxColumn
            // 
            this.iDPannelliDataGridViewTextBoxColumn.DataPropertyName = "iDPannelli";
            this.iDPannelliDataGridViewTextBoxColumn.HeaderText = "iDPannelli";
            this.iDPannelliDataGridViewTextBoxColumn.Name = "iDPannelliDataGridViewTextBoxColumn";
            this.iDPannelliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pONTEDataGridViewTextBoxColumn
            // 
            this.pONTEDataGridViewTextBoxColumn.DataPropertyName = "PONTE";
            this.pONTEDataGridViewTextBoxColumn.HeaderText = "PONTE";
            this.pONTEDataGridViewTextBoxColumn.Name = "pONTEDataGridViewTextBoxColumn";
            this.pONTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pANNELLODataGridViewTextBoxColumn
            // 
            this.pANNELLODataGridViewTextBoxColumn.DataPropertyName = "PANNELLO";
            this.pANNELLODataGridViewTextBoxColumn.HeaderText = "PANNELLO";
            this.pANNELLODataGridViewTextBoxColumn.Name = "pANNELLODataGridViewTextBoxColumn";
            this.pANNELLODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPontiDataGridViewTextBoxColumn
            // 
            this.idPontiDataGridViewTextBoxColumn.DataPropertyName = "idPonti";
            this.idPontiDataGridViewTextBoxColumn.HeaderText = "idPonti";
            this.idPontiDataGridViewTextBoxColumn.Name = "idPontiDataGridViewTextBoxColumn";
            this.idPontiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aperturaDataGridViewTextBoxColumn
            // 
            this.aperturaDataGridViewTextBoxColumn.DataPropertyName = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.HeaderText = "Apertura";
            this.aperturaDataGridViewTextBoxColumn.Name = "aperturaDataGridViewTextBoxColumn";
            this.aperturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanzaDataGridViewTextBoxColumn
            // 
            this.distanzaDataGridViewTextBoxColumn.DataPropertyName = "Distanza";
            this.distanzaDataGridViewTextBoxColumn.HeaderText = "Distanza";
            this.distanzaDataGridViewTextBoxColumn.Name = "distanzaDataGridViewTextBoxColumn";
            this.distanzaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direzioneDataGridViewTextBoxColumn
            // 
            this.direzioneDataGridViewTextBoxColumn.DataPropertyName = "Direzione";
            this.direzioneDataGridViewTextBoxColumn.HeaderText = "Direzione";
            this.direzioneDataGridViewTextBoxColumn.Name = "direzioneDataGridViewTextBoxColumn";
            this.direzioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tecnologiaDataGridViewTextBoxColumn
            // 
            this.tecnologiaDataGridViewTextBoxColumn.DataPropertyName = "Tecnologia";
            this.tecnologiaDataGridViewTextBoxColumn.HeaderText = "Tecnologia";
            this.tecnologiaDataGridViewTextBoxColumn.Name = "tecnologiaDataGridViewTextBoxColumn";
            this.tecnologiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cboTecnologia
            // 
            this.cboTecnologia.DisplayMember = "Tecnologia";
            this.cboTecnologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTecnologia.FormattingEnabled = true;
            this.cboTecnologia.Location = new System.Drawing.Point(112, 283);
            this.cboTecnologia.Name = "cboTecnologia";
            this.cboTecnologia.Size = new System.Drawing.Size(121, 21);
            this.cboTecnologia.TabIndex = 11;
            this.cboTecnologia.ValueMember = "iD";
            // 
            // txtIDPannelli
            // 
            this.txtIDPannelli.Location = new System.Drawing.Point(112, 49);
            this.txtIDPannelli.Name = "txtIDPannelli";
            this.txtIDPannelli.ReadOnly = true;
            this.txtIDPannelli.Size = new System.Drawing.Size(121, 20);
            this.txtIDPannelli.TabIndex = 2;
            // 
            // txtPANNELLO
            // 
            this.txtPANNELLO.Location = new System.Drawing.Point(112, 82);
            this.txtPANNELLO.Name = "txtPANNELLO";
            this.txtPANNELLO.Size = new System.Drawing.Size(296, 20);
            this.txtPANNELLO.TabIndex = 4;
            // 
            // txtPONTE
            // 
            this.txtPONTE.Location = new System.Drawing.Point(112, 114);
            this.txtPONTE.Name = "txtPONTE";
            this.txtPONTE.Size = new System.Drawing.Size(121, 20);
            this.txtPONTE.TabIndex = 6;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(492, 49);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(246, 262);
            this.txtNote.TabIndex = 13;
            // 
            // cboIdPonti
            // 
            this.cboIdPonti.DisplayMember = "Ponte";
            this.cboIdPonti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdPonti.FormattingEnabled = true;
            this.cboIdPonti.Location = new System.Drawing.Point(112, 147);
            this.cboIdPonti.Name = "cboIdPonti";
            this.cboIdPonti.Size = new System.Drawing.Size(121, 21);
            this.cboIdPonti.TabIndex = 7;
            this.cboIdPonti.ValueMember = "iDPonti";
            // 
            // numApertura
            // 
            this.numApertura.DecimalPlaces = 2;
            this.numApertura.Location = new System.Drawing.Point(112, 181);
            this.numApertura.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numApertura.Name = "numApertura";
            this.numApertura.Size = new System.Drawing.Size(121, 20);
            this.numApertura.TabIndex = 8;
            this.numApertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numDistanza
            // 
            this.numDistanza.DecimalPlaces = 2;
            this.numDistanza.Location = new System.Drawing.Point(112, 214);
            this.numDistanza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDistanza.Name = "numDistanza";
            this.numDistanza.Size = new System.Drawing.Size(121, 20);
            this.numDistanza.TabIndex = 9;
            this.numDistanza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numDirezione
            // 
            this.numDirezione.DecimalPlaces = 2;
            this.numDirezione.Location = new System.Drawing.Point(112, 248);
            this.numDirezione.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDirezione.Name = "numDirezione";
            this.numDirezione.Size = new System.Drawing.Size(121, 20);
            this.numDirezione.TabIndex = 10;
            this.numDirezione.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmPannelli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(757, 627);
            this.Controls.Add(this.cboTecnologia);
            this.Controls.Add(iDPannelliLabel);
            this.Controls.Add(this.txtIDPannelli);
            this.Controls.Add(pANNELLOLabel);
            this.Controls.Add(this.txtPANNELLO);
            this.Controls.Add(pONTELabel);
            this.Controls.Add(this.txtPONTE);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(idPontiLabel);
            this.Controls.Add(this.cboIdPonti);
            this.Controls.Add(aperturaLabel);
            this.Controls.Add(this.numApertura);
            this.Controls.Add(distanzaLabel);
            this.Controls.Add(this.numDistanza);
            this.Controls.Add(direzioneLabel);
            this.Controls.Add(this.numDirezione);
            this.Controls.Add(tecnologiaLabel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(773, 666);
            this.Name = "FrmPannelli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pannelli";
            this.Load += new System.EventHandler(this.FrmPannelli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPannelli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numApertura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDirezione)).EndInit();
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
        private System.Windows.Forms.BindingSource bsPannelli;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPannelliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pANNELLODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPontiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direzioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnologiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboTecnologia;
        private System.Windows.Forms.TextBox txtIDPannelli;
        private System.Windows.Forms.TextBox txtPANNELLO;
        private System.Windows.Forms.TextBox txtPONTE;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboIdPonti;
        private System.Windows.Forms.NumericUpDown numApertura;
        private System.Windows.Forms.NumericUpDown numDistanza;
        private System.Windows.Forms.NumericUpDown numDirezione;
    }
}