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

namespace KongN.StrutturaRete
{
    public partial class FrmAlbero : Form
    {
        SQLControl sql = new SQLControl(Global.connKongN);

        DataTable dtFonti = new DataTable();
        DataTable dtGateways = new DataTable();
        DataTable dtPonti = new DataTable();
        DataTable dtPannelli = new DataTable();
        DataTable dtClienti = new DataTable();

        public FrmAlbero()
        {
            InitializeComponent();
        }

        private void FrmAlbero_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            gbx.Visible = false;
        }

        private void Etichette()
        {
            gbx.Visible = true;
            string query = "";
            query = "SELECT [1_fonti].FONTE FROM [1_fonti] ORDER BY [1_fonti].FONTE";
            sql.ExecQuery(query);
            if (sql.HasException())
            {

                return;
            }
            lblFornitori.Text = "Fornitori: " + sql.DBDT.Rows.Count.ToString();




            query = "SELECT [2_gateways].GATEWAY FROM [2_gateways] ORDER BY [2_gateways].GATEWAY";
            sql.ExecQuery(query);
            if (sql.HasException())
            {

                return;
            }
            lblGateway.Text = "Gateways: " + sql.DBDT.Rows.Count.ToString();

            // gateway senza fonte
            query = "SELECT [2_gateways].GATEWAY FROM [2_gateways] WHERE [2_gateways].idFonte = 0 ORDER BY [2_gateways].GATEWAY";
            sql.ExecQuery(query);
            if (sql.HasException())
            {

                return;
            }
            lblGatewaySenza.Text = "Gateways senza fonte: " + sql.DBDT.Rows.Count.ToString();

            // gateway senza ponte


            query = "SELECT [3_ponti].Ponte FROM [3_ponti] ORDER BY [3_ponti].Ponte";
            sql.ExecQuery(query);
            if (sql.HasException())
            {

                return;
            }
            lblPonti.Text = "Ponti: " + sql.DBDT.Rows.Count.ToString();

            // ponti senza gateway
            query = "SELECT [3_ponti].Ponte FROM [3_ponti] WHERE [3_ponti].idGateway = 0 ORDER BY [3_ponti].Ponte";
            sql.ExecQuery(query);
            if (sql.HasException())
            {

                return;
            }
            lblPontiSenza.Text = "Ponti senza gateway: " + sql.DBDT.Rows.Count.ToString();


            query = "SELECT [4_pannelli].PANNELLO FROM [4_pannelli] ORDER BY [4_pannelli].PANNELLO";
            sql.ExecQuery(query);
            if (sql.HasException())
            {

                return;
            }
            lblPannelli.Text = "Pannelli: " + sql.DBDT.Rows.Count.ToString();

            // pannelli senza ponte
            query = "SELECT [4_pannelli].PANNELLO FROM [4_pannelli] WHERE [4_pannelli].idPonti = 0 ORDER BY [4_pannelli].PANNELLO";
            sql.ExecQuery(query);
            if (sql.HasException())
            {

                return;
            }
            lblPannelliSenza.Text = "Pannelli senza ponte: " + sql.DBDT.Rows.Count.ToString();


            if (chkAncheClienti.Checked)
            {
                query = "SELECT [5_Clientirete].Username FROM [5_Clientirete] ORDER BY [5_Clientirete].Username";
                sql.ExecQuery(query);
                if (sql.HasException())
                {

                    return;
                }
                lblClienti.Text = "Clienti: " + sql.DBDT.Rows.Count.ToString();
            }
            else
            {
                lblClienti.Text = "Clienti: 0";
            }

            // clienti senza pannello
            query = "SELECT [5_Clientirete].Username FROM [5_Clientirete] WHERE [5_Clientirete].Location = '' ORDER BY [5_Clientirete].Username";
            sql.ExecQuery(query);
            if (sql.HasException())
            {

                return;
            }
            lblClientiSenza.Text = "Clienti senza pannello: " + sql.DBDT.Rows.Count.ToString();

        }

