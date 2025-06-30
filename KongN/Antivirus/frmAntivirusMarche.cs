using KongN.Classi;
using System;
using System.Windows.Forms;
using KongN.Find;
using System.Drawing;


namespace KongN.Antivirus
{
    public partial class frmAntivirusMarche : Form
    {
        // creo una variabile per sapere se è stato cliccato il bottone Aggiungi o modifica in base all' Id

        private int _iDMarca = 0;

        ButtonManager _buttonManager;


        public string Table = "AntivirusMarche";
        // Declare a ClsTableSchema object
        private ClsTableSchema _tableSchema;
        SQLControl Marche = new SQLControl(Global.connKongN);

        public frmAntivirusMarche()
        {
            InitializeComponent();
            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void frmAntivirusMarche_Load(object sender, EventArgs e)
        {
            BindControls();
            Services.Tracker.Track(this);
            DataLoad();

            // Initialize ClsTableSchema with the connection and name of the table
            _tableSchema = new ClsTableSchema(Global.connKongN, Table);
            ClsMaxLenght maxLengthSetter = new ClsMaxLenght();

            // We call the SetMaxLength method and give it the table schema as a parameter
            maxLengthSetter.SetMaxLength(this, _tableSchema);
        }

        private void DataLoad()
        {
           
            string sql = "Select * from AntivirusMarche";
            Marche.ExecQuery(sql);

            if (Marche.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati AntivirusMarche.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Marche.DBDT.Rows.Count > 0)
            {
                LeggiCampi();
            }

            txtiDMarca.Visible = false;
            _iDMarca = Convert.ToInt32(txtiDMarca.Text);
            ReadOnlyControls(true);

        }

        public void LeggiCampi()
        {
            txtiDMarca.Text = Marche.DBDT.Rows[0]["iD"].ToString();
            txtMarche.Text = Marche.DBDT.Rows[0]["Antivirus"].ToString();
            nP1.Value = Convert.ToDecimal(Marche.DBDT.Rows[0]["P1"]);
            nP2.Value = Convert.ToDecimal(Marche.DBDT.Rows[0]["P2"]);
            nP3.Value = Convert.ToDecimal(Marche.DBDT.Rows[0]["P3"]);
            nP4.Value = Convert.ToDecimal(Marche.DBDT.Rows[0]["P4"]);
            nP5.Value = Convert.ToDecimal(Marche.DBDT.Rows[0]["P5"]);
            nP6.Value = Convert.ToDecimal(Marche.DBDT.Rows[0]["P6"]);
            nP7.Value = Convert.ToDecimal(Marche.DBDT.Rows[0]["P7"]);
            nP8.Value = Convert.ToDecimal(Marche.DBDT.Rows[0]["P8"]);
            nP9.Value = Convert.ToDecimal(Marche.DBDT.Rows[0]["P9"]);
            nP10.Value = Convert.ToDecimal(Marche.DBDT.Rows[0]["P10"]);
            bsMarche.DataSource = Marche.DBDT;
        }


        public void BindControls()
        {
            txtMarche.DataBindings.Add("Text", bsMarche, "Antivirus");
            nP1.DataBindings.Add("Value", bsMarche, "P1");
            nP2.DataBindings.Add("Value", bsMarche, "P2");
            nP3.DataBindings.Add("Value", bsMarche, "P3");
            nP4.DataBindings.Add("Value", bsMarche, "P4");
            nP5.DataBindings.Add("Value", bsMarche, "P5");
            nP6.DataBindings.Add("Value", bsMarche, "P6");
            nP7.DataBindings.Add("Value", bsMarche, "P7");
            nP8.DataBindings.Add("Value", bsMarche, "P8");
            nP9.DataBindings.Add("Value", bsMarche, "P9");
            nP10.DataBindings.Add("Value", bsMarche, "P10");
            txtiDMarca.DataBindings.Add("Text", bsMarche, "iD");
        }

      

        private void ClearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
            }
        }

