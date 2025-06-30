namespace KongN
{
    partial class frmUtenti
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label livelloPasswordLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label ultimoCambioPasswordLabel;
            System.Windows.Forms.Label usernameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtenti));
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
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtLvlPass = new System.Windows.Forms.TextBox();
            this.chkPasswordSenzaScadenza = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpUltimoCambioPassword = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnCrypta = new System.Windows.Forms.Button();
            this.btnDecrypta = new System.Windows.Forms.Button();
            this.btnAccessi = new System.Windows.Forms.Button();
            this.btnVediPassword = new System.Windows.Forms.Button();
            this.chkTuttiUtenti = new System.Windows.Forms.CheckBox();
            this.btnEmailCredenziali = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCambiaPassword = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnEmailPersonale = new System.Windows.Forms.Button();
            this.chkSuperuser = new System.Windows.Forms.CheckBox();
            this.btnEsercizio = new System.Windows.Forms.Button();
            this.txtEsercizio = new System.Windows.Forms.TextBox();
            this.bsUtenti = new System.Windows.Forms.BindingSource(this.components);
            emailLabel = new System.Windows.Forms.Label();
            livelloPasswordLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ultimoCambioPasswordLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUtenti)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            emailLabel.Location = new System.Drawing.Point(369, 115);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(50, 19);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Email:";
            // 
            // livelloPasswordLabel
            // 
            livelloPasswordLabel.AutoSize = true;
            livelloPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            livelloPasswordLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            livelloPasswordLabel.Location = new System.Drawing.Point(201, 182);
            livelloPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            livelloPasswordLabel.Name = "livelloPasswordLabel";
            livelloPasswordLabel.Size = new System.Drawing.Size(64, 19);
            livelloPasswordLabel.TabIndex = 23;
            livelloPasswordLabel.Text = "Lvl Pass:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            nomeLabel.Location = new System.Drawing.Point(31, 115);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(54, 19);
            nomeLabel.TabIndex = 24;
            nomeLabel.Text = "Nome:";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            passwordLabel.Location = new System.Drawing.Point(366, 55);
            passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(78, 19);
            passwordLabel.TabIndex = 25;
            passwordLabel.Text = "Password:";
            // 
            // ultimoCambioPasswordLabel
            // 
            ultimoCambioPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ultimoCambioPasswordLabel.AutoSize = true;
            ultimoCambioPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ultimoCambioPasswordLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            ultimoCambioPasswordLabel.Location = new System.Drawing.Point(369, 183);
            ultimoCambioPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ultimoCambioPasswordLabel.Name = "ultimoCambioPasswordLabel";
            ultimoCambioPasswordLabel.Size = new System.Drawing.Size(182, 19);
            ultimoCambioPasswordLabel.TabIndex = 26;
            ultimoCambioPasswordLabel.Text = "Ultimo Cambio Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            usernameLabel.Location = new System.Drawing.Point(29, 55);
            usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(81, 19);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
            this.nav.BackColor = System.Drawing.SystemColors.Window;
            this.nav.BindingSource = this.bsUtenti;
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
            this.btnUndo,
            this.btnSave,
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
            this.nav.Size = new System.Drawing.Size(694, 27);
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
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = global::KongN.Properties.Resources.Search;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 24);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::KongN.Properties.Resources.check;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 24);
            this.btnSave.Text = "toolStripButton1";
            this.btnSave.ToolTipText = "Salva";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::KongN.Properties.Resources.Refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.Text = "Refresh";
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
            // chkAdmin
            // 
            this.chkAdmin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkAdmin.Location = new System.Drawing.Point(435, 266);
            this.chkAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(132, 20);
            this.chkAdmin.TabIndex = 13;
            this.chkAdmin.Text = "Administrator:";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkActive.Location = new System.Drawing.Point(326, 266);
            this.chkActive.Margin = new System.Windows.Forms.Padding(2);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(80, 20);
            this.chkActive.TabIndex = 12;
            this.chkActive.Text = "Active:";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtLvlPass
            // 
            this.txtLvlPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLvlPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLvlPass.Location = new System.Drawing.Point(201, 213);
            this.txtLvlPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtLvlPass.Name = "txtLvlPass";
            this.txtLvlPass.Size = new System.Drawing.Size(65, 27);
            this.txtLvlPass.TabIndex = 8;
            // 
            // chkPasswordSenzaScadenza
            // 
            this.chkPasswordSenzaScadenza.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkPasswordSenzaScadenza.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPasswordSenzaScadenza.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPasswordSenzaScadenza.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkPasswordSenzaScadenza.Location = new System.Drawing.Point(89, 263);
            this.chkPasswordSenzaScadenza.Margin = new System.Windows.Forms.Padding(2);
            this.chkPasswordSenzaScadenza.Name = "chkPasswordSenzaScadenza";
            this.chkPasswordSenzaScadenza.Size = new System.Drawing.Size(212, 27);
            this.chkPasswordSenzaScadenza.TabIndex = 11;
            this.chkPasswordSenzaScadenza.Text = "Password Senza Scadenza:";
            this.chkPasswordSenzaScadenza.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(602, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(89, 20);
            this.txtID.TabIndex = 27;
            // 
            // dtpUltimoCambioPassword
            // 
            this.dtpUltimoCambioPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpUltimoCambioPassword.BackColor = System.Drawing.SystemColors.Window;
            this.dtpUltimoCambioPassword.DateTimeIcon = null;
            this.dtpUltimoCambioPassword.Location = new System.Drawing.Point(371, 213);
            this.dtpUltimoCambioPassword.Name = "dtpUltimoCambioPassword";
            this.dtpUltimoCambioPassword.Size = new System.Drawing.Size(114, 27);
            this.dtpUltimoCambioPassword.TabIndex = 9;
            this.dtpUltimoCambioPassword.ToolTipText = "";
            // 
            // btnCrypta
            // 
            this.btnCrypta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCrypta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrypta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCrypta.Location = new System.Drawing.Point(172, 338);
            this.btnCrypta.Name = "btnCrypta";
            this.btnCrypta.Size = new System.Drawing.Size(70, 27);
            this.btnCrypta.TabIndex = 16;
            this.btnCrypta.Text = "Crypta";
            this.btnCrypta.UseVisualStyleBackColor = true;
            this.btnCrypta.Click += new System.EventHandler(this.btnCrypta_Click);
            // 
            // btnDecrypta
            // 
            this.btnDecrypta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDecrypta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDecrypta.Location = new System.Drawing.Point(172, 378);
            this.btnDecrypta.Name = "btnDecrypta";
            this.btnDecrypta.Size = new System.Drawing.Size(70, 27);
            this.btnDecrypta.TabIndex = 17;
            this.btnDecrypta.Text = "Decrypta";
            this.btnDecrypta.UseVisualStyleBackColor = true;
            this.btnDecrypta.Click += new System.EventHandler(this.btnDecrypta_Click);
            // 
            // btnAccessi
            // 
            this.btnAccessi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccessi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAccessi.Location = new System.Drawing.Point(401, 338);
            this.btnAccessi.Name = "btnAccessi";
            this.btnAccessi.Size = new System.Drawing.Size(133, 27);
            this.btnAccessi.TabIndex = 19;
            this.btnAccessi.Text = "Vedi Accessi";
            this.btnAccessi.UseVisualStyleBackColor = true;
            this.btnAccessi.Click += new System.EventHandler(this.btnAccessi_Click);
            // 
            // btnVediPassword
            // 
            this.btnVediPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVediPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVediPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVediPassword.Location = new System.Drawing.Point(401, 379);
            this.btnVediPassword.Name = "btnVediPassword";
            this.btnVediPassword.Size = new System.Drawing.Size(133, 27);
            this.btnVediPassword.TabIndex = 20;
            this.btnVediPassword.Text = "Vedi Password";
            this.btnVediPassword.UseVisualStyleBackColor = true;
            this.btnVediPassword.Click += new System.EventHandler(this.btnVediPassword_Click);
            // 
            // chkTuttiUtenti
            // 
            this.chkTuttiUtenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTuttiUtenti.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTuttiUtenti.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTuttiUtenti.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkTuttiUtenti.Location = new System.Drawing.Point(547, 339);
            this.chkTuttiUtenti.Margin = new System.Windows.Forms.Padding(2);
            this.chkTuttiUtenti.Name = "chkTuttiUtenti";
            this.chkTuttiUtenti.Size = new System.Drawing.Size(130, 24);
            this.chkTuttiUtenti.TabIndex = 21;
            this.chkTuttiUtenti.Text = "Tutti gli Utenti";
            this.chkTuttiUtenti.UseVisualStyleBackColor = true;
            // 
            // btnEmailCredenziali
            // 
            this.btnEmailCredenziali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEmailCredenziali.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailCredenziali.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmailCredenziali.Location = new System.Drawing.Point(30, 378);
            this.btnEmailCredenziali.Name = "btnEmailCredenziali";
            this.btnEmailCredenziali.Size = new System.Drawing.Size(133, 27);
            this.btnEmailCredenziali.TabIndex = 15;
            this.btnEmailCredenziali.Text = "Invia Credenziali";
            this.btnEmailCredenziali.UseVisualStyleBackColor = true;
            this.btnEmailCredenziali.Click += new System.EventHandler(this.btnEmailCredenziali_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(30, 81);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(294, 27);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Tag = "Cliente";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(368, 81);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(309, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Tag = "Cliente";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(30, 141);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(294, 27);
            this.txtNome.TabIndex = 4;
            this.txtNome.Tag = "Cliente";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(368, 141);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 27);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Tag = "Cliente";
            // 
            // btnCambiaPassword
            // 
            this.btnCambiaPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCambiaPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiaPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCambiaPassword.Location = new System.Drawing.Point(30, 338);
            this.btnCambiaPassword.Name = "btnCambiaPassword";
            this.btnCambiaPassword.Size = new System.Drawing.Size(133, 27);
            this.btnCambiaPassword.TabIndex = 14;
            this.btnCambiaPassword.Text = "Cambia Password";
            this.btnCambiaPassword.UseVisualStyleBackColor = true;
            this.btnCambiaPassword.Click += new System.EventHandler(this.btnCambiaPassword_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel.Location = new System.Drawing.Point(12, 309);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(673, 3);
            this.panel.TabIndex = 28;
            // 
            // btnEmailPersonale
            // 
            this.btnEmailPersonale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEmailPersonale.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailPersonale.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmailPersonale.Location = new System.Drawing.Point(254, 378);
            this.btnEmailPersonale.Name = "btnEmailPersonale";
            this.btnEmailPersonale.Size = new System.Drawing.Size(133, 27);
            this.btnEmailPersonale.TabIndex = 18;
            this.btnEmailPersonale.Text = "Email Personale";
            this.btnEmailPersonale.UseVisualStyleBackColor = true;
            this.btnEmailPersonale.Click += new System.EventHandler(this.btnEmailPersonale_Click);
            // 
            // chkSuperuser
            // 
            this.chkSuperuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSuperuser.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkSuperuser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSuperuser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkSuperuser.Location = new System.Drawing.Point(581, 183);
            this.chkSuperuser.Margin = new System.Windows.Forms.Padding(2);
            this.chkSuperuser.Name = "chkSuperuser";
            this.chkSuperuser.Size = new System.Drawing.Size(96, 49);
            this.chkSuperuser.TabIndex = 10;
            this.chkSuperuser.Text = "Superuser:";
            this.chkSuperuser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSuperuser.UseVisualStyleBackColor = true;
            // 
            // btnEsercizio
            // 
            this.btnEsercizio.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsercizio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEsercizio.Location = new System.Drawing.Point(30, 213);
            this.btnEsercizio.Name = "btnEsercizio";
            this.btnEsercizio.Size = new System.Drawing.Size(78, 27);
            this.btnEsercizio.TabIndex = 6;
            this.btnEsercizio.Text = "Esercizio";
            this.btnEsercizio.UseVisualStyleBackColor = true;
            this.btnEsercizio.Click += new System.EventHandler(this.btnEsercizio_Click);
            // 
            // txtEsercizio
            // 
            this.txtEsercizio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEsercizio.Location = new System.Drawing.Point(114, 213);
            this.txtEsercizio.Name = "txtEsercizio";
            this.txtEsercizio.Size = new System.Drawing.Size(65, 27);
            this.txtEsercizio.TabIndex = 7;
            // 
            // bsUtenti
            // 
            this.bsUtenti.DataSource = typeof(KongN.ClassiTabelle.TabellaUtenti);
            // 
            // frmUtenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(694, 424);
            this.Controls.Add(this.txtEsercizio);
            this.Controls.Add(this.btnEsercizio);
            this.Controls.Add(this.chkSuperuser);
            this.Controls.Add(this.btnEmailPersonale);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnCambiaPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnEmailCredenziali);
            this.Controls.Add(this.chkTuttiUtenti);
            this.Controls.Add(this.btnVediPassword);
            this.Controls.Add(this.btnAccessi);
            this.Controls.Add(this.btnDecrypta);
            this.Controls.Add(this.btnCrypta);
            this.Controls.Add(this.dtpUltimoCambioPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(livelloPasswordLabel);
            this.Controls.Add(this.txtLvlPass);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.chkPasswordSenzaScadenza);
            this.Controls.Add(ultimoCambioPasswordLabel);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(710, 463);
            this.Name = "frmUtenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utenti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUtenti_FormClosed);
            this.Load += new System.EventHandler(this.frmUtenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUtenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator nav;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPreviews;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtLvlPass;
        private System.Windows.Forms.CheckBox chkPasswordSenzaScadenza;
        private System.Windows.Forms.BindingSource bsUtenti;
        private System.Windows.Forms.TextBox txtID;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpUltimoCambioPassword;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.Button btnCrypta;
        private System.Windows.Forms.Button btnDecrypta;
        private System.Windows.Forms.Button btnAccessi;
        private System.Windows.Forms.Button btnVediPassword;
        private System.Windows.Forms.CheckBox chkTuttiUtenti;
        private System.Windows.Forms.Button btnEmailCredenziali;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCambiaPassword;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnEmailPersonale;
        private System.Windows.Forms.CheckBox chkSuperuser;
        private System.Windows.Forms.Button btnEsercizio;
        private System.Windows.Forms.TextBox txtEsercizio;
    }
}