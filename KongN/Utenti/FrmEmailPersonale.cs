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

namespace KongN.Utenti
{
    public partial class FrmEmailPersonale : Form
    {

        public string _messaggio { get; set; }
        public string _nome { get; set; }

        public FrmEmailPersonale()
        {
            InitializeComponent();
        }

        private void FrmEmailPersonale_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
        }


        private void btnInvia_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Length == 0)
            {
                MessageBox.Show("Inserire il testo del messaggio");
                return;
            }

            _messaggio = txtMessage.Text;
            this.Close();
        }


        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
