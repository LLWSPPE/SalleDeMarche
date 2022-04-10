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

namespace LLWS.UserInterface.Responsable
{
    public partial class ManageUsers : Form
    {

        public string response;
        public ManageUsers(string response)
        {
            InitializeComponent();
            this.response = response;
            setUpDataGridView();
        }

        private void setUpDataGridView()
        {

            dtgUsers.ColumnCount = 9;

            dtgUsers.Columns[0].Name = "id";
            dtgUsers.Columns[1].Name = "Email";
            dtgUsers.Columns[2].Name = "Prénom";
            dtgUsers.Columns[3].Name = "Nom";
            dtgUsers.Columns[4].Name = "Inscription";
            dtgUsers.Columns[5].Name = "Responsable ?";
            dtgUsers.Columns[6].Name = "Administrateur ?";
            dtgUsers.Columns[7].Name = "Suspendu ?";
            dtgUsers.Columns[8].Name = "Budget";

            DataGridViewButtonColumn colonneButton = new DataGridViewButtonColumn();
            colonneButton.HeaderText = "Actions";
            colonneButton.Text = "Gérer";
            colonneButton.Name = "btnManageUser";
            colonneButton.UseColumnTextForButtonValue = true;
            dtgUsers.Columns.Add(colonneButton);

            dtgUsers.RowHeadersVisible = false;

            remplirDataGridView();


        }

        private void remplirDataGridView()
        {
            var datas = JsonConvert.DeserializeObject<List<Trader>>(this.response);

            foreach (Trader trader in datas)
            {

                dtgUsers.Rows.Add(
                    trader.id.ToString(),
                    trader.email.ToString(),
                    trader.first_name.ToString(),
                    trader.last_name.ToString(),
                    trader.register_date.ToString(),
                    trader.responsable.ToString(),
                    trader.admin.ToString(),
                    trader.suspendu.ToString(),
                    trader.budget.ToString()
               );
            }
        }

        private async void dtgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                string response = await GetUser(Int32.Parse(dtgUsers.Rows[e.RowIndex].Cells[0].Value.ToString()));

                Trader traderToManage = JsonConvert.DeserializeObject<Trader>(response);

                ManageUserWindows gererUser = new ManageUserWindows(traderToManage);
                gererUser.Show();

             }

        }

        private static async Task<string> GetUser(int userId)
        {

            string response = "";
            string apiRoute = APIManager.API_ROUTES_GET_SPECIFIC_USER + userId.ToString();

            var responseString = await apiRoute
            .GetStringAsync();

            JToken token = JToken.Parse(responseString);

            if (token.SelectToken("status").ToString() == "SUCCESS")
            {

                response = token.SelectToken("result[0]").ToString();

            }
            else
            {
                MessageBox.Show("Une erreur est survenue. Veuillez réessayer.");
            }

            return response;

        }
    }
}
