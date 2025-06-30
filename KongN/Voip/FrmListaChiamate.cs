using KongN.Classi;
using KongN.Find;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Voip
{
    public partial class FrmListaChiamate : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        SQLControl connAna = new SQLControl(Global.connAna);

        DataTable dt = new DataTable();

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }

        public FrmListaChiamate()
        {
            InitializeComponent();
        }

        private void FrmListaChiamate_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            //dtpInizio.Value = DateTime.Now;
            //dtpFine.Value = DateTime.Now;

            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
        }


        private void btnCliente_Click(object sender, EventArgs e)
        {

            string query = "Select * from VoipContratti order BY CodCli";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Contratti Voip.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = connKong.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                // riporta i campi prendendoli da frm._ReturnData

                txtCodCli.Text = frm._ReturnData["CodCli"].ToString();
                lblContratto.Text = frm._ReturnData["idContratto"].ToString();

            }
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            /*
           *
           *Svuotamento dei dati della
           *tabella tmpTabellaFatturazione
           *
           *
           */

            string sql = @"delete from  VoiptmpListaChiamate DBCC CHECKIDENT ('VoiptmpListaChiamate', RESEED, 0)";
            connKong.ExecQuery(sql);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nella cancellazione dei dati dentro la tabella");
                Cursor = Cursors.Default;
                return;
            }

            /*--------------------------------------
              popola la tabella tmpListaChiamate    
              con i dati estratti dalla tabella dettaglio
              e dalla tabella cliente
             ----------------------------------------*/

            if (PplTmpFattClient() != "")
            {
                Cursor = Cursors.Default;
                return;
            }

            /*------------------------
             inserisce lo scatto alla risposta
            se previsto dall'offerta
            --------------------------*/



            sql = "SELECT * FROM VoiptmpListaChiamate Order by Data, OraChiamata ";
            connKong.ExecQuery(sql);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore alla tabella VoiptmpListaChiamate");
                Cursor = Cursors.Default;
                return;
            }

            if (connKong.RecordCount == 0)
            {
                MessageBox.Show("La tabella risulta vuota");
                Cursor = Cursors.Default;
                return;
            }


            dt.Clear();
            dt = connKong.DBDT;
            Grid.DataSource = dt;

            Cursor = Cursors.Default;
        }

        private string PplTmpFattClient()
        {


            /*
             *popolamente della tabella tmpFatturazione
             *
             */
            string sql = @"INSERT INTO [dbo].[VoiptmpListaChiamate] (
                            [orachiamata],
                            [data],
                            [idDettaglio],
                            [contratto],
                            [nome],
                            [CodCli],
                            [NumeroVoip],
                            [Numeroportabilita],
                            [offerta], 
                            [durata]  
		                    )
   
                            SELECT 
                                voipdettaglio.orachiamata,
                                voipdettaglio.data,
	                            voipdettaglio.id,
                                VoipContratti.idContratto AS [contratto],
                                VoipContratti.nome,
                                VoipContratti.CodCli,
                                VoipContratti.voip,
                                VoipContratti.portabilita,
                                VoipContratti.offerta,
                                voipdettaglio.durata
                             FROM 
                                VoipContratti 
                             JOIN 
                                voipdettaglio ON voipdettaglio.chiamante in (VoipContratti.voip ,  VoiPContratti.portabilita)
    

                            WHERE   
                               (voipdettaglio.data >= @inizio AND voipdettaglio.data <= @fine)


                                    AND  voipcontratti.idcontratto ='" + lblContratto.Text + "'";



            connKong.Params.Clear();



            connKong.AddParam("@inizio", dtpStart.Value.Value.ToString("dd/MM/yyyy"));
            connKong.AddParam("@fine", dtpEnd.Value.Value.ToString("dd/MM/yyyy"));
            connKong.ExecQuery(sql);



            return "";
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
