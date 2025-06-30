using KongN.Classi;
using KongN.Find;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.SMS
{
    public partial class FrmSmsSingolo : Form
    {

        SQLControl connAna = new SQLControl(Global.connAna);
        SQLControl connKong = new SQLControl(Global.connKongN);

        private void txtMessaggio_TextChanged(object sender, EventArgs e)
        {
            var l = txtMessaggio.Text.Length;

            Rimanentilbl.Text = (320 - l).ToString();

            inseritilbl.Text = l.ToString();
            txtTipoMessaggio.Text = "Messaggio Singolo";
        }

        public FrmSmsSingolo()
        {
            InitializeComponent();
        }

        private void FrmSmsSingolo_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            ClearForm();
            btnPreleva.Visible = false;
            lblDenom.Text = "";
            txtTipoMessaggio.Text = "Messaggio Singolo";
        }

        private void ClearForm()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string query = "Select CodCli, Denom, U_CellulareSMS from Clienti WHERE stato='A'";

            connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Clienti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = connAna.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                txtCliente.Text = frm._ReturnData["CodCli"].ToString();
                txtNumero.Text = frm._ReturnData["U_CellulareSMS"].ToString();
                lblDenom.Text = frm._ReturnData["Denom"].ToString();
            }
        }

        private void btnPredefinito_Click(object sender, EventArgs e)
        {
            string query = "Select * from MessaggiDefinizione";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Si è verificato un errore nell'estrazione dei dati dalla tabella MessaggiDefinizione.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = connKong.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                txtTipoMessaggio.Text = frm._ReturnData["Descrizione"].ToString();
                txtMessaggio.Text = frm._ReturnData["Messaggio"].ToString();
            }
        }

        private void btnPreleva_Click(object sender, EventArgs e)
        {
            string query = "SELECT Codice, SUM(Saldo) AS Saldo FROM PartiteAperte " +
               "GROUP BY Codice " +
               "HAVING (Codice = @Codice)";

            connKong.AddParam("@Codice", txtCliente.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException() == true)
            {
                MessageBox.Show("Si è verificato un errore nell'estrazione dei dati dalla tabella PartiteAperte di KONG. Non posso proseguire.", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (connKong.DBDT.Rows.Count == 0)
            {
                MessageBox.Show("Non ci sono partite aperte per il cliente selezionato. ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //abs.Contains("s"); // to look for lower case s
            // testa se il messaggio contiene il pattern @Importo   
            if (txtMessaggio.Text.Contains("@Importo"))
            {
                // sostituisce il pattern con il saldo
                txtMessaggio.Text = txtMessaggio.Text.Replace("@Importo", " " + connKong.DBDT.Rows[0]["Saldo"].ToString());
                return;
            }


            txtMessaggio.Text += " Totale partite Aperte:" + connKong.DBDT.Rows[0]["Saldo"].ToString();
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtMessaggio.Text = "";
        }

        private void btnFattureAperte_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Non hai selezionato nessun cliente. Non posso proseguire.", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SqlConnectionStringBuilder builderK = new SqlConnectionStringBuilder(Global.connKongN);

            string dataSourceK = builderK.DataSource;
            string initialCatalogK = builderK.InitialCatalog;
            string userIdK = builderK.UserID;
            string passwordK = builderK.Password;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(Global.connAna);

            string dataSource = builder.DataSource;
            string initialCatalog = builder.InitialCatalog;
            string userId = builder.UserID;
            string password = builder.Password;

            string query = "SELECT PartiteAperte.Partita, FattTest.NumDoc, FattTest.DataDoc, FattTest.Cliente, (PartiteAperte.Dare - PartiteAperte.Avere) as Saldo ";
            query += $"FROM {initialCatalog}.dbo.FattTest INNER JOIN ";
            query += $"{initialCatalogK}.dbo.PartiteAperte ON FattTest.NumDoc = RIGHT(PartiteAperte.Partita, 6) AND FattTest.Cliente = PartiteAperte.Codice ";
            query += "WHERE FattTest.Cliente = @Cliente ";
            query += "ORDER BY FattTest.DataDoc DESC";

            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                try
                {

                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Cliente", txtCliente.Text);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Non ci sono fatture aperte per il cliente selezionato.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string s = "";
                        foreach (DataRow dr in dt.Rows)
                        {
                            string data = Convert.ToDateTime(dr["DataDoc"]).ToString("dd/MM/yyyy");
                            s += Environment.NewLine + " Fattura: " + dr["NumDoc"].ToString() + " del " + data + " saldo €. " + dr["Saldo"].ToString() + Environment.NewLine;
                        }

                        if (txtMessaggio.Text.Contains("@F"))
                        {
                            txtMessaggio.Text = txtMessaggio.Text.Replace("@F", s);
                        }
                        else
                        {
                            txtMessaggio.Text += s;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Si è verificato un errore: {ex.Message}");
                }
            }

            //DataTable dt = new DataTable();
            //dt = connAna.DBDT;

            //if (dt.Rows.Count == 0)
            //{
            //    MessageBox.Show("Non ci sono fatture aperte per il cliente selezionato. ", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return;
            //}

            //string s = "";

            //foreach (DataRow dr in dt.Rows)
            //{
            //    // deve formattare la data senza il time

            //    string data = dr["DataDoc"].ToString();
            //    data = data.Substring(0, 10);
            //    s += Environment.NewLine + " Fattura: " + dr["NumDoc"].ToString() + " del " + data + " saldo €. " + dr["Saldo"].ToString() + Environment.NewLine;
            //}

            //if (txtMessaggio.Text.Contains("@F"))
            //{
            //    // sostituisce il pattern con il saldo
            //    txtMessaggio.Text = txtMessaggio.Text.Replace("@F", s);
            //    return;
            //}

            //txtMessaggio.Text += s;
        }

        private async void btnInvia_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Non hai selezionato nessun numero. Non posso proseguire.", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNumero.Text.Length > 13 || txtNumero.Text.Length < 7)
            {


                if (MessageBox.Show("", "Il numero di telefono sembra essere troppo lungo o troppo corto. Proseguo?", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;

            }

            if (txtMessaggio.Text == "")
            {
                MessageBox.Show("Non hai inserito nessun messaggio. Non posso proseguire.", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            //controlla che il numero di telefono inzi con 39
            if (txtNumero.Text.Substring(0, 3) != "+39")
            {
                if (MessageBox.Show("", "Il numero di telefono non inizia con +39. Proseguo?", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            }

            CSMS sms = new CSMS();
            sms._numero = txtNumero.Text;
            sms._messaggio = txtMessaggio.Text;
            var c = await sms.ControllaCredito();


            double Credito = Convert.ToDouble(c["credito"]);
            double Costo = Convert.ToDouble(c["costo"]);

            if (Credito == 0 && Costo == 0)
            {
                MessageBox.Show("Si è verificato un errore nel recupero del credito", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (Credito < Costo)
            {
                MessageBox.Show("Non hai credito sufficiente per inviare il messaggio. Credito Rimanente : " + Credito.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }



            var s = await sms.InviaSMS();


            var statoinvio = s["status"];
            var id = s["id"];

            if (statoinvio == "INSERTED")
            {
                MessageBox.Show("Messaggio inviato correttamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                // se salva ritorna true allora salva il messaggio in agenda    
                if (Salva(id, statoinvio) == true)
                {
                    //ScriviAgenda();
                    ClearForm();
                }
                return;
            }
            else
            {
                MessageBox.Show("Si è verificato un errore nell'invio del messaggio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void ScriviAgenda()
        {
            //            Titolo varchar(50)	Checked
            //Interno bit Checked
            //Codice nchar(10)	Checked
            //Denom   varchar(60) Checked
            //GeneratoDa  varchar(50) Checked
            //Descrizione text Unchecked
            //DataInserimento datetime    Checked
            //DataInizio  datetime Checked
            //DataFine datetime    Checked
            //Concluso    bit Checked
            //iDUtente    int Checked
            //DataModifica datetime    Checked
            //Id  int Unchecked

            //        Unchecked


            //string query = "INSERT INTO Agenda (Titolo, Interno, Codice, Denom, GeneratoDa, Descrizione, DataInserimento, DataInizio, DataFine, Concluso, iDUtente, DataModifica) " +
            //    "VALUES (@Titolo,@Interno,@Codice,@Denom,@Generatoda,@Descrizione,@DataInserimento,@DataInizio,@DataFine,@Concluso,@IdUtnte,@DataModifica)";

            string className = this.GetType().Name;

            string query = "INSERT INTO Agenda (Titolo, Descrizione, Interno, Codice, Denom, GeneratoDa, DataInserimento, DataInizio, " +
                "DataFine, Concluso, iDUtente, DataModifica) " +
                            "VALUES (@Titolo, @Descrizione, @Interno, @Codice, @Denom, @GeneratoDa, @DataInserimento, @DataInizio, " +
                "@DataFine, @Concluso, @iDUtente, @DataModifica)";


            connKong.AddParam("@Titolo", "SMS Singolo");

            connKong.AddParam("@Descrizione", txtMessaggio.Text);

            connKong.AddParam("@Interno", true);

            connKong.AddParam("@Codice", txtCliente.Text);
            connKong.AddParam("@Denom", lblDenom.Text);
            connKong.AddParam("@GeneratoDa", className);

            connKong.AddParam("@DataInserimento", DateTime.Now);
            connKong.AddParam("@DataInizio", DateTime.Now);
            connKong.AddParam("@DataFine", DateTime.Now);
            connKong.AddParam("@Concluso", false);
            connKong.AddParam("@IdUtente", Global.ID);
            connKong.AddParam("@DataModifica", DateTime.Now);
            connKong.ExecQuery(query, false);

            if (connKong.HasException() == true)
            {
                MessageBox.Show("Si è verificato un errore nell'inserimento del messaggio nella tabella Agenda di KONG.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("Messaggio salvato correttamente nell'Agenda", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private bool Salva(string id_sms, string s)
        {

            string query = "INSERT INTO Sms (Numero, Messaggio, Elaborato, id_SMS, Stato, Data, TipoMessaggio, Codice, Denom, iDUtente, DataModifica)" +
                 "VALUES (@Numero, @Messaggio, @Elaborato, @iD_SMS, @Stato, @Data, @TipoMessaggio, @Codice, @Denom, @IdUtente, @DataModifica)";
            
            connKong.AddParam("@Numero", txtNumero.Text);
            connKong.AddParam("@Messaggio", txtMessaggio.Text);
            connKong.AddParam("@Elaborato", false);
            connKong.AddParam("@iD_SMS", id_sms);
            connKong.AddParam("@Stato", s);
            connKong.AddParam("@Data", DateTime.Now);
            connKong.AddParam("@TipoMessaggio", txtTipoMessaggio.Text);
            connKong.AddParam("@Codice", txtCliente.Text);
            connKong.AddParam("@Denom", lblDenom.Text);
            connKong.AddParam("@IdUtente", Global.ID);
            connKong.AddParam("@DataModifica", DateTime.Now);


            connKong.ExecQuery(query);
            if (connKong.HasException() == true)
            {
                MessageBox.Show("Si è verificato un errore nell'inserimento del messaggio nella tabella SMS di KONG. Non posso proseguire.", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }


            MessageBox.Show("Messaggio salvato correttamente", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                btnPreleva.Visible = true;

            }
        }
    }
}
