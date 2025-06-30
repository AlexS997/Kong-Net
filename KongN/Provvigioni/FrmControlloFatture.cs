using KongN.Classi;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace KongN.Provvigioni
{
    public partial class FrmControlloFatture : Form
    {
        SQLControl Fatture = new SQLControl(Global.connAna);
        DataTable dt = new DataTable();

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }

        public FrmControlloFatture()
        {
            InitializeComponent();
            Grid.QueryRowStyle += Grid_QueryRowStyle;
        }

        private void FrmControlloFatture_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            lblRecord.Visible = false;
            Bar.Visible = false;
        }

        private bool Controlla()
        { 
            bool result = true;

            if (dtpStart.Value > dtpEnd.Value)
            {
                MessageBox.Show("La seconda data non può essere inferiore alla prima", "Parametri non sufficienti", MessageBoxButtons.OK, MessageBoxIcon.Question);

                result = false;
                return result;
            }

            return result;
        }


        private void btnEstrai_Click(object sender, EventArgs e)
        {
            Estrai();
        }

        private void Estrai()
        {
            if (Controlla())
            {

                string query = @"SELECT F.NumDoc, F.Cliente, C.Denom, C.Prov, C.CF, T.Descrizione, F.DataDoc
                                    FROM FattTest F
                                    INNER JOIN Clienti C ON F.Cliente = C.CodCli
                                    INNER JOIN TabAge T On F.Agente = T.CodAge
                                    WHERE F.DataDoc BETWEEN @StartDate AND @EndDate
                                    AND (F.Agente IS NOT NULL AND F.Agente <> '')
                                    AND C.Stato = 'A'
                                    Order by F.DataDoc";


                Fatture.AddParam("@StartDate", dtpStart.Value.ToString());
                Fatture.AddParam("@EndDate", dtpEnd.Value.ToString());

                Fatture.ExecQuery(query);

                if (Fatture.HasException(true))
                {
                    MessageBox.Show(this + " - Errore durante l'estrazione dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Grid.DataSource = Fatture.DBDT;
                int r = Fatture.DBDT.Rows.Count;
                lblRecord.Visible = true;
                lblRecord.Text = "Record estratti: " + r.ToString();
                dt = Fatture.DBDT;

                Bar.Visible = true;
                Bar.Maximum = dt.Rows.Count;
                Bar.Minimum = 0;

                foreach (DataRow row in dt.Rows)
                {
                    Bar.Value += 1;
                }

                Bar.Value = 0;
                Bar.Visible = false;
            }
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
