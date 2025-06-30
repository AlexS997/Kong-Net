using KongN.Classi;
using KongN.Find;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Controlli
{
    public partial class FrmPartiteAperte : Form

    {
        SQLControl Partite = new SQLControl(Global.connKongN);
        SQLControlSP sqlSP = new SQLControlSP(Global.connKongN);
        SQLControl Clienti = new SQLControl(Global.connAna);

        public FrmPartiteAperte()
        {
            InitializeComponent();

            Grid.QueryRowStyle += Grid_QueryRowStyle;
        }

        private void FrmPartiteAperte_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            dtpStart.Value = Convert.ToDateTime("01/01/" + DateTime.Now.Year);
            dtpEnd.Value = DateTime.Now;
            lblRecord.Visible = false;
        }


        private void Estrai()

        {

            // deleteall records from table PartiteAperte
            CancellaTabelle();

            // modificata con la store procedure per non fare tutto quel casino
            // 


            // Testa se è stato Scelto un cliente e pure il checkbox Esclusi
            // questo non è permesso
            if (txtCodiceCliente.Text != "" && chkEsclusi.Checked == true)
            {
                MessageBox.Show("Non è possibile scegliere un cliente e selezionare il checkbox Esclusi", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            sqlSP.AddParam("@DaData", dtpStart.Value);
            sqlSP.AddParam("@Adata", dtpEnd.Value);

            if (txtCodiceCliente.Text != "")
            {
                sqlSP.AddParam("@Cliente", txtCodiceCliente.Text);
            }

            if (chkEsclusi.Checked == true)
            {
                sqlSP.AddParam("@Esclusi", 1);
            }

            sqlSP.ExecStoredProcedure("sp_InserisciDatiPartiteAperte");
            if (sqlSP.HasException(true))
            {
                MessageBox.Show(" Si è verificata un'Eccezione");
                return;
            }

            string query = "Select * from PartiteAperte Order BY Codice,DataScad";
            Partite.ExecQuery(query);

            if (Partite.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;
            }

            Grid.DataSource = Partite.DBDT;

            int r = Partite.DBDT.Rows.Count;
            lblRecord.Visible = true;
            lblRecord.Text = "Record Estratti: " + r.ToString();
            if (r == 0)
            {
                MessageBox.Show("Non ci sono partite aperte");
                return;
            }
            return;



            //SqlConnection cnn = new SqlConnection(FunzioniComuni.GetConnectionStringByName("cnKong"));
            //cnn.Open();
            //SqlCommand cmd = new SqlCommand("[sp_InserisciDatiPartiteAperte]", cnn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@DaData", Da);
            //cmd.Parameters.AddWithValue("@Adata", A);
            //if (txtCodiceCliente.Text != "")
            //{
            //    cmd.Parameters.AddWithValue("@Cliente", txtCodiceCliente.Text);
            //}

            //if (chkEsclusi.Checked == true)
            //{
            //    cmd.Parameters.AddWithValue("@Esclusi", 1);
            //}



            //cmd.ExecuteNonQuery();

            //cnn.Close();

            //string query = "Select * from PartiteAperte Order BY Codice,DataScad";
            //sql.ExecQuery(query);
            //if (sql.HasException(true))
            //{
            //    MessageBox.Show(" Si è verificata un'Eccezione");

            //    return;

            //}

            //Flex.DataSource = sql.DBDT;
            //int r = sql.DBDT.Rows.Count;
            //lblRecord.Visible = true;
            //lblRecord.Text = "Record Estratti: " + r.ToString();
            //if (r == 0)
            //{
            //    MessageBox.Show("Non ci sono partite aperte");

            //    return;
            //}

            //return;

        }


        private void CancellaTabelle()
        {
            // deleteall records from table PartiteAperte

            string query = @"DELETE FROM PartiteAperte  DBCC CHECKIDENT ('PartiteAperte', RESEED, 0)";
            Partite.ExecQuery(query);

            if (Partite.HasException(true))
            {
                MessageBox.Show(" Si è verificata un'Eccezione");
                return;

            }

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            // before we do anything, check if the user has selected a date range  good
            if (dtpEnd.Value <= dtpStart.Value)
            {
                dtpEnd.Focus();
                MessageBox.Show("La data di fine deve essere maggiore della data di inizio", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Estrai();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CercaCliente();

        }

        private void CercaCliente()
        {
            string query = " Select CodCli,Denom from Clienti WHERE Stato='A' Order by Denom";
            Clienti.ExecQuery(query);

            if (Clienti.HasException(true))
            {
                MessageBox.Show(" Si è verificata un Errore nel cercare il cliente.");
                return;
            }

            FormFind frm = new FormFind();
            frm.Text = "Cerca Cliente";
            frm._DT = Clienti.DBDT;
            frm.ShowDialog();

            // se _returnData contiene qualcosa allora abbini i campi di testo
            if (frm._ReturnData != null)
            {
                txtCodiceCliente.Text = frm._ReturnData["CodCli"].ToString();
                txtCliente.Text = frm._ReturnData["Denom"].ToString();
            }

        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            txtCodiceCliente.Text = "";
        }

        private void dtpEnd_DropDownClosed(object sender, EventArgs e)
        {
            if (dtpEnd.Value <= dtpStart.Value)
            {
                dtpEnd.Focus();
                MessageBox.Show("La data di fine deve essere maggiore della data di inizio", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }
    }
}
