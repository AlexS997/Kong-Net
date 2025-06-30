using KongN.Classi;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Azioni
{
    public partial class FrmMessaggiInCoda : Form
    {
        SQLControl connKong = new SQLControl(Global.connKongN);
        DataTable dt = new DataTable();

        public FrmMessaggiInCoda()
        {
            InitializeComponent();
        }

        private void FrmMessaggiInCoda_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Messaggi order by data";

            connKong.ExecQuery(query);
            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati");
                return;
            }
            
            Grid.DataSource = connKong.DBDT;
            lblRecord.Text = "Record estratti: " + connKong.RecordCount.ToString();
            dt = connKong.DBDT;

            if (connKong.RecordCount == 0)
            {
                MessageBox.Show("Non ci sono operazioni in coda");
                return;
            }

        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Non ci sono record da cancellare");
                return;
            }

            if (Grid.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nessuna riga selezionata. Seleziona una riga prima di procedere.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Confermi la cancellazione del record? Ricorda che se Cancelli l'Operazione Pianificata automaticamente verranno cancellati anche i record a essa abbinati.", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var selectedRow = Grid.SelectedItems[0] as DataRowView;
            string id = selectedRow["id"].ToString();

            string query = "DELETE FROM Messaggi WHERE id = " + id;
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }

        private void btnCambiaData_Click(object sender, EventArgs e)
        {
            if (Check() == DateTime.Now)
                return;
            // chiede conferma della modifica con messaggio
            DialogResult dialogResult = MessageBox.Show("Confermi la modifica della data?", "Conferma", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var selectedRow = Grid.SelectedItems[0] as DataRowView;
            selectedRow["data"] = Check();

            // poi dovrà salvare nel database
            string id = selectedRow["id"].ToString();
            string query = "UPDATE Messaggi SET data = '" + selectedRow["data"] + "' WHERE id = " + id;

            connKong.ExecQuery(query);
            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nella modifica del record");
                return;
            }

            // aggiorna la griglia
            LoadData();
        }

        private DateTime Check()
        {

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Non ci sono record da modificare");
                return DateTime.Now;
            }

            if (Grid.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selezionare un record", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return DateTime.Now;
            }

            // testa se la data  + o meno i giorni inseriti nel numData è inferiore a quella attuale
            if (numData.Value == 0)
            {
                MessageBox.Show("Inserire un numero di giorni");
                return DateTime.Now;
            }

            var selectedRow = Grid.SelectedItems[0] as DataRowView;
            DateTime data = Convert.ToDateTime(selectedRow["data"]);
            data = data.AddDays(Convert.ToDouble(numData.Value));
            return data;
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }
    }
}
