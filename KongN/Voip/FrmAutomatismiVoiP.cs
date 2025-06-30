using KongN.Classi;
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
    public partial class FrmAutomatismiVoiP : Form
    {
        SQLControl connKong = new SQLControl(Global.connKongN);
        DataTable _dt = new DataTable();

        public FrmAutomatismiVoiP()
        {
            InitializeComponent();
        }

        private void FrmAutomatismiVoiP_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            string query = "SELECT * FROM VoipAutomatismi";
            connKong.ExecQuery(query);

            if (connKong.RecordCount > 0)
            {
                _dt = connKong.DBDT;
                // prende il valore del campo LunghezzaPrefisso da VoipAutomatismi 
                //e lo mette in LunghezzaPrefisso
                numPrefisso.Text = _dt.Rows[0]["LunghezzaPrefisso"].ToString();

            }
            else
            {
                MessageBox.Show("Non ci sono record presenti nella Tabella Auomatismi VoiP e questo non è possibile. Non posso continuare.");
                this.Close();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // salva il valore di LunghezzaPrefisso in VoipAutomatismi
            string query = "UPDATE VoipAutomatismi SET LunghezzaPrefisso = " + numPrefisso.Text;
            connKong.ExecQuery(query);

            MessageBox.Show("Salvataggio effettuato");
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
