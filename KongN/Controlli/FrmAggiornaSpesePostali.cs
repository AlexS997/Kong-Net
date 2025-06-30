using KongN.Classi;
using System;
using System.Windows.Forms;

namespace KongN.Controlli
{
    public partial class FrmAggiornaSpesePostali : Form
    {
        SQLControl conn = new SQLControl(Global.connAna);


        public FrmAggiornaSpesePostali()
        {
            InitializeComponent();
        }

        private void FrmAggiornaSpesePostali_Load(object sender, EventArgs e)
        {
            label.Text = "La procedure si occupa di aggiornare il costo delle spese postali su tutti i clìenti che le hanno impostate.";
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {

            if (num.Value == 0)
            {
                MessageBox.Show("Inserire un valore diverso da 0");
                return;
            }

            try
            {

                string n = num.Value.ToString();

                // sostituisce la virgola con il punto
                n = n.Replace(",", ".");

                string query = "Update CliFatt1 set U_SpesePostali=" + n + " WHERE U_SpesePostali > 0";
                conn.ExecQuery(query);

                if (conn.HasException(true))
                {
                    MessageBox.Show("Errore nell'aggiornamento delle spese postali.");
                    return;
                }

                MessageBox.Show("Aggiornamento spese postali eseguito");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Operazione eseguita");

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
