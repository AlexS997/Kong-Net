using FastReport;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace KongN.Stampa
{
    public partial class FormStampa : Form
    {
        private Report report;

        public FormStampa(DataTable dataTable, string reportPath, string reportName, string dataTableName, Dictionary<string, object> parameters = null)
        {
            InitializeComponent();


            // Crea un'istanza del report
            report = new Report();

            // Carica il file del report
            // deve caricarlo ma controllare che esista quindi lo deve mettere dentro a try catch

            try
            {
                report.Load(System.IO.Path.Combine(reportPath, reportName));
            }
            catch (Exception)
            {
                MessageBox.Show($"File '{reportName}' not found.");
                return;

            }

            // Registra il nuovo dataset
            report.RegisterData(dataTable, dataTableName);

            // Imposta il nuovo dataset come sorgente dati del report
            var dataSource = report.GetDataSource(dataTableName);
            if (dataSource != null)
            {
                dataSource.Enabled = true;
            }
            else
            {
                MessageBox.Show($"Data source '{dataTableName}' not found.");
                return;
            }

            // Imposta i parametri nel report
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    report.SetParameterValue(param.Key, param.Value);
                }
            }

        }

        

        public void ShowReport()
        {
            // Mostra il report
            report.Show();

        }

       
    }
}
