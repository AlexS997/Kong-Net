using KongN.Classi;
using Syncfusion.WinForms.Input;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.StrutturaRete
{
    public partial class FrmFornitoriRete : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);

        ButtonManager _buttonManager;

        public FrmFornitoriRete()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
            
        }

        private void FrmFornitoriRete_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
            ReadOnlyControls(true);
        }

        private void LoadData()
        {

            string query = "SELECT * FROM [1_fonti]";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Fornitori.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }

        }

        public void LeggiCampi(DataTable fornitori)
        {
            txtIDFonte.Text = fornitori.Rows[0]["iDFonte"].ToString();
            txtFONTE.Text = fornitori.Rows[0]["FONTE"].ToString();
            txtNote.Text = fornitori.Rows[0]["Note"].ToString();

            bsFornitori.DataSource = fornitori;
        }

        public void AbbinaCampi()
        {
            txtIDFonte.DataBindings.Add("Text", bsFornitori, "iDFonte");
            txtFONTE.DataBindings.Add("Text", bsFornitori, "FONTE");
            txtNote.DataBindings.Add("Text", bsFornitori, "Note");
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
            txtIDFonte.ReadOnly = true;
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (txtIDFonte.Text == "")
            {
                query = "INSERT INTO [1_fonti] (FONTE, Note) VALUES (@FONTE, @Note)";
            }
            else
            {
                query = "UPDATE [1_fonti] SET FONTE = @FONTE, Note = @Note where iDFonte = @iDFonte";
            }

            connKong.AddParam("@iDFonte", txtIDFonte.Text);
            connKong.AddParam("@FONTE", txtFONTE.Text);
            connKong.AddParam("@Note", txtNote.Text);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Fornitori.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati Fornitori salvati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();

        }

        public bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtFONTE.Text))
            {
                MessageBox.Show("Inserire il nome del fornitore.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFONTE.Focus();
                result = false;
                return result;
            }

            return result;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtIDFonte.ReadOnly = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtIDFonte.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtIDFonte.Text);
                ClearFields();
                LoadData();
                bsFornitori.Find("iDFonte", pos);
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
            ReadOnlyControls(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool c = CheckEsiste();

            if (c == true)
            {
                MessageBox.Show("Impossibile cancellare il record. Esistono gateway collegati a questo fornitore.");
                return;
            }

            switch (MessageBox.Show("Attenzione!!!! Confermi la cancellazione?", "Messaggio di Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:

                    string query = "DELETE FROM [1_fonti] WHERE iDFonte = @iDFonte";

                    connKong.AddParam("@iDFonte", txtIDFonte.Text);

                    connKong.ExecQuery(query);

                    if (connKong.HasException(true))
                    {
                        MessageBox.Show("Errore nella cancellazione dei dati Fornitori.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Dati Fornitori cancellati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;

                case DialogResult.No:

                    break;

            }

            LoadData();
            ReadOnlyControls(true);
        }

        private bool CheckEsiste()
        {
            string s = "SELECT COUNT(*) FROM [2_gateways] WHERE idFonte = " + txtIDFonte.Text;
            connKong.ExecQuery(s);

            if (connKong.HasException())
            {
                MessageBox.Show("Si è verificato un errore nel recupero dati.");
                return true;
            }

            int n = Convert.ToInt32(connKong.DBDT.Rows[0][0]);


            if (n > 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

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
    }
}
