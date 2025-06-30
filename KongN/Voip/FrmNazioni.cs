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
    public partial class FrmNazioni : Form
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

        public FrmNazioni()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmNazioni_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM VoIPNazioni order by Stato";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Nazioni VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }

            bsNazioni.DataSource = connKong.DBDT;

            ReadOnlyControls(true);
        }

        public void LeggiCampi(DataTable nazioni)
        {
            txtiD.Text = nazioni.Rows[0]["iD"].ToString();
            txtStato.Text = nazioni.Rows[0]["Stato"].ToString();

        }

        public void AbbinaCampi()
        {
            txtiD.DataBindings.Add("Text", bsNazioni, "iD");
            txtStato.DataBindings.Add("Text", bsNazioni, "Stato");
        }

        public void ReadOnlyControls(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtiD.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtiD.Text);
                ClearFields();
                LoadData();
                bsNazioni.Find("iD", pos);
                ReadOnlyControls(true);
            }
            else
            {
                LoadData();
                ReadOnlyControls(true);
            }
        }

        private void ClearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtiD.ReadOnly = true;
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtiD.ReadOnly = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete From VoIPNazioni Where iD = @iD";
            connKong.AddParam("@iD", txtiD.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Nazioni VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (txtiD.Text == "")
            {
                query = "INSERT INTO VoIPNazioni (Stato) VALUES (@Stato)";
            }
            else
            {
                query = "UPDATE VoIPNazioni SET Stato = @Stato where iD = @iD";
            }

            connKong.AddParam("@iD", txtiD.Text);
            connKong.AddParam("@Stato", txtStato.Text);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Nazioni VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
        }

        public bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtStato.Text))
            {
                MessageBox.Show("Il campo Stato è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStato.Focus();
                result = false;
                return result;
            }

            return result;
        }
    }
}
