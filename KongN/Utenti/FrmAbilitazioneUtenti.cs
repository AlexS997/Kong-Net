using FastReport.DevComponents.DotNetBar.Controls;
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

namespace KongN.Utenti
{
    public partial class FrmAbilitazioneUtenti: Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);

        //used not to call the event lstUtenti_SelectedIndexChanged when loading data
        private bool isLoading = false;

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

        public FrmAbilitazioneUtenti()
        {
            InitializeComponent();
        }

        private void FrmAbilitazioneUtenti_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            isLoading = true;
            LoadData();
            isLoading = false;

            lblText.Text = "0 - Abilitato 1 - Abilitato solo in lettura 2 - Disabilitato.\nSeleziona una riga per aggiornare il suo valore.";
        }

        private void LoadData()
        {
            string query = "Select * from Utenti";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Utenti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Aggiungi una colonna calcolata per combinare "username" e "nome"
            connKong.DBDT.Columns.Add("DisplayName", typeof(string), "Username + '   -   ' + Nome");

            //add in lstUtenti the data from the query
            lstUtenti.DataSource = connKong.DBDT;
            lstUtenti.DisplayMember = "DisplayName";
            lstUtenti.ValueMember = "iD";
            //lstUtenti.SelectedIndex = 0;


        }

        private void lstUtenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            // do not call the event when loading data
            if (isLoading) return;

            string query = "Select * from Utenti where ID = @ID";
            connKong.AddParam("@ID", lstUtenti.SelectedValue.ToString());

            connKong.ExecQuery(query);
            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Utenti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv.DataSource = connKong.DBDT;

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
