using KongN.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN
{
    public partial class vLogin : Form
    {
        public AppConfiguration AppConfiguration { get; set; } = new AppConfiguration();

        public Dictionary<string, string> ParametriSMTP = new Dictionary<string, string>();

        SQLControl KongN = new SQLControl(Global.connKongN);


        public vLogin()
        {
            InitializeComponent();

            string ConfigFile = Application.StartupPath + @"\Appconfiguration.json";
            // controlla se il file esiste se non esiste esce dal programma
            if (!System.IO.File.Exists(ConfigFile))
            {
                MessageBox.Show("File di configurazione non trovato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                //carica configurazzione
                if (!AppConfiguration.CaricaConfigurazione(ConfigFile))
                {
                    MessageBox.Show("Errore nel caricamento del file di configurazione", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            // aggiunge un evento al form per la pressione del tasto invio
            this.KeyDown += new KeyEventHandler(vLogin_KeyDown);
            this.KeyPreview = true;
        }

        // crea un metodo per la pressione del tasto invio
        private void vLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void vLogin_Load(object sender, EventArgs e)
        {
            lblDimenticata.Visible = true;
            lblAttendere.Visible = false;
            SQLControl Auto = new SQLControl(Global.connKongN);

            string sqlQuery = "SELECT * FROM Automatismi ";
            Auto.ExecQuery(sqlQuery);

            if (Auto.HasException(true))
            {
                MessageBox.Show("Errore durante la lettura della tabella Automatismi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }

            if (Auto.RecordCount > 0)
            {
                Global.IndirizzoServerSMTP = Auto.DBDT.Rows[0]["IndirizzoServerSMTP"].ToString();
                Global.NomeUtenteSMTP = Auto.DBDT.Rows[0]["NomeUtenteSMTP"].ToString();
                Global.PasswordSMTP = Auto.DBDT.Rows[0]["PasswordSMTP"].ToString();
                Global.TLSSMTP = (bool)Auto.DBDT.Rows[0]["TLSSMTP"];
                Global.Porta = Convert.ToInt32(Auto.DBDT.Rows[0]["Porta"]);

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SQLControl KongN = new SQLControl(Global.connKongN);
            
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Inserisci il tuo nome utente e la tua password.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                // crypta la password
                string encryptedPassword = EncryptDecrypt.Encrypt(txtPassword.Text);

                string query = "SELECT * FROM Utenti WHERE Username = @UserName AND Password = @Password";

                KongN.AddParam("@UserName", txtUser.Text);
                KongN.AddParam("@Password", encryptedPassword);
                //KongN.AddParam("@Password", txtPassword.Text);
                KongN.ExecQuery(query);

                if (KongN.HasException(true))
                {
                    MessageBox.Show("Errore durante il login", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (KongN.RecordCount > 0)
                {
                    Global.Username = KongN.DBDT.Rows[0]["Username"].ToString();
                    Global.Password = KongN.DBDT.Rows[0]["Password"].ToString();
                    Global.ID = KongN.DBDT.Rows[0]["iD"].ToString();
                    Global.Nome = KongN.DBDT.Rows[0]["Nome"].ToString();
                    Global.Email = KongN.DBDT.Rows[0]["Email"].ToString();
                    Global.IsSuperuser = (bool)KongN.DBDT.Rows[0]["isSuperuser"];
                    Global.IsAdmin = (bool)KongN.DBDT.Rows[0]["isAdministrator"];
                    Global.Esercizio = KongN.DBDT.Rows[0]["Esercizio"].ToString();
                    Global.UltimoCambioPassword = KongN.DBDT.Rows[0]["UltimoCambioPassword"].ToString();
                    Global.PasswordSenzaScadenza = (bool)KongN.DBDT.Rows[0]["PasswordSenzaScadenza"];
                    Global.IsActive = (bool)KongN.DBDT.Rows[0]["isActive"];
                    Global.LivelloPassword = KongN.DBDT.Rows[0]["LivelloPassword"].ToString();

                    if (Global.IsActive == false)
                    {
                        MessageBox.Show("Utente non attivo, non è possibile continuare");
                        txtPassword.Text = "";
                        txtUser.Text = "";
                        txtUser.Focus();
                        return;
                    }


                    frmPrima frmPrima = new frmPrima();
                    frmPrima.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username o Password errati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtUser.Text = "";
                    txtUser.Focus();
                }
            }

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }

        private void lblEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                lblEye.Image = Properties.Resources.eye_open;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                lblEye.Image = Properties.Resources.eye;
            }
        }

        private void lblDimenticata_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Inserisci il tuo nome utente.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string E = "";
            Dictionary<string, string> Dati = new Dictionary<string, string>();

            // recupera il nome utente chiamando la funzione RecuperaUsername

            Dati = RecuperaUsername();



            // non restituisce una minchia

            // se il dizionario è vuoto
            if (Dati.Count == 0)
            {
                MessageBox.Show("Il nome utente non esiste oppure si è verificato un errore nel recupero.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            // se non è vuoto
            // invia la mail
            lblAttendere.Visible = true;
            E = InviaEmail(Dati);
            if (E == "")
            {
                MessageBox.Show("Entro pochi secondi una mail contenente i dati di accesso sarà inviata all'indirizzo registrato sull'utente. Prima sarà effettuato un controllo sullo Username per verificare che esista.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Question);

                lblAttendere.Visible = false;
            }
            else
            {
                lblAttendere.Visible = false;

                MessageBox.Show("Si è verificato un errore :" + E, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }

            lblAttendere.Visible = false;
        }

        private Dictionary<string, string> RecuperaUsername()
        {
            SQLControl User = new SQLControl(Global.connKongN);
            string sqlQuery = "SELECT * FROM Utenti WHERE Username = @Username";
            User.AddParam("@Username", txtUser.Text);
            User.ExecQuery(sqlQuery);

            if (User.HasException(true))
            {
                MessageBox.Show("Errore durante il recupero del nome utente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // aggiunge un dizionario vuoto
                return new Dictionary<string, string>();

            }

            if (User.RecordCount > 0)
            {
                // decripta la password
                string decryptedPassword = EncryptDecrypt.Decrypt(User.DBDT.Rows[0]["Password"].ToString());

                // aggiunge un dizionario con  i dati dell'utente
                return new Dictionary<string, string>
                {
                    { "Username", User.DBDT.Rows[0]["Username"].ToString() },
                    { "Password", decryptedPassword },
                    { "Email", User.DBDT.Rows[0]["Email"].ToString() }
                };

            }
            else
            {
                return new Dictionary<string, string>();
            }
        }

        // crea un metodo per mandare la mail che restiruisce una stringa e accetta un dizionario
        private string InviaEmail(Dictionary<string, string> Dati)
        {
            try
            {
                // manda la mail con i dati dell'utente e i parametri SMTP
                Classi.Email.MandamailConDizionario(Dati["Email"], Dati["Email"], "Credenziali di accesso", "Il nome di accesso è: " + Dati["Username"] + "\r\n" + "La Password è: " + Dati["Password"], ParametriSMTP);

                return "";
            }
            catch (Exception ex)
            {
                var errorMessage = ex.GetBaseException().Message;
                return errorMessage;
            }
        }

    }
}