        private void RiempiAlbero()
        {
            treeView1.Nodes.Clear();


            string query = "";
            string numero = "";

            query = "SELECT [1_fonti].FONTE FROM [1_fonti] ORDER BY [1_fonti].FONTE";


            sql.ExecQuery(query);
            if (sql.HasException())
            {
                MessageBox.Show(" Errore nell'estrazione dei record.");
                return;
            }
            dtFonti = sql.DBDT;

            foreach (DataRow dr in dtFonti.Rows)
            {
                // the text font not enought to show the full text  
                // so we use the node font to show the full text

                numero = " (" + RecGateway(dr).ToString() + ")";
                TreeNode tnFonte = new TreeNode(dr["FONTE"].ToString() + numero.ToString());
                tnFonte.Tag = "FONTE     ";
                tnFonte.ImageIndex = 0;
                tnFonte.SelectedImageIndex = 0;
                tnFonte.ForeColor = Color.Blue;
                tnFonte.NodeFont = new Font("Arial", 10, FontStyle.Bold);
                tnFonte.Text = tnFonte.Text.PadRight(50, ' ');
                tnFonte.ToolTipText = "FONTE     ";
                treeView1.Nodes.Add(tnFonte);
                // add child node count to the text


                query = "SELECT [2_gateways].GATEWAY FROM [2_gateways] INNER JOIN [1_fonti] ON [2_gateways].idFonte = [1_fonti].iDFonte WHERE [1_fonti].FONTE = '" + dr["FONTE"].ToString() + "' ORDER BY [2_gateways].GATEWAY";
                sql.ExecQuery(query);
                if (sql.HasException())
                {
                    MessageBox.Show(" Errore nell'estrazione dei record.");
                    return;
                }
                dtGateways = sql.DBDT;

                // per ogni fonte riempie il nodo gateway

                foreach (DataRow dr1 in dtGateways.Rows)
                {
                    numero = " (" + RecPonti(dr1).ToString() + ")";
                    TreeNode tnGateway = new TreeNode(dr1["GATEWAY"].ToString() + numero.ToString());
                    tnGateway.Tag = "GATEWAY";
                    tnGateway.ImageIndex = 1;
                    tnGateway.SelectedImageIndex = 1;
                    tnGateway.ForeColor = Color.IndianRed;
                    tnGateway.NodeFont = new Font("Arial", 10, FontStyle.Bold);
                    tnGateway.Text = tnGateway.Text.PadRight(50, ' ');
                    tnGateway.ToolTipText = "GATEWAY     ";
                    tnFonte.Nodes.Add(tnGateway);
                    // per ogni gateway riempie il nodo ponte

                    query = "SELECT [3_ponti].Ponte,[3_ponti].iDPonti  FROM [3_ponti] INNER JOIN [2_gateways] ON [3_ponti].idGateway = [2_gateways].iDGateway WHERE [2_gateways].GATEWAY = '" + dr1["GATEWAY"].ToString() + "' ORDER BY [3_ponti].Ponte";
                    sql.ExecQuery(query);
                    if (sql.HasException())
                    {
                        MessageBox.Show(" Errore nell'estrazione dei record.");
                        return;
                    }
                    dtPonti = sql.DBDT;
                    foreach (DataRow dr2 in dtPonti.Rows)
                    {
                        numero = " (" + RecPannelli(dr2).ToString() + ")";
                        TreeNode tnPonte = new TreeNode(dr2["Ponte"].ToString() + numero.ToString());
                        tnPonte.Tag = "PONTE";
                        tnPonte.ImageIndex = 2;
                        tnPonte.SelectedImageIndex = 2;
                        tnPonte.ForeColor = Color.DarkGreen;
                        tnPonte.NodeFont = new Font("Arial", 10, FontStyle.Bold);
                        tnPonte.Text = tnPonte.Text.PadRight(50, ' ');
                        tnPonte.ToolTipText = "PONTE     ";
                        tnGateway.Nodes.Add(tnPonte);

                        query = "SELECT [4_pannelli].PANNELLO FROM [4_pannelli] INNER JOIN [3_ponti] ON [4_pannelli].idPonti = [3_ponti].iDPonti WHERE [3_ponti].IdPonti = '" + dr2["iDPonti"].ToString() + "' ORDER BY [4_pannelli].PANNELLO";
                        sql.ExecQuery(query);
                        if (sql.HasException())
                        {
                            MessageBox.Show(" Errore nell'estrazione dei record.");
                            return;
                        }
                        dtPannelli = sql.DBDT;
                        foreach (DataRow dr3 in dtPannelli.Rows)
                        {
                            numero = " (" + RecClienti(dr3).ToString() + ")";
                            TreeNode tnPannello = new TreeNode(dr3["PANNELLO"].ToString() + numero.ToString());
                            tnPannello.Tag = "PANNELLO";
                            tnPannello.ImageIndex = 3;
                            tnPannello.SelectedImageIndex = 3;
                            tnPannello.ForeColor = Color.DarkOrange;
                            tnPannello.NodeFont = new Font("Arial", 10, FontStyle.Bold);
                            tnPannello.Text = tnPannello.Text.PadRight(50, ' ');
                            tnPannello.ToolTipText = "PANNELLO     ";
                            tnPonte.Nodes.Add(tnPannello);
                            // per ogni pannello riempie il nodo cliente

                            // per ogni pannello riempie il nodo cliente
                            if (chkAncheClienti.Checked)
                            {
                                query = "SELECT [5_Clientirete].Username, [5_Clientirete].ActualProfile,[5_Clientirete].CodCli,[5_Clientirete].Denom FROM [5_Clientirete] INNER JOIN [4_pannelli] ON [5_Clientirete].iDpannelli = [4_pannelli].iDPannelli WHERE [4_pannelli].PANNELLO = '" + dr3["PANNELLO"].ToString() + "' ORDER BY [5_Clientirete].Username";
                                sql.ExecQuery(query);
                                if (sql.HasException())
                                {
                                    MessageBox.Show(" Errore nell'estrazione dei record.");
                                    return;
                                }
                                dtClienti = sql.DBDT;
                                foreach (DataRow dr4 in dtClienti.Rows)
                                {
                                    TreeNode tnCliente = new TreeNode(dr4["Username"] + " - " + dr4["ActualProfile"] + " - " + dr4["CodCli"] + " - " + dr4["Denom"].ToString());
                                    tnCliente.Tag = "CLIENTE";
                                    tnCliente.ImageIndex = 4;
                                    tnCliente.SelectedImageIndex = 4;
                                    tnCliente.ForeColor = Color.DarkMagenta;
                                    tnCliente.NodeFont = new Font("Arial", 10, FontStyle.Bold);
                                    tnCliente.Text = tnCliente.Text.PadRight(200, ' ');
                                    tnCliente.ToolTipText = "CLIENTE     ";
                                    tnPannello.Nodes.Add(tnCliente);
                                }


                            }
                        }

                    }

                }

            }
        }

