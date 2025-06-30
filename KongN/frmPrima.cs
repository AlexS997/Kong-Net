using System;
using System.Drawing;
using System.Windows.Forms;
using KongN.Classi;
using KongN.Antivirus;
using KongN.Controlli;
using KongN.Profili;
using KongN.Provvigioni;
using KongN.Tabelle;
using KongN.Stampa;
using KongN.StrutturaRete;
using KongN.SMS;
using KongN.Contratti;
using KongN.SIM;
using KongN.Voip;
using KongN.Apparati;
using KongN.Azioni;
using KongN.Agenda;
using KongN.Utenti;


namespace KongN
{
    public partial class frmPrima : Form
    {
        
        SQLControl connKong = new SQLControl(Global.connKongN);
        SQLControl connAna = new SQLControl(Global.connAna);

        public frmPrima()
        {
            InitializeComponent();

        }


        private void frmPrima_Load(object sender, EventArgs e)
        {
            Init();
            LoadData();

            string VersioneCorrente = Application.ProductVersion.ToString();

            // scrive il titolo del programma + la versione corrente del programma nella barra del titolo

            this.Text = "KongN - Versione " + VersioneCorrente;

            //controlla se ci sono aggiornamenti disponibili
            UpdateChecker updateChecker = new UpdateChecker();
            (bool isNewVersionAvailable, string latestVersion) = updateChecker.CheckForUpdates();
            if (isNewVersionAvailable)
            {
                MessageBox.Show("E' disponibile la versione " + latestVersion + " del programma", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Text = "KongN - Versione " + VersioneCorrente + " - Aggiornamento disponibile: " + latestVersion;
            }
        }

        internal void LoadData()
        {
            /*----------------------- needs to refresh info from frmPrima statusStrip when update the Esercizio for a User --------------------------*/
            string e = "Select Esercizio from Utenti where ID = " + Global.ID.ToString();
            connKong.ExecQuery(e);

            if (connKong.HasException())
            {
                MessageBox.Show("Errore nella lettura dell'esercizio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                Global.Esercizio = connKong.DBDT.Rows[0]["Esercizio"].ToString();
            }
            else
            {
                MessageBox.Show("Errore nella lettura dell'esercizio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*-----------------------------------------------------------------------------------------------------------------*/

            lblUser.Text = "Username: " + Global.Username;
            lblData.Text = "Data " + DateTime.Now.ToShortDateString();
            lblEsercizio.Text = "Esercizio " + Global.Esercizio.ToString();

            string query = "Select DataIni from Esercizi where NumEser = " + Global.Esercizio.ToString();
            connAna.ExecQuery(query);

            if (connAna.HasException())
            {
                MessageBox.Show("Errore nella lettura della data di inizio dell'esercizio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connAna.DBDT.Rows.Count > 0)
            {
                DateTime dataInizio = DateTime.Parse(connAna.DBDT.Rows[0]["DataIni"].ToString());
                lblDataEsercizio.Text = "Data Esercizio " + dataInizio.Year.ToString();
            }
            
        }


        private void Init()
        {

            string ConfigFile = Application.StartupPath + @"\AppConfiguration.json";
            //controlla se il file esiste
            if (System.IO.File.Exists(ConfigFile))
            {
                AppConfiguration AppConfig = new AppConfiguration();

                AppConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<AppConfiguration>(System.IO.File.ReadAllText("AppConfiguration.json"));
            }
            else
            { 
               
                MessageBox.Show("Il file di configurazione non esiste, non posso proseguire.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                //termina il programma
                Application.Exit();
           
            }
        }


        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void frmPrima_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        private void toolLogout_Click(object sender, EventArgs e)
        {
            // Nascondi tutti i form figli
            foreach (Form childForm in MdiChildren)
            {
                childForm.Hide();
            }

            // Mostra il form di login
            vLogin loginForm = new vLogin();
            loginForm.Show();

            this.Hide();

        }

        #region Antivirus
        private void mnuArchivoAntivirus_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<frmAntivirus>(this);
        private void marcheAntivirusToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<frmAntivirusMarche>(this);

        #endregion

        #region Provvigione
        private void mnuArticoliProvvigioni_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmArticoliProvvigioni>(this);

        private void mnuGestioneProvvigioni_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmGestioneProvvigioni>(this);

        private void mnuClientiConProvvigioni_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmClientiXAgente>(this);

        private void controlloPresenzaAgenteSuFattureToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmControlloFatture>(this);

        #endregion

        #region Agenda

        private void mnuGestioneAgenda_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmAgenda>(this);

        private void mnuStoricoAgenda_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmStoricoAgenda>(this);

        #endregion

        #region Controlli

        private void mnuPartiteAperte_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmPartiteAperte>(this);

        private void spesePostaliToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmAggiornaSpesePostali>(this);

        private void clientiEsclusiDaScadenzarioKingToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmClientiEsclusiScadenzario>(this);
        
        private void clientiSenzaContrattoToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmClientiSenzaContratto>(this);

        private void clientiConTelefonoErratoToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmTelefonoErrato>(this);

        private void spesePostaliFatturazioneToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmSpesePostali>(this);

        private void contrattiNONRinnovatiToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmContrattiNONRinnovati>(this);

        #endregion

        #region Tabelle

        private void mnuTipiContratto_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmTipiContratto>(this);
        private void automatismiToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmAutomatismi>(this);
        private void utentiMenu_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<frmUtenti>(this);
        private void mnuAbilitazioneUtenti_Click(object sender, EventArgs e)
        {
            if (Global.IsAdmin)
            {
                ClsUtilityForms.LoadForm<FrmAbilitazioneUtenti>(this);
            }
            else
            {
                MessageBox.Show("Non hai i permessi per accedere a questa funzione", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Profili
        private void mnuProfiliUtenti_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmProfiliUtenti>(this);

        private void mnuProfiliKing_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmProfiliUtentiKing>(this);
        #endregion

        #region BtnToolStrip
        private void ToolStripProfiliUtenti_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmProfiliUtenti>(this);
        private void ToolStripGestioneProvvigioni_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmGestioneProvvigioni>(this);
        private void ToolStripPartiteAperte_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmPartiteAperte>(this);
        private void tsSms_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmGestioneSMS>(this);

        #endregion

        #region Struttura Rete
        private void fornitoriToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmFornitoriRete>(this);
        private void gatewaysToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmGateways>(this);
        private void pontiToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmPonti>(this);
        private void pannelliToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmPannelli>(this);
        private void mnuClientiDellaRete_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmClientiRete>(this);
        private void mnuAlberoDellaRete_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmAlbero>(this);
        private void mnuTecnologiaPannelli_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmTecnologia>(this);
        private void mnuTabellaDiEsclusione_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmTabellaEsclusione>(this);
        #endregion

        #region Update
        private async void mnuVerificaAggiornamenti_Click(object sender, EventArgs e)
        {
            // verifica se ci sono aggiornamenti chiamando la classe UpdateChecker
            UpdateChecker updateChecker = new UpdateChecker();
            (bool isNewVersionAvailable, string latestVersion) = updateChecker.CheckForUpdates();
            if (isNewVersionAvailable)
            {
                switch (MessageBox.Show("Una nuova versione è disponibile, voi scaricarla e installarla?", "Nuova versione Disponibile", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.Yes:
                        // scarica il file di installazione chiamando la classe UpdateApplicationAsync

                        // cursore di attesa
                        Cursor.Current = Cursors.WaitCursor;

                        await updateChecker.UpdateApplicationAsync();
                        Cursor.Current = Cursors.Default;
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Non ci sono aggiornamenti disponibili", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string VersioneCorrente = Application.ProductVersion.ToString();
            MessageBox.Show("KongN - Versione " + VersioneCorrente + "\n\nSviluppato da EtruriaWiFi.net", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region SMS
        private void mnuSMSSingolo_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmSmsSingolo>(this);
        private void mnuGestioneSMS_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmGestioneSMS>(this);
        private void mnuStoricoSMS_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmStoricoSMS>(this);

        private async void mnuCreditoResiduo_Click(object sender, EventArgs e)
        {
            CSMS sms = new CSMS();

            var c = await sms.ControllaCredito(true);


            var Credito = c;


            if (Credito == "0")
            {
                MessageBox.Show("Il credito è esaurito oppure il programma non è riuscito a recuperarlo.", "Messaggio di Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            MessageBox.Show("Il credito residuo è di " + Credito.ToString(), "Messaggio di Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuDefinizioneDeiMessaggi_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmMessaggiDefinizione>(this);

        #endregion

        #region Contratti

        private void profiliDisponibiliEArticoliToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmContrattiProfili>(this);
        private void contrattiTipiToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmContrattiTipi>(this);
        private void mnuImportaContrattiDaKing_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmImportaContratti>(this);

        #endregion

        #region SIM
        private void schedeSIMToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmSchedeSIM>(this);
        #endregion

        #region VoIP
        private void mnuGestioneChiamate_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmGestioneChiamate>(this);
        private void mnuOfferteVoIP_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmOfferteVoip>(this);
        private void mnuAutomatismiVoiP_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmAutomatismiVoiP>(this);
        private void mnuNumeriVoIP_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmNumeriVoIP>(this);
        private void numPrefissiTelefonici_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmPrefissi>(this);
        private void mnuTabellaNazioni_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmNazioni>(this);
        private void mnuInserisciDettaglio_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmDettagliInserimento>(this);
        private void mnuNormalizzazioneChiamate_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmNormalizzazione>(this);
        private void mnuTrasferimentoChiamateAStorico_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmTrasferimentoStorico>(this);
        private void mnuFileAgenziaEntrate_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmAgenziaEntrate>(this);
        private void mnuCostoPrefissiStandard_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmCostoPrefissiStandard>(this);
        private void consumiDeiClientiToolStripMenuItem_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmConsumi>(this);
        private void mnuListaChiamatePerCliente_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmListaChiamate>(this);


        #endregion

        #region Apparati

        private void mnuGestioneApparatiEPassword_Click(object sender, EventArgs e)
        {
            // entra se l'utente è abilitato o se è admin   
            if (HaiPermessi() == true || Global.IsAdmin == true)
            {
                ClsUtilityForms.LoadForm<FrmApparati>(this);
            }
            else
            {
                MessageBox.Show("Non hai i permessi per accedere a questa funzione", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool HaiPermessi()
        {
            string query = "SELECT iDUtente FROM ApparatiAbilitazioni WHERE iDUtente = " + Global.ID.ToString();
            connKong.ExecQuery(query);

            if (connKong.HasException())
            {
                MessageBox.Show("Errore nella lettura delle abilitazioni");

                return false;
            }
            if (connKong.DBDT.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void mnuTipiDiApparati_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmApparatiTipi>(this);
        
        private void mnuAbilitazioneApparati_Click(object sender, EventArgs e)
        {
            if (Global.IsAdmin == true)
            {
                //FrmAbilitazioneApparati frm = new FrmAbilitazioneApparati();
                //frm.ShowDialog();

                ClsUtilityForms.LoadForm<FrmAbilitazioneApparati>(this);

            }
            else
            {
                MessageBox.Show("Non hai i permessi per accedere a questa funzione", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Azioni
        private void mnuOperazioniInCoda_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmOperazioniInCoda>(this);
        private void mnuMessaggiInCoda_Click(object sender, EventArgs e) => ClsUtilityForms.LoadForm<FrmMessaggiInCoda>(this);


        #endregion

        private void mnuVenditaPrefissiStandard_Click(object sender, EventArgs e)
        {

        }

    }
}
