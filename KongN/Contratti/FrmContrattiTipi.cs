using KongN.Classi;
using KongN.Find;
using KongN.Funzioni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Contratti
{
    public partial class FrmContrattiTipi : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        SQLControl connAna = new SQLControl(Global.connAna);
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


        public FrmContrattiTipi()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmContrattiTipi_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
            txtId.Visible = false;
        }

        private void LoadData()
        {
            string query = "SELECT * FROM ContrattiTipi";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Ponti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }

            bsTipi.DataSource = connKong.DBDT;

            ReadOnlyControls(true);
        }

        public void LeggiCampi(DataTable ctRete)
        {
            txtId.Text = ctRete.Rows[0]["Id"].ToString();
            txtCodice.Text = ctRete.Rows[0]["Codice"].ToString();
            txtDocumento.Text = ctRete.Rows[0]["Descrizione"].ToString();

            chkConnessione.Checked = Convert.ToBoolean(ctRete.Rows[0]["Connessione"]);
            chkConsumi.Checked = Convert.ToBoolean(ctRete.Rows[0]["FlagConsumi"]);
        }

        public void AbbinaCampi()
        {
            txtId.DataBindings.Add("Text", bsTipi, "Id");
            txtCodice.DataBindings.Add("Text", bsTipi, "Codice");
            txtDocumento.DataBindings.Add("Text", bsTipi, "Descrizione");
            chkConnessione.DataBindings.Add("Checked", bsTipi, "Connessione");
            chkConsumi.DataBindings.Add("Checked", bsTipi, "FlagConsumi");
        }


        public void ReadOnlyControls(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }
                if (c is Button)
                {
                    ((Button)c).Enabled = !x;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Enabled = !x;
                }
            }
        }


        private void btnCodice_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodDoc, DesCodDoc, TipoDoc, Protocollo FROM TabCodDoc";
            connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show("Errore nell'apertura della tabella TabCodDoc.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = connAna.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                txtCodiceDocumento.Text = frm._ReturnData["CodDoc"].ToString();
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
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            ClearFields();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtId.Text);
                ClearFields();
                LoadData();
                bsTipi.Find("iD", pos);
                ReadOnlyControls(true);
            }
            else
            {
                LoadData();
                ReadOnlyControls(true);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (txtId.Text == "")
            {
                query = "INSERT INTO ContrattiTipi (Codice, Descrizione, Connessione, FlagConsumi, DataModifica, iDUtente) " +
                        "VALUES (@Codice, @Descrizione, @Connessione, @FlagConsumi, @DataModifica, @iDUtente)";
            }
            else
            {
                query = "UPDATE ContrattiTipi SET Codice = @Codice, Descrizione = @Descrizione, Connessione = @Connessione, " +
                            "FlagConsumi = @FlagConsumi, DataModifica = @DataModifica, iDUtente = @IdUtente " +
                        "WHERE iD = @iD";
            }

            connKong.AddParam("@iD", txtId.Text);
            connKong.AddParam("@Codice", txtCodice.Text);
            connKong.AddParam("@Descrizione", txtDocumento.Text);
            connKong.AddParam("@Connessione", chkConnessione.Checked);
            connKong.AddParam("@FlagConsumi", chkConsumi.Checked);
            connKong.AddParam("@DataModifica", DateTime.Now);
            connKong.AddParam("@IdUtente", Global.ID);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
        }

        public bool Check()
        {
            bool result = true;

            if (txtCodice.Text == "")
            {
                MessageBox.Show("Inserire il codice", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodice.Focus();

                result = false;
                return result;
            }

            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Inserire la descrizione", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDocumento.Focus();

                result = false;
                return result;
            }

            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Vuoi Cancellare veramente?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:

                    string query = "DELETE FROM ContrattiTipi WHERE iD = @iD";

                    connKong.AddParam("@iD", txtId.Text);

                    connKong.ExecQuery(query);

                    if (connKong.HasException(true))
                    {
                        MessageBox.Show("Errore nella cancellazione del record.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Record cancellato correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();

                    break;

                case DialogResult.No:

                    break;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
