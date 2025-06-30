using KongN.Classi;
using KongN.Find;
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

namespace KongN.Contratti
{
    public partial class FrmContrattiProfili : Form
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

        public FrmContrattiProfili()
        {
            InitializeComponent();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmContrattiProfili_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();


        }

        private void LoadData()
        {


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
                if (c is Button)
                {
                    ((Button)c).Enabled = !x;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Enabled = !x;
                }
                if (c is SfDateTimeEdit)
                {
                    ((SfDateTimeEdit)c).Enabled = !x;
                }
                if(c is NumericUpDown)
                {
                    ((NumericUpDown)c).Enabled = !x;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrelevaCodice_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodArt, Descrizione, PVendPub FROM Articoli WHERE (U_ArticoloKong = 1) ORDER BY CodArt";
            connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Articoli.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca
            FormFind frm = new FormFind();
            frm._DT = connAna.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                // riporta i campi prendendoli da frm._ReturnData
                txtCodice.Text = frm._ReturnData["CodArt"].ToString();
                txtDescrizione.Text = frm._ReturnData["Descrizione"].ToString();
                numPrezzoAnnuale.Value = Convert.ToDecimal(frm._ReturnData["PVendPub"]);
                txtProfilo.Text = txtCodice.Text;
            }
        }

        private void btnProfilo_Click(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT ActualProfile FROM ProfiliUtentiTutti ORDER BY ActualProfile";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati ProfiliUtentiTutti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca
            FormFind frm = new FormFind();
            frm._DT = connKong.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                // riporta i campi prendendoli da frm._ReturnData
                txtProfilo.Text = frm._ReturnData["ActualProfile"].ToString();
            }
        }

        private void btnIVA_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodIVA, Descrizione, Aliquota FROM TabIVA ORDER BY CodIVA";
            connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati TabIVA.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca
            FormFind frm = new FormFind();
            frm._DT = connAna.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                // riporta i campi prendendoli da frm._ReturnData
                txtCodIva.Text = frm._ReturnData["CodIVA"].ToString();
            }
        }

        private void btnContoRicavo_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodCto, Descrizione FROM ContiGen ORDER BY CodCto";
            connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati ContiGen.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca
            FormFind frm = new FormFind();
            frm._DT = connAna.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                // riporta i campi prendendoli da frm._ReturnData
                txtContoRicavo.Text = frm._ReturnData["CodCto"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            LoadData();
            ReadOnlyControls(true);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
