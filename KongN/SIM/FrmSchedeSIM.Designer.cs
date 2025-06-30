namespace KongN.SIM
{
    partial class FrmSchedeSIM
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
            System.Windows.Forms.Label pukLabel;
            System.Windows.Forms.Label utenteLabel;
            System.Windows.Forms.Label iMEILabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label aPNLabel;
            System.Windows.Forms.Label fornitoreLabel;
            System.Windows.Forms.Label tipoAbbonamentoLabel;
            System.Windows.Forms.Label riferimentoOperatoreLabel;
            System.Windows.Forms.Label dataAttivazioneLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSchedeSIM));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMEIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornitoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAbbonamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riferimentoOperatoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inMagazzinoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dismessaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.attivaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataAttivazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSim = new System.Windows.Forms.BindingSource(this.components);
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
            this.txtPuk = new System.Windows.Forms.TextBox();
            this.txtUtente = new System.Windows.Forms.TextBox();
            this.txtIMEI = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtAPN = new System.Windows.Forms.TextBox();
            this.txtFornitore = new System.Windows.Forms.TextBox();
            this.txtTipoAbbonamento = new System.Windows.Forms.TextBox();
            this.txtRiferimentoOperatore = new System.Windows.Forms.TextBox();
            this.chkInMagazzino = new System.Windows.Forms.CheckBox();
            this.chkDismessa = new System.Windows.Forms.CheckBox();
            this.chkAttiva = new System.Windows.Forms.CheckBox();
            this.dtpDataAttivazione = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            pukLabel = new System.Windows.Forms.Label();
            utenteLabel = new System.Windows.Forms.Label();
            iMEILabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            aPNLabel = new System.Windows.Forms.Label();
            fornitoreLabel = new System.Windows.Forms.Label();
            tipoAbbonamentoLabel = new System.Windows.Forms.Label();
            riferimentoOperatoreLabel = new System.Windows.Forms.Label();
            dataAttivazioneLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pukLabel
            // 
            pukLabel.AutoSize = true;
            pukLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pukLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            pukLabel.Location = new System.Drawing.Point(26, 76);
            pukLabel.Name = "pukLabel";
            pukLabel.Size = new System.Drawing.Size(35, 18);
            pukLabel.TabIndex = 15;
            pukLabel.Text = "Puk:";
            // 
            // utenteLabel
            // 
            utenteLabel.AutoSize = true;
            utenteLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            utenteLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            utenteLabel.Location = new System.Drawing.Point(26, 102);
            utenteLabel.Name = "utenteLabel";
            utenteLabel.Size = new System.Drawing.Size(56, 18);
            utenteLabel.TabIndex = 16;
            utenteLabel.Text = "Utente:";
            // 
            // iMEILabel
            // 
            iMEILabel.AutoSize = true;
            iMEILabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iMEILabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iMEILabel.Location = new System.Drawing.Point(26, 128);
            iMEILabel.Name = "iMEILabel";
            iMEILabel.Size = new System.Drawing.Size(40, 18);
            iMEILabel.TabIndex = 17;
            iMEILabel.Text = "IMEI:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            telefonoLabel.Location = new System.Drawing.Point(26, 154);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(67, 18);
            telefonoLabel.TabIndex = 18;
            telefonoLabel.Text = "Telefono:";
            // 
            // aPNLabel
            // 
            aPNLabel.AutoSize = true;
            aPNLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aPNLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            aPNLabel.Location = new System.Drawing.Point(26, 180);
            aPNLabel.Name = "aPNLabel";
            aPNLabel.Size = new System.Drawing.Size(39, 18);
            aPNLabel.TabIndex = 19;
            aPNLabel.Text = "APN:";
            // 
            // fornitoreLabel
            // 
            fornitoreLabel.AutoSize = true;
            fornitoreLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fornitoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            fornitoreLabel.Location = new System.Drawing.Point(26, 206);
            fornitoreLabel.Name = "fornitoreLabel";
            fornitoreLabel.Size = new System.Drawing.Size(70, 18);
            fornitoreLabel.TabIndex = 20;
            fornitoreLabel.Text = "Fornitore:";
            // 
            // tipoAbbonamentoLabel
            // 
            tipoAbbonamentoLabel.AutoSize = true;
            tipoAbbonamentoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoAbbonamentoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            tipoAbbonamentoLabel.Location = new System.Drawing.Point(26, 232);
            tipoAbbonamentoLabel.Name = "tipoAbbonamentoLabel";
            tipoAbbonamentoLabel.Size = new System.Drawing.Size(131, 18);
            tipoAbbonamentoLabel.TabIndex = 21;
            tipoAbbonamentoLabel.Text = "Tipo Abbonamento:";
            // 
            // riferimentoOperatoreLabel
            // 
            riferimentoOperatoreLabel.AutoSize = true;
            riferimentoOperatoreLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            riferimentoOperatoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            riferimentoOperatoreLabel.Location = new System.Drawing.Point(26, 258);
            riferimentoOperatoreLabel.Name = "riferimentoOperatoreLabel";
            riferimentoOperatoreLabel.Size = new System.Drawing.Size(154, 18);
            riferimentoOperatoreLabel.TabIndex = 22;
            riferimentoOperatoreLabel.Text = "Riferimento Operatore:";
            // 
            // dataAttivazioneLabel
            // 
            dataAttivazioneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataAttivazioneLabel.AutoSize = true;
            dataAttivazioneLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataAttivazioneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataAttivazioneLabel.Location = new System.Drawing.Point(469, 161);
            dataAttivazioneLabel.Name = "dataAttivazioneLabel";
            dataAttivazioneLabel.Size = new System.Drawing.Size(113, 18);
            dataAttivazioneLabel.TabIndex = 23;
            dataAttivazioneLabel.Text = "Data Attivazione:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iDLabel.Location = new System.Drawing.Point(26, 50);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 18);
            iDLabel.TabIndex = 24;
            iDLabel.Text = "iD:";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.iDDataGridViewTextBoxColumn,
            this.pukDataGridViewTextBoxColumn,
            this.utenteDataGridViewTextBoxColumn,
            this.iMEIDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.aPNDataGridViewTextBoxColumn,
            this.fornitoreDataGridViewTextBoxColumn,
            this.tipoAbbonamentoDataGridViewTextBoxColumn,
            this.riferimentoOperatoreDataGridViewTextBoxColumn,
            this.inMagazzinoDataGridViewCheckBoxColumn,
            this.dismessaDataGridViewCheckBoxColumn,
            this.attivaDataGridViewCheckBoxColumn,
            this.dataAttivazioneDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsSim;
            this.dgv.Location = new System.Drawing.Point(0, 322);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(842, 275);
            this.dgv.TabIndex = 13;
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "iD";
            this.iDDataGridViewTextBoxColumn.HeaderText = "iD";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 42;
            // 
            // pukDataGridViewTextBoxColumn
            // 
            this.pukDataGridViewTextBoxColumn.DataPropertyName = "Puk";
            this.pukDataGridViewTextBoxColumn.HeaderText = "Puk";
            this.pukDataGridViewTextBoxColumn.Name = "pukDataGridViewTextBoxColumn";
            this.pukDataGridViewTextBoxColumn.ReadOnly = true;
            this.pukDataGridViewTextBoxColumn.Width = 51;
            // 
            // utenteDataGridViewTextBoxColumn
            // 
            this.utenteDataGridViewTextBoxColumn.DataPropertyName = "Utente";
            this.utenteDataGridViewTextBoxColumn.HeaderText = "Utente";
            this.utenteDataGridViewTextBoxColumn.Name = "utenteDataGridViewTextBoxColumn";
            this.utenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.utenteDataGridViewTextBoxColumn.Width = 64;
            // 
            // iMEIDataGridViewTextBoxColumn
            // 
            this.iMEIDataGridViewTextBoxColumn.DataPropertyName = "IMEI";
            this.iMEIDataGridViewTextBoxColumn.HeaderText = "IMEI";
            this.iMEIDataGridViewTextBoxColumn.Name = "iMEIDataGridViewTextBoxColumn";
            this.iMEIDataGridViewTextBoxColumn.ReadOnly = true;
            this.iMEIDataGridViewTextBoxColumn.Width = 54;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 74;
            // 
            // aPNDataGridViewTextBoxColumn
            // 
            this.aPNDataGridViewTextBoxColumn.DataPropertyName = "APN";
            this.aPNDataGridViewTextBoxColumn.HeaderText = "APN";
            this.aPNDataGridViewTextBoxColumn.Name = "aPNDataGridViewTextBoxColumn";
            this.aPNDataGridViewTextBoxColumn.ReadOnly = true;
            this.aPNDataGridViewTextBoxColumn.Width = 54;
            // 
            // fornitoreDataGridViewTextBoxColumn
            // 
            this.fornitoreDataGridViewTextBoxColumn.DataPropertyName = "Fornitore";
            this.fornitoreDataGridViewTextBoxColumn.HeaderText = "Fornitore";
            this.fornitoreDataGridViewTextBoxColumn.Name = "fornitoreDataGridViewTextBoxColumn";
            this.fornitoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.fornitoreDataGridViewTextBoxColumn.Width = 73;
            // 
            // tipoAbbonamentoDataGridViewTextBoxColumn
            // 
            this.tipoAbbonamentoDataGridViewTextBoxColumn.DataPropertyName = "TipoAbbonamento";
            this.tipoAbbonamentoDataGridViewTextBoxColumn.HeaderText = "TipoAbbonamento";
            this.tipoAbbonamentoDataGridViewTextBoxColumn.Name = "tipoAbbonamentoDataGridViewTextBoxColumn";
            this.tipoAbbonamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoAbbonamentoDataGridViewTextBoxColumn.Width = 119;
            // 
            // riferimentoOperatoreDataGridViewTextBoxColumn
            // 
            this.riferimentoOperatoreDataGridViewTextBoxColumn.DataPropertyName = "RiferimentoOperatore";
            this.riferimentoOperatoreDataGridViewTextBoxColumn.HeaderText = "RiferimentoOperatore";
            this.riferimentoOperatoreDataGridViewTextBoxColumn.Name = "riferimentoOperatoreDataGridViewTextBoxColumn";
            this.riferimentoOperatoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.riferimentoOperatoreDataGridViewTextBoxColumn.Width = 132;
            // 
            // inMagazzinoDataGridViewCheckBoxColumn
            // 
            this.inMagazzinoDataGridViewCheckBoxColumn.DataPropertyName = "InMagazzino";
            this.inMagazzinoDataGridViewCheckBoxColumn.HeaderText = "InMagazzino";
            this.inMagazzinoDataGridViewCheckBoxColumn.Name = "inMagazzinoDataGridViewCheckBoxColumn";
            this.inMagazzinoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.inMagazzinoDataGridViewCheckBoxColumn.Width = 73;
            // 
            // dismessaDataGridViewCheckBoxColumn
            // 
            this.dismessaDataGridViewCheckBoxColumn.DataPropertyName = "Dismessa";
            this.dismessaDataGridViewCheckBoxColumn.HeaderText = "Dismessa";
            this.dismessaDataGridViewCheckBoxColumn.Name = "dismessaDataGridViewCheckBoxColumn";
            this.dismessaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.dismessaDataGridViewCheckBoxColumn.Width = 58;
            // 
            // attivaDataGridViewCheckBoxColumn
            // 
            this.attivaDataGridViewCheckBoxColumn.DataPropertyName = "Attiva";
            this.attivaDataGridViewCheckBoxColumn.HeaderText = "Attiva";
            this.attivaDataGridViewCheckBoxColumn.Name = "attivaDataGridViewCheckBoxColumn";
            this.attivaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.attivaDataGridViewCheckBoxColumn.Width = 40;
            // 
            // dataAttivazioneDataGridViewTextBoxColumn
            // 
            this.dataAttivazioneDataGridViewTextBoxColumn.DataPropertyName = "DataAttivazione";
            this.dataAttivazioneDataGridViewTextBoxColumn.HeaderText = "DataAttivazione";
            this.dataAttivazioneDataGridViewTextBoxColumn.Name = "dataAttivazioneDataGridViewTextBoxColumn";
            this.dataAttivazioneDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataAttivazioneDataGridViewTextBoxColumn.Width = 107;
            // 
            // bsSim
            // 
            this.bsSim.DataSource = typeof(KongN.ClassiTabelle.SchedeSim);
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
            this.nav.BindingSource = this.bsSim;
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
            this.nav.Size = new System.Drawing.Size(842, 27);
            this.nav.TabIndex = 14;
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
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(192, 48);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtPuk
            // 
            this.txtPuk.Location = new System.Drawing.Point(192, 74);
            this.txtPuk.Name = "txtPuk";
            this.txtPuk.Size = new System.Drawing.Size(200, 20);
            this.txtPuk.TabIndex = 1;
            // 
            // txtUtente
            // 
            this.txtUtente.Location = new System.Drawing.Point(192, 100);
            this.txtUtente.Name = "txtUtente";
            this.txtUtente.Size = new System.Drawing.Size(200, 20);
            this.txtUtente.TabIndex = 2;
            // 
            // txtIMEI
            // 
            this.txtIMEI.Location = new System.Drawing.Point(192, 126);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(200, 20);
            this.txtIMEI.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(192, 152);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtAPN
            // 
            this.txtAPN.Location = new System.Drawing.Point(192, 178);
            this.txtAPN.Name = "txtAPN";
            this.txtAPN.Size = new System.Drawing.Size(200, 20);
            this.txtAPN.TabIndex = 5;
            // 
            // txtFornitore
            // 
            this.txtFornitore.Location = new System.Drawing.Point(192, 204);
            this.txtFornitore.Name = "txtFornitore";
            this.txtFornitore.Size = new System.Drawing.Size(200, 20);
            this.txtFornitore.TabIndex = 6;
            // 
            // txtTipoAbbonamento
            // 
            this.txtTipoAbbonamento.Location = new System.Drawing.Point(192, 230);
            this.txtTipoAbbonamento.Name = "txtTipoAbbonamento";
            this.txtTipoAbbonamento.Size = new System.Drawing.Size(200, 20);
            this.txtTipoAbbonamento.TabIndex = 7;
            // 
            // txtRiferimentoOperatore
            // 
            this.txtRiferimentoOperatore.Location = new System.Drawing.Point(192, 256);
            this.txtRiferimentoOperatore.Name = "txtRiferimentoOperatore";
            this.txtRiferimentoOperatore.Size = new System.Drawing.Size(200, 20);
            this.txtRiferimentoOperatore.TabIndex = 8;
            // 
            // chkInMagazzino
            // 
            this.chkInMagazzino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInMagazzino.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkInMagazzino.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInMagazzino.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkInMagazzino.Location = new System.Drawing.Point(472, 47);
            this.chkInMagazzino.Name = "chkInMagazzino";
            this.chkInMagazzino.Size = new System.Drawing.Size(143, 24);
            this.chkInMagazzino.TabIndex = 9;
            this.chkInMagazzino.Text = "In Magazzino:";
            this.chkInMagazzino.UseVisualStyleBackColor = true;
            // 
            // chkDismessa
            // 
            this.chkDismessa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDismessa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDismessa.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDismessa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkDismessa.Location = new System.Drawing.Point(472, 79);
            this.chkDismessa.Name = "chkDismessa";
            this.chkDismessa.Size = new System.Drawing.Size(143, 24);
            this.chkDismessa.TabIndex = 10;
            this.chkDismessa.Text = "Dismessa:";
            this.chkDismessa.UseVisualStyleBackColor = true;
            // 
            // chkAttiva
            // 
            this.chkAttiva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAttiva.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAttiva.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAttiva.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkAttiva.Location = new System.Drawing.Point(472, 115);
            this.chkAttiva.Name = "chkAttiva";
            this.chkAttiva.Size = new System.Drawing.Size(143, 24);
            this.chkAttiva.TabIndex = 11;
            this.chkAttiva.Text = "Attiva:";
            this.chkAttiva.UseVisualStyleBackColor = true;
            // 
            // dtpDataAttivazione
            // 
            this.dtpDataAttivazione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataAttivazione.DateTimeIcon = null;
            this.dtpDataAttivazione.Location = new System.Drawing.Point(600, 158);
            this.dtpDataAttivazione.Name = "dtpDataAttivazione";
            this.dtpDataAttivazione.Size = new System.Drawing.Size(130, 21);
            this.dtpDataAttivazione.TabIndex = 12;
            this.dtpDataAttivazione.ToolTipText = "";
            // 
            // FrmSchedeSIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(842, 597);
            this.Controls.Add(this.dtpDataAttivazione);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(pukLabel);
            this.Controls.Add(this.txtPuk);
            this.Controls.Add(utenteLabel);
            this.Controls.Add(this.txtUtente);
            this.Controls.Add(iMEILabel);
            this.Controls.Add(this.txtIMEI);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(aPNLabel);
            this.Controls.Add(this.txtAPN);
            this.Controls.Add(fornitoreLabel);
            this.Controls.Add(this.txtFornitore);
            this.Controls.Add(tipoAbbonamentoLabel);
            this.Controls.Add(this.txtTipoAbbonamento);
            this.Controls.Add(riferimentoOperatoreLabel);
            this.Controls.Add(this.txtRiferimentoOperatore);
            this.Controls.Add(this.chkInMagazzino);
            this.Controls.Add(this.chkDismessa);
            this.Controls.Add(this.chkAttiva);
            this.Controls.Add(dataAttivazioneLabel);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(858, 636);
            this.Name = "FrmSchedeSIM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schede SIM";
            this.Load += new System.EventHandler(this.FrmSchedeSIM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
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
        private System.Windows.Forms.BindingSource bsSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMEIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornitoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAbbonamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riferimentoOperatoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inMagazzinoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dismessaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn attivaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAttivazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPuk;
        private System.Windows.Forms.TextBox txtUtente;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtAPN;
        private System.Windows.Forms.TextBox txtFornitore;
        private System.Windows.Forms.TextBox txtTipoAbbonamento;
        private System.Windows.Forms.TextBox txtRiferimentoOperatore;
        private System.Windows.Forms.CheckBox chkInMagazzino;
        private System.Windows.Forms.CheckBox chkDismessa;
        private System.Windows.Forms.CheckBox chkAttiva;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpDataAttivazione;
    }
}