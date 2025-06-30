using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Classi
{
    class UpdateChecker
    {
        private string currentVersion;
        private string latestVersionUrl;
        private string installationFileUrl;
        private string nomeSetup;

        public UpdateChecker()
        {
            currentVersion = Application.ProductVersion.ToString();
            latestVersionUrl = Global.FileUltimaVersione;
            installationFileUrl = Global.FileSetup;
            nomeSetup = Global.NomeSetup;
        }

        public (bool isNewVersionAvailable, string latestVersion) CheckForUpdates()
        {
            string latestVersion = string.Empty;

            // aggiungi il cursore di attesa
            Cursor.Current = Cursors.WaitCursor;

            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                try
                {
                    // deve riportare oltre che l'ultima versione anche se true o false se è disponibile un aggiornamento
                    latestVersion = wc.DownloadString(latestVersionUrl);

                    // Converti le versioni in oggetti Version
                    Version current = new Version(currentVersion);
                    Version latest = new Version(latestVersion);

                    // confronta le versioni
                    if (current.CompareTo(latest) < 0)
                    {
                        return (true, latestVersion);
                    }
                    else
                    {
                        return (false, latestVersion);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Errore nel controllo degli aggiornamenti", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false, string.Empty);
                }
                finally
                {
                    // rimuovi il cursore di attesa
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        public async Task UpdateApplicationAsync()
        {
            // aggiungi il cursore di attesa
            Cursor.Current = Cursors.WaitCursor;
            Varie.FormAttendere formAttendere = new Varie.FormAttendere();
            try
            {
                using (System.Net.WebClient wc = new System.Net.WebClient())
                {
                    // chiama la form di attesa
                   
                    formAttendere.Show();
                    await wc.DownloadFileTaskAsync(new Uri(installationFileUrl), nomeSetup);
                    formAttendere.Close();
                }
                System.Diagnostics.Process.Start(nomeSetup);
                Application.Exit();
            }
            catch (Exception)
            {
                formAttendere.Close();
                MessageBox.Show("Errore nel download del file di installazione", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // rimuovi il cursore di attesa
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