        public void ReadOnlyControls(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).ReadOnly = x;
                    ((NumericUpDown)c).Enabled = !x;
                }
            }
        }

        public bool Check()
        {
            bool result = true;
            // se il campo txtMarche è vuoto
            if (string.IsNullOrEmpty(txtMarche.Text))
            {
                MessageBox.Show("Inserire la Marca Antivirus.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarche.Focus();
                result = false;
                return result;
            }


            NumericUpDown[] numeri = { nP1, nP2, nP3, nP4, nP5, nP6, nP7, nP8, nP9, nP10 };
            string[] messaggi = {
                                    "1 deve essere maggiore di 0",
                                    "2 deve essere maggiore di 0",
                                    "3 deve essere maggiore di 0",
                                    "4 deve essere maggiore di 0",
                                    "5 deve essere maggiore di 0",
                                    "6 deve essere maggiore di 0",
                                    "7 deve essere maggiore di 0",
                                    "8 deve essere maggiore di 0",
                                    "9 deve essere maggiore di 0",
                                    "10 deve essere maggiore di 0"
                                };

            for (int i = 1; i < numeri.Length; i++)
            {
                if (numeri[i].Value > 0 && numeri[i - 1].Value == 0)
                {
                    MessageBox.Show(messaggi[i - 1], "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numeri[i - 1].Focus();
                    result = false;
                    break;
                }
            }

            return result;
        }


        private bool checkPresent()
        {
            bool result = true;
            //Controllo se l'antivirus è presente in Antivirus
            SQLControl conn = new SQLControl(Global.connKongN);

            string query = "SELECT * FROM Antivirus WHERE iDMarca = @iDMarca";
            conn.AddParam("@iDMarca", txtiDMarca.Text);

            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show("Errore nel recupero dei dati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            if (conn.DBDT.Rows.Count > 0)
            {
                MessageBox.Show("La Marca Antivirus è presente nella tabella dei Clienti , impossibile eliminare.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            //Elimina i dati da AntivirusMarche

            query = @"DELETE FROM AntivirusMarche WHERE iDMarca = @iDMarca";

            conn.AddParam("@iDMarca", txtiDMarca.Text);
            conn.ExecQuery(query);

            if (conn.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati AntivirusMarche.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

            if (_iDMarca != 0)
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtiDMarca.Text); //bsMarche.Find("iD", _iDMarca);
                ClearFields();
                DataLoad();
                //bsMarche.Position = pos;
                bsMarche.Find("iD", pos);
            }
            else
            {
                DataLoad();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // chiede conferma per l'eliminazione
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            if (checkPresent())
            {
                return;
            }


            DataLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }


            SQLControl Marche = new SQLControl(Global.connKongN);
            string query = "";

            if (_iDMarca == 0)
            {
                query = @"INSERT INTO AntivirusMarche (Antivirus, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, iDUtente, DataModifica) 
                    VALUES (@Antivirus, @P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, '" + Global.ID + "', '" + DateTime.Now + "')";
            }
            else
            {
                query = @"UPDATE AntivirusMarche SET P1 = @P1, P2 = @P2, P3 = @P3, P4 = @P4, P5 = @P5, 
                    P6 = @P6, P7 = @P7, P8 = @P8, P9 = @P9, P10 = @P10, Antivirus = @Antivirus, iDUtente = '" + Global.ID + "', DataModifica = '" + DateTime.Now + "' WHERE iD = @iD";
            }

            Marche.AddParam("@P1", nP1.Value);
            Marche.AddParam("@P2", nP2.Value);
            Marche.AddParam("@P3", nP3.Value);
            Marche.AddParam("@P4", nP4.Value);
            Marche.AddParam("@P5", nP5.Value);
            Marche.AddParam("@P6", nP6.Value);
            Marche.AddParam("@P7", nP7.Value);
            Marche.AddParam("@P8", nP8.Value);
            Marche.AddParam("@P9", nP9.Value);
            Marche.AddParam("@P10", nP10.Value);
            Marche.AddParam("@Antivirus", txtMarche.Text);
            Marche.AddParam("@iD", txtiDMarca.Text);

            Marche.ExecQuery(query);

            if (Marche.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati AntivirusMarche.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _iDMarca = Convert.ToInt32(txtiDMarca.Text);

            DataLoad();
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            ClearFields();
            _iDMarca = 0;

            // manda alla classe ButtonManager il nome del bottone cliccato
            _buttonManager.HandleButtonClick((ToolStripButton)sender);


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SQLControl M = new SQLControl(Global.connKongN);
            FormFind frmFind = new FormFind();
            string query = "SELECT * FROM AntivirusMarche ORDER BY Antivirus";

            M.ExecQuery(query);

            if (M.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati AntivirusMarche.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmFind._DT = M.DBDT;
            
            frmFind.ShowDialog();
            // se ritorna una datarow allora si posiziona nel record corrispondente
            if (frmFind._ReturnData != null)
            {

                // prende l'id del record selezionato ed effettua un find

                int id = Convert.ToInt32(frmFind._ReturnData["iD"]);


                var r = bsMarche.Find("iD", id);

                // si sposta sulla riga trovata
                bsMarche.Position = r;

            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataLoad();
        }


    }
}
