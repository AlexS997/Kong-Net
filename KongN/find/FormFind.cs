using KongN.Classi;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Enums;
using Printing;
using Syncfusion.XlsIO;
using System.IO;
using Syncfusion.WinForms.DataGridConverter;

namespace KongN.Find
{
    public partial class FormFind : Form
    {
        Color oddRow = Color.Transparent;
        Color evenRow = Color.AliceBlue;
        
        public FormFind()
        {
            InitializeComponent();
        }
    

        #region VariabiliPubbliche

        /* Le variabili hanno il seguente significato
         
        _campo è il nome del campo indicato dal chiamante che deve restituire il valore della cella e della riga selezionata in _ReturnDesc
        _id è l'id della tabella passata che viene ritornato se richiesto
        _ReturnRow è il numero di riga ritornato comunque anche se non rischiesto
        _DT è il DataTable che gli viene passato, non deve restituire nulla almeno per il momento
        _ReturnDesc è il valore restituito
        _NomeColonnaiD è il nome della colonna che contiene la chiave primaria serve per restituire l'id se richiesto


        */

        public string _campo { get; set; }
        public int _id { get; set; }
        public int _ReturnRow { get; set; }
        public DataTable _DT { get; set; }
        public string _ReturnDesc { get; set; }
        public string _NomeColonnaiD { get; set; }


        // se _typeColonnaiD=0 allora è una stringa altrimenti un int
        public int _TypeColonnaiD { get; set; }

        public DataView _DVRitorno { get; set; }

        public System.Data.DataRow _ReturnData { get; set; }

        #endregion


        private void Grid_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = evenRow;
            else
                e.Style.BackColor = oddRow;
        }


        private void btnEsci_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FormFind_Load(object sender, EventArgs e)
        {

        
            Services.Tracker.Track(this);

            Grid.AllowEditing = false;
            Grid.AllowDeleting = false;
            Grid.AllowSorting = true;
            Grid.AllowFiltering = true;
            Grid.AllowResizingColumns = true;

            // Verifica se _DT è popolato
            if (_DT != null && _DT.Rows.Count > 0)
            {
                // Assegna _DT come DataSource della griglia
                Grid.DataSource = _DT;
            }
            else
            {
                MessageBox.Show("Nessun dato disponibile per la visualizzazione.");
            }

            // Aggiungi l'evento QueryRowStyle
            Grid.QueryRowStyle += Grid_QueryRowStyle;


            if (_DT.Rows.Count > 0)
            {
                Grid.DataSource = _DT;

            }

        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleziona_Click(object sender, EventArgs e)
        {
            // se c'è almeno una cella selezionata
            if (Grid.SelectedItems.Count > 0)
            {
                // suggerito da Gemini
                // Ottieni l'oggetto dati selezionato nella griglia
                var selectedItem = Grid.SelectedItem;
                if (selectedItem != null)
                {
                    // Converti l'oggetto dati in un DataRow (se necessario)
                    DataRowView selectedRowView = selectedItem as DataRowView;
                    if (selectedRowView != null)
                    {
                        System.Data.DataRow selectedRow = selectedRowView.Row;
                        // ... utilizza selectedRow ...

                        // riporta indietro la riga selezionata mediante _ReturnRow
                        _ReturnData = selectedRow;

                       // MessageBox.Show(selectedRow[0].ToString());
                    }
                }
                // Fine Gemini */

                this.Close();
            }
        }


        private void Grid_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            // richiama il metodo btnSeleziona_Click
            btnSeleziona_Click(sender, e);
        }

        private void Grid_FilterChanged(object sender, FilterChangedEventArgs e)
        {
            // Aggiorna la griglia
            Grid.Refresh();
            Grid.Update();
            

        }

        private void Grid_FilterChanging(object sender, FilterChangingEventArgs e)
        {
            // Aggiorna la griglia
            Grid.Refresh();
            Grid.Update();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            
            PrintPreviewForm previewform = new PrintPreviewForm() { dataGrid = this.Grid };
            previewform.Show();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            var excelEngine = Grid.ExportToExcel(Grid.View, ExcelExportingOptions1());
            var workBook = excelEngine.Excel.Workbooks[0];
            SaveFileDialog sfd = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx",
                FileName = "Book1"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    if (sfd.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else
                        workBook.Version = ExcelVersion.Excel2010;
                    workBook.SaveAs(stream);
                }

                //Message box confirmation to view the created spreadsheet.
                if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    Open(sfd.FileName);
                }
            }

        }
        private ExcelExportingOptions ExcelExportingOptions1()
        {
            var options = new ExcelExportingOptions();
            //options.Exporting += GridExcelExportingOptions_Exporting1;
            //options.CellExporting += GridExcelExportingOptions_CellExporting1;
            //options.AllowOutlining = this.allowGroupOutlining.Checked;
            return options;
        }
        private void Open(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Non è possibile aprire il file: " + ex.Message);
            }
        }
        //private ExcelExportingOptions ExcelExportingOptions1()
        //{
        //    GridExcelExportingOptions.Exporting += GridExcelExportingOptions_Exporting1;
        //    GridExcelExportingOptions.CellExporting += GridExcelExportingOptions_CellExporting1;
        //    GridExcelExportingOptions.AllowOutlining = this.allowGroupOutlining.Checked;
        //    return GridExcelExportingOptions;
        //}
    }


}




