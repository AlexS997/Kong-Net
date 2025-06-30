using KongN.Classi;
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

namespace KongN.Voip
{
    public partial class FrmOfferteVoip : Form
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

        public FrmOfferteVoip()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmOfferteVoip_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM VoIPofferte";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Offerte VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }


            bsOfferte.DataSource = connKong.DBDT;

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
                if (c is CheckBox)
                {
                    ((CheckBox)c).Enabled = !x;
                }
            }
        }

        public void LeggiCampi(DataTable offerte)
        {
            txtIdOfferta.Text = offerte.Rows[0]["idofferta"].ToString();
            txtDescrizione.Text = offerte.Rows[0]["Descrizione"].ToString();
            txtNote.Text = offerte.Rows[0]["Note"].ToString();

            chkScatto.Checked = offerte.Rows[0]["Scatto"] != DBNull.Value && Convert.ToBoolean(offerte.Rows[0]["Scatto"]);
            chkAllInclusive.Checked = offerte.Rows[0]["AllInclusive"] != DBNull.Value && Convert.ToBoolean(offerte.Rows[0]["AllInclusive"]);


            offerte.Rows[0]["Minfisso"] = offerte.Rows[0]["Minfisso"] == DBNull.Value ? offerte.Rows[0]["Minfisso"] = 0 : offerte.Rows[0]["Minfisso"];
            numMinfisso.Value = Convert.ToDecimal(offerte.Rows[0]["Minfisso"]);

            offerte.Rows[0]["Minmobile"] = offerte.Rows[0]["Minmobile"] == DBNull.Value ? offerte.Rows[0]["Minmobile"] = 0 : offerte.Rows[0]["Minmobile"];
            numMinmobile.Value = Convert.ToDecimal(offerte.Rows[0]["Minmobile"]);

            offerte.Rows[0]["CostoScatto"] = offerte.Rows[0]["CostoScatto"] == DBNull.Value ? offerte.Rows[0]["CostoScatto"] = 0 : offerte.Rows[0]["CostoScatto"];
            numCostoScatto.Value = Convert.ToDecimal(offerte.Rows[0]["CostoScatto"]);

            offerte.Rows[0]["CostoMensile"] = offerte.Rows[0]["CostoMensile"] == DBNull.Value ? offerte.Rows[0]["CostoMensile"] = 0 : offerte.Rows[0]["CostoMensile"];
            numCanoneMensile.Value = Convert.ToDecimal(offerte.Rows[0]["CostoMensile"]);

        }

        public void AbbinaCampi()
        {
            txtIdOfferta.DataBindings.Add("Text", bsOfferte, "idofferta");
            txtDescrizione.DataBindings.Add("Text", bsOfferte, "Descrizione");
            txtNote.DataBindings.Add("Text", bsOfferte, "Note");

            chkScatto.DataBindings.Add("Checked", bsOfferte, "Scatto");
            chkAllInclusive.DataBindings.Add("Checked", bsOfferte, "AllInclusive");

            numMinfisso.DataBindings.Add("Text", bsOfferte, "Minfisso");
            numMinmobile.DataBindings.Add("Text", bsOfferte, "Minmobile");
            numCostoScatto.DataBindings.Add("Text", bsOfferte, "CostoScatto");
            numCanoneMensile.DataBindings.Add("Text", bsOfferte, "CostoMensile");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (txtIdOfferta.Text == "")
            {
                query = "INSERT INTO VoIPofferte (Descrizione, Minfisso, Minmobile, Scatto, CostoMensile, CostoScatto, Note) " +
                    "VALUES (@Descrizione, @Minfisso, @Minmobile, @Scatto, @CostoMensile, @CostoScatto, @Note)";
            }
            else
            {
                query = "UPDATE VoIPofferte SET Descrizione = @Descrizione, Minfisso = @Minfisso, Minmobile = @Minmobile, Scatto = @Scatto, " +
                    "CostoMensile = @CostoMensile, CostoScatto = @CostoScatto, Note = @Note where idofferta = @idofferta";
            }

            connKong.AddParam("@idofferta", txtIdOfferta.Text);
            connKong.AddParam("@Descrizione", txtDescrizione.Text);
            connKong.AddParam("@Note", txtNote.Text);
            connKong.AddParam("@Scatto", chkScatto.Checked);
            connKong.AddParam("@Minfisso", numMinfisso.Value);
            connKong.AddParam("@Minmobile", numMinmobile.Value);
            connKong.AddParam("@CostoMensile", numCanoneMensile.Value);
            connKong.AddParam("@CostoScatto", numCostoScatto.Value);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Offerte VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
        }

        public bool Check()
        {
            bool result = true;

            // controlla che i valori immessi siano cooerenti
            if (string.IsNullOrEmpty(this.txtDescrizione.Text))
            {
                MessageBox.Show("Il campo Descrizione è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescrizione.Focus();
                result = false;
                return result;
            }
            if (numCanoneMensile.Value == 0)
            {
                MessageBox.Show("Il Canone Mensile non può essere zero.");
                return false;
            }
            if (chkScatto.Checked && numCostoScatto.Value == 0)
            {
                MessageBox.Show("Lo scatto non può essere zero se l'offerta prevede lo scatto alla risposta.");
                return false;
            }

            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtIdOfferta.ReadOnly = true;
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtIdOfferta.ReadOnly = true;
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
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtIdOfferta.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtIdOfferta.Text);
                ClearFields();
                LoadData();
                bsOfferte.Find("idofferta", pos);
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

            string query = "Delete From VoIPofferte Where idofferta = @idofferta";
            connKong.AddParam("@idofferta", txtIdOfferta.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Offerte VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);


            LoadData();
        }
    }
}
