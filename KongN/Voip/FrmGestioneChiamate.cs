using KongN.Classi;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Voip
{
    public partial class FrmGestioneChiamate : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        string _Sql = "";

        string _Tabella = "VoipDettaglio";
        DataTable _dt = new DataTable();


        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }


        public FrmGestioneChiamate()
        {
            InitializeComponent();
        }


        private void FrmGestioneChiamate_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            label.Text = "Attenzione la maschera permette di manipolare le chiamate o lo storico delle chiamate.\n " +
                "Permette di Aggiungere, Cancellare e Modificare senza nessun controllo.\n " +
                "Se sei un utente abilitato puoi farlo altrimenti puoi solo vedere le chiamate.";

            lblRecord.Visible = false;
            groupBox.Visible = false;
           
        }


        private void btnEstrai_Click(object sender, EventArgs e)
        {
            Estrai();
        }


        private void Estrai()
        {
            _Sql = "SELECT * FROM " + _Tabella + " ORDER BY data, orachiamata, chiamante";
            Cursor.Current = Cursors.WaitCursor;

            connKong.ExecQuery(_Sql);
            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore: " + connKong.Exception);
                Cursor.Current = Cursors.Default;
                return;
            }

            _dt = connKong.DBDT;
            Grid.DataSource = _dt;
            Cursor.Current = Cursors.Default;
            lblRecord.Visible = true;
            lblRecord.Text = "Record presenti: " + _dt.Rows.Count.ToString();

            return;
        }


        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void rbuChiamate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbuChiamate.Checked)
            {
                _dt.Clear();
                lblRecord.Text = "Record presenti: ";
                _Tabella = "VoIPdettaglio";
                groupBox.Visible = false;

            }
            else
            {
                _dt.Clear();
                lblRecord.Text = "Record presenti: ";
                _Tabella = "VoIPDettaglioStorico";
                groupBox.Visible = true;

                dtp.Value = DateTime.Now.AddYears(-2);

            }
        }


        private void btnDettaglio_Click(object sender, EventArgs e)
        {
            /*
             Il metodo btnDettaglio_Click è progettato per:
                1. Spostare i dati più vecchi (fino a una certa data) dalla tabella 
                        principale VoIPdettaglio alla tabella VoipDettaglioStorico.

                2. Utilizzare una tabella temporanea (VoipDetteaglioStoricoTemp) per 
                        gestire i dati durante il processo.

                3. Garantire che i dati duplicati non vengano inseriti nella tabella 
                        VoipDettaglioStorico.

                4. Mantenere la tabella principale pulita, eliminando i dati già archiviati.

             */


            // chiede conferma del trasferimento a storico
            if (MessageBox.Show("Sei sicuro di voler spostare le chiamate più vecchie di " + dtp.Value.Value.ToString("dd-MM-yyyy") + " a storico?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            string query = "Delete from VoipDettaglioTemp DBCC CHECKIDENT ('VoipDettaglioTemp', RESEED, 0)";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore: " + connKong.Exception + " \nNon è stato possibile cancellare la tabella temporanea.");
                return;
            }


            query = "INSERT INTO VoIPDettaglioTemp ";
            query += "(orachiamata, data, chiamante, prefisso, chiamato, durata, importo, spesa, tipo, NTipo, DurataTime, iDDettaglio , iDUtente, DataModifica) ";
            query += "SELECT orachiamata, data, chiamante, prefisso, chiamato, durata, importo, spesa, tipo,  NTipo, DurataTime, iD, @iDUtente, @DataModifica ";
            query += "FROM VoIPdettaglio ";
            query += "WHERE data <= @data ORDER BY data";


            connKong.AddParam("@data", dtp.Value.Value.ToString("dd-MM-yyyy"));
            connKong.AddParam("@iDUtente", Global.ID);
            connKong.AddParam("@DataModifica", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore: " + connKong.Exception + "\nNon è stato possibile inserire i dati nella tabella temporanea.");
                return;
            }


            query = "INSERT INTO VoipDettaglioStorico (orachiamata, data, chiamante, prefisso, chiamato, " +
                        "durata, importo, spesa, tipo, NTipo, DurataTime, iDUtente, DataModifica) " +
                    "SELECT orachiamata, data, chiamante, prefisso, chiamato, " +
                        "durata, importo, spesa, tipo, NTipo, DurataTime, iDUtente, DataModifica " +
                    "FROM VoipDettaglioTemp " +
                    "WHERE NOT EXISTS (" +
                        "SELECT 1 FROM VoipDettaglioStorico " +
                        "WHERE VoipDettaglioStorico.data = VoipDettaglioTemp.data)";


            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore: " + connKong.Exception +"\nNon è stato possibile inserire i dati nello storico.");
                return;
            }

            query = "DELETE FROM VoIPdettaglio FROM VoIPDettaglioTemp INNER JOIN VoIPdettaglio ON VoIPDettaglioTemp.iDDettaglio = VoIPdettaglio.iD";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore: " + connKong.Exception + "\n Non è stato possibile cancellare i dati dalla tabella delle chiamate.");
                return;
            }

            MessageBox.Show("Operazione completata con successo.", "Successo!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Estrai();

        }


        private void dtp_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
           // se la data che inserisco è maggiore della data attuale - 2 anni allora la deve rifiutare
            if (dtp.Value > DateTime.Now.AddYears(-2))
            {
                MessageBox.Show("Almeno 2 anni devono essere presenti nelle chiamate");
                dtp.Value = DateTime.Now.AddYears(-2);
            }
           
        }
    }
}
