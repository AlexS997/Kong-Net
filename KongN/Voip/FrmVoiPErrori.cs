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

namespace KongN.Voip
{
    public partial class FrmVoiPErrori : Form
    {

        public FrmVoiPErrori()
        {
            InitializeComponent();
        }

        private void FrmVoiPErrori_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
