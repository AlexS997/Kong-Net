namespace KongN.SMS
{
    partial class FrmGestioneSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestioneSMS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsSMS = new System.Windows.Forms.BindingSource(this.components);
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
            this.lblRecord = new System.Windows.Forms.Label();
            this.chkConclusi = new System.Windows.Forms.CheckBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnStorico = new System.Windows.Forms.Button();
            this.btnElabora = new System.Windows.Forms.Button();
            this.btnElaborato = new System.Windows.Forms.Button();
            this.chkElaborato = new System.Windows.Forms.CheckBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messaggioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elaboratoDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idSmsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDetailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMessaggioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nav)).BeginInit();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // nav
            // 
            this.nav.AddNewItem = null;
            this.nav.BindingSource = this.bsSMS;
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
            this.nav.Size = new System.Drawing.Size(837, 27);
            this.nav.TabIndex = 0;
            // 
            // bsSMS
            // 
            this.bsSMS.DataSource = typeof(KongN.ClassiTabelle.Sms);
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
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::KongN.Properties.Resources.Modify;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(24, 24);
            this.btnEdit.ToolTipText = "Modifica";
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
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecord.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRecord.Location = new System.Drawing.Point(377, 58);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(184, 23);
            this.lblRecord.TabIndex = 1;
            this.lblRecord.Text = "Record estratti :";
            // 
            // chkConclusi
            // 
            this.chkConclusi.AutoSize = true;
            this.chkConclusi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConclusi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkConclusi.Location = new System.Drawing.Point(25, 56);
            this.chkConclusi.Name = "chkConclusi";
            this.chkConclusi.Size = new System.Drawing.Size(124, 22);
            this.chkConclusi.TabIndex = 2;
            this.chkConclusi.Text = "Anche Elaborati";
            this.chkConclusi.UseVisualStyleBackColor = true;
            this.chkConclusi.CheckedChanged += new System.EventHandler(this.chkConclusi_CheckedChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(25, 82);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 6;
            // 
            // btnStorico
            // 
            this.btnStorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStorico.Location = new System.Drawing.Point(669, 54);
            this.btnStorico.Name = "btnStorico";
            this.btnStorico.Size = new System.Drawing.Size(73, 31);
            this.btnStorico.TabIndex = 4;
            this.btnStorico.Text = "Storico";
            this.btnStorico.UseVisualStyleBackColor = true;
            this.btnStorico.Click += new System.EventHandler(this.btnStorico_Click);
            // 
            // btnElabora
            // 
            this.btnElabora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElabora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElabora.ForeColor = System.Drawing.Color.Green;
            this.btnElabora.Location = new System.Drawing.Point(748, 54);
            this.btnElabora.Name = "btnElabora";
            this.btnElabora.Size = new System.Drawing.Size(73, 31);
            this.btnElabora.TabIndex = 5;
            this.btnElabora.Text = "Elabora";
            this.btnElabora.UseVisualStyleBackColor = true;
            this.btnElabora.Click += new System.EventHandler(this.btnElabora_Click);
            // 
            // btnElaborato
            // 
            this.btnElaborato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElaborato.Location = new System.Drawing.Point(590, 54);
            this.btnElaborato.Name = "btnElaborato";
            this.btnElaborato.Size = new System.Drawing.Size(73, 31);
            this.btnElaborato.TabIndex = 3;
            this.btnElaborato.Text = "Elaborato";
            this.btnElaborato.UseVisualStyleBackColor = true;
            this.btnElaborato.Click += new System.EventHandler(this.btnElaborato_Click);
            // 
            // chkElaborato
            // 
            this.chkElaborato.AutoSize = true;
            this.chkElaborato.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkElaborato.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkElaborato.Location = new System.Drawing.Point(135, 85);
            this.chkElaborato.Name = "chkElaborato";
            this.chkElaborato.Size = new System.Drawing.Size(15, 14);
            this.chkElaborato.TabIndex = 7;
            this.chkElaborato.UseVisualStyleBackColor = true;
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
            this.numeroDataGridViewTextBoxColumn1,
            this.messaggioDataGridViewTextBoxColumn1,
            this.elaboratoDataGridViewCheckBoxColumn1,
            this.idSmsDataGridViewTextBoxColumn1,
            this.statoDataGridViewTextBoxColumn1,
            this.statusDetailDataGridViewTextBoxColumn1,
            this.dataDataGridViewTextBoxColumn1,
            this.tipoMessaggioDataGridViewTextBoxColumn1,
            this.codiceDataGridViewTextBoxColumn1,
            this.denomDataGridViewTextBoxColumn1});
            this.dgv.DataSource = this.bsSMS;
            this.dgv.Location = new System.Drawing.Point(0, 108);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(837, 402);
            this.dgv.TabIndex = 8;
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // numeroDataGridViewTextBoxColumn1
            // 
            this.numeroDataGridViewTextBoxColumn1.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn1.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn1.Name = "numeroDataGridViewTextBoxColumn1";
            this.numeroDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // messaggioDataGridViewTextBoxColumn1
            // 
            this.messaggioDataGridViewTextBoxColumn1.DataPropertyName = "Messaggio";
            this.messaggioDataGridViewTextBoxColumn1.HeaderText = "Messaggio";
            this.messaggioDataGridViewTextBoxColumn1.Name = "messaggioDataGridViewTextBoxColumn1";
            this.messaggioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // elaboratoDataGridViewCheckBoxColumn1
            // 
            this.elaboratoDataGridViewCheckBoxColumn1.DataPropertyName = "Elaborato";
            this.elaboratoDataGridViewCheckBoxColumn1.HeaderText = "Elaborato";
            this.elaboratoDataGridViewCheckBoxColumn1.Name = "elaboratoDataGridViewCheckBoxColumn1";
            this.elaboratoDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // idSmsDataGridViewTextBoxColumn1
            // 
            this.idSmsDataGridViewTextBoxColumn1.DataPropertyName = "Id_Sms";
            this.idSmsDataGridViewTextBoxColumn1.HeaderText = "Id_Sms";
            this.idSmsDataGridViewTextBoxColumn1.Name = "idSmsDataGridViewTextBoxColumn1";
            this.idSmsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statoDataGridViewTextBoxColumn1
            // 
            this.statoDataGridViewTextBoxColumn1.DataPropertyName = "Stato";
            this.statoDataGridViewTextBoxColumn1.HeaderText = "Stato";
            this.statoDataGridViewTextBoxColumn1.Name = "statoDataGridViewTextBoxColumn1";
            this.statoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statusDetailDataGridViewTextBoxColumn1
            // 
            this.statusDetailDataGridViewTextBoxColumn1.DataPropertyName = "StatusDetail";
            this.statusDetailDataGridViewTextBoxColumn1.HeaderText = "StatusDetail";
            this.statusDetailDataGridViewTextBoxColumn1.Name = "statusDetailDataGridViewTextBoxColumn1";
            this.statusDetailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            this.dataDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tipoMessaggioDataGridViewTextBoxColumn1
            // 
            this.tipoMessaggioDataGridViewTextBoxColumn1.DataPropertyName = "TipoMessaggio";
            this.tipoMessaggioDataGridViewTextBoxColumn1.HeaderText = "TipoMessaggio";
            this.tipoMessaggioDataGridViewTextBoxColumn1.Name = "tipoMessaggioDataGridViewTextBoxColumn1";
            this.tipoMessaggioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // codiceDataGridViewTextBoxColumn1
            // 
            this.codiceDataGridViewTextBoxColumn1.DataPropertyName = "Codice";
            this.codiceDataGridViewTextBoxColumn1.HeaderText = "Codice";
            this.codiceDataGridViewTextBoxColumn1.Name = "codiceDataGridViewTextBoxColumn1";
            this.codiceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // denomDataGridViewTextBoxColumn1
            // 
            this.denomDataGridViewTextBoxColumn1.DataPropertyName = "Denom";
            this.denomDataGridViewTextBoxColumn1.HeaderText = "Denom";
            this.denomDataGridViewTextBoxColumn1.Name = "denomDataGridViewTextBoxColumn1";
            this.denomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FrmGestioneSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(837, 509);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.chkElaborato);
            this.Controls.Add(this.btnElabora);
            this.Controls.Add(this.btnElaborato);
            this.Controls.Add(this.btnStorico);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.chkConclusi);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.nav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(853, 548);
            this.Name = "FrmGestioneSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione SMS";
            this.Load += new System.EventHandler(this.FrmGestioneSMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nav)).EndInit();
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSMS)).EndInit();
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
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.CheckBox chkConclusi;
        private System.Windows.Forms.BindingSource bsSMS;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnStorico;
        private System.Windows.Forms.Button btnElabora;
        private System.Windows.Forms.Button btnElaborato;
        private System.Windows.Forms.CheckBox chkElaborato;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messaggioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn elaboratoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSmsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDetailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMessaggioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn denomDataGridViewTextBoxColumn1;
    }
}