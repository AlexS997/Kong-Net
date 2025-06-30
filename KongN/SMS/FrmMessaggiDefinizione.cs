using KongN.Classi;
using KongN.ClassiTabelle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.SMS
{
    public partial class FrmMessaggiDefinizione : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        ButtonManager _buttonManager;

        public FrmMessaggiDefinizione()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmMessaggiDefinizione_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
            ReadOnlyControls(true);

            lblRecord.Text = "Record estratti: " + bsMsgDef.Count.ToString();
        }

        private void LoadData()
        {
            string query = "Select * from MessaggiDefinizione";

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

            bsMsgDef.DataSource = connKong.DBDT;
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

        public void LeggiCampi(DataTable antivirus)
        {
            txtId.Text = antivirus.Rows[0]["Id"].ToString();
            txtDescrizione.Text = antivirus.Rows[0]["Descrizione"].ToString();
            txtMessaggio.Text = antivirus.Rows[0]["Messaggio"].ToString();
            txtPar1.Text = antivirus.Rows[0]["Parametro1"].ToString();
            txtPar2.Text = antivirus.Rows[0]["Parametro2"].ToString();
            txtPar3.Text = antivirus.Rows[0]["Parametro3"].ToString();
        }

        public void AbbinaCampi()
        {
            txtId.DataBindings.Add("Text", bsMsgDef, "Id");
            txtDescrizione.DataBindings.Add("Text", bsMsgDef, "Descrizione");
            txtMessaggio.DataBindings.Add("Text", bsMsgDef, "Messaggio");
            txtPar1.DataBindings.Add("Text", bsMsgDef, "Parametro1");
            txtPar2.DataBindings.Add("Text", bsMsgDef, "Parametro2");
            txtPar3.DataBindings.Add("Text", bsMsgDef, "Parametro3");
        }

        private void btnProfili_Click(object sender, EventArgs e)
        {
            FrmLegendaProfili frm = new FrmLegendaProfili();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete From MessaggiDefinizione Where iD = @iD";

            connKong.AddParam("@iD", txtId.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtId.Text);
                ClearFields();
                LoadData();
                bsMsgDef.Find("Id", pos);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ReadOnlyControls(true);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (txtId.Text == "")
            {
                query = "INSERT INTO MessaggiDefinizione (Descrizione, Messaggio, Parametro1, Parametro2, Parametro3) " +
                    "VALUES (@Descrizione, @Messaggio, @Parametro1, @Parametro2, @Parametro3)";
            }
            else
            {
                query = "UPDATE MessaggiDefinizione SET Descrizione = @Descrizione, Messaggio = @Messaggio, Parametro1 = @Parametro1, " +
                    "Parametro2 = @Parametro2, Parametro3 = @Parametro3 where Id = @Id";
            }

            connKong.AddParam("@Id", txtId.Text);
            connKong.AddParam("@Descrizione", txtDescrizione.Text);
            connKong.AddParam("@Messaggio", txtMessaggio.Text);
            connKong.AddParam("@Parametro1", txtPar1.Text);
            connKong.AddParam("@Parametro2", txtPar2.Text);
            connKong.AddParam("@Parametro3", txtPar3.Text);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            ReadOnlyControls(true);

        }

        public bool Check()
        {
            if (txtDescrizione.Text == "")
            {
                MessageBox.Show("Inserire la descrizione");
                return false;
            }
            if (txtMessaggio.Text == "")
            {
                MessageBox.Show("Inserire il messaggio");
                return false;
            }
            if (txtPar2.Text != "" && txtPar1.Text == "")
            {
                MessageBox.Show("Non puoi inserire il parametro 2 se prima non inserisci il parametro 1");
                return false;
            }
            if (txtPar3.Text != "" && txtPar2.Text == "")
            {
                MessageBox.Show("Non puoi inserire il parametro 3 se prima non inserisci il parametro 2");
                return false;
            }
            if (txtMessaggio.Text.Length > 320)
            {
                MessageBox.Show("Il messaggio non può superare i 320 caratteri");
                return false;
            }
            // testa se il messaggio è lungo 320 caratteri
            // ma contiene parametri
            if (txtMessaggio.Text.Length == 320)
            {
                if (txtPar1.Text != "" || txtPar2.Text != "" || txtPar3.Text != "")
                {
                    MessageBox.Show("Il messaggio ha dei parametri, devi ridurre la lunghezza del messarggio.");
                    return false;
                }
            }
            return true;
        }

        private void txtMessaggio_TextChanged(object sender, EventArgs e)
        {
            lblLunghezza.Text = "Lunghezza : " + txtMessaggio.Text.Length.ToString();
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
