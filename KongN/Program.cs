using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzgwMzM3NkAzMjM5MmUzMDJlMzAzYjMyMzkzYkVGakRGVnU3d0drV0o4cTd2U2p3ZCt1dVJ6M3ppVTFXSkVDVFFQUTJMWnM9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new vLogin());
        }
    }
}
