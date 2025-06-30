namespace KongN.Agenda
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsAgenda = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPreviews = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnADD = new System.Windows.Forms.ToolStripButton();
            this.btnEDIT = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnPassaAStorico = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generatoDaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInserimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInizioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUtenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataModificaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
            this.nav.BindingSource = this.bsAgenda;
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
            this.btnADD,
            this.btnEDIT,
            this.btnDelete,
            this.btnSearch,
            this.btnSave,
            this.btnUndo,
            this.btnRefresh,
            this.btnPassaAStorico,
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
            this.nav.TabIndex = 1;
            // 
            // bsAgenda
            // 
            this.bsAgenda.DataSource = typeof(KongN.ClassiTabelle.Agenda);
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
            // btnADD
            // 
            this.btnADD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnADD.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.Image")));
            this.btnADD.Name = "btnADD";
            this.btnADD.RightToLeftAutoMirrorImage = true;
            this.btnADD.Size = new System.Drawing.Size(24, 24);
            this.btnADD.Text = "Aggiungi nuovo";
            this.btnADD.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEDIT.Image = global::KongN.Properties.Resources.Modify;
            this.btnEDIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(24, 24);
            this.btnEDIT.ToolTipText = "Modifica";
            this.btnEDIT.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnSave.ToolTipText = "Salva";
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = global::KongN.Properties.Resources.Annulla;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(24, 24);
            this.btnUndo.ToolTipText = "Annulla";
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
            // btnPassaAStorico
            // 
            this.btnPassaAStorico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPassaAStorico.Image = global::KongN.Properties.Resources.file;
            this.btnPassaAStorico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPassaAStorico.Name = "btnPassaAStorico";
            this.btnPassaAStorico.Size = new System.Drawing.Size(24, 24);
            this.btnPassaAStorico.Text = "toolStripButton1";
            this.btnPassaAStorico.ToolTipText = "Passa a Storico gli eventi Conclusi";
            this.btnPassaAStorico.Click += new System.EventHandler(this.btnEsclusione_Click);
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
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titoloDataGridViewTextBoxColumn,
            this.internoDataGridViewTextBoxColumn,
            this.codiceDataGridViewTextBoxColumn,
            this.denomDataGridViewTextBoxColumn,
            this.generatoDaDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn,
            this.dataInserimentoDataGridViewTextBoxColumn,
            this.dataInizioDataGridViewTextBoxColumn,
            this.dataFineDataGridViewTextBoxColumn,
            this.conclusoDataGridViewTextBoxColumn,
            this.iDUtenteDataGridViewTextBoxColumn,
            this.dataModificaDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bsAgenda;
            this.dgv.Location = new System.Drawing.Point(0, 57);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(842, 392);
            this.dgv.TabIndex = 40;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titoloDataGridViewTextBoxColumn
            // 
            this.titoloDataGridViewTextBoxColumn.DataPropertyName = "Titolo";
            this.titoloDataGridViewTextBoxColumn.HeaderText = "Titolo";
            this.titoloDataGridViewTextBoxColumn.Name = "titoloDataGridViewTextBoxColumn";
            this.titoloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // internoDataGridViewTextBoxColumn
            // 
            this.internoDataGridViewTextBoxColumn.DataPropertyName = "Interno";
            this.internoDataGridViewTextBoxColumn.HeaderText = "Interno";
            this.internoDataGridViewTextBoxColumn.Name = "internoDataGridViewTextBoxColumn";
            this.internoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codiceDataGridViewTextBoxColumn
            // 
            this.codiceDataGridViewTextBoxColumn.DataPropertyName = "Codice";
            this.codiceDataGridViewTextBoxColumn.HeaderText = "Codice";
            this.codiceDataGridViewTextBoxColumn.Name = "codiceDataGridViewTextBoxColumn";
            this.codiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denomDataGridViewTextBoxColumn
            // 
            this.denomDataGridViewTextBoxColumn.DataPropertyName = "Denom";
            this.denomDataGridViewTextBoxColumn.HeaderText = "Denom";
            this.denomDataGridViewTextBoxColumn.Name = "denomDataGridViewTextBoxColumn";
            this.denomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generatoDaDataGridViewTextBoxColumn
            // 
            this.generatoDaDataGridViewTextBoxColumn.DataPropertyName = "GeneratoDa";
            this.generatoDaDataGridViewTextBoxColumn.HeaderText = "GeneratoDa";
            this.generatoDaDataGridViewTextBoxColumn.Name = "generatoDaDataGridViewTextBoxColumn";
            this.generatoDaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            this.descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInserimentoDataGridViewTextBoxColumn
            // 
            this.dataInserimentoDataGridViewTextBoxColumn.DataPropertyName = "DataInserimento";
            this.dataInserimentoDataGridViewTextBoxColumn.HeaderText = "DataInserimento";
            this.dataInserimentoDataGridViewTextBoxColumn.Name = "dataInserimentoDataGridViewTextBoxColumn";
            this.dataInserimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInizioDataGridViewTextBoxColumn
            // 
            this.dataInizioDataGridViewTextBoxColumn.DataPropertyName = "DataInizio";
            this.dataInizioDataGridViewTextBoxColumn.HeaderText = "DataInizio";
            this.dataInizioDataGridViewTextBoxColumn.Name = "dataInizioDataGridViewTextBoxColumn";
            this.dataInizioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFineDataGridViewTextBoxColumn
            // 
            this.dataFineDataGridViewTextBoxColumn.DataPropertyName = "DataFine";
            this.dataFineDataGridViewTextBoxColumn.HeaderText = "DataFine";
            this.dataFineDataGridViewTextBoxColumn.Name = "dataFineDataGridViewTextBoxColumn";
            this.dataFineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conclusoDataGridViewTextBoxColumn
            // 
            this.conclusoDataGridViewTextBoxColumn.DataPropertyName = "Concluso";
            this.conclusoDataGridViewTextBoxColumn.HeaderText = "Concluso";
            this.conclusoDataGridViewTextBoxColumn.Name = "conclusoDataGridViewTextBoxColumn";
            this.conclusoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDUtenteDataGridViewTextBoxColumn
            // 
            this.iDUtenteDataGridViewTextBoxColumn.DataPropertyName = "iDUtente";
            this.iDUtenteDataGridViewTextBoxColumn.HeaderText = "iDUtente";
            this.iDUtenteDataGridViewTextBoxColumn.Name = "iDUtenteDataGridViewTextBoxColumn";
            this.iDUtenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataModificaDataGridViewTextBoxColumn
            // 
            this.dataModificaDataGridViewTextBoxColumn.DataPropertyName = "DataModifica";
            this.dataModificaDataGridViewTextBoxColumn.HeaderText = "DataModifica";
            this.dataModificaDataGridViewTextBoxColumn.Name = "dataModificaDataGridViewTextBoxColumn";
            this.dataModificaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 41;
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(842, 449);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(858, 488);
            this.Name = "FrmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgenda)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnADD;
        private System.Windows.Forms.ToolStripButton btnEDIT;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnPassaAStorico;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.BindingSource bsAgenda;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generatoDaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInserimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInizioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUtenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataModificaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtId;
    }
}