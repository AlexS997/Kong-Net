using KongN.Classi;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Agenda
{
    public partial class FrmAgenda : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        ButtonManager _buttonManager;

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

        public FrmAgenda()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");

        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Agenda";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Agenda.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);

            }

            bsAgenda.DataSource = connKong.DBDT;

            txtId.Visible = false;
        }

        public void LeggiCampi(DataTable agenda)
        {
            txtId.Text = agenda.Rows[0]["iD"].ToString();
        }

        public void AbbinaCampi()
        {
            txtId.DataBindings.Add("Text", bsAgenda, "iD");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // chiede conferma per l'eliminazione
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete From Agenda Where iD = @iD";
            connKong.AddParam("@iD", txtId.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Agenda.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmAgendaMaschera frm = new FrmAgendaMaschera();
            frm._ID = Convert.ToInt32(txtId.Text);

            // Aggiungi il gestore dell'evento FormClosed
            frm.FormClosed += (s, args) => LoadData();
            frm.ShowDialog();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAgendaMaschera frm = new FrmAgendaMaschera();
            frm._ID = 0;

            // After FrmAgendaMaschera is closed, reload data
            frm.FormClosed += (s, args) => LoadData();

            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        // la procedura passa a storico tutti gli eventi conclusi
        private void btnEsclusione_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Vuoi passare a Storico gli eventi Conclusi?", "Messaggio di Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:

                    string query = "INSERT INTO AgendaStorico " +
                                      "(Titolo, Interno, Codice, Denom, GeneratoDa, Descrizione, DataInserimento, DataInizio, DataFine, Concluso, IdUtente, DataModifica) " +
                                      "SELECT Titolo, Interno, Codice, Denom, GeneratoDa, Descrizione, DataInserimento, DataInizio, DataFine, Concluso ," + Global.ID + ", GetDate() AS DataModifica " +
                                   "FROM Agenda WHERE (Concluso = 1)";

                    connKong.ExecQuery(query);

                    if (connKong.HasException(true))
                    {
                        MessageBox.Show("Errore nel trasferimento dei dati Agenda.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Dati trasferiti correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    query = "Delete From Agenda Where Concluso = 1";
                    connKong.ExecQuery(query);

                    if (connKong.HasException(true))
                    {
                        MessageBox.Show("Errore nell'eliminazione dei dati Agenda.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    LoadData();

                    break;

                case DialogResult.No:

                    break;

            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }
    }
}
