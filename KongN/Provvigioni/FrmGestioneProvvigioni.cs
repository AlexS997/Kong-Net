using KongN.Classi;
using KongN.Find;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Provvigioni
{
    public partial class FrmGestioneProvvigioni : Form
    {

        SQLControl SQLKONG = new SQLControl(Global.connKongN);
        SQLControl SQL = new SQLControl(Global.connAna);

        private DataTable _DT = new DataTable();
        private DataTable _DTFattureNonPagate = new DataTable();

        AgentiProvvigioni AP = new AgentiProvvigioni();
        List<String> articoli = new List<String>();

        private bool mancanopagamenti = false;
        private bool bSalva = false;

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

        private void dgvFatture_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgvFatture.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dgvFatture.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        public FrmGestioneProvvigioni()
        {
            InitializeComponent();
            dgv.RowPrePaint += dgv_RowPrePaint;
            dgvFatture.RowPrePaint += dgvFatture_RowPrePaint;
        }

        private void FrmGestioneProvvigioni_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            double? incassato = 0;
            double? importoscadenza = 0;
            // bool bRet = true;
            if (Controlla())
            {
                estraidatiKing();
                mancanopagamenti = false;

                string query = "Select * from AgentiProvvigioni Order by Datadoc,NumDoc,Cliente";
                SQLKONG.ExecQuery(query);

                if (SQLKONG.HasException(true))
                {
                    MessageBox.Show(" Si è verificata un'Eccezione nell'estrazione dei dati dalla tabella AgentiProvvigioni");
                    return;
                }

                _DT = SQLKONG.DBDT;
                dgv.DataSource = _DT;

                if (dgv.Rows.Count > 0)
                {
                    ContaProvvigioni();
                }


                foreach (DataGridViewRow row in dgv.Rows)
                {

                    if (row.Index % 2 == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightBlue;

                    }
                    // deve vedere se la colonna incassato is ugual to column importoscadenza
                    // se non è uguale deve colorare la riga di giallo

                    incassato = (double?)row.Cells["Incassato"].Value;
                    importoscadenza = (double?)row.Cells["ImportoScadenza"].Value;

                    if (incassato != importoscadenza)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        mancanopagamenti = true;
                    }
                }

            }
        }

        private bool Controlla()
        {
            bool ritorno = true;
            bool bRet = true;

            if (string.IsNullOrEmpty(txtAgente.Text))

            {
                MessageBox.Show("Il campo dell'agente non può essere vuoto.", "Parametri non sufficienti", MessageBoxButtons.OK, MessageBoxIcon.Question);
                ritorno = false;
            }

            if (dtpStart.Value > dtpEnd.Value)

            {
                MessageBox.Show("La seconda data non può essere inferiore alla prima", "Parametri non sufficienti", MessageBoxButtons.OK, MessageBoxIcon.Question);

                ritorno = false;
            }


            // bRet = ControllaStorico();
            {
                if (bRet == false)
                {
                    ritorno = false;
                }

            }
            return ritorno;
        }

        private void estraidatiKing()
        {

            // vuota la tabella di destinazione
            CancellaTabella();

            // riempie la tabella degli articoli da includere
            ArticoliCompresi();

            // crea una stringa dalla list articoli di tutti gli articoli da includere
            string a = "";

            for (int i = 0; i < articoli.Count; i++)

                a = a + "'" + articoli[i].ToString() + "',";

            // rimuove l'ultima virgola
            a = a.Substring(0, a.Length - 1);

            // modifica fatta in data 13/11/2023 per fargli prendere anche gli * in caso di note di credito
            a = a + ",'*'";

            // a.Remove(0,a.Length-1);

            SQL.AddParam("@agente", txtAgente.Text);
            SQL.AddParam("@dadata", dtpStart.Value);
            SQL.AddParam("@adata", dtpEnd.Value);


            string query = " SELECT  FattTest.Anno, FattTest.NumDoc, FattTest.DataDoc, FattTest.Cliente, Clienti.Denom, FattTest.Agente, TabAge.Descrizione,TabAge.PercProv, FattTest.TotMerce, FattTest.TotDocum, FattTest.CodDoc, BolFatDett.Nriga, BolFatDett.Importo," +

                          "MovContScad.NumRiga, MovContScad.Partita, MovContScad.DataScad, MovContScad.Importo AS ImportoScadenza, MovContScad.Incassato, MovMagDett.CodArt,MovMagDett.Qta, MovMagDett.ImpUni, MovMagDett.ValoreMov, round( (TabAge.PercProv * MovMagDett.ValoreMov/100),2) as Provvigioni " +
                          " FROM  BolFatDett INNER JOIN FattTest ON BolFatDett.IDTest = FattTest.ID " +

                          " INNER JOIN Clienti ON FattTest.Cliente = Clienti.CodCli" +

                          " INNER JOIN MovContTest ON FattTest.IDMovCont = MovContTest.ID " +

                          " INNER JOIN MovContScad ON MovContTest.ID = MovContScad.IDMov " +

                          " INNER JOIN MovMagDett ON BolFatDett.ID = MovMagDett.IDdettDoc " +

                          " INNER JOIN TabAge on TabAge.CodAge= FattTest.Agente " +
                          // modifca fatta in data 10/11/2023 per fare in modo che vengano considerati anche i documenti non completamente pagati
                          //" WHERE(BolFatDett.Importo > 0) AND(MovContTest.DataMov > CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) AND(MovContScad.FlagStato = 'C') AND(MovContScad.Incassato > 0)" +
                          " WHERE(BolFatDett.Importo > 0) AND(MovContTest.DataMov > CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) AND(MovContScad.FlagStato = 'C') " +

                          " and(FattTest.Agente = @agente and(FattTest.datadoc between convert(datetime, @dadata, 102) and convert(datetime, @adata, 102)))" +

                          " And MovMagDett.CodArt  in (" + a + ")" +

                          " ORDER BY FattTest.NumDoc,BolFatDett.Nriga, FattTest.DataDoc, FattTest.Cliente";


            SQL.ExecQuery(query);

            if (SQL.HasException(true))
            {
                MessageBox.Show(" Si è verificata un'Eccezione");
                return;

            }

            else
            {
                _DT = SQL.DBDT;

                // deve controllare se ci sono note di credito in base al tipo documento
                // se ci sono deve mettere l'importo negativo
                foreach (DataRow row in _DT.Rows)
                {
                    if (row["CodDoc"].ToString() == "NOTCLI")
                    {
                        row["ImportoScadenza"] = -(double)row["ImportoScadenza"];

                    }
                }

                dgv.DataSource = _DT;
                if (dgv.Rows.Count > 0)
                {
                    ContaProvvigioni();
                }

            }

            // esegue la query per estrarre le fatture non pagate   

            SQL.AddParam("@agente", txtAgente.Text);
            SQL.AddParam("@dadata", dtpStart.Value);
            SQL.AddParam("@adata", dtpEnd.Value);


            query = " SELECT  FattTest.Anno, FattTest.NumDoc, FattTest.DataDoc, FattTest.Cliente, Clienti.Denom, FattTest.Agente, TabAge.Descrizione,TabAge.PercProv, FattTest.TotMerce, FattTest.TotDocum, FattTest.CodDoc, BolFatDett.Nriga, BolFatDett.Importo," +

                         "MovContScad.NumRiga, MovContScad.Partita, MovContScad.DataScad, MovContScad.Importo AS ImportoScadenza, MovContScad.Incassato, MovMagDett.CodArt,MovMagDett.Qta, MovMagDett.ImpUni, MovMagDett.ValoreMov, round( (TabAge.PercProv * MovMagDett.ValoreMov/100),2) as Provvigioni " +
                        " FROM  BolFatDett INNER JOIN FattTest ON BolFatDett.IDTest = FattTest.ID " +

                         " INNER JOIN Clienti ON FattTest.Cliente = Clienti.CodCli" +

                         " INNER JOIN MovContTest ON FattTest.IDMovCont = MovContTest.ID " +

                         " INNER JOIN MovContScad ON MovContTest.ID = MovContScad.IDMov " +

                         " INNER JOIN MovMagDett ON BolFatDett.ID = MovMagDett.IDdettDoc " +

                         " INNER JOIN TabAge on TabAge.CodAge= FattTest.Agente " +
                         // modifca fatta in data 10/11/2023 per fare in modo che vengano considerati anche i documenti non completamente pagati
                         " WHERE(BolFatDett.Importo > 0) AND(MovContTest.DataMov > CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) AND(MovContScad.FlagStato = 'C') AND(MovContScad.Incassato = 0)" +
                         //" WHERE(BolFatDett.Importo > 0) AND(MovContTest.DataMov > CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) AND(MovContScad.FlagStato = 'C') " +

                         " and(FattTest.Agente = @agente and(FattTest.datadoc between convert(datetime, @dadata, 102) and convert(datetime, @adata, 102)))" +

                         " And MovMagDett.CodArt  in (" + a + ")" +

                         " ORDER BY FattTest.NumDoc,BolFatDett.Nriga, FattTest.DataDoc, FattTest.Cliente";


            SQL.ExecQuery(query);
            if (SQL.HasException(true))
            {
                MessageBox.Show(" Si è verificata un'Eccezione");
                return;

            }


            _DTFattureNonPagate = SQL.DBDT;
            dgvFatture.DataSource = _DTFattureNonPagate;
            // ci sono righe con fatture non pagate
            // deve allora andare a gestire queste righe andando a copiarle nella tabella
            //AgentiFattureNonPagate controllando se gia' non vi sono
            // nello stesso tempo va a vedere se c'erano righe che nel frattempo sono state pagate 
            // e le va ad aggiungere alla tabella AgentiProvvigioni
            // se l'utente salva va a cancellare le righe trasferite nella tabella AgentiFattureNonPagate
            // tutto questo lo fa chiamand un metodo che si chiama GestisciFattureNonPagate

            if (dgvFatture.Rows.Count > 0)
            {
                GestisciFattureNonPagate();
            }

            btnSalva.Visible = true;
            btnSalva.PerformClick();
            btnSalva.Visible = false;

            if (mancanopagamenti == true)
            {
                MessageBox.Show("Ci sono delle fatture che non sono state completamente pagate. Controllare la tabella AgentiProvvigioni", "Messaggio di Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tutte le fatture sono state completamente pagate. Controllare la tabella AgentiProvvigioni", "Messaggio di Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CancellaRigheNonCoerenti();

        }

        private void GestisciFattureNonPagate()
        {
            // cancella le righe dalla tabella AgentiFattureNonPagate che sono state pagate
            // e aggiunge le righe che sono state pagate alla tabella AgentiProvvigioni
            // controlla che non vi siano righe che sono state pagate e che non sono state aggiunte alla tabella AgentiProvvigioni
            // se ci sono righe che sono state pagate e che non sono state aggiunte alla tabella AgentiProvvigioni
            // chiede conferma della volonta di aggiungere le righe
            // se la risposta è si aggiunge le righe alla tabella AgentiProvvigioni
            // se la risposta è no esce
            // controlla che vi siano righe che sono state pagate e che non sono state aggiunte alla tabella AgentiProvvigioni
            // se non ci sono righe che sono state pagate e che non sono state aggiunte alla tabella AgentiProvvigioni
            // chiede conferma della volonta di cancellare le righe
            // se la risposta è si cancella le righe dalla tabella AgentiFattureNonPagate
            // se la risposta è no esce
            // controlla che vi siano righe che sono state pagate e che non sono state aggiunte alla tabella AgentiProvvigioni
            // se non ci sono righe che sono state pagate e che non sono state aggiunte alla tabella AgentiProvvigioni
            // chiede conferma della volonta di aggiungere le righe
            // se la risposta è si aggiunge le righe alla tabella AgentiProvvigioni
            // se la risposta è no esce
            // controlla che vi siano righe che sono state pagate e che non sono state aggiunte alla tabella AgentiProvvigioni

            string numdoc = "";
            string agente = "";

            // variabile di tipo DateTime che contiene la data di oggi
            DateTime DataDoc = DateTime.Now;

            // crea una list dove andra' a mettere le righe della Datagridview _DTFattureNonPagate
            // che ha spostato nella tabella in modo che alla fine possa cancellare le righe dalla Datagridview _DTFattureNonPagate

            foreach (DataRow row in _DTFattureNonPagate.Rows)
            {
                numdoc = (string)row["NumDoc"].ToString();
                agente = (string)row["Agente"].ToString();
                DataDoc = (DateTime)row["DataDoc"];

                // deve determinare il numero di row
                //della Datagridview _DTFattureNonPagate

                // riga = _DTFattureNonPagate.Rows.IndexOf(row);


                // controlla che non vi sia gia' la fattura archiviata
                string query = "Select * from AgentiFattureNonPagate where Agente='" + agente + "' and NumDoc='" + numdoc + "' and DataDoc='" + DataDoc.ToString("dd-MM-yyyy") + "'";
                SQLKONG.ExecQuery(query);

                if (SQLKONG.HasException(true))
                {
                    MessageBox.Show(" Si è verificata un'Eccezione");
                    return;

                }
                else
                {
                    if (SQLKONG.DBDT.Rows.Count == 0)
                    {
                        // salva la riga nel database

                        query = "INSERT INTO AgentiFattureNonPagate (anno,NumDoc,DataDoc,Cliente,Denom,Agente,Descrizione,PercProv,TotMerce,TotDocum,CodDoc,NRiga," +
                                    "Importo,NumRiga,Partita,DataScad,ImportoScadenza,Incassato,CodArt,Qta,ImpUni,ValoreMov,Provvigioni)" +
                                " VALUES (@anno,@NUmDoc,@DataDoc,@Cliente,@Denom,@Agente,@Descrizione,@PercProv,@TotMerce,@TotDocum,@CodDoc,@NRiga," +
                                    "@Importo,@NumRiga,@Partita,@DataScad,@ImportoScadenza,@Incassato,@CodArt,@Qta,@ImpUni,@ValoreMov,@Provvigioni)";

                        SQLKONG.AddParam("@anno", row["Anno"].ToString());
                        SQLKONG.AddParam("@NUmDoc", row["NumDoc"].ToString());
                        SQLKONG.AddParam("@DataDoc", row["DataDoc"].ToString());
                        SQLKONG.AddParam("@Cliente", row["Cliente"].ToString());
                        SQLKONG.AddParam("@Denom", row["Denom"].ToString());
                        SQLKONG.AddParam("@Agente", row["Agente"].ToString());
                        SQLKONG.AddParam("@Descrizione", row["Descrizione"].ToString());
                        SQLKONG.AddParam("@PercProv", row["PercProv"]);
                        SQLKONG.AddParam("@TotMerce", row["TotMerce"]);
                        SQLKONG.AddParam("@TotDocum", row["TotDocum"]);
                        SQLKONG.AddParam("@CodDoc", row["CodDoc"].ToString());
                        SQLKONG.AddParam("@NRiga", row["Nriga"]);
                        SQLKONG.AddParam("@Importo", row["Importo"]);
                        SQLKONG.AddParam("@NumRiga", row["NumRiga"]);
                        SQLKONG.AddParam("@Partita", row["Partita"].ToString());
                        SQLKONG.AddParam("@DataScad", row["DataScad"].ToString());
                        SQLKONG.AddParam("@ImportoScadenza", row["ImportoScadenza"]);
                        SQLKONG.AddParam("@Incassato", row["Incassato"]);
                        SQLKONG.AddParam("@CodArt", row["CodArt"].ToString());
                        SQLKONG.AddParam("@Qta", row["Qta"]);
                        SQLKONG.AddParam("@ImpUni", row["ImpUni"]);
                        SQLKONG.AddParam("@ValoreMov", row["ValoreMov"]);
                        SQLKONG.AddParam("@Provvigioni", row["Provvigioni"]);

                        SQLKONG.ExecQuery(query);

                        if (SQLKONG.HasException(true))
                        {
                            MessageBox.Show("Si è verificata un'Eccezione");
                            return;

                        }
                        else
                        {
                            // aggiunge in numero di riga alla list
                            //

                        }
                    }
                }

            }

            //adesso va a controllare tutte le righe della tabella AgentiFattureNonPagate
            // e va a vedere se nel frattempo sono state pagate
            // se sono state pagate le va ad aggiungere alla tabella AgentiProvvigioni
            // e le cancella dalla tabella AgentiFattureNonPagate

            SonoStatePagate();

        }

        private void CancellaRigheNonCoerenti()
        {

            string query = "";

            query = "DELETE from AgentiProvvigioni WHERE ImportoScadenza < 0 AND (ABS(Incassato) - ABS(ImportoScadenza) = 0)";
            SQLKONG.ExecQuery(query);

            if (SQLKONG.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;

            }

            query = "DELETE from AgentiProvvigioni WHERE Incassato = 0 AND ImportoScadenza > 0";
            SQLKONG.ExecQuery(query);

            if (SQLKONG.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;

            }

            query = "Select * from AgentiProvvigioni Order By DataDoc,Cliente";
            SQLKONG.ExecQuery(query);

            if (SQLKONG.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;

            }

            _DT = SQLKONG.DBDT;

            dgv.DataSource = _DT;
        }

        private void SonoStatePagate()
        {
            // deve controllare se la fattura è stata pagata
            // se è stata pagata deve aggiungere la riga alla tabella AgentiProvvigioni
            // e cancellarla dalla tabella AgentiFattureNonPagate
            // se non è stata pagata deve cancellarla dalla tabella AgentiFattureNonPagate
            // deve controllare che non vi sia gia' la fattura archiviata
            // se non vi è la fattura archiviata deve aggiung

            string queryKing = "";

            string query = "Select * from AgentiFattureNonPagate";
            SQLKONG.ExecQuery(query);

            if (SQLKONG.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;
            }

            if (SQLKONG.DBDT.Rows.Count == 0)
            {
                return;
            }

            foreach (DataRow row in SQLKONG.DBDT.Rows)
            {

                queryKing = "Select * from MovContScad where Partita='" + row["Partita"].ToString() + "' and FlagStato = 'C' AND (Incassato > 0  AND Importo >0) AND (Incassato - Importo=0)";

                SQL.AddParam("@Partita", row["Partita"].ToString());
                SQL.ExecQuery(queryKing);

                if (SQL.HasException(true))
                {
                    MessageBox.Show("Si è verificata un'Eccezione");
                    return;
                }

                if (SQL.DBDT.Rows.Count == 0)
                {
                    // non e' stata pagata
                    continue;
                }

                // prende la riga dalla tabella AgentiFattureNonPagate
                // e la aggiunge alla tabella AgentiProvvigioni
                // e la cancella dalla tabella AgentiFattureNonPagate


                AP.Add();
                AP.DataDoc = (DateTime)row["DataDoc"];
                AP.NumDoc = row["NumDoc"].ToString();
                AP.Anno = row["Anno"].ToString();
                AP.Cliente = row["Cliente"].ToString();
                AP.Denom = row["Denom"].ToString();
                AP.Agente = row["Agente"].ToString();
                AP.Descrizione = row["Descrizione"].ToString();
                AP.PercProv = (float?)row["PercProv"];
                AP.TotMerce = (double?)row["TotMerce"];
                AP.TotDocum = (double?)row["TotDocum"];
                AP.CodDoc = row["CodDoc"].ToString();
                AP.Nriga = (short?)row["Nriga"];
                AP.Importo = (double?)row["Importo"];
                AP.NumRiga = (short?)row["NumRiga"];
                AP.Partita = row["Partita"].ToString();
                AP.DataScad = (DateTime?)row["DataScad"];
                AP.ImportoScadenza = (double?)row["ImportoScadenza"];
                AP.Incassato = (double?)row["Incassato"];
                AP.CodArt = row["CodArt"].ToString();
                AP.Qta = (double?)row["Qta"];
                AP.ImpUni = (double?)row["ImpUni"];
                AP.ValoreMov = (double?)row["ValoreMov"];
                AP.Provvigioni = (double?)row["Provvigioni"];
                AP.Update();

                // cancella la riga dalla tabella AgentiFattureNonPagate
                query = "Delete from AgentiFattureNonPagate where Partita='" + row["Partita"].ToString() + "' ";
                SQLKONG.ExecQuery(query);

                if (SQLKONG.HasException(true))
                {
                    MessageBox.Show("Si è verificata un'Eccezione");
                    return;
                }
            }
        }

        private void ContaProvvigioni()
        {
            double? incassato = 0;
            double? importoscadenza = 0;

            lblConteggioProvvigioni.Visible = true;

            double? p = 0;
            int j = 0;
            double? s = 0;

            for (int i = 0; i < dgv.RowCount; i++)
            {

                try
                {
                    incassato = (double?)dgv.Rows[i].Cells["Incassato"].Value;
                    importoscadenza = (double?)dgv.Rows[i].Cells["ImportoScadenza"].Value;

                    if (incassato == importoscadenza)
                    {
                        p = (double)dgv.Rows[i].Cells[22].Value;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Si è verificata un'Eccezione: " + e);
                    return;

                }

                s = s + p;

            }

            String.Format("{0:0.00}", s);

            lblConteggioProvvigioni.Text = "Conteggio Provvigioni : " + Math.Round(s ?? 0, 2).ToString("0.00");

        }

        private void CancellaTabella()
        {
            string query = "Delete from AgentiProvvigioni DBCC CHECKIDENT ('AgentiProvvigioni', RESEED, 0)";
            SQLKONG.ExecQuery(query);

            if (SQLKONG.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;

            }
            else
            {
                query = "Select * from AgentiProvvigioni";
                SQLKONG.ExecQuery(query);
            }
        }

        private bool ArticoliCompresi()
        {
            string query = "Select * from ArticoliProvvigioni";
            SQLKONG.ExecQuery(query);

            if (SQLKONG.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return false;

            }

            if (SQLKONG.DBDT.Rows.Count == 0)
            {

                MessageBox.Show("La tabella degli articoli per le provvigioni degli agenti è vuota. Non posso prosegire.", "Dati Mancanti", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return false;

            }
            else
            {
                foreach (DataRow row in SQLKONG.DBDT.Rows)
                    articoli.Add(row.ItemArray[0].ToString());
                return true;
            }
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgente_Click(object sender, EventArgs e)
        {

            string query = "Select codage,descrizione from TabAge Order by Codage";

            SQL.ExecQuery(query);

            if(SQL.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Agente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormFind frm = new FormFind();

            frm.Text = "Ricerca Agente";

            frm._DT = SQL.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                txtAgente.Text = frm._ReturnData["CodAge"].ToString();
                lblAgenteNome.Text = frm._ReturnData["Descrizione"].ToString();
            }

        }

        private void btnCancellaRiga_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0) return;

            if (dgv.SelectedRows.Count > 0)
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
                _DT.AcceptChanges();

                ContaProvvigioni();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0) return;
            try
            {
                CancellaTabella();
                SalvaRecord();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Si è verificata un'Eccezione: " + ex);
                return;
            }

            MessageBox.Show("I dati sono stati salvati.", "Messaggio di Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bSalva = true;
        }

        private void SalvaRecord()
        {

            foreach (DataRow row in _DT.Rows) //SQL.DBDT.Rows)
            {
                AP.Add();

                AP.Anno = row.ItemArray[0].ToString();
                AP.NumDoc = row.ItemArray[1].ToString();
                AP.DataDoc = (DateTime)row.ItemArray[2];
                AP.Cliente = row.ItemArray[3].ToString();
                AP.Denom = row.ItemArray[4].ToString();
                AP.Agente = row.ItemArray[5].ToString();
                AP.Descrizione = row.ItemArray[6].ToString();
                AP.PercProv = (float?)row.ItemArray[7];
                AP.TotMerce = (double?)row.ItemArray[8];
                AP.TotDocum = (double?)row.ItemArray[9];
                AP.CodDoc = row.ItemArray[10].ToString();
                AP.Nriga = (short?)row.ItemArray[11];
                AP.Importo = (double?)row.ItemArray[12];
                AP.NumRiga = (short?)row.ItemArray[13];
                AP.Partita = row.ItemArray[14].ToString();
                AP.DataScad = (DateTime?)row.ItemArray[15];
                AP.ImportoScadenza = (double?)row.ItemArray[16];
                AP.Incassato = (double?)row.ItemArray[17];
                AP.CodArt = row.ItemArray[18].ToString();
                AP.ImpUni = (double?)row.ItemArray[19];
                AP.ValoreMov = (double?)row.ItemArray[20];
                AP.Provvigioni = (double?)row.ItemArray[22];

                AP.Update();

            }
        }
    }
}
