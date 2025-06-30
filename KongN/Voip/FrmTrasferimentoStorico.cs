using KongN.Classi;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KongN.Voip
{
    public partial class FrmTrasferimentoStorico : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);

        public FrmTrasferimentoStorico()
        {
            InitializeComponent();
        }

        private void FrmTrasferimentoStorico_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            //dtp.Value = DateTime.Now.AddYears(-1);
            //// Imposto la data nel DateTimePicker a 365 giorni prima della data corrente
            //dtp.MaxDate = DateTime.Now.AddYears(-1);

            dtpTrasferimento.Value = DateTime.Now.AddYears(-1);
            // Imposto la data nel DateTimePicker a 365 giorni prima della data corrente
            dtpTrasferimento.MaxDateTime = DateTime.Now.AddYears(-1);
        }


        private void btnTrasferisci_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (!PrefissoEsiste("VoiPDettaglio"))
            {
                Cursor = Cursors.Default;
                return;
            }

            if (!SecondExist("VoiPDettaglio"))
            {
                Cursor = Cursors.Default;
                return;
            }

            trasferisciDati();
            Cursor = Cursors.Default;
        }

        private bool PrefissoEsiste(string tabella)
        {

            string query = $"SELECT COUNT(*) FROM {tabella} WHERE prefisso IS NOT NULL";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                return false;
            }
            return connKong.DBDT.Rows[0][0].ToString() != "0";
        }

        private bool SecondExist(string tabella)
        {

            return true;
        }

        private void trasferisciDati()
        {
            SqlTransaction objTrans = null;
            string _Sql = "";

            Cursor = Cursors.WaitCursor;

            _Sql = "insert into VoiPDettaglioStorico (orachiamata ,data,chiamante ,prefisso ,chiamato,durata,importo,spesa ,Ntipo,tipo,duratatime ,dataPassaggioStorico,IdUtente) " +
                    "select orachiamata ,data,chiamante ,prefisso ,chiamato,durata,importo,spesa ,Ntipo,tipo ,duratatime,'" +
                    DateTime.Now.ToString("dd/MM/yyyy") + "'," + Global.ID +
                    " from VoiPdettaglio where data <= @data " +

            "delete from VoiPdettaglio " +
             "where data<=@data ";



            using (SqlConnection objConn = new SqlConnection(Global.connKongN))
            {
                objConn.Open();
                objTrans = objConn.BeginTransaction();

                SqlCommand objCmd = new SqlCommand(_Sql, objConn);
                objCmd.Transaction = objTrans;

                //objCmd.Parameters.AddWithValue("@data", dtp.Value.ToShortDateString());
                objCmd.Parameters.AddWithValue("@data", dtpTrasferimento.Value.Value.ToShortDateString());


                try
                {

                    objCmd.ExecuteNonQuery();
                    objTrans.Commit();

                    MessageBox.Show("Il trasferimento delle Chiamate nello Storico è avvenuto con successo.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Cursor = Cursors.Default;
                }
                catch (Exception ex)
                {
                    objTrans.Rollback();
                    MessageBox.Show($"  Message: {0}" + ex.Message);

                    Cursor = Cursors.Default;
                }
            }
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