        private int RecPonti(DataRow dr1)
        {
            string query = query = "SELECT [3_ponti].Ponte,[3_ponti].iDPonti  FROM [3_ponti] INNER JOIN [2_gateways] ON [3_ponti].idGateway = [2_gateways].iDGateway WHERE [2_gateways].GATEWAY = '" + dr1["GATEWAY"].ToString() + "' ORDER BY [3_ponti].Ponte";

            sql.ExecQuery(query);
            if (sql.HasException())
            {
                MessageBox.Show(" Errore nell'estrazione dei record.");
                return 0;
            }
            return sql.DBDT.Rows.Count;
        }

        private int RecPannelli(DataRow dr2)
        {
            string query = query = "SELECT [4_pannelli].PANNELLO FROM [4_pannelli] INNER JOIN [3_ponti] ON [4_pannelli].idPonti = [3_ponti].iDPonti WHERE [3_ponti].IdPonti = '" + dr2["iDPonti"].ToString() + "' ORDER BY [4_pannelli].PANNELLO";

            sql.ExecQuery(query);
            if (sql.HasException())
            {
                MessageBox.Show(" Errore nell'estrazione dei record.");
                return 0;
            }
            return sql.DBDT.Rows.Count;
        }

        private int RecClienti(DataRow dr3)
        {
            string query = "SELECT [5_Clientirete].Username, [5_Clientirete].ActualProfile,[5_Clientirete].CodCli,[5_Clientirete].Denom FROM [5_Clientirete] INNER JOIN [4_pannelli] ON [5_Clientirete].iDpannelli = [4_pannelli].iDPannelli WHERE [4_pannelli].PANNELLO = '" + dr3["PANNELLO"].ToString() + "' ORDER BY [5_Clientirete].Username";

            sql.ExecQuery(query);
            if (sql.HasException())
            {
                MessageBox.Show(" Errore nell'estrazione dei record.");
                return 0;
            }
            return sql.DBDT.Rows.Count;
        }

        private int RecGateway(DataRow dr)
        {
            string query = "SELECT [2_gateways].GATEWAY FROM [2_gateways] INNER JOIN [1_fonti] ON [2_gateways].idFonte = [1_fonti].iDFonte WHERE [1_fonti].FONTE = '" + dr["FONTE"].ToString() + "' ORDER BY [2_gateways].GATEWAY";
            sql.ExecQuery(query);
            if (sql.HasException())
            {
                MessageBox.Show(" Errore nell'estrazione dei record.");
                return 0;
            }
            return sql.DBDT.Rows.Count;
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            gbx.Visible = false;
            Etichette();
            RiempiAlbero();
        }


        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var livello = e.Node.Level.ToString();

            switch (livello)
            {
                case "0":
                    FrmFornitoriRete frm = new FrmFornitoriRete();
                    // la form deve apparire dentro la form mdiprima
                    // e davanti alla from che ha creato questa form
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                    break;
                case "1":
                    // gateway
                    FrmGateways frm1 = new FrmGateways();
                    frm1.MdiParent = this.MdiParent;
                    frm1.Show();
                    break;
                case "2":
                    // ponte
                    FrmPonti frm2 = new FrmPonti();
                    frm2.MdiParent = this.MdiParent;
                    frm2.Show();
                    break;
                case "3":

                    // pannello
                    FrmPannelli frm3 = new FrmPannelli();
                    frm3.MdiParent = this.MdiParent;
                    frm3.Show();
                    break;
                case "4":
                    // cliente
                    FrmClientiRete frm4 = new FrmClientiRete();
                    frm4.MdiParent = this.MdiParent;
                    frm4.Show();
                    break;
            }
        }
    }
}
