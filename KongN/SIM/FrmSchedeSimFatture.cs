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

namespace KongN.SIM
{
    public partial class FrmSchedeSimFatture : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        ButtonManager _buttonManager;

        public int _idSchedaSim { get; set; }

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

        public FrmSchedeSimFatture()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }


        private void FrmSchedeSimFatture_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM SchedeSimFatture where iDScheda = " + _idSchedaSim;

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Fatture Schede Sim.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);

            }


            bsFattureSIM.DataSource = connKong.DBDT;

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
                if (c is SfDateTimeEdit)
                {
                    ((SfDateTimeEdit)c).Enabled = !x;
                }
                if(c is NumericUpDown)
                {
                    ((NumericUpDown)c).ReadOnly = x;
                    ((NumericUpDown)c).Enabled = !x;
                }
            }
        }

        public void LeggiCampi(DataTable fattsim)
        {
            txtId.Text = fattsim.Rows[0]["iD"].ToString();
            txtIdScheda.Text = fattsim.Rows[0]["iDScheda"].ToString();
            txtNumeroFattura.Text = fattsim.Rows[0]["NumeroFattura"].ToString();
            txtPeriodo.Text = fattsim.Rows[0]["Periodo"].ToString();

            dtpDataFattura.Value = fattsim.Rows[0]["DataFattura"] == DBNull.Value ? dtpDataFattura.Value = null : Convert.ToDateTime(fattsim.Rows[0]["DataFattura"].ToString());

            fattsim.Rows[0]["Importo"] = fattsim.Rows[0]["Importo"] == DBNull.Value ? fattsim.Rows[0]["Importo"] = 0 : fattsim.Rows[0]["Importo"];
            numImporto.Value = Convert.ToDecimal(fattsim.Rows[0]["Importo"]);
        }

        public void AbbinaCampi()
        {
            txtId.DataBindings.Add("Text", bsFattureSIM, "iD");
            txtIdScheda.DataBindings.Add("Text", bsFattureSIM, "iDScheda");
            txtNumeroFattura.DataBindings.Add("Text", bsFattureSIM, "NumeroFattura");
            txtPeriodo.DataBindings.Add("Text", bsFattureSIM, "Periodo");

            dtpDataFattura.DataBindings.Add("Value", bsFattureSIM, "DataFattura", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd-MM-yyyy");

            numImporto.DataBindings.Add("Text", bsFattureSIM, "Importo");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtId.Text);
                ClearFields();
                LoadData();
                bsFattureSIM.Find("iD", pos);
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

                if (c is TextBox && c.Name != "txtIdScheda")
                {
                    ((TextBox)c).Clear();
                }


                if (c is SfDateTimeEdit)
                {
                    ((SfDateTimeEdit)c).Value = null;
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtId.ReadOnly = true;
            txtIdScheda.ReadOnly = true;
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtId.ReadOnly = true;
            txtIdScheda.ReadOnly = true;
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
                query = "INSERT INTO SchedeSimFatture (iDScheda, NumeroFattura, DataFattura, Importo, Periodo) " +
                    "VALUES (@iDScheda, @NumeroFattura, @DataFattura, @Importo, @Periodo)";
            }
            else
            {
                query = "UPDATE SchedeSimFatture SET iDScheda = @iDScheda, NumeroFattura = @NumeroFattura, DataFattura = @DataFattura, " +
                    "Importo = @Importo, Periodo = @Periodo where iD = @iD";
            }

            connKong.AddParam("@iD", txtId.Text);
            connKong.AddParam("@iDScheda", txtIdScheda.Text);
            connKong.AddParam("@NumeroFattura", txtNumeroFattura.Text);
            connKong.AddParam("@Periodo", txtPeriodo.Text);
            connKong.AddParam("@DataFattura", dtpDataFattura.Value);
            connKong.AddParam("@Importo", numImporto.Value);


            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Fatture Schede SIM.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
        }

        public bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtIdScheda.Text))
            {
                MessageBox.Show("Il campo Id Scheda è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdScheda.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtNumeroFattura.Text))
            {
                MessageBox.Show("Il campo Numero Fattura è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroFattura.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtPeriodo.Text))
            {
                MessageBox.Show("Il campo Periodo è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPeriodo.Focus();
                result = false;
                return result;
            }

            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete From SchedeSimFatture Where iD = @iD";
            connKong.AddParam("@iD", txtId.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Fatture Schede SIM.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }
    }
}
