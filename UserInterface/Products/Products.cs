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

namespace LLWS.UserInterface.Products
{
    public partial class Products : Form
    {
        public string response;
        public Products(string response)
        {
            InitializeComponent();
            this.response = response;
            setUpDataGridView();
            this.Text = "Cotations du jour";

        }

        #region "Fonctions d'initialisation des composants"
        private void setUpDataGridView()
        {

           

            //Initialisation du DataGridView
            dtgCotations.Size = new Size(this.Size.Width - 10, this.Size.Height - 30);

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
            var model = JsonConvert.DeserializeObject<List<Cotation>>(this.response);

            foreach (Cotation cotation in model)
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

    }
}
