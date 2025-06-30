using KongN.Classi;
using KongN.Find;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Agenda
{
    public partial class FrmAgendaMaschera : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        public int _ID { get; set; }

        public FrmAgendaMaschera()
        {
            InitializeComponent();
        }


        private void FrmAgendaMaschera_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            LoadData();
        }


        private void LoadData()
        {
            string query = "";

            if (_ID != 0) 
            {
                query = "SELECT * FROM Agenda WHERE Id = " + _ID;
                connKong.ExecQuery(query);

                if (connKong.RecordCount > 0)
                {
                    txtTitolo.Text = connKong.DBDT.Rows[0]["Titolo"].ToString();
                    txtDenom.Text = connKong.DBDT.Rows[0]["Denom"].ToString();
                    txtCodCli.Text = connKong.DBDT.Rows[0]["Codice"].ToString();
                    txtDescrizione.Text = connKong.DBDT.Rows[0]["Descrizione"].ToString();
                    lblGenerato.Text = connKong.DBDT.Rows[0]["GeneratoDa"].ToString();

                    dtpInserimento.Value = Convert.ToDateTime(connKong.DBDT.Rows[0]["DataInserimento"].ToString());
                    dtpInizio.Value = Convert.ToDateTime(connKong.DBDT.Rows[0]["DataInizio"].ToString());
                    dtpFine.Value = Convert.ToDateTime(connKong.DBDT.Rows[0]["DataFine"].ToString());

                    chkRegistrazione.Checked = Convert.ToBoolean(connKong.DBDT.Rows[0]["Interno"].ToString());
                    chkConcluso.Checked = Convert.ToBoolean(connKong.DBDT.Rows[0]["Concluso"].ToString());
                }
            }

        }
        

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (_ID == 0)
            {
                query = "INSERT INTO Agenda (Titolo, Interno, Codice, Denom, GeneratoDa, Descrizione, DataInserimento, DataInizio, DataFine, Concluso, " +
                                            "iDUtente, DataModifica) " +
                        "VALUES (@Titolo, @Interno, @Codice, @Denom, @GeneratoDa, @Descrizione, @DataInserimento, @DataInizio, @DataFine, @Concluso, " +
                        "@iDUtente, @DataModifica)";
            }
            else
            {
                query = "UPDATE Agenda SET Titolo = @Titolo, Interno = @Interno, Codice = @Codice, Denom = @Denom, GeneratoDa = @GeneratoDa, " +
                    "Descrizione = @Descrizione, DataInserimento = @DataInserimento, DataInizio = @DataInizio, DataFine = @DataFine, Concluso = @Concluso, " +
                    "iDUtente = @iDUtente, DataModifica = @DataModifica WHERE Id = " + _ID;
            }

            connKong.AddParam("@Titolo", txtTitolo.Text);
            connKong.AddParam("@Interno", chkRegistrazione.Checked);
            connKong.AddParam("@Codice", txtCodCli.Text);
            connKong.AddParam("@Denom", txtDenom.Text);
            connKong.AddParam("@GeneratoDa", lblGenerato.Text);
            connKong.AddParam("@Descrizione", txtDescrizione.Text);
            connKong.AddParam("@DataInserimento", dtpInserimento.Value);
            connKong.AddParam("@DataInizio", dtpInizio.Value);
            connKong.AddParam("@DataFine", dtpFine.Value);
            connKong.AddParam("@Concluso", chkConcluso.Checked);

            connKong.AddParam("@iDUtente", Global.ID);
            connKong.AddParam("@DataModifica", DateTime.Now);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Agenda.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);


            
            this.Close();
        }

        private bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtDescrizione.Text))
            {
                MessageBox.Show("La descrizione non può essere vuota", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                result = false;
                return result;
            }

            return result;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            string query = "Select * from Clienti Order By CodCli";
            SQLControl Clienti = new SQLControl(Global.connAna);
            Clienti.ExecQuery(query);

            if (Clienti.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Clienti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = Clienti.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                // riporta i campi prendendoli da frm._ReturnData

                txtCodCli.Text = frm._ReturnData["CodCli"].ToString();
            }
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
