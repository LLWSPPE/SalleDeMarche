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
        public string reponseCotations;
        public string selectIsinVendre;
        public string selectIsinAchat;
        public int actuelQuantite;

        public Operations(string reponsePortefeuille, string reponseCotations)
        {
            InitializeComponent();
            this.reponsePortefeuille = reponsePortefeuille;
            this.reponseCotations = reponseCotations;
            chargerInterface();
        }


        private void chargerInterface()
        {

            this.lblMyBudget.Text = "Mon budget : " + User.budget.ToString();
            this.pnlVendre.Visible = false;
            this.pnlAchat.Visible = false;

            dtgMonPortefeuille.ColumnCount = 5;

            dtgMonPortefeuille.Columns[0].Name = "id";
            dtgMonPortefeuille.Columns[1].Name = "Code ISIN";
            dtgMonPortefeuille.Columns[2].Name = "Société";
            dtgMonPortefeuille.Columns[3].Name = "Titres possédés";
            dtgMonPortefeuille.Columns[4].Name = "Valeur actuelle";

            dtgMonPortefeuille.Columns["Valeur actuelle"].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            dtgMonPortefeuille.Columns["Valeur actuelle"].DefaultCellStyle.ForeColor = Color.White;

            dtgCotations.ColumnCount = 10;

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

            remplirDataGridView();

        }

        private void remplirDataGridView()
        {
            var listActionsPortefeuille = JsonConvert.DeserializeObject<List<Portefeuille>>(this.reponsePortefeuille);

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

            var listActionsJour = JsonConvert.DeserializeObject<List<Cotation>>(this.reponseCotations);

            foreach (Cotation cotation in listActionsJour)
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
                    cotation.stock_lowest_value.ToString()
               );
            }
        }

        private void dtgMonPortefeuille_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            this.selectIsinVendre = dtgMonPortefeuille.Rows[e.RowIndex].Cells[1].Value.ToString();

            this.lblValeurActuelle.Text = "Valeur du titre : "+dtgMonPortefeuille.Rows[e.RowIndex].Cells[4].Value.ToString()+ " €";
            this.pnlVendre.Visible = true;
            this.lblSociete.Text = "Société : " + dtgMonPortefeuille.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.lblNombrePossede.Text = "Nombre de titre possédés : " + dtgMonPortefeuille.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.nupQuantite.Maximum = Int32.Parse(dtgMonPortefeuille.Rows[e.RowIndex].Cells[3].Value.ToString());
            this.nupQuantite.Minimum = 0;
            this.nupQuantite.DecimalPlaces = 0;
        }

        private void dtgCotations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectIsinAchat = dtgCotations.Rows[e.RowIndex].Cells[4].Value.ToString();

            this.pnlAchat.Visible = true;
            this.lblSociete2.Text = "Société : " + dtgCotations.Rows[e.RowIndex].Cells[2].Value.ToString() + " ["+ dtgCotations.Rows[e.RowIndex].Cells[3].Value.ToString()+"]";
            this.lblValeur.Text = "Valeur d'un titre : " + dtgCotations.Rows[e.RowIndex].Cells[7].Value.ToString() + "€";
            this.nupQuantiteAchat.Minimum = 0;
            this.nupQuantiteAchat.DecimalPlaces = 0;
        }

        private async void btnVendreAction_Click(object sender, EventArgs e)
        {
            string isinCode = this.selectIsinVendre;
            int quantite = (int)this.nupQuantite.Value;


            string response = await vendreCotation(isinCode, quantite);
            MessageBox.Show(response);
        }

        private async void btnAchat_Click(object sender, EventArgs e)
        {
            string isinCode = this.selectIsinAchat;
            int quantite = (int)this.nupQuantiteAchat.Value;


            string response = await achatCotation(isinCode, quantite);
            MessageBox.Show(response);
        }


        private static async Task<string> vendreCotation(string isinCode, int quantite)
        {
            string response = "";

            var responseString = await APIManager.API_ROUTES_POST_SELL
            .PostUrlEncodedAsync(new { 
                userToken = User.userToken,
                isinCode = isinCode,
                quantity = quantite
            })
            .ReceiveString();

            JToken token = JToken.Parse(responseString);

            response = token.SelectToken("message").ToString();

            return response;

        }

        private static async Task<string> achatCotation(string isinCode, int quantite)
        {
            string response = "";

            var responseString = await APIManager.API_ROUTES_POST_BUY
            .PostUrlEncodedAsync(new
            {
                userToken = User.userToken,
                isinCode = isinCode,
                quantity = quantite
            })
            .ReceiveString();

            JToken token = JToken.Parse(responseString);

            response = token.SelectToken("message").ToString();

            return response;

        }

     
    }
}
