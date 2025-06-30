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

namespace KongN.Agenda
{
    public partial class FrmStoricoAgenda : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        DataTable _dt = new DataTable();

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }


        public FrmStoricoAgenda()
        {
            InitializeComponent();
        }

        private void FrmStoricoAgenda_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            LoadData();

            dtpData.Value = DateTime.Now.AddYears(-1);
        }

        private void LoadData()
        {
            string query = "SELECT * FROM AgendaStorico ORDER BY DataInizio DESC";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore durante il caricamento dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _dt = connKong.DBDT;
            Grid.DataSource = _dt;

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Vuoi Cancellare Il record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:
                    if (Grid.SelectedItem != null)
                    {
                        // Supponiamo che l'ID del record sia nella colonna "ID"
                        int selectedRecordId = Convert.ToInt32(((DataRowView)Grid.SelectedItem)["Id"]);

                        // Esegui la query di eliminazione
                        string deleteQuery = "DELETE FROM AgendaStorico WHERE Id = @ID";

                        connKong.AddParam("@ID", selectedRecordId);
                        connKong.ExecQuery(deleteQuery);

                        if (connKong.HasException(true))
                        {
                            MessageBox.Show("Errore durante l'eliminazione del record", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Ricarica i dati nella griglia
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Nessun record selezionato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case DialogResult.No:

                    break;

            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Confermi di voler eliminare i record vecchi? Sarà possibile eliminare solo i record più vecchi di anni uno.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:

                    TimeSpan difference = getDateDifference(DateTime.Now, dtpData.Value.Value);

                    int differenceInDays = difference.Days;
                    if (differenceInDays < 365)
                    {
                        MessageBox.Show("La data deve essere inferiore a un anno fa.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "DELETE FROM AgendaStorico WHERE DataInizio < @DataInizio";
                    connKong.AddParam("@DataInizio", dtpData.Value);

                    connKong.ExecQuery(query);
                    if (connKong.HasException(true))
                    {
                        MessageBox.Show("Errore durante la cancellazione del record", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Record eliminati correttamente", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();

                    break;

                case DialogResult.No:

                    break;

            }

        }

        TimeSpan getDateDifference(DateTime date1, DateTime date2)
        {
            TimeSpan ts = date1 - date2;

            return ts;
        }


        //change the records from Grid when dataPicker value is changed
        private void dtpData_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            string query = "SELECT * FROM AgendaStorico where DataInizio < @DataInizio ORDER BY DataInizio DESC";
            connKong.AddParam("@DataInizio", dtpData.Value);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore durante il caricamento dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _dt = connKong.DBDT;
            Grid.DataSource = _dt;
        }
    }
}
