using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LLWS.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LLWS.Core;
using Flurl.Http;

namespace LLWS.UserInterface.Operations
{

    public partial class Operations : Form
    {
        public string reponsePortefeuille;
        public string selectIsinVendre;
        public string selectIsinAchat;
        public int actuelQuantite;

        public Operations(string reponsePortefeuille)
        {
            InitializeComponent();
            this.reponsePortefeuille = reponsePortefeuille;
            chargerInterface();
        }


        private void chargerInterface()
        {

            this.lblMyBudget.Text = "Mon budget : " + User.budget.ToString() + "€";
            this.pnlVendre.Visible = false;
            this.pnlAchat.Visible = false;

            dtgMonPortefeuille.ColumnCount = 5;

            dtgMonPortefeuille.Columns[0].Name = "id";
            dtgMonPortefeuille.Columns[1].Name = "Code ISIN";
            dtgMonPortefeuille.Columns[2].Name = "Société";
            dtgMonPortefeuille.Columns[3].Name = "Titres possédés";
            dtgMonPortefeuille.Columns[4].Name = "Valeur actuelle";

            dtgMonPortefeuille.Columns["id"].Visible = false;

            dtgMonPortefeuille.Columns["Valeur actuelle"].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dtgMonPortefeuille.Columns["Valeur actuelle"].DefaultCellStyle.ForeColor = Color.White;

            dtgCotations.ColumnCount = 11;

            dtgCotations.Columns[0].Name = "id";
            dtgCotations.Columns[1].Name = "Volume";
            dtgCotations.Columns[2].Name = "Société";
            dtgCotations.Columns[3].Name = "Ticker";
            dtgCotations.Columns[4].Name = "ISIN";
            dtgCotations.Columns[5].Name = "Date";
            dtgCotations.Columns[6].Name = "Prix ouverture";
            dtgCotations.Columns[7].Name = "Prix fermeture";
            dtgCotations.Columns[8].Name = "Prix haut";
            dtgCotations.Columns[9].Name = "Prix bas";
            dtgCotations.Columns[10].Name = "Valeur actuelle";

            dtgCotations.Columns["Valeur actuelle"].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dtgCotations.Columns["Valeur actuelle"].DefaultCellStyle.ForeColor = Color.White;

            remplirDtgPortefeuille(this.reponsePortefeuille);
            remplirDtgCotations();

        }

        private void remplirDtgPortefeuille(string donneesPortefeuille)
        {
            var listActionsPortefeuille = JsonConvert.DeserializeObject<List<Portefeuille>>(donneesPortefeuille);

            if (listActionsPortefeuille != null)
            {
                foreach (Portefeuille actionPortefeuille in listActionsPortefeuille)
                {

                    dtgMonPortefeuille.Rows.Add(
                        actionPortefeuille.id.ToString(),
                        actionPortefeuille.isin_code.ToString(),
                        actionPortefeuille.full_name.ToString(),
                        actionPortefeuille.quantite.ToString(),
                        actionPortefeuille.stock_closing_value.ToString()
                   );
                }
            }
        }

        private void remplirDtgCotations() { 

                foreach (Cotation cotation in CotationsDuJour.ListeCotation)
                {

                    dtgCotations.Rows.Add(
                        cotation.id.ToString(),
                        cotation.stock_volume.ToString(),
                        cotation.full_name.ToString(),
                        cotation.ticker_code.ToString(),
                        cotation.isin_code.ToString(),
                        cotation.stock_date.ToString(),
                        cotation.stock_opening_value.ToString(),
                        cotation.stock_closing_value.ToString(),
                        cotation.stock_highest_value.ToString(),
                        cotation.stock_lowest_value.ToString(),
                        cotation.stock_closing_value.ToString()
                   );
                }
            
        }

        private void rechargerPortefeuille(string nouvelleDonnees)
        {
            this.lblMyBudget.Text = "Mon budget : " + User.budget.ToString() + "€";
            dtgMonPortefeuille.Rows.Clear();
            remplirDtgPortefeuille(nouvelleDonnees);
        }

