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

namespace KongN.SMS
{
    public partial class FrmLegendaProfili : Form
    {
        public FrmLegendaProfili()
        {
            InitializeComponent();
        }
        
        private void FrmLegendaProfili_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            txt.Text = "Legenda Profili";
            txt.Text += "\r\n";
            txt.Text += "I parametri sono utilizzati nei messaggi SMS e nelle operazioni pianificate\r\n";
            txt.Text += "Sostanzialmente i parametri vanno a riprendere i segnaposto indicati con @ e nome del parametro sostituendoli con i dati presi o dalla contabilità nel caso deigli SMS\r\n";
            txt.Text += "oppure direttamente dalla maschera delle operazioni pianificate\r\n";
            txt.Text += "I parametri sono i seguenti:\r\n";
            txt.Text += "Parametri utilizzati nella maschera delle Operazioni Pianificate.\r\n";
            txt.Text += "@D1: Data di riferimento dell'operazione pianificata. Cioè la prima data che viene chiesta.\r\n";
            txt.Text += "@D2: Data di riferimento dell'operazione pianificata. Cioè la seconda data che viene chiesta.\r\n";
            txt.Text += "@Profilo1: Il vecchio profilo dell'utente.\r\n";
            txt.Text += "@Profilo2: Il nuovo profilo dell'utente.\r\n";
            txt.Text += "Parametri utilizzate negli SMS .\r\n";
            txt.Text += "@Importo: Importo delle partite aperte per il cliente selezionato.\r\n";
            txt.Text += "@F: Fatture del cliente con Importo, Data Documento e Numero Documento.\r\n";
            txt.Text += "Nel caso delle operazioni pianificate e il contemporaneo invio del SMS il testo del SMS rifletterà quanto inserito nell'operazione pianificata.\r\n";

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
