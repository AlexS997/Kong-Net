using KongN.Classi;
using System;
using System.Data;
using System.Windows.Forms;
using KongN.Funzioni;
using Syncfusion.WinForms.Input;
using KongN.Find;
using System.Collections.Generic;
using KongN.Stampa;
using System.Drawing;


namespace KongN
{
    public partial class frmAntivirus : Form
    {

        private int _iDAntivirus = 0;
        private bool isUndoAction = false;

        ButtonManager _buttonManager;

        public string Table = "Antivirus";
        // Declare a ClsTableSchema object
        private ClsTableSchema _tableSchema;
        SQLControl Antivirus = new SQLControl(Global.connKongN);
        
        public frmAntivirus()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void frmAntivirus_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();

            //ReadOnlyControls(true);

            // Initialize ClsTableSchema with the connection and name of the table
            _tableSchema = new ClsTableSchema(Global.connKongN, Table);
            ClsMaxLenght maxLengthSetter = new ClsMaxLenght();

            // We call the SetMaxLength method and give it the table schema as a parameter
            maxLengthSetter.SetMaxLength(this, _tableSchema);
        }


        private void LoadData()
        {

            SQLControl Antivirus = new SQLControl(Global.connKongN);
            string query = "SELECT * FROM Antivirus ORDER BY Cliente";

            Antivirus.ExecQuery(query);

            if (Antivirus.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Antivirus.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClsFunzioni.FillComboBox("SELECT * FROM AntivirusMarche order by Antivirus", "ID", "Antivirus", cboMarca);
            

            if (Antivirus.DBDT.Rows.Count > 0)
            {
                LeggiCampi(Antivirus.DBDT);

            }

            bsAntivirus.DataSource = Antivirus.DBDT;

            txtiD.Visible = false;
            txtiDUtente.Visible = false;
            ReadOnlyControls(true);
        }

        public void LeggiCampi(DataTable antivirus)
        {
            txtCap.Text = antivirus.Rows[0]["Cap"].ToString();
            txtCitta.Text = antivirus.Rows[0]["Citta"].ToString();
            txtCliente.Text = antivirus.Rows[0]["Cliente"].ToString();
            txtCodiceAntivirus.Text = antivirus.Rows[0]["CodiceAntivirus"].ToString();
            txtCodiceKing.Text = antivirus.Rows[0]["CodiceKing"].ToString();
            txtEmail.Text = antivirus.Rows[0]["Email"].ToString();
            txtiD.Text = antivirus.Rows[0]["iD"].ToString();
            txtiDUtente.Text = antivirus.Rows[0]["iDUtente"].ToString();

            // se il campo è vuoto mette 0 altrimenti il valore
            // con il metodo ternario

            antivirus.Rows[0]["Importo"] = antivirus.Rows[0]["Importo"] == DBNull.Value ? antivirus.Rows[0]["Importo"] = 0 : antivirus.Rows[0]["Importo"];



            numImporto.Value = Convert.ToDecimal(antivirus.Rows[0]["Importo"]);
            txtIndirizzo.Text = antivirus.Rows[0]["Indirizzo"].ToString();
            txtNote.Text = antivirus.Rows[0]["Note"].ToString();
            numPostazioni.Value = Convert.ToInt32(antivirus.Rows[0]["Postazioni"]) ;
            txtPr.Text = antivirus.Rows[0]["Pr"].ToString();
            txtTel2.Text = antivirus.Rows[0]["Tel2"].ToString();
            txtTelefono.Text = antivirus.Rows[0]["Telefono"].ToString();

            // se il campo dtpDataacquisto è vuoto mette a null altrimenti il valore con il metodo ternario
            dtpDataAcquisto.Value = antivirus.Rows[0]["DataAcquisto"] == DBNull.Value ? dtpDataAcquisto.Value = null : Convert.ToDateTime(antivirus.Rows[0]["DataAcquisto"].ToString());

            //// fa la stessa cosa per il campo dtpDataScadenza e dtpDataRinnovo
            dtpDataScadenza.Value = antivirus.Rows[0]["DataScadenza"] == DBNull.Value ? dtpDataScadenza.Value = null : Convert.ToDateTime(antivirus.Rows[0]["DataScadenza"].ToString());

            dtpDataRinnovo.Value = antivirus.Rows[0]["DataRinnovo"] == DBNull.Value ? dtpDataRinnovo.Value = null : Convert.ToDateTime(antivirus.Rows[0]["DataRinnovo"].ToString());


            // prende il valore idmarca dalla tabella antivirus e lo assegna al combobox


            cboMarca.SelectedValue = antivirus.Rows[0]["iDMarca"];
        

        }

        public void AbbinaCampi()
        {
            txtCap.DataBindings.Add("Text", bsAntivirus, "Cap");
            txtCitta.DataBindings.Add("Text", bsAntivirus, "Citta");
            txtCliente.DataBindings.Add("Text", bsAntivirus, "Cliente");
            txtCodiceKing.DataBindings.Add("Text", bsAntivirus, "CodiceKing");
            txtEmail.DataBindings.Add("Text", bsAntivirus, "Email");
            txtiD.DataBindings.Add("Text", bsAntivirus, "iD");
            txtiDUtente.DataBindings.Add("Text", bsAntivirus, "iDUtente");
            numImporto.DataBindings.Add("Text", bsAntivirus, "Importo");
            txtIndirizzo.DataBindings.Add("Text", bsAntivirus, "Indirizzo");
            txtNote.DataBindings.Add("Text", bsAntivirus, "Note");
            numPostazioni.DataBindings.Add("Text", bsAntivirus, "Postazioni");
            txtPr.DataBindings.Add("Text", bsAntivirus, "Pr");
            txtTel2.DataBindings.Add("Text", bsAntivirus, "Tel2");
            txtTelefono.DataBindings.Add("Text", bsAntivirus, "Telefono");
            txtCodiceAntivirus.DataBindings.Add("Text", bsAntivirus, "CodiceAntivirus");

            dtpDataAcquisto.DataBindings.Add("Value", bsAntivirus, "DataAcquisto",
                                    true, // 'FormattingEnabled' - true allows the default formatting of the data
                                    DataSourceUpdateMode.OnPropertyChanged, //The data source will be updated every time the value in the control changes
                                    null, //'NullValue' - if the value in the control is null, it will be reflected as DBNull.Value in the data source
                                    "dd-MM-yyyy"); //'Format' - defines the date format

            dtpDataScadenza.DataBindings.Add("Value", bsAntivirus, "DataScadenza", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd-MM-yyyy");
            dtpDataRinnovo.DataBindings.Add("Value", bsAntivirus, "DataRinnovo", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd-MM-yyyy");
            cboMarca.DataBindings.Add("SelectedValue", bsAntivirus, "iDMarca");

        }

        public bool Check()
        {
            bool result = true;

            // controlla che tutti i campi di testo eccetto txtCodiceKing  e txt note siano compilati
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Name != "txtCodiceKing" && ((TextBox)c).Name != "txtNote" && ((TextBox)c).Name != "txtTel2" 
                        && ((TextBox)c).Name != "txtiD" && ((TextBox)c).Name != "txtiDUtente")
                    {
                        if (((TextBox)c).Text == "")
                        {
                            MessageBox.Show("Il campo " + ((TextBox)c).Tag + " è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ((TextBox)c).Focus();
                            result = false;
                            return result;
                            
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(txtCodiceKing.Text))
            {
                txtCodiceKing.Text = "0";
            }
            
            // controlla che txtemail sia un indirizzo email valido
            EmailCheck emailCheck = new EmailCheck();
            if (emailCheck.IsValidEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Formato Email non valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                result = false;
                return result;
            }

            // controlla che la data di acquisto sia minore o uguale alla data di scadenza
            //if (dtpDataAcquisto.Value > dtpDataScadenza.Value || dtpDataAcquisto.Value == null)
            //{
            //    MessageBox.Show("La data di acquisto non può essere maggiore della data di scadenza o non può essere vuota.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    result = false;
            //    return result;
            //}


            // controlla che numPostazioni sia maggiore di 0
            if (numPostazioni.Value == 0)
            {
                MessageBox.Show("Il campo Postazioni deve essere maggiore di 0.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }
            //controlla che numImporto sia maggiore di 0
            if (numImporto.Value == 0)
            {
                MessageBox.Show("Il campo Importo deve essere maggiore di 0.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            // controlla che cbomarca abbia un valore selezionato
            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Il campo Marca è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            return result;
        }

        public void ReadOnlyControls(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }
                if (c is SfDateTimeEdit)
                {
                    ((SfDateTimeEdit)c).Enabled = !x;
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Enabled = !x;
                    ((NumericUpDown)c).ReadOnly = x;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Enabled = !x;
                }
                if (c is Button)
                {
                    ((Button)c).Enabled = !x;
                }
            }
        }

        private void ClearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if(c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                if(c is SfDateTimeEdit)
                {
                    ((SfDateTimeEdit)c).Value = null;
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
            }
            
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // chiede conferma per l'eliminazione
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete From Antivirus Where iD = @iD";
            Antivirus.AddParam("@iD", txtiD.Text);
            Antivirus.ExecQuery(query);

            if (Antivirus.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Antivirus.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);



            LoadData();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //isAddNewClicked = true;
            ReadOnlyControls(false);
            btnRinnova.Enabled = false;
            dgv.Enabled = false;

            ClearFields();

           

            _iDAntivirus = 0;
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            dgv.Enabled = false;
            _iDAntivirus = Convert.ToInt32(txtiD.Text);
            _buttonManager.HandleButtonClick((ToolStripButton)sender);

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            isUndoAction = true;

            if (_iDAntivirus != 0)
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtiD.Text); //bsAntivirus.Find("iD", _iDAntivirus);
                ClearFields();
                LoadData();
                //bsAntivirus.Position = pos;
                bsAntivirus.Find("iD", pos);
                ReadOnlyControls(true);
            }
            else
            {                
                LoadData();
            }

            isUndoAction = false;
            dgv.Enabled = true;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            string query = "Select * from Clienti Order By CodCli";
            SQLControl Clienti = new SQLControl(Global.connAna);
            Clienti.ExecQuery(query);

            if (Clienti.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Clienti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = Clienti.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                // riporta i campi prendendoli da frm._ReturnData

                txtCodiceKing.Text = frm._ReturnData["CodCli"].ToString();
                txtCliente.Text = frm._ReturnData["Denom"].ToString();
                txtCap.Text = frm._ReturnData["Cap"].ToString();
                txtCitta.Text = frm._ReturnData["Loc"].ToString();
                txtIndirizzo.Text = frm._ReturnData["Ind"].ToString();
                txtPr.Text = frm._ReturnData["Prov"].ToString();
                txtTelefono.Text = frm._ReturnData["Tel"].ToString();
                txtTel2.Text = frm._ReturnData["Tel2"].ToString();
                txtEmail.Text = frm._ReturnData["Email"].ToString();


                //txtCodiceKing.Text = frm._DVRitorno[0]["CodCLi"].ToString();
                //txtCliente.Text = frm._DVRitorno[0]["Denom"].ToString();
                //txtCap.Text = frm._DVRitorno[0]["Cap"].ToString();
                //txtCitta.Text = frm._DVRitorno[0]["Loc"].ToString();
                //txtIndirizzo.Text = frm._DVRitorno[0]["Ind"].ToString();
                //txtPr.Text = frm._DVRitorno[0]["Prov"].ToString();
                //txtTelefono.Text = frm._DVRitorno[0]["Tel"].ToString();
                //txtTel2.Text = frm._DVRitorno[0]["Tel2"].ToString();
                //txtEmail.Text = frm._DVRitorno[0]["Email"].ToString();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "Select * from Antivirus Order By DataScadenza,Cliente";

            Antivirus.ExecQuery(query);

            if (Antivirus.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Antivirus.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormFind frm = new FormFind();
            frm._DT = Antivirus.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {

                int id = Convert.ToInt32(frm._ReturnData["iD"]);


                var r = bsAntivirus.Find("iD", id);

                // si sposta sulla riga trovata
                bsAntivirus.Position = r;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (Check() == false)
            {

                return;
            }


            string query = "";

            if (_iDAntivirus == 0)
            {
                

                query = @"Insert Into Antivirus (Cliente, CodiceKing, Indirizzo, Cap, Citta, Pr, Telefono, Tel2, Email,
                            iDMarca, CodiceAntivirus, Postazioni, Importo, DataAcquisto, DataScadenza, DataRinnovo, Note, DataModifica, iDUtente) 
                        Values (@Cliente, @CodiceKing, @Indirizzo, @Cap, @Citta, @Pr, @Telefono, @Tel2, @Email,
                            @iDMarca, @CodiceAntivirus, @Postazioni, @Importo, @DataAcquisto, @DataScadenza , @DataRinnovo, " +
                            "@Note, '" + DateTime.Now + "' , '" + Global.ID + "')";
            }
            else
            {
                query = @"Update Antivirus Set Cliente = @Cliente, CodiceKing = @CodiceKing, Indirizzo = @Indirizzo, Cap = @Cap, Citta = @Citta, Pr = @Pr, 
                            Telefono = @Telefono, Tel2 = @Tel2, Email = @Email, iDMarca = @iDMarca, CodiceAntivirus = @CodiceAntivirus, Postazioni = @Postazioni,
                            Importo = @Importo, DataAcquisto = @DataAcquisto, DataScadenza = @DataScadenza, DataRinnovo = @DataRinnovo, Note = @Note, 
                            DataModifica = '" + DateTime.Now + "', iDUtente = '" + Global.ID + "' Where iD = @iD";
            }

            Antivirus.AddParam("@Cliente", txtCliente.Text);
            Antivirus.AddParam("@CodiceKing", txtCodiceKing.Text);
            Antivirus.AddParam("@Indirizzo", txtIndirizzo.Text);
            Antivirus.AddParam("@Cap", txtCap.Text);
            Antivirus.AddParam("@Citta", txtCitta.Text);
            Antivirus.AddParam("@Pr", txtPr.Text);
            Antivirus.AddParam("@Telefono", txtTelefono.Text);
            Antivirus.AddParam("@Tel2", txtTel2.Text);
            Antivirus.AddParam("@Email", txtEmail.Text);
            Antivirus.AddParam("@iDMarca", cboMarca.SelectedValue);
            Antivirus.AddParam("@CodiceAntivirus", txtCodiceAntivirus.Text);
            Antivirus.AddParam("@Postazioni", numPostazioni.Value);
            Antivirus.AddParam("@Importo", numImporto.Value);
            Antivirus.AddParam("@DataAcquisto", dtpDataAcquisto.Value);
            Antivirus.AddParam("@DataScadenza", dtpDataScadenza.Value);
            Antivirus.AddParam("@DataRinnovo", dtpDataRinnovo.Value);
            Antivirus.AddParam("@Note", txtNote.Text);
            Antivirus.AddParam("@iD", txtiD.Text);


            Antivirus.ExecQuery(query);

            if (Antivirus.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Antivirus.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            LoadData();
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
            dgv.Enabled = true;

        }

        private void btnRinnova_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler rinnovare l'antivirus?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }


            dtpDataRinnovo.Value = DateTime.Now;
            dtpDataScadenza.Value = DateTime.Now.AddYears(1).AddDays(-1);
            

            MessageBox.Show("Antivirus rinnovato correttamente.", "Rinnovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtpDataRinnovo.Enabled = false;
            dtpDataScadenza.Enabled = false;

        }

     
       
        private void UpdateImporto()
        {
            
            string query = "SELECT P" + numPostazioni.Value + " FROM AntivirusMarche WHERE Antivirus = @Antivirus";

            Antivirus.AddParam("@Antivirus", cboMarca.Text.ToString());

            Antivirus.ExecQuery(query);


            if (Antivirus.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dell'importo per la marca.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Antivirus.DBDT.Rows.Count > 0)
            {
                numImporto.Value = Convert.ToDecimal(Antivirus.DBDT.Rows[0][0].ToString());
            }
            else
            {
                numImporto.Value = 0;
            }
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {

            // se le postazioni sono maggiori di zero e il cbomarca contiene qualcosa allora prosegue altrimenti esce
            if (numPostazioni.Value == 0 || cboMarca.Text == "")
            {
               
                return;
            }

            //se numPostazioni è maggiore di 10 e il cbomarca contiene qualcosa non effettua il calcolo

            if (numPostazioni.Value > 10 && cboMarca.Text != "")
            {
                MessageBox.Show("Il calcolo dell'importo non è possibile per più di 10 postazioni. Inseriscilo manualmente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler Ricalcolare?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            UpdateImporto();

        }

        private void dtpDataAcquisto_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            // aumenta la data di scadenza di un anno rispetto alla data di acquisto
            // solo se siamo in aggiunta di un nuovo record
            if (_iDAntivirus == 0)
            {
                if (dtpDataAcquisto.Value.HasValue)
                {
                    dtpDataScadenza.Value = dtpDataAcquisto.Value.Value.AddYears(1).AddDays(-1);
                    dtpDataRinnovo.Value = dtpDataAcquisto.Value; 
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ReadOnlyControls(true);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string query = "SELECT A.Cliente, A.CodiceKing, A.Indirizzo, A.Cap, A.Citta, A.Pr, A.Telefono, A.Tel2, A.Email, A1.Antivirus, A.CodiceAntivirus, A.Postazioni,";
                query += " A.DataAcquisto, A.DataRinnovo, A.DataScadenza, A.Importo, A.Note FROM Antivirus A INNER JOIN AntivirusMarche A1 ON A.iDMarca = A1.iD " +

                " ORDER BY A.Cliente Asc, A.DataScadenza Desc";
            Antivirus.ExecQuery(query);

            if (Antivirus.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Antivirus.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = new DataTable();
            dt = Antivirus.DBDT;

            // verifica se ci sono dati nel datatable
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Non ci sono dati per generare il rapporto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // crea un nuovo report
            // Crea un dizionario di parametri
            var parameters = new Dictionary<string, object>
             {
                { "ReportTitle", "Antivirus" },
                 { "Param2", 123 }
             };
            // Crea un'istanza della form Stampa e passa i parametri

            
            // crea una variabile stringa che contiene dove sono gli eseguibili

            string path = Application.StartupPath;
            // crea una variabile stringa che contiene il percorso del report
            string reportPath = path + @"\Reports\";
            string reportName = "Antivirus.frx";



            FormStampa stampa = new FormStampa(dt, reportPath, reportName, "Table", parameters);



            // Mostra il report
            stampa.ShowReport();

        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
