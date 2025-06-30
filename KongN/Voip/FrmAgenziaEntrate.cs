using KongN.Classi;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Voip
{
    public partial class FrmAgenziaEntrate : Form
    {
        
        SQLControl connKong = new SQLControl(Global.connKongN);

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }

        public FrmAgenziaEntrate()
        {
            InitializeComponent();
        }

        private void FrmAgenziaEntrate_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            numericUpDown.Maximum = DateTime.Now.Year - 1;
            numericUpDown.Value = DateTime.Now.Year - 1;


            bpbBox.Visible = false;
            btnElabora.Visible = false;
            btnLog.Visible = false;
        }


        private void bntPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog path = new SaveFileDialog();
            if (path.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = path.FileName;
            }
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCrea_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            string dataAll = data.ToString("yyyy-MM-dd");
            string fileTxt = textBox1.Text + numericUpDown.Value.ToString() + dataAll + ".txt";

            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                // creaFile();
                if (creaFileNuovo(fileTxt) == true)
                {
                    MessageBox.Show("Il file e' stato creato correttamente");
                }
                else
                {
                    MessageBox.Show("Errore nella creazione del file");
                }

            }
            else
            {
                MessageBox.Show("Inserire un path valido nel campo.");

            }
        }

        private bool creaFileNuovo(string _nomefile)
        {
            return false;

        }

        private string creaSpazi(int lunghezza)
        {
            return new string(' ', lunghezza);
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            btnElabora.Visible = false;
            btnLog.Visible = false;
            bpbBox.Visible = false;
            estrai();
        }

        private bool estrai()
        {
            Cursor = Cursors.WaitCursor;
            //creazione di un dataTable e visibile in griglia
            DataTable dt = new DataTable();

            connKong.AddParam("@anno", numericUpDown.Value);
            connKong.ExecQuery("select * from voipdettaglio");


            if (connKong.HasException(true))
            {
                MessageBox.Show("La tabella Dettagli ha generato un errore");
                Cursor = Cursors.Default;
                return true;
            }

            dt = connKong.DBDT;

            if (dt.Rows.Count == 0)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("La tabella dettagli non sono presenti dati");
                return true;

            }

            Grid.DataSource = dt;
            btnElabora.Visible = true;
            Cursor = Cursors.Default;
            return true;
        }
    }
}
