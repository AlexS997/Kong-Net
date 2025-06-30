using KongN.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace KongN.Voip
{
    public partial class FrmNormalizzazione : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);

        public FrmNormalizzazione()
        {
            InitializeComponent();
        }

        private void FrmNormalizzazione_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            label.Text = "La procedura si occupa di normalizzare il tipo di chiamata in base al prefisso";
            label.Text += " Può normalizzare sia il dettaglio delle chiamate sia lo storico delle chiamate.";
            label.Text += " Attenzione !!! La normalizzazione può impiegare diversi minuti nel caso di molti record presenti.";
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElabora_Click(object sender, EventArgs e)
        {
            string _Tabella = "";
            string _Sql = "";

            //DATEDIFF(second, '0:0:0', voipdettaglio.durata) AS secondi
            if (rbuChiamate.Checked)
            {
                // Elabora chiamate
                _Tabella = "VoIPdettaglio";
            }
            else
            {
                // Elabora storico
                _Tabella = "VoipDettaglioStorico";
            }

            Cursor = Cursors.WaitCursor;

            //if (FunzioniComuni.MancaPrefisso("VoiPDettaglio") == false)
            //{
            //    Cursor = Cursors.Default;
            //    return;
            //}

            if (!PrefissoEsiste("VoIPdettaglio"))
            {
                Cursor = Cursors.Default;
                return;
            }

            //--------------------------------------------------------------------------------
            // questa funzione di controllo non deve essere eseguita in questo contesto
            // in quanto è in questa funzione che si effettua il calcolo dei secondi
            // e quindi non ha senso controllare se mancano i secondi
            //--------------------------------------------------------------------------------



            Int32 _Lunghezza = 0;
            _Sql = "SELECT LunghezzaPrefisso FROM VoipAutomatismi";
            connKong.ExecQuery(_Sql);
            _Lunghezza = Convert.ToInt32(connKong.DBDT.Rows[0]["LunghezzaPrefisso"]);


            // todo : implementare la funzione di normalizzazione
            // per lo storico e per il dettaglio
            //            UPDATE Voipdettaglio
            //SET tipo = VoiPTipoChiamate.Tipo, NTipo = VoiPTipoChiamate.iD
            //FROM Voipdettaglio INNER JOIN
            //  VoiPTipoChiamate ON LEFT(Voipdettaglio.prefisso, 3) = VoiPTipoChiamate.Prefisso


            string _SQL = @"UPDATE  " + _Tabella +
               " SET  tipo = " + _Tabella + ".Tipo, NTipo = VoiPTipoChiamate.iD ,DurataTime = DATEDIFF(second, '0:0:0'," + _Tabella + ".durata)" +
                " FROM " + _Tabella + "  INNER JOIN " +
                         " VoiPTipoChiamate ON LEFT( " + _Tabella + ".prefisso, " + _Lunghezza + ") = VoiPTipoChiamate.Prefisso";

            // SQLControl cnKong = new SQLControl(FunzioniComuni.GetConnectionStringByName(connKong));

            // cursore hourglass perchè l'operazione potrebbe richiedere tempo
            Cursor.Current = Cursors.WaitCursor;

            connKong.ExecQuery(_SQL);
            if (connKong.HasException(true))
            {
                // cursore normale
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Errore durante l'elaborazione", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Elaborazione completata", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cursor.Current = Cursors.Default;
            Cursor = Cursors.Default;
        }


        // Funzione per verificare se il prefisso esiste
        private bool PrefissoEsiste(string tabella)
        {

            string query = $"SELECT COUNT(*) FROM {tabella} WHERE prefisso IS NOT NULL";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                return false;
            }
            return connKong.DBDT.Rows[0][0].ToString() != "0";
        }
    }
}
