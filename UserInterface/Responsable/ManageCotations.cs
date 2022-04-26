using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LLWS.Core;
using Newtonsoft.Json.Linq;

namespace LLWS.UserInterface.Responsable
{
    public partial class ManageCotations : Form
    {
        public ManageCotations()
        {
            InitializeComponent();
            this.richTextBox1.Text = "";
            this.btnMajCotations.Enabled = false;
            this.btnMajCotations.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    filePath = openFileDialog.FileName;

                    
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            this.richTextBox1.Text = fileContent;
            MessageBox.Show("Fichier uploadé : " + filePath);
        }

        private async void btnSendText_Click(object sender, EventArgs e)
        {
            string cotationsText = this.richTextBox1.Text;
            string route = APIManager.API_ROUTES_POST_COTATIONS;
            var data = new
            {
                cotations = cotationsText
            };

            if (cotationsText == "")
            {
                MessageBox.Show("Attention, le contenu à envoyer est invalide");
            }
            else
            {
                JToken response = await APIManager.posterData(route, data);
                MessageBox.Show(response.SelectToken("status").ToString() +" : "+ response.SelectToken("message").ToString());
                if(response.SelectToken("status").ToString() == "SUCCESS")
                {
                    this.btnMajCotations.Enabled = true;
                    this.btnMajCotations.BackColor = Color.LimeGreen;
                }
            }
        }

        private async void btnMajCotations_Click(object sender, EventArgs e)
        {
            string route = APIManager.API_ROUTES_UPDATE_COTATIONS;
            JToken response = await APIManager.recevoirData(route);
            if(response.SelectToken("status").ToString() == "SUCCESS")
            {
                this.btnMajCotations.Enabled = false;
                this.btnMajCotations.BackColor = Color.Gray;
            }
            MessageBox.Show(response.SelectToken("message").ToString());
        }
    }
}
