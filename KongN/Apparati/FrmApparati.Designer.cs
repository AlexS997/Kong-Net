namespace KongN.Apparati
{
    partial class FrmApparati
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
            System.Windows.Forms.Label descrizioneLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label apparatoLabel;
            System.Windows.Forms.Label luogoApparatoLabel;
            System.Windows.Forms.Label indirizzoIPLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label dataInstallazioneLabel;
            System.Windows.Forms.Label tipoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApparati));
            this.nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsApparati = new System.Windows.Forms.BindingSource(this.components);
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
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apparatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luogoApparatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzoIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUtenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInstallazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataModificaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdUtente = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtApparato = new System.Windows.Forms.TextBox();
            this.txtLuogoApparato = new System.Windows.Forms.TextBox();
            this.txtIndirizzoIP = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dtpInstallazione = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.dtpModifica = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            iDLabel = new System.Windows.Forms.Label();
            descrizioneLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            apparatoLabel = new System.Windows.Forms.Label();
            luogoApparatoLabel = new System.Windows.Forms.Label();
            indirizzoIPLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            dataInstallazioneLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsApparati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iDLabel.Location = new System.Drawing.Point(33, 47);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(24, 18);
            iDLabel.TabIndex = 12;
            iDLabel.Text = "Id:";
            // 
            // descrizioneLabel
            // 
            descrizioneLabel.AutoSize = true;
            descrizioneLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descrizioneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            descrizioneLabel.Location = new System.Drawing.Point(33, 73);
            descrizioneLabel.Name = "descrizioneLabel";
            descrizioneLabel.Size = new System.Drawing.Size(84, 18);
            descrizioneLabel.TabIndex = 13;
            descrizioneLabel.Text = "Descrizione:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noteLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            noteLabel.Location = new System.Drawing.Point(531, 59);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(43, 18);
            noteLabel.TabIndex = 14;
            noteLabel.Text = "Note:";
            // 
            // apparatoLabel
            // 
            apparatoLabel.AutoSize = true;
            apparatoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apparatoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            apparatoLabel.Location = new System.Drawing.Point(33, 99);
            apparatoLabel.Name = "apparatoLabel";
            apparatoLabel.Size = new System.Drawing.Size(69, 18);
            apparatoLabel.TabIndex = 15;
            apparatoLabel.Text = "Apparato:";
            // 
            // luogoApparatoLabel
            // 
            luogoApparatoLabel.AutoSize = true;
            luogoApparatoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            luogoApparatoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            luogoApparatoLabel.Location = new System.Drawing.Point(33, 125);
            luogoApparatoLabel.Name = "luogoApparatoLabel";
            luogoApparatoLabel.Size = new System.Drawing.Size(109, 18);
            luogoApparatoLabel.TabIndex = 16;
            luogoApparatoLabel.Text = "Luogo Apparato:";
            // 
            // indirizzoIPLabel
            // 
            indirizzoIPLabel.AutoSize = true;
            indirizzoIPLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            indirizzoIPLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            indirizzoIPLabel.Location = new System.Drawing.Point(33, 151);
            indirizzoIPLabel.Name = "indirizzoIPLabel";
            indirizzoIPLabel.Size = new System.Drawing.Size(80, 18);
            indirizzoIPLabel.TabIndex = 17;
            indirizzoIPLabel.Text = "Indirizzo IP:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            usernameLabel.Location = new System.Drawing.Point(33, 177);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(76, 18);
            usernameLabel.TabIndex = 18;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            passwordLabel.Location = new System.Drawing.Point(33, 203);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(71, 18);
            passwordLabel.TabIndex = 19;
            passwordLabel.Text = "Password:";
            // 
            // dataInstallazioneLabel
            // 
            dataInstallazioneLabel.AutoSize = true;
            dataInstallazioneLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataInstallazioneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataInstallazioneLabel.Location = new System.Drawing.Point(33, 230);
            dataInstallazioneLabel.Name = "dataInstallazioneLabel";
            dataInstallazioneLabel.Size = new System.Drawing.Size(122, 18);
            dataInstallazioneLabel.TabIndex = 20;
            dataInstallazioneLabel.Text = "Data Installazione:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            tipoLabel.Location = new System.Drawing.Point(33, 255);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(39, 18);
            tipoLabel.TabIndex = 21;
            tipoLabel.Text = "Tipo:";
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
            this.nav.BindingSource = this.bsApparati;
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
            this.nav.Size = new System.Drawing.Size(1061, 27);
            this.nav.TabIndex = 0;
            // 
            // bsApparati
            // 
            this.bsApparati.DataSource = typeof(KongN.ClassiTabelle.Apparati);
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
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.apparatoDataGridViewTextBoxColumn,
            this.luogoApparatoDataGridViewTextBoxColumn,
            this.indirizzoIPDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.iDUtenteDataGridViewTextBoxColumn,
            this.dataInstallazioneDataGridViewTextBoxColumn,
            this.dataModificaDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsApparati;
            this.dgv.Location = new System.Drawing.Point(0, 367);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1061, 283);
            this.dgv.TabIndex = 11;
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "iD";
            this.iDDataGridViewTextBoxColumn.HeaderText = "iD";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // apparatoDataGridViewTextBoxColumn
            // 
            this.apparatoDataGridViewTextBoxColumn.DataPropertyName = "Apparato";
            this.apparatoDataGridViewTextBoxColumn.HeaderText = "Apparato";
            this.apparatoDataGridViewTextBoxColumn.Name = "apparatoDataGridViewTextBoxColumn";
            this.apparatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // luogoApparatoDataGridViewTextBoxColumn
            // 
            this.luogoApparatoDataGridViewTextBoxColumn.DataPropertyName = "LuogoApparato";
            this.luogoApparatoDataGridViewTextBoxColumn.HeaderText = "LuogoApparato";
            this.luogoApparatoDataGridViewTextBoxColumn.Name = "luogoApparatoDataGridViewTextBoxColumn";
            this.luogoApparatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indirizzoIPDataGridViewTextBoxColumn
            // 
            this.indirizzoIPDataGridViewTextBoxColumn.DataPropertyName = "IndirizzoIP";
            this.indirizzoIPDataGridViewTextBoxColumn.HeaderText = "IndirizzoIP";
            this.indirizzoIPDataGridViewTextBoxColumn.Name = "indirizzoIPDataGridViewTextBoxColumn";
            this.indirizzoIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDUtenteDataGridViewTextBoxColumn
            // 
            this.iDUtenteDataGridViewTextBoxColumn.DataPropertyName = "iDUtente";
            this.iDUtenteDataGridViewTextBoxColumn.HeaderText = "iDUtente";
            this.iDUtenteDataGridViewTextBoxColumn.Name = "iDUtenteDataGridViewTextBoxColumn";
            this.iDUtenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInstallazioneDataGridViewTextBoxColumn
            // 
            this.dataInstallazioneDataGridViewTextBoxColumn.DataPropertyName = "DataInstallazione";
            this.dataInstallazioneDataGridViewTextBoxColumn.HeaderText = "DataInstallazione";
            this.dataInstallazioneDataGridViewTextBoxColumn.Name = "dataInstallazioneDataGridViewTextBoxColumn";
            this.dataInstallazioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataModificaDataGridViewTextBoxColumn
            // 
            this.dataModificaDataGridViewTextBoxColumn.DataPropertyName = "DataModifica";
            this.dataModificaDataGridViewTextBoxColumn.HeaderText = "DataModifica";
            this.dataModificaDataGridViewTextBoxColumn.Name = "dataModificaDataGridViewTextBoxColumn";
            this.dataModificaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtIdUtente
            // 
            this.txtIdUtente.Location = new System.Drawing.Point(19, 324);
            this.txtIdUtente.Name = "txtIdUtente";
            this.txtIdUtente.Size = new System.Drawing.Size(100, 20);
            this.txtIdUtente.TabIndex = 22;
            this.txtIdUtente.Tag = "idUtente";
            this.txtIdUtente.Text = "idUtente";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(163, 44);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(88, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(163, 70);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(200, 20);
            this.txtDescrizione.TabIndex = 2;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(581, 56);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(445, 278);
            this.txtNote.TabIndex = 10;
            // 
            // txtApparato
            // 
            this.txtApparato.Location = new System.Drawing.Point(163, 96);
            this.txtApparato.Name = "txtApparato";
            this.txtApparato.Size = new System.Drawing.Size(200, 20);
            this.txtApparato.TabIndex = 3;
            // 
            // txtLuogoApparato
            // 
            this.txtLuogoApparato.Location = new System.Drawing.Point(163, 122);
            this.txtLuogoApparato.Name = "txtLuogoApparato";
            this.txtLuogoApparato.Size = new System.Drawing.Size(200, 20);
            this.txtLuogoApparato.TabIndex = 4;
            // 
            // txtIndirizzoIP
            // 
            this.txtIndirizzoIP.Location = new System.Drawing.Point(163, 148);
            this.txtIndirizzoIP.Name = "txtIndirizzoIP";
            this.txtIndirizzoIP.Size = new System.Drawing.Size(200, 20);
            this.txtIndirizzoIP.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(163, 174);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(163, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(163, 252);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(200, 21);
            this.cboTipo.TabIndex = 9;
            // 
            // dtpInstallazione
            // 
            this.dtpInstallazione.DateTimeIcon = null;
            this.dtpInstallazione.Location = new System.Drawing.Point(163, 226);
            this.dtpInstallazione.Name = "dtpInstallazione";
            this.dtpInstallazione.Size = new System.Drawing.Size(115, 21);
            this.dtpInstallazione.TabIndex = 8;
            this.dtpInstallazione.ToolTipText = "";
            // 
            // dtpModifica
            // 
            this.dtpModifica.DateTimeIcon = null;
            this.dtpModifica.Location = new System.Drawing.Point(136, 323);
            this.dtpModifica.Name = "dtpModifica";
            this.dtpModifica.Size = new System.Drawing.Size(115, 21);
            this.dtpModifica.TabIndex = 23;
            this.dtpModifica.ToolTipText = "";
            // 
            // FrmApparati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1061, 650);
            this.Controls.Add(this.dtpModifica);
            this.Controls.Add(this.dtpInstallazione);
            this.Controls.Add(this.txtIdUtente);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(descrizioneLabel);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(apparatoLabel);
            this.Controls.Add(this.txtApparato);
            this.Controls.Add(luogoApparatoLabel);
            this.Controls.Add(this.txtLuogoApparato);
            this.Controls.Add(indirizzoIPLabel);
            this.Controls.Add(this.txtIndirizzoIP);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(dataInstallazioneLabel);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(988, 689);
            this.Name = "FrmApparati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apparati";
            this.Load += new System.EventHandler(this.FrmApparati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsApparati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
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
        private System.Windows.Forms.TextBox txtIdUtente;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtApparato;
        private System.Windows.Forms.TextBox txtLuogoApparato;
        private System.Windows.Forms.TextBox txtIndirizzoIP;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.BindingSource bsApparati;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apparatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luogoApparatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzoIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUtenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInstallazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataModificaDataGridViewTextBoxColumn;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpInstallazione;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpModifica;
    }
}