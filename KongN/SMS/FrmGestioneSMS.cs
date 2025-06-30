using FastReport.DevComponents.DotNetBar.Controls;
using KongN.Classi;
using KongN.ClassiTabelle;
using Org.BouncyCastle.Utilities;
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KongN.SMS
{
    public partial class FrmGestioneSMS : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        ButtonManager _buttonManager;

        DataTable dt = new DataTable();

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

        public FrmGestioneSMS()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmGestioneSMS_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();

            lblRecord.Text = "Record estratti: " + bsSMS.Count.ToString();
        }

        private void LoadData() 
        {

            string query = chkConclusi.Checked ? "SELECT * FROM Sms" : "SELECT * FROM Sms WHERE Elaborato = 'false'";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Ponti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);

            }

            txtId.Visible = false;
            chkElaborato.Visible = false;

            bsSMS.DataSource = connKong.DBDT;

            //ReadOnlyControls(true);
        }

        public void LeggiCampi(DataTable antivirus)
        {
            txtId.Text = antivirus.Rows[0]["Id"].ToString();
            chkElaborato.Checked = Convert.ToBoolean(antivirus.Rows[0]["Elaborato"]);
        }

        public void AbbinaCampi()
        {
            txtId.DataBindings.Add("Text", bsSMS, "Id");
            chkElaborato.DataBindings.Add("Checked", bsSMS, "Elaborato");
        }


        private void chkConclusi_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
            lblRecord.Text = "Record estratti: " + bsSMS.Count.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete From Sms Where iD = @iD";
            connKong.AddParam("@iD", txtId.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Sms.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);



            LoadData();

        }

        private void btnStorico_Click(object sender, EventArgs e)
        {
            // controlla che vi siano righe con il campo elaborato a true
            // se non ci sono righe non prosegue
            bool b = false;

            foreach (DataRowView rowView in bsSMS)
            {
                DataRow row = rowView.Row;
                if (row["Elaborato"].ToString() == "True")
                {
                    b = true;
                    break;
                }
            }



            if (b == false)
            {
                MessageBox.Show("Non ci sono record da spostare nello storico", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // chiede conferma 



            if (MessageBox.Show("Si vuole spostare tutti i record elaborati nello storico?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            // Id  int Unchecked
            //Numero varchar(25)	Checked
            //Messaggio   nvarchar(MAX)   Checked
            //Elaborato   bit Checked
            //Id_Sms varchar(15)	Checked
            //Stato   varchar(15) Checked
            //Data    datetime Checked
            //TipoMessaggio varchar(50)	Checked
            //Codice  nvarchar(10)    Checked
            //Denom   nvarchar(60)    Checked
            //iDUtente    int Checked
            //DataModifica datetime    Checked


            // passa tutti i record elaborati nello storico
            string sql = "INSERT INTO SMSStorico ( Data, Numero, Messaggio, Elaborato, id_sms, Stato, Data, TipoMessaggio, Codice, Denom, iDUtente, DataModifica) " +
                    "SELECT Data, Numero, Messaggio, Elaborato, id_sms, Stato, Data, TipoMessaggio, Codice, Denom, iDUtente, DataModifica FROM SMS WHERE Elaborato = 1";
            connKong.ExecQuery(sql);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Si è verificato un errore nello spostamento dei record nello storico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            // cancella tutti i record elaborati
            sql = "DELETE FROM SMS WHERE Elaborato = 1";
            connKong.ExecQuery(sql);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Si è verificato un errore nella cancellazione dei record.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("I record sono stati spostati nello storico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private async void btnElaborato_Click(object sender, EventArgs e)
        {
            // cambia lo stato da elaborato a non elaborato e viceversa

            if (txtId.Text == "")
            {
                MessageBox.Show("Non ci sono record da elaborare", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "UPDATE SMS SET Elaborato = ";

            if (chkElaborato.Checked == false)
            {
                sql += "1";
            }
            else
            {
                sql += "0";
            }

            sql += " WHERE Id = @Id";

            connKong.AddParam("@Id", txtId.Text);
            connKong.ExecQuery(sql);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Si è verificato un errore nell'aggiornamento del record.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("Il Record è stato aggiornato correttamente Cambiando il suo Stato.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }

        private async void btnElabora_Click(object sender, EventArgs e)
        {
            // la procedura elabora tutti i record non elaborati
            // andando a vedere se il messaggio inviato ha avuto una ritorno di qualche tipo

            // guarda se ci sono record
            //if (txtId.Text == "")
            //{
            //    MessageBox.Show("Non ci sono record da elaborare", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            // apre la tabella con la query dove i record non sono elaborati

            string sql = "SELECT * FROM SMS WHERE Elaborato = 0";
            DataTable dt = new DataTable();

            connKong.ExecQuery(sql);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Si è verificato un errore nell'apertura della tabella.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // se non ci sono record non elaborati
            if (connKong.DBDT.Rows.Count == 0)
            {
                MessageBox.Show("Non ci sono record da elaborare", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dt = connKong.DBDT;

            CSMS sms = new CSMS();
            string StatoAttuale = "";
            string StatoRitorno = "";
            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // controlla se il record è stato elaborato
                if (dt.Rows[i]["Elaborato"].ToString() == "False")
                {
                    // controlla se il record ha un ritorno

                    sms._iDMessaggio = dt.Rows[i]["ID_SMS"].ToString();
                    StatoAttuale = dt.Rows[i]["Stato"].ToString();
                    var s = await sms.ControllaStatoSMS();


                    if (s != null)
                    {
                        StatoRitorno = s;

                        if (StatoRitorno != StatoAttuale)
                        {
                            // aggiorna il record                            
                            sql = "UPDATE SMS SET Elaborato = 1, Stato = '" + StatoRitorno + "' WHERE ID = " + dt.Rows[i]["ID"].ToString();
                            connKong.ExecQuery(sql);
                            if (connKong.HasException(true))
                            {
                                sb.Append(dt.Rows[i]["ID_SMS"].ToString());
                                sb.Append(" - ");
                                return;
                            }
                        }
                    }

                }
            }



            // scorre tutto il recordset

            //    CSMS sms = new CSMS();
            //foreach (DataRow row in dt.Rows)
            //{
            //    // per ogni record controlla se c'è un ritorno
            //    sms._iDMessaggio = row["ID_SMS"].ToString();
            //    var s = await sms.ControllaStatoSMS();
            //    if (s != null)
            //    {
            //        // se c'è un ritorno aggiorna il record
            //        string sql1 = "UPDATE SMS SET Elaborato = 1, Stato = @StatoRitorno WHERE Id = @ID";
            //        connKong.AddParam("@StatoRitorno", s);
            //        connKong.AddParam("@ID", row["Id"].ToString());
            //        connKong.ExecQuery(sql1);
            //        if (connKong.HasException(true))
            //        {
            //            MessageBox.Show("Si è verificato un errore nell'aggiornamento del record.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //    }
            //}












            // scorre tutta la tabella e per ogni record va a vedere se c'è un ritorno
            // se c'è un ritorno aggiorna il record con il messaggio di ritorno
            // il messaggio di ritorno potrebbe avere lo status uguale a prima
            // in quel caso non aggiorna il record
            // se lo status è diverso da prima aggiorna il record

            //CSMS sms = new CSMS();
            //StringBuilder sb = new StringBuilder();

            //// scorre la tabella
            //foreach (DataRowView rowView in bsSMS)
            //{
            //    // controlla se il record è stato elaborato
            //    DataRow row = rowView.Row;
            //    if (row["Elaborato"].ToString() == "False")
            //    {
            //        sms._iDMessaggio = row["ID_SMS"].ToString();
            //        string StatoAttuale = row["Stato"].ToString();
            //        var s = await sms.ControllaStatoSMS();

            //        if (s != null)
            //        {
            //            string StatoRitorno = s;

            //            if (StatoRitorno != StatoAttuale)
            //            {
            //                // aggiorna il record
            //                string sql = "UPDATE SMS SET Elaborato = 1, Stato = @StatoRitorno WHERE Id = @ID";
            //                connKong.AddParam("@StatoRitorno", StatoRitorno);
            //                connKong.AddParam("@ID", row["Id"].ToString());
            //                connKong.ExecQuery(sql);

            //                if (connKong.HasException(true))
            //                {
            //                    sb.Append(row["ID_SMS"].ToString());
            //                    sb.Append(" - ");
            //                    return;
            //                }
            //            }
            //        }
            //    }
            //}

            if (sb.Length > 0)
            {
                MessageBox.Show("Si è verificato un errore nell'aggiornamento dei record con ID: " + sb.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("I record sono stati aggiornati correttamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtId.Text);
                //ClearFields();
                LoadData();
                bsSMS.Find("Id", pos);
            }
            else
            {
                LoadData();
            }
        }
    }
}
