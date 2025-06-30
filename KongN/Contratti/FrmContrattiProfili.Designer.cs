namespace KongN.Contratti
{
    partial class FrmContrattiProfili
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
            System.Windows.Forms.Label attivazioneSOLabel;
            System.Windows.Forms.Label attivazioneLabel;
            System.Windows.Forms.Label prezzoAnnualeSOLabel;
            System.Windows.Forms.Label prezzoAnnualeLabel;
            System.Windows.Forms.Label contoRicavoLabel;
            System.Windows.Forms.Label codIvaLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label codiceLabel;
            System.Windows.Forms.Label descrizioneLabel;
            System.Windows.Forms.Label profiloLabel;
            System.Windows.Forms.Label idUtenteLabel;
            System.Windows.Forms.Label dataModificaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContrattiProfili));
            this.dgv = new System.Windows.Forms.DataGridView();
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
            this.bsProfiliCtr = new System.Windows.Forms.BindingSource(this.components);
            this.chkRicaricabile = new System.Windows.Forms.CheckBox();
            this.chkAttivo = new System.Windows.Forms.CheckBox();
            this.btnPrelevaDaTabellaAutomatismi = new System.Windows.Forms.Button();
            this.txtContoRicavo = new System.Windows.Forms.TextBox();
            this.txtCodIva = new System.Windows.Forms.TextBox();
            this.btnProfilo = new System.Windows.Forms.Button();
            this.btnContoRicavo = new System.Windows.Forms.Button();
            this.btnIVA = new System.Windows.Forms.Button();
            this.btnPrelevaCodice = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtProfilo = new System.Windows.Forms.TextBox();
            this.txtIdUtente = new System.Windows.Forms.TextBox();
            this.numPrezzoAnnuale = new System.Windows.Forms.NumericUpDown();
            this.numAttivazione = new System.Windows.Forms.NumericUpDown();
            this.numAttivazioneSO = new System.Windows.Forms.NumericUpDown();
            this.numPrezzoAnnualeSO = new System.Windows.Forms.NumericUpDown();
            this.dtpModifica = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.chkNoleggio = new System.Windows.Forms.CheckBox();
            attivazioneSOLabel = new System.Windows.Forms.Label();
            attivazioneLabel = new System.Windows.Forms.Label();
            prezzoAnnualeSOLabel = new System.Windows.Forms.Label();
            prezzoAnnualeLabel = new System.Windows.Forms.Label();
            contoRicavoLabel = new System.Windows.Forms.Label();
            codIvaLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            codiceLabel = new System.Windows.Forms.Label();
            descrizioneLabel = new System.Windows.Forms.Label();
            profiloLabel = new System.Windows.Forms.Label();
            idUtenteLabel = new System.Windows.Forms.Label();
            dataModificaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProfiliCtr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzoAnnuale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttivazione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttivazioneSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzoAnnualeSO)).BeginInit();
            this.SuspendLayout();
            // 
            // attivazioneSOLabel
            // 
            attivazioneSOLabel.AutoSize = true;
            attivazioneSOLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            attivazioneSOLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            attivazioneSOLabel.Location = new System.Drawing.Point(26, 232);
            attivazioneSOLabel.Name = "attivazioneSOLabel";
            attivazioneSOLabel.Size = new System.Drawing.Size(102, 18);
            attivazioneSOLabel.TabIndex = 69;
            attivazioneSOLabel.Text = "Attivazione SO:";
            // 
            // attivazioneLabel
            // 
            attivazioneLabel.AutoSize = true;
            attivazioneLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            attivazioneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            attivazioneLabel.Location = new System.Drawing.Point(27, 193);
            attivazioneLabel.Name = "attivazioneLabel";
            attivazioneLabel.Size = new System.Drawing.Size(82, 18);
            attivazioneLabel.TabIndex = 68;
            attivazioneLabel.Text = "Attivazione:";
            // 
            // prezzoAnnualeSOLabel
            // 
            prezzoAnnualeSOLabel.AutoSize = true;
            prezzoAnnualeSOLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prezzoAnnualeSOLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            prezzoAnnualeSOLabel.Location = new System.Drawing.Point(302, 232);
            prezzoAnnualeSOLabel.Name = "prezzoAnnualeSOLabel";
            prezzoAnnualeSOLabel.Size = new System.Drawing.Size(128, 18);
            prezzoAnnualeSOLabel.TabIndex = 67;
            prezzoAnnualeSOLabel.Text = "Prezzo Annuale SO:";
            // 
            // prezzoAnnualeLabel
            // 
            prezzoAnnualeLabel.AutoSize = true;
            prezzoAnnualeLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prezzoAnnualeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            prezzoAnnualeLabel.Location = new System.Drawing.Point(301, 193);
            prezzoAnnualeLabel.Name = "prezzoAnnualeLabel";
            prezzoAnnualeLabel.Size = new System.Drawing.Size(108, 18);
            prezzoAnnualeLabel.TabIndex = 66;
            prezzoAnnualeLabel.Text = "Prezzo Annuale:";
            // 
            // contoRicavoLabel
            // 
            contoRicavoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            contoRicavoLabel.AutoSize = true;
            contoRicavoLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contoRicavoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            contoRicavoLabel.Location = new System.Drawing.Point(718, 58);
            contoRicavoLabel.Name = "contoRicavoLabel";
            contoRicavoLabel.Size = new System.Drawing.Size(92, 18);
            contoRicavoLabel.TabIndex = 63;
            contoRicavoLabel.Text = "Conto Ricavo:";
            // 
            // codIvaLabel
            // 
            codIvaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            codIvaLabel.AutoSize = true;
            codIvaLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codIvaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            codIvaLabel.Location = new System.Drawing.Point(719, 88);
            codIvaLabel.Name = "codIvaLabel";
            codIvaLabel.Size = new System.Drawing.Size(57, 18);
            codIvaLabel.TabIndex = 61;
            codIvaLabel.Text = "Cod Iva:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            iDLabel.Location = new System.Drawing.Point(28, 60);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(24, 18);
            iDLabel.TabIndex = 49;
            iDLabel.Text = "Id:";
            // 
            // codiceLabel
            // 
            codiceLabel.AutoSize = true;
            codiceLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codiceLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            codiceLabel.Location = new System.Drawing.Point(28, 91);
            codiceLabel.Name = "codiceLabel";
            codiceLabel.Size = new System.Drawing.Size(54, 18);
            codiceLabel.TabIndex = 51;
            codiceLabel.Text = "Codice:";
            // 
            // descrizioneLabel
            // 
            descrizioneLabel.AutoSize = true;
            descrizioneLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descrizioneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            descrizioneLabel.Location = new System.Drawing.Point(28, 122);
            descrizioneLabel.Name = "descrizioneLabel";
            descrizioneLabel.Size = new System.Drawing.Size(84, 18);
            descrizioneLabel.TabIndex = 52;
            descrizioneLabel.Text = "Descrizione:";
            // 
            // profiloLabel
            // 
            profiloLabel.AutoSize = true;
            profiloLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            profiloLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            profiloLabel.Location = new System.Drawing.Point(28, 157);
            profiloLabel.Name = "profiloLabel";
            profiloLabel.Size = new System.Drawing.Size(53, 18);
            profiloLabel.TabIndex = 53;
            profiloLabel.Text = "Profilo:";
            // 
            // idUtenteLabel
            // 
            idUtenteLabel.AutoSize = true;
            idUtenteLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idUtenteLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            idUtenteLabel.Location = new System.Drawing.Point(28, 273);
            idUtenteLabel.Name = "idUtenteLabel";
            idUtenteLabel.Size = new System.Drawing.Size(71, 18);
            idUtenteLabel.TabIndex = 54;
            idUtenteLabel.Text = "Id Utente:";
            // 
            // dataModificaLabel
            // 
            dataModificaLabel.AutoSize = true;
            dataModificaLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataModificaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataModificaLabel.Location = new System.Drawing.Point(302, 272);
            dataModificaLabel.Name = "dataModificaLabel";
            dataModificaLabel.Size = new System.Drawing.Size(97, 18);
            dataModificaLabel.TabIndex = 56;
            dataModificaLabel.Text = "Data Modifica:";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 321);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1019, 240);
            this.dgv.TabIndex = 44;
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
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
            this.nav.Size = new System.Drawing.Size(1019, 27);
            this.nav.TabIndex = 45;
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
            // chkRicaricabile
            // 
            this.chkRicaricabile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRicaricabile.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRicaricabile.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRicaricabile.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkRicaricabile.Location = new System.Drawing.Point(718, 157);
            this.chkRicaricabile.Name = "chkRicaricabile";
            this.chkRicaricabile.Size = new System.Drawing.Size(115, 24);
            this.chkRicaricabile.TabIndex = 73;
            this.chkRicaricabile.Text = "Ricaricabile:";
            this.chkRicaricabile.UseVisualStyleBackColor = true;
            // 
            // chkAttivo
            // 
            this.chkAttivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAttivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAttivo.Checked = true;
            this.chkAttivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAttivo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAttivo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkAttivo.Location = new System.Drawing.Point(719, 192);
            this.chkAttivo.Name = "chkAttivo";
            this.chkAttivo.Size = new System.Drawing.Size(114, 24);
            this.chkAttivo.TabIndex = 71;
            this.chkAttivo.Text = "Attivo:";
            this.chkAttivo.UseVisualStyleBackColor = true;
            // 
            // btnPrelevaDaTabellaAutomatismi
            // 
            this.btnPrelevaDaTabellaAutomatismi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrelevaDaTabellaAutomatismi.Location = new System.Drawing.Point(772, 283);
            this.btnPrelevaDaTabellaAutomatismi.Name = "btnPrelevaDaTabellaAutomatismi";
            this.btnPrelevaDaTabellaAutomatismi.Size = new System.Drawing.Size(215, 23);
            this.btnPrelevaDaTabellaAutomatismi.TabIndex = 65;
            this.btnPrelevaDaTabellaAutomatismi.Text = "Preleva Da Tabella Automatismi";
            this.btnPrelevaDaTabellaAutomatismi.UseVisualStyleBackColor = true;
            // 
            // txtContoRicavo
            // 
            this.txtContoRicavo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContoRicavo.Location = new System.Drawing.Point(819, 57);
            this.txtContoRicavo.Name = "txtContoRicavo";
            this.txtContoRicavo.ReadOnly = true;
            this.txtContoRicavo.Size = new System.Drawing.Size(100, 20);
            this.txtContoRicavo.TabIndex = 64;
            // 
            // txtCodIva
            // 
            this.txtCodIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodIva.Location = new System.Drawing.Point(819, 88);
            this.txtCodIva.Name = "txtCodIva";
            this.txtCodIva.ReadOnly = true;
            this.txtCodIva.Size = new System.Drawing.Size(100, 20);
            this.txtCodIva.TabIndex = 62;
            // 
            // btnProfilo
            // 
            this.btnProfilo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProfilo.Location = new System.Drawing.Point(585, 154);
            this.btnProfilo.Name = "btnProfilo";
            this.btnProfilo.Size = new System.Drawing.Size(31, 22);
            this.btnProfilo.TabIndex = 57;
            this.btnProfilo.Text = "...";
            this.btnProfilo.UseVisualStyleBackColor = true;
            this.btnProfilo.Click += new System.EventHandler(this.btnProfilo_Click);
            // 
            // btnContoRicavo
            // 
            this.btnContoRicavo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContoRicavo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContoRicavo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnContoRicavo.Location = new System.Drawing.Point(929, 56);
            this.btnContoRicavo.Name = "btnContoRicavo";
            this.btnContoRicavo.Size = new System.Drawing.Size(31, 22);
            this.btnContoRicavo.TabIndex = 58;
            this.btnContoRicavo.Text = "...";
            this.btnContoRicavo.UseVisualStyleBackColor = true;
            this.btnContoRicavo.Click += new System.EventHandler(this.btnContoRicavo_Click);
            // 
            // btnIVA
            // 
            this.btnIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIVA.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIVA.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIVA.Location = new System.Drawing.Point(929, 87);
            this.btnIVA.Name = "btnIVA";
            this.btnIVA.Size = new System.Drawing.Size(31, 22);
            this.btnIVA.TabIndex = 59;
            this.btnIVA.Text = "...";
            this.btnIVA.UseVisualStyleBackColor = true;
            this.btnIVA.Click += new System.EventHandler(this.btnIVA_Click);
            // 
            // btnPrelevaCodice
            // 
            this.btnPrelevaCodice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrelevaCodice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrelevaCodice.Location = new System.Drawing.Point(284, 88);
            this.btnPrelevaCodice.Name = "btnPrelevaCodice";
            this.btnPrelevaCodice.Size = new System.Drawing.Size(31, 22);
            this.btnPrelevaCodice.TabIndex = 60;
            this.btnPrelevaCodice.Text = "...";
            this.btnPrelevaCodice.UseVisualStyleBackColor = true;
            this.btnPrelevaCodice.Click += new System.EventHandler(this.btnPrelevaCodice_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(133, 58);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(96, 20);
            this.txtId.TabIndex = 50;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(133, 89);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(141, 20);
            this.txtCodice.TabIndex = 46;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(132, 121);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(443, 20);
            this.txtDescrizione.TabIndex = 47;
            // 
            // txtProfilo
            // 
            this.txtProfilo.Location = new System.Drawing.Point(133, 155);
            this.txtProfilo.Name = "txtProfilo";
            this.txtProfilo.Size = new System.Drawing.Size(443, 20);
            this.txtProfilo.TabIndex = 48;
            // 
            // txtIdUtente
            // 
            this.txtIdUtente.Location = new System.Drawing.Point(132, 271);
            this.txtIdUtente.Name = "txtIdUtente";
            this.txtIdUtente.ReadOnly = true;
            this.txtIdUtente.Size = new System.Drawing.Size(132, 20);
            this.txtIdUtente.TabIndex = 55;
            // 
            // numPrezzoAnnuale
            // 
            this.numPrezzoAnnuale.DecimalPlaces = 2;
            this.numPrezzoAnnuale.Location = new System.Drawing.Point(442, 192);
            this.numPrezzoAnnuale.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrezzoAnnuale.Name = "numPrezzoAnnuale";
            this.numPrezzoAnnuale.Size = new System.Drawing.Size(113, 20);
            this.numPrezzoAnnuale.TabIndex = 75;
            this.numPrezzoAnnuale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numAttivazione
            // 
            this.numAttivazione.Location = new System.Drawing.Point(133, 192);
            this.numAttivazione.Name = "numAttivazione";
            this.numAttivazione.Size = new System.Drawing.Size(131, 20);
            this.numAttivazione.TabIndex = 76;
            this.numAttivazione.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numAttivazioneSO
            // 
            this.numAttivazioneSO.Location = new System.Drawing.Point(133, 230);
            this.numAttivazioneSO.Name = "numAttivazioneSO";
            this.numAttivazioneSO.Size = new System.Drawing.Size(131, 20);
            this.numAttivazioneSO.TabIndex = 77;
            this.numAttivazioneSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numPrezzoAnnualeSO
            // 
            this.numPrezzoAnnualeSO.DecimalPlaces = 2;
            this.numPrezzoAnnualeSO.Location = new System.Drawing.Point(442, 230);
            this.numPrezzoAnnualeSO.Name = "numPrezzoAnnualeSO";
            this.numPrezzoAnnualeSO.Size = new System.Drawing.Size(113, 20);
            this.numPrezzoAnnualeSO.TabIndex = 78;
            this.numPrezzoAnnualeSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpModifica
            // 
            this.dtpModifica.DateTimeIcon = null;
            this.dtpModifica.Location = new System.Drawing.Point(442, 268);
            this.dtpModifica.Name = "dtpModifica";
            this.dtpModifica.Size = new System.Drawing.Size(113, 24);
            this.dtpModifica.TabIndex = 79;
            this.dtpModifica.ToolTipText = "";
            // 
            // chkNoleggio
            // 
            this.chkNoleggio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNoleggio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkNoleggio.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNoleggio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkNoleggio.Location = new System.Drawing.Point(719, 122);
            this.chkNoleggio.Name = "chkNoleggio";
            this.chkNoleggio.Size = new System.Drawing.Size(114, 24);
            this.chkNoleggio.TabIndex = 80;
            this.chkNoleggio.Text = "A Noleggio:";
            this.chkNoleggio.UseVisualStyleBackColor = true;
            // 
            // FrmContrattiProfili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1019, 561);
            this.Controls.Add(this.chkNoleggio);
            this.Controls.Add(this.dtpModifica);
            this.Controls.Add(this.numPrezzoAnnualeSO);
            this.Controls.Add(this.numAttivazioneSO);
            this.Controls.Add(this.numAttivazione);
            this.Controls.Add(this.numPrezzoAnnuale);
            this.Controls.Add(this.chkRicaricabile);
            this.Controls.Add(this.chkAttivo);
            this.Controls.Add(attivazioneSOLabel);
            this.Controls.Add(attivazioneLabel);
            this.Controls.Add(prezzoAnnualeSOLabel);
            this.Controls.Add(prezzoAnnualeLabel);
            this.Controls.Add(this.btnPrelevaDaTabellaAutomatismi);
            this.Controls.Add(contoRicavoLabel);
            this.Controls.Add(this.txtContoRicavo);
            this.Controls.Add(codIvaLabel);
            this.Controls.Add(this.txtCodIva);
            this.Controls.Add(this.btnProfilo);
            this.Controls.Add(this.btnContoRicavo);
            this.Controls.Add(this.btnIVA);
            this.Controls.Add(this.btnPrelevaCodice);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(codiceLabel);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(descrizioneLabel);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(profiloLabel);
            this.Controls.Add(this.txtProfilo);
            this.Controls.Add(idUtenteLabel);
            this.Controls.Add(this.txtIdUtente);
            this.Controls.Add(dataModificaLabel);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1035, 600);
            this.Name = "FrmContrattiProfili";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profili dei Contratti";
            this.Load += new System.EventHandler(this.FrmContrattiProfili_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProfiliCtr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzoAnnuale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttivazione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttivazioneSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzoAnnualeSO)).EndInit();
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
        private System.Windows.Forms.BindingSource bsProfiliCtr;
        private System.Windows.Forms.CheckBox chkRicaricabile;
        private System.Windows.Forms.CheckBox chkAttivo;
        private System.Windows.Forms.Button btnPrelevaDaTabellaAutomatismi;
        private System.Windows.Forms.TextBox txtContoRicavo;
        private System.Windows.Forms.TextBox txtCodIva;
        private System.Windows.Forms.Button btnProfilo;
        private System.Windows.Forms.Button btnContoRicavo;
        private System.Windows.Forms.Button btnIVA;
        private System.Windows.Forms.Button btnPrelevaCodice;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.TextBox txtProfilo;
        private System.Windows.Forms.TextBox txtIdUtente;
        private System.Windows.Forms.NumericUpDown numPrezzoAnnuale;
        private System.Windows.Forms.NumericUpDown numAttivazione;
        private System.Windows.Forms.NumericUpDown numAttivazioneSO;
        private System.Windows.Forms.NumericUpDown numPrezzoAnnualeSO;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpModifica;
        private System.Windows.Forms.CheckBox chkNoleggio;
    }
}