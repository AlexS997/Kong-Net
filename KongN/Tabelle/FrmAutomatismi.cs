using KongN.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Tabelle
{
    public partial class FrmAutomatismi : Form
    {
        private ClsTableSchema _tableSchema;
        SQLControl Auto = new SQLControl(Global.connKongN);
        private string Table = "Automatismi";

        public FrmAutomatismi()
        {
            InitializeComponent();
            Services.Tracker.Track(this);

        }

      

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAutomatismi_Load(object sender, EventArgs e)
        {

            _tableSchema = new ClsTableSchema(Global.connKongN, Table);
            ClsMaxLenght maxLengthSetter = new ClsMaxLenght();

            // We call the SetMaxLength method and give it the table schema as a parameter
            maxLengthSetter.SetMaxLength(this, _tableSchema);

            ReadOnlyControls(true);
            btnSalva.Text = "Modifica";
            LoadData();

        }

        private void LoadData()
        {
            string sql = "Select * from Automatismi";
            Auto.ExecQuery(sql);

            if (Auto.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati nella tabella Automatismi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Auto.DBDT.Rows.Count > 0)
            {
                LeggiCampi();
            }

            

        }

        private void LeggiCampi()
        {
            // Leggi i campi dalla tabella Automatismi
            txtIndirizzoServerSMTP.Text = Auto.DBDT.Rows[0]["IndirizzoServerSMTP"].ToString();
            txtNomeUtenteSMTP.Text = Auto.DBDT.Rows[0]["NomeUtenteSMTP"].ToString();
            txtPasswordSMTP.Text = Auto.DBDT.Rows[0]["PasswordSMTP"].ToString();
            numPorta.Value = Convert.ToInt32(Auto.DBDT.Rows[0]["Porta"].ToString());
            chkTLSSMTP.Checked = Convert.ToBoolean(Auto.DBDT.Rows[0]["TLSSMTP"].ToString());
            getAllUsernameTextBox.Text = Auto.DBDT.Rows[0]["getAllUsername"].ToString();
            getProfileUsernameTextBox.Text = Auto.DBDT.Rows[0]["getProfileUsername"].ToString();
            setProfileUsernameTextBox.Text = Auto.DBDT.Rows[0]["setProfileUsername"].ToString();
            chkContrattiSuKong.Checked = Convert.ToBoolean(Auto.DBDT.Rows[0]["ContrattiSuKong"].ToString());
            txtMikrotikUser.Text = Auto.DBDT.Rows[0]["MikrotikUser"].ToString();
            txtMikrotikPass.Text = Auto.DBDT.Rows[0]["MikrotikPass"].ToString();
            txtMikrotikIP.Text = Auto.DBDT.Rows[0]["MikrotikIP"].ToString();
            txtUserSMS.Text = Auto.DBDT.Rows[0]["UserSMS"].ToString();
            txtPwdSms.Text = Auto.DBDT.Rows[0]["PwdSMS"].ToString();
            txtUserSMSAPI.Text = Auto.DBDT.Rows[0]["UserSMSAPI"].ToString();
            txtPwdSMSAPI.Text = Auto.DBDT.Rows[0]["PwdSMSAPI"].ToString();
            numCostoSMS.Value = Convert.ToDecimal(Auto.DBDT.Rows[0]["CostoSMS"].ToString());
            txtSmsSend.Text = Auto.DBDT.Rows[0]["SMSSend"].ToString();
            txtSmsEstimate.Text = Auto.DBDT.Rows[0]["SMSEstimate"].ToString();
            txtSmsCredito.Text = Auto.DBDT.Rows[0]["SMSCreditoUser"].ToString();
            txtUrl.Text = Auto.DBDT.Rows[0]["SMSUrl"].ToString();

        }

      


        public void ReadOnlyControls(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).ReadOnly = x;
                    ((NumericUpDown)c).Enabled = !x;
                }
               
                if (c is CheckBox)
                {
                    ((CheckBox)c).Enabled = !x;
                }
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // se il text del pulsante è modifica diventa salva
            if (btnSalva.Text == "Modifica")
            {
                // abilita i controlli
                ReadOnlyControls(false);
                btnSalva.Text = "Salva";
               
            }

            // effettua un check sui campi
            if (Check()== false)
            {
                return;
            }

            // salvo i dati
           
            string sql = @"Update Automatismi set IndirizzoServerSMTP = @IndirizzoServerSMTP, NomeUtenteSMTP = @NomeUtenteSMTP, PasswordSMTP = @PasswordSMTP,
                            Porta = @PortaServerSMTP, TLSSMTP = @TLSSMTP, getAllUsername = @getAllUsername, getProfileUsername = @getProfileUsername,
                            setProfileUsername = @setProfileUsername, MikrotikUser = @MikrotikUser, MikrotikPass = @MikrotikPass, 
                            MikrotikIP = @MikrotikIP, ContrattiSuKong = @ContrattiSuKong, UserSMS = @UserSMS, PwdSMS = @PwdSMS, UserSMSAPI = @UserSMSAPI,
                            PwdSMSAPI = @PwdSMSAPI, CostoSms = @CostoSms, SMSSend = @SMSSend, SMSEstimate = @SMSEstimate, SMSCreditoUser = @SMSCreditoUser, 
                            SMSUrl = @SMSUrl";

            Auto.AddParam("@IndirizzoServerSMTP", txtIndirizzoServerSMTP.Text);
            Auto.AddParam("@NomeUtenteSMTP", txtNomeUtenteSMTP.Text);
            Auto.AddParam("@PasswordSMTP", txtPasswordSMTP.Text);
            Auto.AddParam("@PortaServerSMTP", numPorta.Value);
            Auto.AddParam("@TLSSMTP", chkTLSSMTP.Checked);
            Auto.AddParam("@getAllUsername", getAllUsernameTextBox.Text);
            Auto.AddParam("@getProfileUsername", getProfileUsernameTextBox.Text);
            Auto.AddParam("@setProfileUsername", setProfileUsernameTextBox.Text);
            Auto.AddParam("@ContrattiSuKong", chkContrattiSuKong.Checked);
            Auto.AddParam("@MikrotikUser", txtMikrotikUser.Text);
            Auto.AddParam("@MikrotikPass", txtMikrotikPass.Text);
            Auto.AddParam("@MikrotikIP", txtMikrotikIP.Text);
            Auto.AddParam("@UserSMS", txtUserSMS.Text);
            Auto.AddParam("@PwdSMS", txtPwdSms.Text);
            Auto.AddParam("@UserSMSAPI", txtUserSMSAPI.Text);
            Auto.AddParam("@PwdSMSAPI", txtPwdSMSAPI.Text);
            Auto.AddParam("@CostoSms", numCostoSMS.Value);
            Auto.AddParam("@SMSSend", txtSmsSend.Text);
            Auto.AddParam("@SMSEstimate", txtSmsEstimate.Text);
            Auto.AddParam("@SMSCreditoUser", txtSmsCredito.Text);
            Auto.AddParam("@SMSUrl", txtUrl.Text);

            Auto.ExecQuery(sql);

            if (Auto.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati nella tabella Automatismi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadData();

            ReadOnlyControls(true);
            btnSalva.Text = "Modifica";

            MessageBox.Show("Dati salvati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private bool Check()
        {
            bool result = true;
            // ogni campo testo deve essere compilato
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Text == "")
                    {
                        MessageBox.Show("Il campo " + ((TextBox)c).Name + " non può essere vuoto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = false;
                        break;
                    }
                }


                if (c is NumericUpDown)
                {
                    if (((NumericUpDown)c).Value == 0)
                    {
                        MessageBox.Show("Il campo " + ((NumericUpDown)c).Name + " non può essere zero.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = false;
                        break;
                    }
                }

            }

            // ogni campo di tipo intero deve essere maggiore di zero
           
            return result;


        }
    }
}
