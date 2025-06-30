using KongN.Classi;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KongN.Voip
{
    public partial class FrmDettagliInserimento : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);

        private bool _elaborato = false;
        private bool _salvato = false;
        string fileNameExcel = "";

        CVoIPofferte _offerta = new CVoIPofferte();
        CVoIPprefissi _prefisso = new CVoIPprefissi();

        DataTable dt = new DataTable();


        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }

        
        public FrmDettagliInserimento()
        {
            InitializeComponent();
        }

       
        private void FrmDettagliInserimento_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();

            lblPercorso.Visible = false;
            Bar.Visible = false;
        }
        
        
        private void LoadData()
        {
            string query = "select * from Voipdettagliotemp Order BY Data, Orachiamata";
            connKong.ExecQuery(query);

            if (connKong.HasException())
            {
                MessageBox.Show("Errore nella lettura della tabella.");
                return;
            }

            Grid.DataSource = connKong.DBDT;
            int r = connKong.DBDT.Rows.Count;

            lblRecord.Visible = true;
            lblRecord.Text = "Record Estratti: " + r.ToString();

            dt = connKong.DBDT;
        }


        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnImporta_Click(object sender, EventArgs e)
        {
            CalcolaDettagli();
        }


        private bool CalcolaDettagli()
        {

            // la procedura si occupa di andare a mettere nel campo spesa della tabella VoIPDettaglioTemp
            // il valore della spesa calcolata in base alla durata della chiamata e al prefisso
            // e in base al contratto che ha il cliente
            // per ogni riga del datatable va a vedere il prefisso e la durata
            // se il prefisso e' presente nella tabella VoipPrefissi


            double scattoSuPrefisso = 0;
            double scattoSuOfferta = 0;


            // scorre dt
            foreach (DataRow row in dt.Rows)
            {

                string chiamante = row[2].ToString();
                string prefisso = row[3].ToString();
                if (TrovaPrefisso(prefisso) == 1)
                {
                    // ha trovato il prefisso che contiene lo scatto

                    scattoSuPrefisso = (double)_prefisso.Scatto;

                }

                if (TrovaOffertaUtente(chiamante) == 1)
                {
                    // ha trovato il prefisso che contiene lo scatto
                    if (_offerta.Scatto == true)
                        scattoSuOfferta = (double)_offerta.CostoScatto;
                }

                // adesso da qui in poi deve calcolare la spesa
                // deve vedere se la durata e' minore di 60 secondi


            }
            return true;

        }

        private int TrovaPrefisso(string prefisso)
        {
            string query = "select * from VoipPrefissi where prefisso = @prefisso";

            connKong.AddParam("@prefisso", prefisso);
            connKong.ExecQuery(query);

            if (connKong.HasException())
            {
                MessageBox.Show("Errore nella lettura della tabella." + connKong.Exception);
                return 0;
            }

            if (connKong.DBDT.Rows.Count == 0)
            {
                // non lo ha trovato nella tabella VoipPrefissi
                // e quindi mette lo scatto che deriva dai numeri chiamati a zero

                _prefisso.Scatto = 0;
            }
            else
            {
                //TrovaOffertaUtente(chiamante);
                _prefisso.ID = Convert.ToInt32(connKong.DBDT.Rows[0]["id"].ToString());
                _prefisso.Get(_prefisso.ID);
                //_prefisso.Scatto = _prefisso.Scatto;

            }
            return 1;
        }

        private int TrovaOffertaUtente(string chiamante)
        {
            // cerca l'utente nella tabella VoipNumeriVoip
            // e se lo trova va a vedere se ha un offerta in cui e' previsto lo scatto o meno
            string query = "select * from VoIPNumerovoip where numerovoip = @numero or NumeroPortato = @numero or numeroportato1 = @numero ";
            
            connKong.AddParam("@numero", chiamante);
            connKong.ExecQuery(query);

            if (connKong.HasException())
            {
                MessageBox.Show("Errore nella lettura della tabella." + connKong.Exception);
                return 0;
            }

            if (connKong.DBDT.Rows.Count == 0)
            {
                // non lo ha trovato nella tabella VoipNumeriVoip
                // e quindi mette esce con errore
                return 0;
            }
            else
            {

                _offerta.Idofferta = Convert.ToInt32(connKong.DBDT.Rows[0]["idofferta"].ToString());
                _offerta.Get(_offerta.Idofferta);

            }
            return 1;
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Non ci sono dati da calcolare");
                return;
            }

            // crea una lista di stringhe
            //List<string> list = new List<string>();

            int count = 0;
            Bar.Visible = true;
            Bar.Value = 0;
            Bar.Minimum = 0;
            Bar.Maximum = dt.Rows.Count;
            foreach (DataRow row in dt.Rows)
            {
                Bar.Value += 1;
                string query = "select * from VoipPrefissi where prefisso = @prefisso";

                // deve togliere gli spazi dal prefisso
                row[3] = row[3].ToString().Replace(" ", "");

                // deve vedere se il prefisso inzia per 00
                // che e' estero
                if (row[3].ToString().Substring(0, 2) == "00")
                {
                    row[3] = row[3].ToString().Substring(2, row[3].ToString().Length - 2);
                }
                else
                {
                    // deve vedere se il prefisso inzia per 39
                    // che e' nazionale ma un fisso
                    if (row[3].ToString().Substring(0, 3) == "390")
                    {
                        // deve porre il prefisso solo delle prime tre cifre
                        row[3] = row[3].ToString().Substring(0, 3);
                        //row[3] = row[3].ToString().Substring(1, row[3].ToString().Length - 1);
                    }
                }




                connKong.AddParam("@prefisso", (row[3].ToString()));
                connKong.ExecQuery(query);

                if (connKong.HasException())
                {
                    MessageBox.Show("Errore nella lettura della tabella.");
                    return;
                }

                if (connKong.DBDT.Rows.Count == 0)
                {
                    //MessageBox.Show("Il prefisso " + row[3].ToString() + " non è presente nella tabella VoipPrefissi");
                    //c1FlexGrid1.Rows(1).StyleNew.BackColor = Color.Azure
                    // la row e' la riga del datatable
                    // mentre la flex.rows e' la riga della griglia
                    // la riga del datatable e' inferiore di 1 rispetto alla riga della griglia
                    //quindi deve fare dt.rows.indexof(row)-1

                    //int index = dt.Rows.IndexOf(row);
                    //index = index - 1;
                    //Flex.Rows[index].StyleNew.BackColor = Color.Red;
                    //Flex.Rows[dt.Rows-1.IndexOf(row)].StyleNew.BackColor=Color.Red;
                    //list.Add(row[3].ToString());
                    count += 1;
                    //return;
                }
            }
            Bar.Visible = false;
            if (count > 0)
            {
                MessageBox.Show("Ci sono " + count.ToString() + " telefonate con prefissi non presenti nella tabella VoipPrefissi. Vedi il file di log per vedere quali.");

            }
            //if( CalcolaDettagli()==false)
            // {
            //     MessageBox.Show("Errore nel calcolo dei dettagli");
            //     return;
            // }
            // _calcolato = true;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Non ci sono dati da salvare");
                return;
            }
            if (_elaborato == false)
            {
                MessageBox.Show("Devi prima elaborare i dati");
                return;
            }


            // salva bulk il datatable nella tabella VoIPDettagliotemp
            foreach (DataRow row in dt.Rows)
            {

                string query = "insert into dbo.VoIPDettaglioTemp (orachiamata, data, chiamante, prefisso, " +
                                        "chiamato, durata, importo, spesa, NTipo, DurataTime, SpesaScatto) " +
                                "values (@ora, @data, @chiamante, @prefisso, @chiamato, @durata, @importo, " +
                                        "@Spesa, @NTipo, @DurataTime, @SpesaScatto)";
                
                connKong.AddParam("@ora", row[0].ToString());
                connKong.AddParam("@data", row[1].ToString());
                connKong.AddParam("@chiamante", row[2].ToString());
                connKong.AddParam("@prefisso", row[3].ToString());
                connKong.AddParam("@chiamato", row[4].ToString());
                connKong.AddParam("@durata", row[5].ToString());
                connKong.AddParam("@importo", row[6].ToString());
                connKong.AddParam("@Spesa", row[7].ToString());
                connKong.AddParam("@NTipo", row[8].ToString());
                connKong.AddParam("@DurataTime", row[9].ToString());
                connKong.AddParam("@SpesaScatto", row[10].ToString());



                connKong.ExecQuery(query);
                if (connKong.HasException())
                {
                    MessageBox.Show("Errore nell'inserimento del numero " + row[0].ToString());
                    return;
                }
                MessageBox.Show("Inserimento effettuato correttamente");
                _salvato = true;
            }

            //apre la tabella VoIPDettaglioTemp e riempie la griglia
            string query2 = "select * from Voipdettagliotemp Order BY Data,Orachiamata";
            connKong.ExecQuery(query2);

            if (connKong.HasException())
            {
                MessageBox.Show("Errore nella lettura della tabella.");
                return;
            }


            Grid.DataSource = connKong.DBDT;
            dt = connKong.DBDT;
            int r = connKong.DBDT.Rows.Count;
            lblRecord.Text = "Record Estratti: " + r.ToString();

            _salvato = true;
        }

        private void btnElabora_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Non ci sono dati da elaborare");
                return;
            }
            // copia il campo durata nel campo DurataTime 

            foreach (DataRow row in dt.Rows)
            {
                string durata = row[5].ToString();
                TimeSpan d = TimeSpan.Parse(durata);
                //TimeSpan d= (TimeSpan)durata.ToString();

                row[9] = d;
            }

            _elaborato = true;
        }

        private void btnImportaExcel_Click(object sender, EventArgs e)
        {
            if (fileNameExcel == "")
            {
                MessageBox.Show("Non hai selezionato il file excel");
                return;
            }
            switch (MessageBox.Show("Attenzione se importi il file i dati prenderanno il posto di quelli presenti in griglia. Confermi?", "Messaggio di conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {


                case DialogResult.No:


                    break;


            }
            // deve cancellare la tabella Voipdettagliotemp
            if (VuotaTabelle() == false)
                return;
            try
            {    //contare le righe del file excel
                int count = File.ReadLines(fileNameExcel).Count();
                Bar.Visible = true;
                Bar.Value = 0;
                Bar.Minimum = 0;
                Bar.Maximum = count;

                using (var fs = File.OpenRead(fileNameExcel))
                using (var reader = new StreamReader(fs))
                {

                    while (!reader.EndOfStream)
                    {
                        Bar.Value += 1;
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        string query = "INSERT INTO Voipdettagliotemp (orachiamata, data, chiamante, prefisso, chiamato, durata, importo) " +
                                            "VALUES (@ora, @data, @chiamante, @pre, @chia, @durata, @importo)";
                        
                        //row[3] = row[3].ToString().Replace(" ", "");
                        // per ogni parametro deve togliere gli spazi
                        values[0] = values[0].ToString().Replace(" ", "");
                        values[1] = values[1].ToString().Replace(" ", "");
                        values[2] = values[2].ToString().Replace(" ", "");
                        values[3] = values[3].ToString().Replace(" ", "");
                        values[4] = values[4].ToString().Replace(" ", "");
                        values[5] = values[5].ToString().Replace(" ", "");
                        values[6] = values[6].ToString().Replace(" ", "");


                        connKong.AddParam("@ora", values[0]);
                        connKong.AddParam("@data", values[1]);
                        connKong.AddParam("@chiamante", values[2]);
                        connKong.AddParam("@pre", values[3]);
                        connKong.AddParam("@chia", values[4]);
                        connKong.AddParam("@durata", values[5]);
                        connKong.AddParam("@importo", values[6]);

                        connKong.ExecQuery(query);


                    }
                    Bar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Bar.Visible = false;

                MessageBox.Show("Errore nella lettura del file excel : " + ex.Message);

                return;
            }


            string query2 = "select * from Voipdettagliotemp Order BY Data,Orachiamata";
            connKong.ExecQuery(query2);
            if (connKong.HasException())
            {
                MessageBox.Show("Errore nella lettura della tabella.");
                return;
            }

            Grid.DataSource = connKong.DBDT;
            dt = connKong.DBDT;
            int r = connKong.DBDT.Rows.Count;
            lblRecord.Text = "Record Estratti: " + r.ToString();
        }

        private bool VuotaTabelle()
        {
            string query = "delete from dbo.VoIPDettaglioTemp";
            connKong.ExecQuery(query);

            if (connKong.HasException())
            {
                MessageBox.Show("Errore nella cancellazione della tabella.");
                return false;
            }
            return true;
        }

        private void btnScegli_Click(object sender, EventArgs e)
        {
            //Apre la finestra di dialogo per scegliere il file excel

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm;*.csv;";
            openFileDialog1.Title = "Seleziona il file excel";
            openFileDialog1.ShowDialog();
            fileNameExcel = openFileDialog1.FileName;
            if (fileNameExcel == "")
                return;
            lblPercorso.Text = fileNameExcel;
            lblPercorso.Visible = true;
        }
    }
}