        private void dtgMonPortefeuille_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dtgMonPortefeuille.CurrentCell == null ||dtgMonPortefeuille.CurrentCell.Value == null || e.RowIndex == -1) return;
            else
            {
                this.selectIsinVendre = dtgMonPortefeuille.Rows[e.RowIndex].Cells[1].Value.ToString();

                this.lblValeurActuelle.Text = "Valeur du titre : " + dtgMonPortefeuille.Rows[e.RowIndex].Cells[4].Value.ToString() + " €";
                this.pnlVendre.Visible = true;
                this.lblSociete.Text = "Société : " + dtgMonPortefeuille.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.lblNombrePossede.Text = "Nombre de titre possédés : " + dtgMonPortefeuille.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.nupQuantite.Maximum = Int32.Parse(dtgMonPortefeuille.Rows[e.RowIndex].Cells[3].Value.ToString());
                this.nupQuantite.Minimum = 0;
                this.nupQuantite.DecimalPlaces = 0;
            }
        }

        private void dtgCotations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCotations.CurrentCell == null || dtgCotations.CurrentCell.Value == null || e.RowIndex == -1) return;
            else
            {
                this.selectIsinAchat = dtgCotations.Rows[e.RowIndex].Cells[4].Value.ToString();

                this.pnlAchat.Visible = true;
                this.lblSociete2.Text = "Société : " + dtgCotations.Rows[e.RowIndex].Cells[2].Value.ToString() + " [" + dtgCotations.Rows[e.RowIndex].Cells[3].Value.ToString() + "]";
                this.lblValeur.Text = "Valeur d'un titre : " + dtgCotations.Rows[e.RowIndex].Cells[7].Value.ToString() + "€";
                this.nupQuantiteAchat.Minimum = 0;
                this.nupQuantiteAchat.DecimalPlaces = 0;
            }
        }

        private async void btnVendreAction_Click(object sender, EventArgs e)
        {
            string isinCode = this.selectIsinVendre;
            int quantite = (int)this.nupQuantite.Value;

            string route = APIManager.API_ROUTES_POST_SELL;
            var donnees = new
            {
                userToken = User.userToken,
                isinCode = isinCode,
                quantity = quantite
            };

            JToken reponse = await APIManager.posterData(route, donnees);
            if(reponse.SelectToken("status").ToString() == "SUCCESS")
            {
                User.budget = (double)reponse.SelectToken("budgetAChanger");

                JToken recharge = await APIManager.recevoirData(APIManager.API_ROUTES_GET_USER_PORTEFEUILLE+User.id.ToString());

                if (recharge.SelectToken("status").ToString() == "SUCCESS")
                {
                    string nouvelleDonnees = recharge.SelectToken("result").ToString();
                    rechargerPortefeuille(nouvelleDonnees);
                }
                else
                {
                    MessageBox.Show(recharge.SelectToken("message").ToString());
                }

            } 
            
            MessageBox.Show(reponse.SelectToken("message").ToString());
           
           
        }

        private async void btnAchat_Click(object sender, EventArgs e)
        {
            string isinCode = this.selectIsinAchat;
            int quantite = (int)this.nupQuantiteAchat.Value;

            string route = APIManager.API_ROUTES_POST_BUY;
            var donnees = new
            {
                userToken = User.userToken,
                isinCode = isinCode,
                quantity = quantite
            };

            JToken reponse = await APIManager.posterData(route, donnees);
            if (reponse.SelectToken("status").ToString() == "SUCCESS")
            {
                User.budget = (double)reponse.SelectToken("budgetFinal");
                JToken recharge = await APIManager.recevoirData(APIManager.API_ROUTES_GET_USER_PORTEFEUILLE + User.id.ToString());

                if (recharge.SelectToken("status").ToString() == "SUCCESS")
                {
                    string nouvelleDonnees = recharge.SelectToken("result").ToString();
                    rechargerPortefeuille(nouvelleDonnees);
                }
                else
                {
                    MessageBox.Show(recharge.SelectToken("message").ToString());
                }
            }
            MessageBox.Show(reponse.SelectToken("message").ToString());
        }


    }
}
