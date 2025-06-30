using KongN.Classi;
using KongN.Find;
using KongN.Funzioni;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KongN.Voip
{
    public partial class FrmPrefissi : Form
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

        public FrmPrefissi()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmPrefissi_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM VoIPprefissi";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Prefissi VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);

            }


            bsPrefissi.DataSource = connKong.DBDT;

            ReadOnlyControls(true);
        }

        public void ReadOnlyControls(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).ReadOnly = x;
                    ((NumericUpDown)c).Enabled = !x;
                }
                if (c is Button)
                {
                    ((Button)c).Enabled = !x;
                }
            }
        }

        public void LeggiCampi(DataTable prefissi)
        {
            txtId.Text = prefissi.Rows[0]["iD"].ToString();
            txtStato.Text = prefissi.Rows[0]["stato"].ToString();
            txtTipo.Text = prefissi.Rows[0]["tipo"].ToString();
            txtPrefisso.Text = prefissi.Rows[0]["prefisso"].ToString();

            txtIdNazione.Text = prefissi.Rows[0]["iDNazione"].ToString();

            prefissi.Rows[0]["costo"] = prefissi.Rows[0]["costo"] == DBNull.Value ? prefissi.Rows[0]["costo"] = 0 : prefissi.Rows[0]["costo"];
            numCosto.Value = Convert.ToDecimal(prefissi.Rows[0]["costo"]);

            prefissi.Rows[0]["scatto"] = prefissi.Rows[0]["scatto"] == DBNull.Value ? prefissi.Rows[0]["scatto"] = 0 : prefissi.Rows[0]["scatto"];
            numScatto.Value = Convert.ToDecimal(prefissi.Rows[0]["scatto"]);

        }

        public void AbbinaCampi()
        {
            txtId.DataBindings.Add("Text", bsPrefissi, "iD");
            txtStato.DataBindings.Add("Text", bsPrefissi, "stato");
            txtTipo.DataBindings.Add("Text", bsPrefissi, "tipo");
            txtPrefisso.DataBindings.Add("Text", bsPrefissi, "prefisso");
            txtIdNazione.DataBindings.Add("Text", bsPrefissi, "iDNazione");

            numCosto.DataBindings.Add("Text", bsPrefissi, "costo");
            numScatto.DataBindings.Add("Text", bsPrefissi, "scatto");

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            switch (txtTipo.Text)
            {
                case "0":
                    lblTipoDescrizione.Text = "Fisso ";
                    break;
                case "1":
                    lblTipoDescrizione.Text = "Mobile ";
                    break;
                case "-1":
                    lblTipoDescrizione.Text = "Speciale Nazionale";
                    break;
                default:
                    lblTipoDescrizione.Text = "Internazionale";
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtId.ReadOnly = true;
            ClearFields();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtId.ReadOnly = true;
        }

        private void ClearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtId.Text);
                ClearFields();
                LoadData();
                bsPrefissi.Find("iD", pos);
                ReadOnlyControls(true);
            }
            else
            {
                LoadData();
                ReadOnlyControls(true);
            }
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

            string query = "Delete From VoIPprefissi Where iD = @iD";
            connKong.AddParam("@iD", txtId.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Prefissi VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (txtId.Text == "")
            {
                query = "INSERT INTO VoIPprefissi (stato, tipo, costo, prefisso, scatto, iDNazione) " +
                    "VALUES (@stato, @tipo, @costo, @prefisso, @scatto, @iDNazione)";
            }
            else
            {
                query = "UPDATE VoIPprefissi SET stato = @stato, tipo = @tipo, costo = @costo, prefisso = @prefisso, " +
                    "scatto = @scatto, iDNazione = @iDNazione where iD = @iD";
            }

            connKong.AddParam("@iD", txtId.Text);
            connKong.AddParam("@stato", txtStato.Text);
            connKong.AddParam("@tipo", txtTipo.Text);
            connKong.AddParam("@prefisso", txtPrefisso.Text);
            connKong.AddParam("@iDNazione", txtIdNazione.Text);
            connKong.AddParam("@costo", numCosto.Value);
            connKong.AddParam("@scatto", numScatto.Value);


            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati ClientiRete.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
        }

        public bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Il campo Tipo è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipo.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtPrefisso.Text))
            {
                MessageBox.Show("Il campo Prefisso è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrefisso.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtStato.Text))
            {
                MessageBox.Show("Il campo Stato è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStato.Focus();
                result = false;
                return result;
            }

            if (numCosto.Value == 0)
            {
                MessageBox.Show("Il campo Costo è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numCosto.Focus();
                result = false;
                return result;
            }

            return result;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT stato, iDNazione FROM VoIPprefissi ORDER BY stato";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Prefissi VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = connKong.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                txtStato.Text = frm._ReturnData["stato"].ToString();
                txtIdNazione.Text = frm._ReturnData["iDNazione"].ToString();
            }
        }
    }
}
