using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LLWS.Core;
using Flurl.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using LLWS.Models;
using System.Windows.Forms.DataVisualization.Charting;

namespace LLWS.UserInterface.Products
{
    public partial class Products : Form
    {

        public Products()
        {
            InitializeComponent();
            setUpDataGridView();
            this.Text = "Cotations du jour";

        }

        #region "Fonctions d'initialisation des composants"
        private void setUpDataGridView()
        {



            //Initialisation du DataGridView

            dtgCotations.ColumnCount = 10;
            dtgCotations.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;


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

            DataGridViewButtonColumn colonneButton = new DataGridViewButtonColumn();
            colonneButton.HeaderText = "Historique";
            colonneButton.Text = "Historique";
            colonneButton.Name = "btnHistorique";
            colonneButton.UseColumnTextForButtonValue = true;
            dtgCotations.Columns.Add(colonneButton);

            dtgHistorique.ColumnCount = 2;

            dtgHistorique.Columns[0].Name = "Date";
            dtgHistorique.Columns[1].Name = "Valeur";

            //Appel de la fonction de remplissage du Dtg
            remplirDataGridView();

        }

        /*
         * On récupére les données de la réponse JSON reçue.
         * On la désérialise : on récupère chaque propriété du JSON qu'on instancie en nouvel Object Cotation 
         * Chaque cotation sera placée dans une Liste de Cotation, et on itèrera à travers celle-ci pour remplir les données du datagridview
         */
        private void remplirDataGridView()
        {

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
                    cotation.stock_lowest_value.ToString()
               );
            }


        }
        #endregion

        private async void dtgCotations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {


                string isinCode = dtgCotations.Rows[e.RowIndex].Cells[4].Value.ToString();
                string route = APIManager.API_ROUTES_GET_HISTORIQUE + isinCode;

                JToken reponse = await APIManager.recevoirData(route);
                if (reponse.SelectToken("status").ToString() == "SUCCESS")
                {
                    dtgHistorique.Rows.Clear();
                    var historiqueCotation = JsonConvert.DeserializeObject<List<Cotation>>(reponse.SelectToken("result").ToString());
                    foreach (Cotation cotation in historiqueCotation)
                    {
                        dtgHistorique.Rows.Add(
                            cotation.stock_date.ToString(),
                            cotation.stock_closing_value.ToString()
                            );
                    }

                    var maxValeur = dtgHistorique.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToDouble(r.Cells["Valeur"].Value));
                    var minValeur = dtgHistorique.Rows.Cast<DataGridViewRow>().Min(t => Convert.ToDouble(t.Cells["Valeur"].Value));

                    var zoneHistorique = chrtHistorique.ChartAreas[0];
                    zoneHistorique.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
                    zoneHistorique.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                    //Date

                    DateTime minDate = Convert.ToDateTime(dtgHistorique.Rows[0].Cells["Date"].Value.ToString());
                    DateTime maxDate = Convert.ToDateTime(dtgHistorique.Rows[dtgHistorique.Rows.Count-1].Cells["Date"].Value.ToString());
                    double minimumDate = minDate.ToOADate();
                    double maximumDate = maxDate.ToOADate();

                    zoneHistorique.AxisX.Minimum = minimumDate;
                    zoneHistorique.AxisX.Maximum = maximumDate;

                    //Prix
                    zoneHistorique.AxisY.Minimum = minValeur;
                    zoneHistorique.AxisY.Maximum = maxValeur;

                    //loop rows to draw multi line chart c#
                    foreach (Cotation cotation in historiqueCotation)
                    {
                        chrtHistorique.Series["Series1"].Points.AddXY(cotation.stock_date, cotation.stock_closing_value);
                    }


                }

            }
        }    
    }
}
