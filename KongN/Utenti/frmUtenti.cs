using KongN.Classi;
using KongN.Find;
using KongN.Utenti;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace KongN
{
    public partial class frmUtenti : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        SQLControl connAna = new SQLControl(Global.connAna);
        public Dictionary<string, string> ParametriSMTP = new Dictionary<string, string>();

        private int _iDUtente = 0;

        ButtonManager _buttonManager;

        public string Table = "Utenti";
        private ClsTableSchema _tableSchema;


        public frmUtenti()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }


        private void frmUtenti_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
            LoadDataSMTP();


            // Initialize ClsTableSchema with the connection and name of the table
            _tableSchema = new ClsTableSchema(Global.connKongN, Table);
            ClsMaxLenght maxLengthSetter = new ClsMaxLenght();

            // We call the SetMaxLength method and give it the table schema as a parameter
            maxLengthSetter.SetMaxLength(this, _tableSchema);

        }


        private void LoadData()
        {
            string query = "";

            if (Global.IsSuperuser)
            {
                query = "SELECT * FROM Utenti";
            }
            else if (Global.IsSuperuser == false && Global.IsAdmin) 
            {
               query = "SELECT * FROM Utenti where isSuperuser not like 1";
            }
            else
            {
                query = "SELECT * FROM Utenti WHERE Username = '" + Global.Username + "'";
            }


            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Utenti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }

            txtID.Visible = false;
            
            if (Global.IsSuperuser == false)
            {
                chkSuperuser.Visible = false;
            }

            _iDUtente = Convert.ToInt32(txtID.Text);
            ReadOnlyControls(true);
            btnEsercizio.Enabled = false;

        }


        private void LoadDataSMTP()
        {
            string sqlQuery = "SELECT * FROM Automatismi";
            connKong.ExecQuery(sqlQuery);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore durante la lettura della tabella Automatismi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (connKong.RecordCount > 0)
            {
                Global.IndirizzoServerSMTP = connKong.DBDT.Rows[0]["IndirizzoServerSMTP"].ToString();
                Global.NomeUtenteSMTP = connKong.DBDT.Rows[0]["NomeUtenteSMTP"].ToString();
                Global.PasswordSMTP = connKong.DBDT.Rows[0]["PasswordSMTP"].ToString();
                Global.TLSSMTP = (bool)connKong.DBDT.Rows[0]["TLSSMTP"];
                Global.Porta = Convert.ToInt32(connKong.DBDT.Rows[0]["Porta"]);

                // se i campi stringa sono vuoti oppure il campo porta è 0 manda un messaggio all'utente
                if (string.IsNullOrWhiteSpace(Global.IndirizzoServerSMTP) || string.IsNullOrWhiteSpace(Global.NomeUtenteSMTP) || string.IsNullOrWhiteSpace(Global.PasswordSMTP) || Global.Porta == 0)
                {
                    MessageBox.Show("Controllare i parametri di configurazione del server SMTP che risultano assenti. Vai a Tabella Automatismi e inseriscili altrimenti alcune funzionalità non saranno disponibili.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // se i campi stringa non sono vuoti e la porta è diversa da 0
                else
                {
                    // aggiunge i parametri al dizionario
                    ParametriSMTP.Add("IndirizzoServerSMTP", Global.IndirizzoServerSMTP);
                    ParametriSMTP.Add("NomeUtenteSMTP", Global.NomeUtenteSMTP);
                    ParametriSMTP.Add("PasswordSMTP", Global.PasswordSMTP);
                    ParametriSMTP.Add("Porta", Global.Porta.ToString());
                }
            }
        }


        public void LeggiCampi(DataTable dt)
        {

            //prende in ingresso il datatable e legge i campi
            txtID.Text = dt.Rows[0]["ID"].ToString();
            txtUsername.Text = dt.Rows[0]["Username"].ToString();
            txtNome.Text = dt.Rows[0]["Nome"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtPassword.Text = dt.Rows[0]["Password"].ToString();
            txtLvlPass.Text = dt.Rows[0]["LivelloPassword"].ToString();
            txtEsercizio.Text = dt.Rows[0]["Esercizio"].ToString();

            chkSuperuser.Checked = Convert.ToBoolean(dt.Rows[0]["isSuperuser"]);
            chkAdmin.Checked = Convert.ToBoolean(dt.Rows[0]["isAdministrator"]);
            chkPasswordSenzaScadenza.Checked = Convert.ToBoolean(dt.Rows[0]["PasswordSenzaScadenza"]);
            chkActive.Checked = Convert.ToBoolean(dt.Rows[0]["isActive"]);

            // se il campo dtpUltimoCambioPassword è vuoto mette a null altrimenti il valore con il metodo ternario
            dtpUltimoCambioPassword.Value = dt.Rows[0]["UltimoCambioPassword"] == DBNull.Value ? dtpUltimoCambioPassword.Value = null : Convert.ToDateTime(dt.Rows[0]["UltimoCambioPassword"].ToString());

            bsUtenti.DataSource = dt;
        }


        public void AbbinaCampi()
        {
            txtID.DataBindings.Add("Text", bsUtenti, "ID");
            txtUsername.DataBindings.Add("Text", bsUtenti, "Username");
            txtNome.DataBindings.Add("Text", bsUtenti, "Nome");
            txtEmail.DataBindings.Add("Text", bsUtenti, "Email");
            txtPassword.DataBindings.Add("Text", bsUtenti, "Password");
            txtLvlPass.DataBindings.Add("Text", bsUtenti, "LivelloPassword");
            txtEsercizio.DataBindings.Add("Text", bsUtenti, "Esercizio");

            chkSuperuser.DataBindings.Add("Checked", bsUtenti, "isSuperuser");
            chkAdmin.DataBindings.Add("Checked", bsUtenti, "isAdministrator");
            chkPasswordSenzaScadenza.DataBindings.Add("Checked", bsUtenti, "PasswordSenzaScadenza");
            chkActive.DataBindings.Add("Checked", bsUtenti, "isActive");
            
            dtpUltimoCambioPassword.DataBindings.Add("Value", bsUtenti, "UltimoCambioPassword", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd-MM-yyyy");

        }


        public void ReadOnlyControls(bool x)
        {
            foreach (Control c in this.Controls) 
            {

                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Enabled = !x;
                }

                //if the name of the control is chkTuttiUtenti then it is not disabled
                if (c.Name == "chkTuttiUtenti")
                {
                    ((CheckBox)c).Enabled = x;
                }


                if (c is SfDateTimeEdit)
                {
                    ((SfDateTimeEdit)c).Enabled = !x;
                }

                if (c is Button)
                {
                    ((Button)c).Enabled = x;
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
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }


        private bool check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Informazioni mancanti.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    txtUsername.Focus();

                }
                else if (string.IsNullOrEmpty(txtNome.Text))
                {
                    txtNome.Focus();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Focus();
                }

                result = false;
                return result;
            }

            if(string.IsNullOrEmpty(txtEsercizio.Text))
            {
                MessageBox.Show("Esercizio mancante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEsercizio.Focus();

                result = false;
                return result;
            }

            //the superuser must be an administrator also
            if (chkSuperuser.Checked == true && chkAdmin.Checked == false)
            {
                MessageBox.Show("Non è possibile assegnare privilegi di superutente senza essere anche un amministratore.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            /*Check Email Format */
            EmailCheck checkEmail = new EmailCheck();
            if (checkEmail.IsValidEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Formato Email non valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                result = false;
                return result;
            }

            string query = "";

            /* Check if the username already exists */
            query = "SELECT * FROM Utenti WHERE Username = @Username AND iD <> @iD";

            connKong.AddParam("@Username", txtUsername.Text);
            connKong.AddParam("@iD", txtID.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore durante il controllo dell'username", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            if (connKong.RecordCount > 0)
            {
                MessageBox.Show("Username già presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                result = false;
                return result;
            }

            /* Check if the email already exists */
            query = "SELECT * FROM Utenti WHERE Email = @Email AND iD <> @iD";

            connKong.AddParam("@Email", txtEmail.Text);
            connKong.AddParam("@iD", txtID.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore durante il controllo dell'email", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            if (connKong.RecordCount > 0)
            {
                MessageBox.Show("Email già presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                result = false;
                return result;
            }


            return result;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (_iDUtente != 0)
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtID.Text); //bsUtenti.Find("iD", _iDUtente);
                ClearFields();
                LoadData();
                //bsUtenti.Position = pos;
                bsUtenti.Find("iD", pos);
            }
            else
            {
                Crypta();
                LoadData();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            if (checkPresent())
            {
                LoadData();
                return;
            }

            LoadData();

        }


        private bool checkPresent()
        {
            bool result = true;

            if (Global.ID == txtID.Text)
            {
                MessageBox.Show("Non puoi eliminare l'utente corrente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }
            
            if (chkAdmin.Checked && Global.IsSuperuser == false)
            {
                MessageBox.Show("Non puoi eliminare un utente con privilegi di amministratore.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }


            string query = @"DELETE FROM Utenti WHERE iD = @iD";

            connKong.AddParam("@iD", txtID.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Utenti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Global.IsSuperuser == true || Global.IsAdmin == true)
            {
                ReadOnlyControls(false);
                btnEsercizio.Enabled = true;
                ClearFields();
                _iDUtente = 0;
                Decripta();
            }
            else
            {
                ReadOnlyControls(false);
                chkPasswordSenzaScadenza.Enabled = false;
                btnEsercizio.Enabled = true;
                chkAdmin.Enabled = false;
                ClearFields();
                _iDUtente = 0;
                Decripta();
            }

            dtpUltimoCambioPassword.Value = DateTime.Now;
            dtpUltimoCambioPassword.Enabled = false;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Global.IsSuperuser == true || Global.IsAdmin)
            {
                ReadOnlyControls(false);
                txtPassword.ReadOnly = true;
            }
            else
            {
                ReadOnlyControls(false);
                chkPasswordSenzaScadenza.Enabled = false;
                chkAdmin.Enabled = false;
                txtPassword.ReadOnly = true;
            }

            dtpUltimoCambioPassword.Enabled = false;
            btnEsercizio.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {
                return;
            }


            string query = "";

            if (_iDUtente == 0)
            {
                query = @"INSERT INTO Utenti (Username, Nome, Email, Password, Esercizio, LivelloPassword, isAdministrator, PasswordSenzaScadenza, isActive, UltimoCambioPassword, isSuperuser) 
                        VALUES (@Username, @Nome, @Email, @Password, @Esercizio, @LivelloPassword, @isAdministrator, @PasswordSenzaScadenza, @isActive, @UltimoCambioPassword, @isSuperuser)";
            }
            else
            {
                query = @"UPDATE Utenti SET Username = @Username, Nome = @Nome, Email = @Email, Password = @Password, 
                    Esercizio = @Esercizio, LivelloPassword = @LivelloPassword, isAdministrator = @isAdministrator, 
                    PasswordSenzaScadenza = @PasswordSenzaScadenza, isActive = @isActive, UltimoCambioPassword = @UltimoCambioPassword, isSuperuser = @isSuperuser WHERE ID = @ID";
            }

            connKong.AddParam("@ID", txtID.Text);
            connKong.AddParam("@Username", txtUsername.Text);
            connKong.AddParam("@Nome", txtNome.Text);
            connKong.AddParam("@Email", txtEmail.Text);
            connKong.AddParam("@Password", txtPassword.Text);
            connKong.AddParam("@Esercizio", txtEsercizio.Text);
            connKong.AddParam("@LivelloPassword", txtLvlPass.Text);
            connKong.AddParam("@isSuperuser", chkSuperuser.Checked);
            connKong.AddParam("@isAdministrator", chkAdmin.Checked);
            connKong.AddParam("@PasswordSenzaScadenza", chkPasswordSenzaScadenza.Checked);
            connKong.AddParam("@isActive", chkActive.Checked);
            connKong.AddParam("@UltimoCambioPassword", dtpUltimoCambioPassword.Value);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Utenti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (_iDUtente == 0)
            {
                Crypta();
            }

            LoadData();
            _buttonManager.HandleButtonClick((ToolStripButton)sender);


            //this calls LoadData function from frmPrima to update the data in the form
            frmPrima pp = (frmPrima)Application.OpenForms["frmPrima"];
            if (pp != null)
            {
                pp.LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "";

            if (Global.IsSuperuser)
            {
                query = "SELECT * FROM Utenti";
            }
            else if (Global.IsSuperuser == false && Global.IsAdmin)
            {
                query = "SELECT * FROM Utenti where isSuperuser not like 1";
            }
            else
            {
                query = "SELECT * FROM Utenti WHERE Username = '" + Global.Username + "'";
            }

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Utenti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormFind frmFind = new FormFind();
            frmFind._DT = connKong.DBDT;

            frmFind.ShowDialog();
            // se ritorna una datarow allora si posiziona nel record corrispondente
            if (frmFind._ReturnData != null)
            {

                // prende l'id del record selezionato ed effettua un find

                int id = Convert.ToInt32(frmFind._ReturnData["iD"]);

                var r = bsUtenti.Find("iD", id);

                // si sposta sulla riga trovata
                bsUtenti.Position = r;

            }

        }


        private void btnCrypta_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 15)
            {
                MessageBox.Show("Le password sono criptate", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Crypta();

            MessageBox.Show("Password criptate con successo", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }


        private void btnDecrypta_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length <= 15)
            {
                MessageBox.Show("Le password non sono criptate", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Decripta();

            MessageBox.Show("Password Decriptate con successo", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            LoadData();
        }


        //function to crypt all passwords
        private void Crypta()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM Utenti";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Si è verificato un errore nel recupero dei dati degli utenti");

                return;
            }

            if (connKong.DBDT.Rows.Count == 0)
            {
                MessageBox.Show("Nessun utente trovato");

                return;
            }

            dt = connKong.DBDT;

            foreach (DataRow dr in dt.Rows)
            {
                string password = dr["Password"].ToString();
                string Passwordcrypted = EncryptDecrypt.Encrypt(password);

                string query1 = "UPDATE Utenti SET Password = @Password WHERE iD = @id";
                connKong.AddParam("@Password", Passwordcrypted);
                connKong.AddParam("@id", dr["iD"]);
                connKong.ExecQuery(query1);
                if (connKong.HasException(true))
                {
                    MessageBox.Show("Si è verificato un errore nel salvataggio ");

                    return;
                }
            }
        }


        //function to decrypt all passwords
        private void Decripta()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM Utenti";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Si è verificato un errore nel recupero dei dati degli utenti ");

                return;
            }

            if (connKong.DBDT.Rows.Count == 0)
            {
                MessageBox.Show("Nessun utente trovato");

                return;
            }

            dt = connKong.DBDT;

            foreach (DataRow dr in dt.Rows)
            {
                string password = dr["Password"].ToString();

                if (password.Length <= 15)
                {
                    continue;
                }

                string Passwordcrypted = EncryptDecrypt.Decrypt(password);
                string query1 = "UPDATE Utenti SET Password = @Password WHERE iD = @id";

                connKong.AddParam("@Password", Passwordcrypted);
                connKong.AddParam("@id", dr["iD"]);
                connKong.ExecQuery(query1);

                if (connKong.HasException(true))
                {

                    MessageBox.Show("Si è verificato un errore nel salvataggio ");

                    return;
                }

            }
        }


        //crypta all passwords when the form is closed
        private void frmUtenti_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (txtPassword.Text.Length < 16)
            {
                Crypta();
            }
        }


        //view selected or all the users access
        private void btnAccessi_Click(object sender, EventArgs e)
        {

            string query = "";

            if (chkTuttiUtenti.Checked == true)
            {
                query = "SELECT iD, Username, Nome FROM Utenti";

            }
            else
            {
                query = "SELECT iD, Username, Nome FROM Utenti WHERE iD = @Id";
                connKong.AddParam("@Id", txtID.Text);
            }

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Si è verificato un errore nel caricamento dei dati");

                return;
            }

            if (connKong.RecordCount == 0)
            {
                MessageBox.Show("Non ci sono dati da visualizzare");
                return;
            }

            // effettua la ricerca del user
            FrmVedi frm = new FrmVedi();
            frm._DT = connKong.DBDT;
            frm.Text = "Vedi Accessi";

            frm.ShowDialog();
        }


        //view selected or all the users passwords
        private void btnVediPassword_Click(object sender, EventArgs e)
        {
            string query = "";

            if (chkTuttiUtenti.Checked == true)
            {
                if (Global.IsSuperuser)
                {
                    query = "SELECT iD, Username, Password, UltimoCambioPassword FROM Utenti ORDER BY UltimoCambioPassword DESC";
                }
                else if (Global.IsAdmin)
                {
                    query = "SELECT iD, Username, Password, UltimoCambioPassword FROM Utenti WHERE isSuperuser = 0 ORDER BY UltimoCambioPassword DESC";
                }
                else
                {
                    query = "SELECT iD, Username, Password, UltimoCambioPassword FROM Utenti WHERE iD = @Id ORDER BY UltimoCambioPassword DESC";
                    connKong.AddParam("@Id", txtID.Text);
                }
            }
            else
            {
                query = "SELECT iD, Username, Password, UltimoCambioPassword FROM Utenti WHERE iD = @Id ORDER BY UltimoCambioPassword DESC";
                connKong.AddParam("@Id", txtID.Text);
            }

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Si è verificato un errore nel caricamento dei dati");

                return;
            }

            if (connKong.RecordCount == 0)
            {
                MessageBox.Show("Non ci sono dati da visualizzare");
                return;
            }

            // effettua la ricerca del user
            FrmVedi frm = new FrmVedi();
            frm._DT = connKong.DBDT;
            frm.Text = "Vedi Password";

            frm.ShowDialog();
        }


        //send email with user credentials
        private void btnEmailCredenziali_Click(object sender, EventArgs e)
        {

            // chiede conferma di voler inviare l'email
            switch (MessageBox.Show("Vuoi inviare le credenziali con Username e password all'utente?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:

                    if (txtPassword.Text.Length >= 16)
                    {
                        Decripta();
                        LoadData();
                    }

                    if (InviaMail() == true)
                    {
                        if (txtPassword.Text.Length < 16)
                        {
                            Crypta();
                            LoadData();
                        }
                        MessageBox.Show("Mail inviata con successo", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (txtPassword.Text.Length < 16)
                        {
                            Crypta();
                            LoadData();
                        }
                        MessageBox.Show("Si è verificato un errore nell'invio della mail", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }


        //function to create and send email
        private bool InviaMail()
        {
            string messaggio = "";
            try
            {
                messaggio = "Ciao " + txtNome.Text + ", \n \n" + "Le tue credenziali per accedere a KongNew sono le seguenti: \n Username: " + txtUsername.Text + "\n Password: " + txtPassword.Text;

                Email.MandamailConDizionario("KongNew", txtEmail.Text, "Credenziali di Accesso", messaggio, ParametriSMTP);

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }


        private void btnCambiaPassword_Click(object sender, EventArgs e)
        {

            string query = "SELECT Password FROM Utenti WHERE iD = @Id";
            connKong.AddParam("@Id", txtID.Text);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Si è verificato un errore nel caricamento dei dati");

                return;
            }

            if (connKong.RecordCount == 0)
            {
                MessageBox.Show("Non ci sono dati da visualizzare");
                return;
            }

            if (txtPassword.Text.Length >= 16)
            {
                Decripta();
            }

            // effettua la ricerca del user
            FrmCambiaPassword frm = new FrmCambiaPassword();
            frm._ID = Convert.ToInt32(txtID.Text);
            frm._chiChiama = true;

            frm._Crypta = Crypta;
            frm._Decripta = Decripta;

            // Aggiungi il gestore dell'evento FormClosed
            frm.FormClosed += (s, args) => LoadData();

            frm.ShowDialog();
        }


        private void btnEmailPersonale_Click(object sender, EventArgs e)
        {
            FrmEmailPersonale frm = new FrmEmailPersonale();
            frm._nome = txtNome.Text;
            frm.ShowDialog();

            if (frm._messaggio.Length > 0)
            {
                try
                {

                    Email.MandamailConDizionario("KongNew", txtEmail.Text, "Messaggio da KongNew", frm._messaggio, ParametriSMTP);
                    MessageBox.Show("Mail inviata con successo", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Si è verificato un errore nell'invio della mail", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnEsercizio_Click(object sender, EventArgs e)
        {
            string query = "Select * from Esercizi";

            connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Esercizi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = connAna.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                // riporta i campi prendendoli da frm._ReturnData

                txtEsercizio.Text = frm._ReturnData["NumEser"].ToString();

            }
        }
    }
}
