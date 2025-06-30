using KongN.Classi;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Voip
{
    public partial class FrmConsumi : Form
    {
        
        SQLControl connKong = new SQLControl(Global.connKongN);

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }


        public FrmConsumi()
        {
            InitializeComponent();
        }


        private void FrmConsumi_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            lblRecord.Visible = false;
        }


        private void btnEstrai_Click(object sender, EventArgs e)
        {
            // testa se la data inserita è maggiore della data corrente
            //if (dtpConsumi.Value > DateTime.Now)
            //{
            //    MessageBox.Show("La data inserita è maggiore della data corrente");
            //    return;
            //}
            if (dtpRiferimento.Value > DateTime.Now)
            {
                MessageBox.Show("La data inserita è maggiore della data corrente");
                return;
            }

            // testa se la data inserita corrisponde all'ultimo giorno del mese
            //if (dtpConsumi.Value.Day != DateTime.DaysInMonth(dtpConsumi.Value.Year, dtpConsumi.Value.Month))
            //{
            //    MessageBox.Show("La data inserita non corrisponde all'ultimo giorno del mese");
            //    return;
            //}
            if (dtpRiferimento.Value.Value.Day != DateTime.DaysInMonth(dtpRiferimento.Value.Value.Year, dtpRiferimento.Value.Value.Month))
            {
                MessageBox.Show("La data inserita non corrisponde all'ultimo giorno del mese");
                return;
            }


            if (FillRecords() == true)
            {



            }
        }

        private bool FillRecords()
        {

            Cursor = Cursors.WaitCursor;

            string sql = "DELETE FROM voiptmpfatturazione  DBCC CHECKIDENT ('voiptmpfatturazione', RESEED, 0)";

            connKong.ExecQuery(sql);
            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nella cancellazione dei dati dentro la tabella");

                Cursor = Cursors.Default;
                return false;
            }
            /*
                  Calcola il periodo di inizio mese e fine mese
                  */
            int mesiDiFatturazione = 2; // Ad esempio, periodo di fatturazione di 3 mesi

            // Output delle date per verifica

            // pone la data di inizio togliendo i mesidifatturazione
            //DateTime DataInizio = dtpConsumi.Value.AddMonths(-mesiDiFatturazione);
            DateTime DataInizio = dtpRiferimento.Value.Value.AddMonths(-mesiDiFatturazione);
            // la data di inizio deve essere il primo giorno del mese
            DateTime inizio = new DateTime(DataInizio.Year, DataInizio.Month, 1);

            // la data di fine è la data inserita nel controllo dtpConsumi
            //DateTime DataFine = dtpConsumi.Value;
            DateTime DataFine = dtpRiferimento.Value.Value;



            sql = @"

            INSERT INTO[dbo].[voiptmpfatturazione] (
                [orachiamata],
                [data],
                [idDettaglio],
                [contratto],
                [nome],
                [CodCli],
                [telefono],
                [offerta],
                [durata],
                [secondi],
                [tipo],
                [ntipo],
                [importochiamata]

            )
            SELECT
                voipdettaglio.orachiamata,
                voipdettaglio.data,
                voipdettaglio.id,
                voipContratti.idContratto AS[contratto],
                voipContratti.nome,
                Contratti.CodCli,
                voipContratti.portabilita,
                voipContratti.offerta,
                voipdettaglio.durata,
                DATEDIFF(second, '0:0:0', voipdettaglio.durata) AS secondi,
                voipdettaglio.tipo,
                voipdettaglio.ntipo,
                voipdettaglio.importo
            FROM
                voipContratti
            JOIN
                voipdettaglio ON voipdettaglio.chiamante = voipContratti.portabilita
            JOIN
                Contratti ON voipContratti.idContratto = Contratti.IdContratto
            WHERE
                voipdettaglio.data >= @inizio AND voipdettaglio.data <= @fine";

            connKong.Params.Clear();
            connKong.AddParam("@inizio", DataInizio.ToString("dd-MM-yyyy"));
            connKong.AddParam("@fine", DataFine.ToString("dd-MM-yyyy"));
            connKong.ExecQuery(sql);


            sql = @"
	
	                INSERT INTO [dbo].[voiptmpfatturazione] (
                    [orachiamata],
                                [data],
                                [idDettaglio],
                                [contratto],
                                [nome],
                                [CodCli],
                                [telefono],
                                [offerta],
                                [durata],
                                [secondi],
                                [tipo],
                                [ntipo],
                                [importochiamata]
                )
                SELECT 
                    voipdettaglio.orachiamata,
                    voipdettaglio.data,
                    voipdettaglio.id,
                    voipContratti.idContratto AS [contratto],
                    voipContratti.nome,
                    Contratti.CodCli,
                    voipContratti.voip,
                    voipContratti.offerta,
                    voipdettaglio.durata,
                    DATEDIFF(second, '0:0:0', voipdettaglio.durata) AS secondi,
                    voipdettaglio.tipo,
                    voipdettaglio.ntipo,
                    voipdettaglio.importo
                FROM 
                    voipContratti
                JOIN 
                    voipdettaglio ON voipdettaglio.chiamante = voipContratti.voip
                JOIN 
                    Contratti ON voipContratti.idcontratto = Contratti.IdContratto
                WHERE 
                    voipdettaglio.data >= @inizio AND voipdettaglio.data <= @fine";


            connKong.Params.Clear();
            connKong.AddParam("@inizio", DataInizio.ToString("dd-MM-yyyy"));
            connKong.AddParam("@fine", DataFine.ToString("dd-MM-yyyy"));
            connKong.ExecQuery(sql);



            //chiama il metodo controlla per verificare alcune condizioni di errore
            if (Controlla() == false)
            {
                Cursor = Cursors.Default;
                return false;
            }


            // cancella i record che non rientrano nei consumi



            sql = @"update VoiPtmpFatturazione
                    set cancellare = 1
                    FROM VoiPtmpFatturazione 
                    INNER JOIN VoiPContratti ON VoiPtmpFatturazione.contratto = VoiPContratti.idContratto
                    WHERE( lastdata between  @Inizio and  @fine )";


            connKong.Params.Clear();
            connKong.AddParam("@Inizio", DataInizio.ToString("dd-MM-yyyy"));
            connKong.AddParam("@fine", DataFine.ToString("dd-MM-yyyy"));
            connKong.ExecQuery(sql);

            //------------------------------------------------------------
            // la parte di procedura che segue effettua le query necessarie

            //numera le chiamate


            if (NumeraChiamate() != "")
            {
                MessageBox.Show("Errore nella query di numerazione delle chiamate");
                Cursor = Cursors.Default;
                return false;
            }

            if (OffertaScatto() != "")
            {
                MessageBox.Show("Errore nella query di calcolo dello scatto alla risposta");
                Cursor = Cursors.Default;
                return false;
            }



            // cancella VoipTmpFatturazione dove cancellare=1
            sql = "delete from voiptmpfatturazione where cancellare=1";
            connKong.ExecQuery(sql);
            Cursor = Cursors.Default;


            //recupera la descrizione dell'offerta
            RecuperaDescrizione();





            // cancella la tabella del Voiptmpfatturazioneclone
            //e la riempie con i dati della voiptmpfatturazione raggruppati per contratto e tipo di chiamata

            FaiClone();


            // conteggio dei minuti compresi a secondo ell'offerta
            CalcolaMinutiCompresi();




            // facciamo calcolare al programma la spese per tipologia di chiamata per cliente
            // e per contratto
            // e per offerta

            CalcolaSpesa();


            //----------------- fine parte di procedura ------------------- 






            sql = "Select * from voiptmpfatturazioneClone order  BY CodCli,Contratto";
            connKong.ExecQuery(sql);
            Grid.DataSource = connKong.DBDT;
            if (connKong.DBDT.Rows.Count > 0)
            {
                lblRecord.Visible = true;
                lblRecord.Text = "Record presenti: " + connKong.DBDT.Rows.Count.ToString();
                Cursor = Cursors.Default;
                return true;
            }
            else
            {
                lblRecord.Visible = false;
                Cursor = Cursors.Default;
                return false;
            }
        }

        private bool Controlla()
        {

            // Verifica se ci sono chiamate senza offerta
            string messaggio = "";

            string sql = @"SELECT distinct VoiPtmpFatturazione.contratto FROM voiptmpfatturazione 
                   WHERE offerta = 0 or offerta is null";

            connKong.ExecQuery(sql);

            if (connKong.RecordCount > 0)
            {

                MessageBox.Show("Attenzione, ci sono chiamate senza offerta. Correggi i contratti che non hanno l'offerta inserita.");
                foreach (DataRow row in connKong.DBDT.Rows)
                {
                    messaggio += "Contratto: " + row["contratto"].ToString() + Environment.NewLine;

                }

                // mostra il messaggio con tutti i contratti non giusti
                MessageBox.Show(" Lista dei contratti con il campo offeta =0 oppure  nullo :" + messaggio);
                Cursor = Cursors.Default;
                return false;
            }


            //----------------------------------------------------







            sql = @"SELECT distinct VoiPtmpFatturazione.contratto
                    FROM VoiPtmpFatturazione 
                    INNER JOIN VoiPContratti 
                    ON VoiPtmpFatturazione.contratto = VoiPContratti.idContratto
                    WHERE(VoiPtmpFatturazione.data <= @data) AND lastdata is null";

            connKong.Params.Clear();
            //connKong.AddParam("@data", dtpConsumi.Value.ToString("dd-MM-yyyy"));
            connKong.AddParam("@data", dtpRiferimento.Value.Value.ToString("dd-MM-yyyy"));
            connKong.ExecQuery(sql);

            if (connKong.RecordCount > 0)
            {


                foreach (DataRow row in connKong.DBDT.Rows)
                {
                    messaggio += "Contratto: " + row["contratto"].ToString() + Environment.NewLine;

                }

                // mostra il messaggio con tutti i contratti non giusti
                MessageBox.Show(" Lista dei contratti con il campo Lastdata nullo :" + messaggio);
                Cursor = Cursors.Default;
                return false;
            }
            return true;

        }
        private string NumeraChiamate()
        {

            /*
             *La Query serve per popolare la colonna Nchiamate che e'
             *impostata a valore 1 servira' ad effetture la somma 
             *delle chiamate effettuate dall'utente
             *
             */
            string sql = "";


            //            sql = @"
            //                     UPDATE voiptmpfatturazione
            //SET secondiAddebitabili=
            //CASE WHEN importochiamata=0 
            //THEN 0 ELSE secondi END
            //FROM voiptmpfatturazione JOIN voipdettaglio 
            //ON voiptmpfatturazione.iddettaglio=voipdettaglio.id



            sql = @"UPDATE voiptmpfatturazione
                SET     nchiamateaddebitabili=CASE 
                WHEN voiptmpfatturazione.importochiamata=0 
                THEN 0  
                ELSE 1 
                END
                , nchiamate = 1, secondiAddebitabili = CASE 
                WHEN voiptmpfatturazione.importochiamata = 0 
                THEN 0 
                ELSE secondi
                END
                FROM voiptmpfatturazione 
                JOIN voipdettaglio 
                ON voiptmpfatturazione.iddettaglio = voipdettaglio.id";


            connKong.ExecQuery(sql);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore alla tabella voiptmpfatturazione");
                return connKong.Exception;
            }
            return "";
        }

        private string OffertaScatto()
        {
            string sql = "";

            /*
             *
             *Query che popola la tabella Tmpfatturazione la colonna scatto
             *Se la tariffa del cliente prevede lo scatto alla risposta alla
             *verifica se esiste un importo diverso da 0.
             *Se l'importo risulta diverso 0 scrive lo scatto alla risposta altrimenti popola la tabella uguale a zero
             *
             */



            sql = @"UPDATE       VoiPtmpFatturazione
                SET                ImportoScatto = 
                CASE WHEN (voipofferte.AllInclusive = 1 )
                then 0
                else    
                round(voipofferte.CostoScatto * nChiamateAddebitabili, 2)
                end

                FROM            VoiPtmpFatturazione INNER JOIN
                         VoiPofferte ON VoiPtmpFatturazione.offerta = VoiPofferte.idofferta";

            connKong.ExecQuery(sql);
            if (connKong.HasException(true))
            {

                return connKong.Exception;
            }
            return "";
        }

        private void RecuperaDescrizione()
        {
            string sql = @"UPDATE VoiPtmpFatturazione SET Descrizione = VoipTipoChiamate.Descrizione
                        FROM VoiPtmpFatturazione 
                        INNER JOIN VoipTipoChiamate ON VoiPtmpFatturazione.ntipo = VoipTipoChiamate.id";
            connKong.ExecQuery(sql);

        }

        private void FaiClone()
        {

            // cancella la tabella del Voiptmpfatturazioneclone
            //e la riempie con i dati della voiptmpfatturazione raggruppati per contratto e tipo di chiamata
            string sql = @"delete from voiptmpfatturazioneclone  DBCC CHECKIDENT ('voiptmpfatturazioneClone', RESEED, 0)
            
                    INSERT INTO VoiPtmpfatturazioneClone
                         (contratto, nome, CodCli, telefono, offerta, Tipo, Ntipo, descrizione, secondi, secondiAddebitabili, Nchiamate, NchiamateAddebitabili, ImportoChiamata,ImportoScatto)
                    SELECT        contratto, nome, CodCli, Telefono, offerta, tipo,NTipo,  Descrizione, SUM(secondi) AS Expr1, SUM(secondiAddebitabili) AS Expr2, SUM(Nchiamate) AS Expr3, SUM(NchiamateAddebitabili) AS Expr4, SUM(ImportoChiamata) 
                         AS Expr5, SUM(ImportoScatto) AS Expr6
                    FROM            VoiPtmpFatturazione
                    GROUP BY contratto, nome, CodCli, Telefono, offerta,  NTipo, tipo, Descrizione";


            connKong.ExecQuery(sql);
            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nella query di creazione della tabella voiptmpfatturazioneclone");
            }
        }

        private void CalcolaMinutiCompresi()
        {
            string sql = @"
           UPDATE       VoiPtmpfatturazioneClone
            SET                MinutiCompresiFissi =
					CASE WHEN 
					VoiPTipoChiamate.RifOfferta=1 AND VoiPTipoChiamate.Fisso=1
					then
					VoiPofferte.Minfisso * VoiPContratti.MesidiFatturazione
					else 0
					END
					
					
					,MinutiCompresiMobili =
					CASE WHEN 
					VoiPTipoChiamate.RifOfferta=1 AND VoiPTipoChiamate.Fisso=0
					then
					VoiPofferte.Minmobile * VoiPContratti.MesidiFatturazione
					else 0
					END


             FROM            VoiPtmpfatturazioneClone INNER JOIN
              VoipOfferte ON VoiPtmpfatturazioneClone.offerta = VoipOfferte.idofferta
				 join VoiPContratti on idContratto=contratto 
				 join  VoipTipoChiamate on ntipo=VoiPTipoChiamate.id

             update VoiPtmpfatturazioneClone
				 set Minutiaddebitabili= 
				 CASE WHEN 

				 (secondiAddebitabili /60) - (Minuticompresifissi + MinuticompresiMobili) <0
				 then
				 0
				 else
				 (secondiAddebitabili /60) - (Minuticompresifissi + MinuticompresiMobili)
				 end";

            connKong.ExecQuery(sql);
            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nella query di calcolo dei minuti compresi");
            }


        }

        private void CalcolaSpesa()
        {
            // facciamo calcolare al programma la spese per tipologia di chiamata per cliente
            // e per contratto
            // e per offerta
            // la prima parte calcolale spese per fissi e mobili italiani


            string sql = @"UPDATE       VoiPtmpfatturazioneClone
            SET                SpesaChiamata =round(( VoiPofferte.CostoVFissi * MinutiAddebitabili) + (VoiPofferte.CostoVMobili * MinutiAddebitabili),2)

            FROM            VoiPtmpfatturazioneClone INNER JOIN
                         VoiPofferte ON VoiPtmpfatturazioneClone.offerta = VoiPofferte.idofferta




             UPDATE VoiPtmpfatturazioneClone
            set SpesaTotale=round(Spesachiamata+ ImportoScatto,2)";

            connKong.ExecQuery(sql);
            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nella query di calcolo della spesa");
            }




            // calcola le spese per le chiamate di tipo diverso (internazionali,speciali, ecc)




            //-----------------------------------------------------

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
