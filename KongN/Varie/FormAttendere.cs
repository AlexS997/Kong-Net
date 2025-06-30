using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KongN.Classi;

namespace KongN.Varie
{
    public partial class FormAttendere: Form
    {
        public FormAttendere()
        {
            InitializeComponent();
            Services.Tracker.Track(this);

        }

        private void FormAttendere_Load(object sender, EventArgs e)
        {

        }
    }
}
