using KongN.Classi;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Controlli
{
    public partial class FrmSpesePostali : Form
    {
        SQLControl BolFat = new SQLControl(Global.connAna);
        SQLControl Auto = new SQLControl(Global.connKongN);

        DataTable dt = new DataTable();

        // variabile che serve per vedere se il programma ha eseguito con successo la query
        bool bQuery = false;
        string cIva = "";

        public FrmSpesePostali()
        {
            InitializeComponent();
            Grid.CellClick += Grid_CellClick;
            Grid.QueryRowStyle += Grid_QueryRowStyle;
        }


        private void FrmSpesePostali_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            lblRecord.Visible = false;
            Bar.Visible = false;
            dtpStart.Value = DateTime.Now.AddMonths(-1);
            dtpEnd.Value = DateTime.Now;

        }


        private void btnEstrai_Click(object sender, EventArgs e)
        {
            if (bQuery == true)
            {
                MessageBox.Show("E' già stata eseguita una query di aggiornamento delle fatture, per eseguirne un'altra chiudere e riaprire il programma tenendo conto che se lo esegui di nuovo le spese verranno raddoppiate.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Estrai();

        }

        private void Estrai()
        {
            if (Controlla() == false)
            {
                return;
            }


            string s = "SELECT FattTest.ID, FattTest.NumDoc, FattTest.DataDoc,CliFatt1.CodCli,Clienti.Denom, CliFatt1.U_SpesePostali " +
                "FROM FattTest " +
                "INNER JOIN CliFatt1 ON FattTest.Cliente = CliFatt1.CodCli " +
                "INNER JOIN Clienti ON CliFatt1.CodCli=Clienti.CodCli " +
                "INNER JOIN  MovContTest ON FattTest.IDMovCont = MovContTest.ID " +
                "WHERE (YEAR(MovContTest.DataMov) = 1900) " +
                "AND (CliFatt1.U_SpesePostali = 0) " +
                "AND (FattTest.DataDoc >= @StartDate ) " +
                "AND (FattTest.DataDoc <= @EndDate) " +
                "ORDER BY FattTest.DataDoc, FattTest.NumDoc";


            //string s = "SELECT FattTest.iD,FattTest.Tipo, FattTest.Anno, FattTest.NumDoc, FattTest.DataDoc, Clienti.CodCli, Clienti.Denom, CliFatt1.U_SpesePostali AS SpesePostali" +
            //  " FROM     Clienti INNER JOIN CliFatt1 ON Clienti.CodCli = CliFatt1.CodCli INNER JOIN FattTest ON Clienti.CodCli = FattTest.Cliente" +
            //  " INNER JOIN MovContTest ON FattTest.IDMovCont = MovContTest.ID " +
            //   " where FattTest.datadoc between ' " + dateTimePicker.Value.Date + "' AND '" + dateTimePicker1.Value.Date + "'  AND U_SpesePostali > 0 AND YEAR( MovContTest.DataMov)= 1900" +

            //   " ORDER BY FattTest.DataDoc,FattTest.NumDoc";

            BolFat.AddParam("@StartDate", dtpStart.Value.ToString());
            BolFat.AddParam("@EndDate", dtpEnd.Value.ToString());

            BolFat.ExecQuery(s);

            if (BolFat.HasException(true))
            {
                MessageBox.Show("Errore durante l'estrazione dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dt = BolFat.DBDT;

            if (dt.Rows.Count >= 0)
            {
                // esamina se le fatture estratte hanno già le spese aggiunte 
                // andando a vedere se nella tabella BolFattSpese esiste una riga con Nriga=1 valorizzata
                // se esiste la riga allora la fattura è già stata aggiornata e quindi la elimino dalla lista   
                EliminaRecordSpeseEsistenti();
                if (dt == null)
                {
                    // vuol dire che si è verificato un errore nell'estrazione dei dati
                    return;
                }

            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Non ci sono dati da visualizzare", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //dt.Columns.Add("Seleziona", typeof(bool));

            // aggiunge la colonna seleziona alla flexgrid


            Grid.DataSource = dt;
            dt.Columns.Add("Seleziona", typeof(bool));



            foreach (var column in Grid.Columns)
            {
                if (column.HeaderText == "Seleziona")
                {
                    column.AllowEditing = true;

                }
                else
                {
                    column.AllowEditing = false;
                }
            }


            //Grid.Columns["Seleziona"].AllowEditing = true;
            ////Grid.Columns["Seleziona"].DataType = typeof(bool);
            //Grid.Columns["Seleziona"].Width = 50;
            ////Grid.Columns["Seleziona"].Caption = "Seleziona";
            //Grid.Columns["Seleziona"].Visible = true;
            //Grid.Columns["Seleziona"].AllowSorting = false;
            //Grid.Columns["Seleziona"].AllowDragging = false;
            //Grid.Columns["Seleziona"].AllowResizing = false;
            ////Grid.Columns["Seleziona"].AllowMerging = false;


            lblRecord.Text = "Record: " + dt.Rows.Count.ToString();
            lblRecord.Visible = true;

            Bar.Visible = true;
            Bar.Maximum = dt.Rows.Count;
            Bar.Minimum = 0;

            // conta le righe con la colonna seleziona=true 
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Seleziona"].ToString() == "True")
                {
                    i++;
                    Bar.Value = i;
                }
            }

            Bar.Visible = false;

        }

        private void EliminaRecordSpeseEsistenti()
        {
            string query = "";
            // esegue il ciclo foreach della taballe dt
            //dt.Columns.Add("Seleziona", typeof(bool));
            foreach (DataRow dr in dt.Rows)
            {
                query = "SELECT * FROM BolFatSpese WHERE Nriga=1 AND IDTest=" + dr[0].ToString();
                BolFat.ExecQuery(query);

                if (BolFat.HasException(true))
                {
                    MessageBox.Show("Errore durante l'estrazione dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //if (BolFat.DBDT.Rows.Count > 0)
                //{
                //    // vuol dire che la fattura è già stata aggiornata e quindi la elimino dalla lista
                //    // aggiunge il valore true alla colonna Selezione
                //    dr["Seleziona"] = true;
                //    // dr.Table.Rows.Remove(dr);
                //}
            }
            return;

        }

        private bool Controlla()
        {
            //controlla che la data iniziale sia minore o uguale a quella finale
            if (dtpStart.Value > dtpEnd.Value)
            {
                MessageBox.Show("La data iniziale deve essere minore o uguale a quella finale", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        private void btnFatture_Click(object sender, EventArgs e)
        {
            if (!ControllaAutoMatismi())
            {
                return;
            }

            MessageBox.Show("Le Fatture saranno modificate aggiungendo le spese.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("Vuoi continuare?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            // contralla che vi siano righe selezionate
            if (Grid.RowCount == 0)
            {
                MessageBox.Show("Non ci sono righe selezionate.");
                return;
            }
            List<object> righe = new List<object>();
            //get each selected row



            // for each row in the selected rows collection

            // per ogni riga selezionata in Flex
            // aggiunge il valore del campo iD nella Lisr righe

            //for (int i = 1; i < Grid.RowCount; i++)
            //{

            // se c'è almeno una cella selezionata
            if (Grid.SelectedItems.Count > 0)
            {
                // Ottieni l'oggetto dati selezionato nella griglia
                var selectedItem = Grid.SelectedItem;
                if (selectedItem != null)
                {
                    // Converti l'oggetto dati in un DataRow (se necessario)
                    DataRowView selectedRowView = selectedItem as DataRowView;
                    //if the selected item from column Seleziona is true
                    if (Convert.ToBoolean(selectedRowView["Seleziona"]) == true)
                    {
                        righe.Add(selectedRowView["iD"]);
                    }
                }
            }



            //var row = Grid.View.Records[i].Data as DataRowView;
            //if (Convert.ToBoolean(row["Seleziona"]) == true)
            //{
            //    righe.Add(row["iD"]);
            //}

            //}
            //{
            //    // metto il valore dell'id nella lista
            //}
            //foreach (Row row in Flex.Rows.Selected)
            //{
            //    // metto il valore dell'id nella lista   


            //    //righe.Add((int)row[1]);
            //    righe.Add((object)row[1]);
            //    // aggiunge il valore di id alla lista righe

            //}
            if (righe.Count == 0)
            {
                MessageBox.Show("Non hai selezionato nessuna riga.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // toglie il primo elemento della lista che è il nome della colonna
            //righe.RemoveAt(0);

            if (UpgradeFatture(righe))
            {
                MessageBox.Show("Le Fatture sono state aggiornate.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Le Fatture non sono state aggiornate. Nessun dato è stato Salvato.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool UpgradeFatture(List<object> r)
        {
            // qui devo fare tutte le operazioni per aggiornare le fatture  



            // questo è l'esempio di trnnsazione che ho trovato su internet
            //string strConnString = "myconnectionstring"; // get it from Web.config file    
            //SqlTransaction objTrans = null;

            //using (SqlConnection objConn = new SqlConnection(strConnString))
            //{
            //    objConn.Open();
            //    objTrans = objConn.BeginTransaction();
            //    SqlCommand objCmd1 = new SqlCommand("insert into tblProject values(1, 'TestProject')", objConn);
            //    SqlCommand objCmd2 = new SqlCommand("insert into tblProjectMember(MemberID, ProjectID) values(2, 1)", objConn);
            //    try
            //    {
            //        objCmd1.ExecuteNonQuery();
            //        objCmd2.ExecuteNonQuery(); // Throws exception due to foreign key constraint   
            //        objTrans.Commit();
            //    }
            //    catch (Exception)
            //    {
            //        objTrans.Rollback();
            //    }
            //    finally
            //    {
            //        objConn.Close();
            //    }
            // }

            // controlla che la List contenga qualcosa
            if (r.Count == 0)
            {
                MessageBox.Show("La lista è vuota");
                return false;
            }



            string query1 = "UPDATE FattTest " +
             "SET  TotSpese = FattTest.TotSpese + CliFatt1.U_SpesePostali, TotDocum = FattTest.TotDocum + CliFatt1.U_SpesePostali," +
            " TotSpese2Val = FattTest.TotSpese2Val + CliFatt1.U_SpesePostali,  TotDocum2Val = FattTest.TotDocum2Val + CliFatt1.U_SpesePostali, TotDocumValBil=TotDocumValBil+CliFatt1.U_SpesePostali,TotSpeseBil=FattTest.TotSpese" +
            " FROM   FattTest INNER JOIN CliFatt1 ON FattTest.Cliente = CliFatt1.CodCli" +
            " WHERE   FattTest.iD in (" + String.Join(",", r) + ")";



            //String.Join(",", resultList1);



            // prima di lanciare la query che aggiunge le righe alla tabella BolFattSpese
            // deve andare a cancellare la riga n.riga=1 se esite
            // questo perchè se da king vengono tolte le spese manualmente
            // la riga rimane e quindi si genererebbero 2 righe con Nriga a 1 

            string query2 = "DELETE FROM BolFatSpese WHERE NRiga=1 AND IDTest in (" + String.Join(",", r) + ")";



            //query che aggiunge una riga per ogni fattura aggiornata nella tabella BolFattSpese
            string query3 = "INSERT INTO BolFatSpese (IDTest, Tipo, NRiga,Importo,CodIva) " +
                "SELECT     FattTest.ID, 'F', 1, CliFatt1.U_SpesePostali, '" + cIva + "'" +
                "FROM         FattTest INNER JOIN " +
                " CliFatt1 ON FattTest.Cliente = CliFatt1.CodCli  " +
                " WHERE      FattTest.iD in(" + String.Join(",", r) + ")";

            // modifica fatta in data 17/11/2023 perchè non aggiornava le scadenze

            // UPDATE MovContScad
            //SET Importo = MovContScad.Importo + 2, ImpVal = MovContScad.ImpVal + 2
            //FROM FattTest INNER JOIN
            // MovContScad ON FattTest.IDMovCont = MovContScad.IDMov

            string query4 = "UPDATE MovContScad " +
                "SET Importo = MovContScad.Importo + CliFatt1.U_SpesePostali, ImpVal = MovContScad.ImpVal + CliFatt1.U_SpesePostali" +
                " FROM FattTest INNER JOIN " +
                " MovContScad ON FattTest.IDMovCont = MovContScad.IDMov INNER JOIN " +
                " CliFatt1 ON FattTest.Cliente = CliFatt1.CodCli " +
                " WHERE FattTest.iD in(" + String.Join(",", r) + ") AND NumRiga=1";







            //conta il numero di righe che hanno le scadenze
            // dipende dal tipo di pagamento e quante rate ha il pagamento

            //                SELECT COUNT(*) AS QuanteRighe
            //FROM FattTest INNER JOIN
            //                         MovContScad ON FattTest.IDMovCont = MovContScad.IDMov
            //GROUP BY FattTest.ID, FattTest.IDMovCont
            //HAVING(FattTest.IDMovCont = 368324)

            // string queryScadenze = "select * from MovContScad where idMov =" +



            try
            {
                BolFat.ExecQuery(query1);
                BolFat.ExecQuery(query2);
                BolFat.ExecQuery(query3);
                BolFat.ExecQuery(query4);

                if (BolFat.HasException(true))
                {
                    MessageBox.Show("Errore durante l'aggiornamento delle fatture", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                // conta quante rrighe ci sono nella List
                // per ogni riga esegue la query che conta le righe delle scadenze
                //  e poi aggiorna le scadenze
                //foreach (Object o in r)
                //  {
                //      string queryRighe=" SELECT COUNT(*) AS QuanteRighe FROM FattTest INNER JOIN MovContScad ON FattTest.IDMovCont = MovContScad.IDMov"+
                //     " GROUP BY FattTest.ID, FattTest.IDMovCont"+
                //      " HAVING(FattTest.IDMovCont =" + (int)o + ")";

                //      SqlCommand objCmdRighe = new SqlCommand(queryRighe, objConn);

                //      // esegue la query che conta le righe delle scadenze

                //      int iRighe = (int)objCmdRighe.ExecuteScalar();

                //      MessageBox.Show("Righe : " + iRighe.ToString());



                //     }







                // Throws exception due to foreign key constraint
                //una volta eseguito senza errori il primo comando eseguo il secondo    
                // deve aggiornare la dabella delle spese nella tabella BolFattSpese
                // aggiungendo una riga per ogni fattura aggiornata
                // per ogni fattura aggiornata devo prendere il valore di U_SpesePostali dalla tabella CliFatt1
                // e inserirlo nella tabella BolFattSpese



                bQuery = true;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private bool ControllaAutoMatismi()
        {
            // // controlla che nella Tabella automatismi il campo CodIvaSpesePostali sia valorizzato  

            string s = "SELECT CodIvaSpesePostali FROM Automatismi";
            Auto.ExecQuery(s);

            if (Auto.HasException(true))
            {
                MessageBox.Show("Errore durante l'estrazione dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            dt = Auto.DBDT;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Il campo CodIvaSpesePostali nella tabella Automatismi non è valorizzato oppure la Tabella Automatismi è vuota", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string CodIvaSpesePostali = dt.Rows[0].Field<string>("CodIvaSpesePostali");
            if (CodIvaSpesePostali == "")
            {
                MessageBox.Show("Il campo CodIvaSpesePostali nella tabella Automatismi non è valorizzato .", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            cIva = CodIvaSpesePostali;
            return true;

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkSelezionaTutto_CheckedChanged(object sender, EventArgs e)
        {
            if (Grid.RowCount == 0)
            {
                MessageBox.Show("Non ci sono dati da selezionare");
                return;
            }


            //if (chkSelezionaTutto.Checked == true)
            //{
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        // la prima riga contiene le intestazioni
            //        if (row.Index == 0)
            //        {
            //            continue;
            //        }

            //        Grid[row.Index, "Seleziona"] = true;

            //    }
            //}

            //else
            //{
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        // la prima riga contiene le intestazioni
            //        if (row.Index == 0)
            //        {
            //            continue;
            //        }
            //        Grid[row.Index, "Seleziona"] = false;
            //    }

            //}


            bool selectAll = chkSelezionaTutto.Checked;

            // Go through all the rows in DataTable and change the value of the "Seleziona" column
            foreach (DataRow row in dt.Rows)
            {
                // Set the value of the "Seleziona" column according to checkbox
                row["Seleziona"] = selectAll;
            }

            // Refresh the grid to reflect changes
            Grid.Refresh();

        }

        private void Grid_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (e.DataColumn != null && e.DataColumn.GridColumn.MappingName == "Seleziona")
            {
                Grid.AllowEditing = true;
            }
            else
            {
                Grid.AllowEditing = false;
            }
        }

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }
    }
}
