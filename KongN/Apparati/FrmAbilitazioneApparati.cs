using KongN.Classi;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Apparati
{
    public partial class FrmAbilitazioneApparati : Form
    {
        SQLControl connKong = new SQLControl(Global.connKongN);

        DataTable dtUtenti = new DataTable();
        DataTable dtAbilitazioni = new DataTable();

        private void dgvUtenti_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgvUtenti.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dgvUtenti.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dgvUtentiAbilitati_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgvUtentiAbilitati.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dgvUtentiAbilitati.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        public FrmAbilitazioneApparati()
        {
            InitializeComponent();

            // Setto la modalità di selezione delle righe
            dgvUtenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUtenti.CellClick += DgvUtenti_CellClick;
            dgvUtentiAbilitati.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUtentiAbilitati.CellClick += DgvUtentiAbilitati_CellClick;
        }

        #region Select full row on cell click
        private void DgvUtenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvUtenti.Rows[e.RowIndex].Selected = true;
            }
        }

        private void DgvUtentiAbilitati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvUtentiAbilitati.Rows[e.RowIndex].Selected = true;
            }
        }
        #endregion

        private void FrmAbilitazioneApparati_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            FillRecord();

            lblModifiche.Visible = false;
        }

        private void FillRecord()
        {
            string query = "SELECT id, nome FROM Utenti WHERE isActive = 1 ORDER BY id";
            connKong.ExecQuery(query);

            if (connKong.HasException())
            {
                MessageBox.Show("Errore nella lettura degli utenti");
                return;
            }

            dtUtenti = connKong.DBDT;
            dgvUtenti.DataSource = dtUtenti;

            query = "SELECT iDUtente FROM ApparatiAbilitazioni";
            connKong.ExecQuery(query);

            if (connKong.HasException())
            {
                MessageBox.Show("Errore nella lettura delle abilitazioni");
                return;
            }

            dtAbilitazioni = connKong.DBDT;
            dgvUtentiAbilitati.DataSource = dtAbilitazioni;

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbilita_Click(object sender, EventArgs e)
        {
            if (dgvUtenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selezionare un utente");
                return;
            }
            // controlla che l'id dell'utente non sia già presente nella tabella delle abilitazioni 
            foreach (DataRow dr in dtAbilitazioni.Rows)
            {
                if (dr.RowState != DataRowState.Deleted && Convert.ToInt32(dr["idUtente"]) == Convert.ToInt32(dgvUtenti.SelectedRows[0].Cells[0].Value))
                {
                    MessageBox.Show("Utente già abilitato");
                    lblModifiche.Visible = false;
                    return;
                }
            }
            // copia l'utente selezionato nella tabella delle abilitazioni
            int idUtente = Convert.ToInt32(dgvUtenti.SelectedRows[0].Cells[0].Value);
            dtAbilitazioni.Rows.Add(idUtente);

            dgvUtentiAbilitati.Refresh();

            lblModifiche.Visible = false;
        }

        private void btnDisabilita_Click(object sender, EventArgs e)
        {
            if (dgvUtentiAbilitati.Rows.Count == 0)
            {
                MessageBox.Show("Nessun utente presente");
                lblModifiche.Visible = false;
                return;
            }
            if (dgvUtentiAbilitati.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selezionare un utente");
                lblModifiche.Visible = false;
                return;
            }
            int idUtente = Convert.ToInt32(dgvUtentiAbilitati.SelectedRows[0].Cells[0].Value);
            dgvUtentiAbilitati.Rows.RemoveAt(dgvUtentiAbilitati.SelectedRows[0].Index);

            lblModifiche.Visible = false;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // controlla che dgvUtentiAbilitati non sia vuoto   
            if (dgvUtentiAbilitati.Rows.Count == 0)
            {
                this.Close();

            }

            // salva le modifiche nella tabella ApparatiAbilitazioni
            string query = "DELETE FROM ApparatiAbilitazioni";
            connKong.ExecQuery(query);

            if (connKong.HasException())
            {
                MessageBox.Show("Errore nella cancellazione delle abilitazioni");
                return;
            }
            foreach (DataRow dr in dtAbilitazioni.Rows)
            {
                if (dr.RowState != DataRowState.Deleted)
                {
                    query = "INSERT INTO ApparatiAbilitazioni (idUtente) VALUES (" + dr["idUtente"].ToString() + ")";
                    connKong.ExecQuery(query);

                    if (connKong.HasException())
                    {
                        MessageBox.Show("Errore nella scrittura delle abilitazioni");
                        return;
                    }
                }
            }
            
            FillRecord();
            lblModifiche.Visible = true;

        }
    }
}
