using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using LLWS.Models;

namespace LLWS.UserInterface.Mouvements
{
    public partial class Mouvements : Form
    {

        public string reponseAchat;
        public string reponseVente;

        public Mouvements(string reponseAchat, string reponseVente)
        {
            InitializeComponent();
            this.reponseAchat = reponseAchat;
            this.reponseVente = reponseVente;
            setupDataGridView();
        }

        public void setupDataGridView()
        {
            dtgAchats.ColumnCount = 4;

            dtgAchats.Columns[0].Name = "ISIN Code";
            dtgAchats.Columns[1].Name = "Quantité";
            dtgAchats.Columns[2].Name = "Date";
            dtgAchats.Columns[3].Name = "Montant (euros)";

            dtgVentes.ColumnCount = 4;

            dtgVentes.Columns[0].Name = "ISIN Code";
            dtgVentes.Columns[1].Name = "Quantité";
            dtgVentes.Columns[2].Name = "Date";
            dtgVentes.Columns[3].Name = "Montant (euros)";

            remplirDataGridView();

        }

        public void remplirDataGridView()
        {

            var listeAchats = JsonConvert.DeserializeObject<List<Mouvement>>(this.reponseAchat);
            var listeVentes = JsonConvert.DeserializeObject<List<Mouvement>>(this.reponseVente);

            if(listeAchats != null)
            {
                listeAchats.Reverse();
                foreach(Mouvement mouvementAchat in listeAchats)
                {
                    dtgAchats.Rows.Add(
                        mouvementAchat.isin_code.ToString(),
                        mouvementAchat.quantite.ToString(),
                        mouvementAchat.date_mouvement.ToString(),
                        mouvementAchat.montant.ToString()
                        );
                }
            }

            if (listeVentes != null)
            {
                listeVentes.Reverse();
                foreach (Mouvement mouvementVente in listeVentes)
                {
                    dtgVentes.Rows.Add(
                        mouvementVente.isin_code.ToString(),
                        mouvementVente.quantite.ToString(),
                        mouvementVente.date_mouvement.ToString(),
                        mouvementVente.montant.ToString()
                        );
                }
            }

        }
    }
}
