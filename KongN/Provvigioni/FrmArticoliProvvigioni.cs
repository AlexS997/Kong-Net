using KongN.Classi;
using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Enums;
using KongN.Find;
using System.Data;
using System.Collections.Generic;

namespace KongN.Provvigioni
{
    public partial class FrmArticoliProvvigioni : Form
    {
        SQLControl Articoli = new SQLControl(Global.connAna);
        SQLControl ArticoliProvvigioni = new SQLControl(Global.connKongN);
        ButtonManager _buttonManager;
       

       

        private void dataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }


        public FrmArticoliProvvigioni()
        {
            InitializeComponent();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.AutoManageNavigator = false;
            _buttonManager.DisableAllButtons();
            _buttonManager.EnableButton("btnAdd");

            _buttonManager.EnableButton("btnDelete");
                
             _buttonManager.EnableButton("btnClose");

            // Deve mettere le colonne della grid in autosize
            //Grid.AutoSizeColumnsMode = (AutoSizeColumnsMode)DataGridViewAutoSizeColumnsMode.Fill;
            //Grid.AutoSizeColumnsMode = (AutoSizeColumnsMode)DataGridViewAutoSizeColumnsMode.AllCells;

            //chiama il metodo Grid_QueryRowStyle per colorare le righe
           

            dataGridView.RowPrePaint += dataGridView_RowPrePaint;
        }

        private void FrmArticoliProvvigioni_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            FillRecord();

            label.Text = "In questa tabella vanno inseriti solo gli articoli di KING che partecipano al conteggio delle provvigioni. Negli articoli di KING esiste un campo denominato U_articoloKong che serve appunto per comuncare a KONG quali articoli prendere in considerazione.";
        }


        private void FillRecord()
        {
            string query= "Select CodArt, Descrizione, IdUtente, DataModifica from ProvvArticoli ORDER by CodArt";
            ArticoliProvvigioni.ExecQuery(query);

            if (ArticoliProvvigioni.HasException(true))
            {
                MessageBox.Show(ArticoliProvvigioni.Exception);
                return;
            }

            if (ArticoliProvvigioni.RecordCount > 0)
            {
                bsProvvArticoli.DataSource = ArticoliProvvigioni.DBDT;

               


                dataGridView.DataSource = bsProvvArticoli;

            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            // obtein CodArt from Provvigioni
            string queryP = "SELECT CodArt FROM ProvvArticoli";
            ArticoliProvvigioni.ExecQuery(queryP);

            if (ArticoliProvvigioni.HasException(true))
            {
                return;
            }

            // List to store all CodArt from Provvigioni

            List<string> codArtList = new List<string>();

            // check if there are records in Provvigioni
            if (ArticoliProvvigioni.RecordCount > 0)
            {
                // Add CodArt to the list
                foreach (DataRow row in ArticoliProvvigioni.DBDT.Rows)
                {
                    codArtList.Add(row["CodArt"].ToString());
                }
            }

            //string query = "SELECT CodArt, Descrizione FROM Articoli WHERE U_articoloKong = 1 ORDER BY CodArt";


            //a query SELECT CodArt, Descrizione FROM Articoli WHERE U_articoloKong = 1 and CodArt not in List codArtList
            string query = "SELECT CodArt, Descrizione FROM Articoli WHERE U_articoloKong = 1 and CodArt not in (";

            foreach (string codArt in codArtList)
            {
                query += "'" + codArt + "',";
            }

            query = query.TrimEnd(',');
            query += ")";



            Articoli.ExecQuery(query);

            
            if(Articoli.HasException(true))
            {
                return;
            }

            if (Articoli.RecordCount > 0)
            {
                FormFind find = new FormFind();
                find._DT = Articoli.DBDT;

                // se ritorna una riga allora lo salva nel database

                find.ShowDialog();

                // se_returnData contiene i dati della riga selezionata 

                if (find._ReturnData != null)

                {
                    string codArt = find._ReturnData["CodArt"].ToString();
                    string descrizione = find._ReturnData["Descrizione"].ToString();

                    ArticoliProvvigioni.AddParam("@CodArt", codArt);
                    ArticoliProvvigioni.AddParam("@Descrizione", descrizione);
                    ArticoliProvvigioni.AddParam("@iDUtente", Global.ID);
                    ArticoliProvvigioni.AddParam("@DataModifica", DateTime.Now);
                    string queryInsert = "Insert into ProvvArticoli (CodArt, Descrizione, IDUtente, DataModifica) values (@CodArt,@Descrizione,@iDUtente,@DataModifica)";

                    //string queryInsert = "Insert into ProvvArticoli (CodArt, Descrizione) values (@CodArt,@Descrizione)";
                    ArticoliProvvigioni.ExecQuery(queryInsert);
                    if (ArticoliProvvigioni.HasException(true))
                    {
                        return;
                    }
                    FillRecord();
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // se l'utente conferma allora si cancella il record il messaggio deve avere come pulsante di default il no
            switch (MessageBox.Show("Sei sicuro di Voler Cancellare", "Cancellazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:
                    string codArt = dataGridView.CurrentRow.Cells["CodArt"].Value.ToString();
                string query = "Delete from ProvvArticoli where CodArt = @CodArt";
                ArticoliProvvigioni.AddParam("@CodArt", codArt);
                ArticoliProvvigioni.ExecQuery(query);
                if (ArticoliProvvigioni.HasException(true))
                {
                    return;
                }
                FillRecord();
                    
                    break;

                case DialogResult.No:

                    break;

            }

           

        }
    }
}
