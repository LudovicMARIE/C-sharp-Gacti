using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVA;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using ComboBox = System.Windows.Forms.ComboBox;

namespace VVA
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            listBoxPanier.Items.AddRange(ORMVVA.GetTousLesPaniers(txtSearch.Text).ToArray());


            // First, get the list of all paniers using the GetTousLesPaniers method
            //List<Panier> paniers = ORMVVA.GetTousLesPaniers(txtSearch.Text);

            // Clear the items in the listBoxPanier control
            //listBoxPanier.Items.Clear();

            // Loop through the paniers and add a ListItem user control for each panier
            //foreach (Panier p in paniers)
            //{
            //    ListItem listItem = new ListItem();
            //    listItem.Update(p);
            //    listBoxPanier.Tag = listItem;
            //    listBoxPanier.Items.Add(listItem);
            //    //ListViewItem listViewItem = new ListViewItem();
            //    //listViewItem.Tag = listItem;

            //    //// Add the ListViewItem to the ListView
            //    //listView1.Items.Add(listViewItem);
            //}



            List<object> etats = ORMVVA.GetEtats();
            comboBoxEtatCommande.Items.Add(new { Id = 0, Nom = "Toutes les commandes" });
            foreach (object etat in etats)
            {
                comboBoxEtatCommande.Items.Add(etat);
            }
            comboBoxEtatCommande.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEtatCommande.DisplayMember = "Nom";
            comboBoxEtatCommande.SelectedIndex = 0;

            Dictionary<string, string> userProfile = ORMVVA.VoirProfil(Session.Instance.Username);
            txtNomProfil.Text = userProfile["NomUtilisateur"];
            txtPrenomProfil.Text = userProfile["PrenomUtilisateur"];
            txtNaissanceProfil.Text = userProfile["DateNaissanceUtilisateur"];
            txtMailProfil.Text = userProfile["MailUtilisateur"];
            txtTelProfil.Text = userProfile["TelUtilisateur"];
            lblBonjour.Text = "Bonjour " + userProfile["PrenomUtilisateur"] + " " + userProfile["NomUtilisateur"];
            this.Text = "VVA - Client - " + userProfile["PrenomUtilisateur"] + " " + userProfile["NomUtilisateur"];

            this.AcceptButton = btnSearch;
            btnCommander.Enabled = false;
            btnAnnulerCommande.Enabled = false;
            btnPayerCommande.Enabled = false;
        }


        #region Méthodes


        public static void AddEtatsToComboBox(List<object> etats, ComboBox comboBoxEtatCommande)
        {
            foreach (object etat in etats)
            {
                comboBoxEtatCommande.Items.Add(etat);
            }

            comboBoxEtatCommande.DisplayMember = "Nom";
        }

        

        private void tabControlClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAnnulerCommande.Enabled = false;
            listBoxPanierCommande.Items.Clear();
            listBoxPanierCommande.Items.AddRange(ORMVVA.GetPanierCommander("",0).ToArray());
            txtSearchCommande.Text = "";

            btnCommander.Enabled = false;
            listBoxPanier.Items.Clear();
            listBoxPanier.Items.AddRange(ORMVVA.GetTousLesPaniers("").ToArray());
            txtSearch.Text = "";
            





            TabPage selectedTabPage = tabControlClient.SelectedTab;

            if (selectedTabPage == tabListCommandes){ this.AcceptButton = btnSearchCommande;}
            else if (selectedTabPage == tabListPanier){ this.AcceptButton = btnSearch; }
            else if (selectedTabPage == tabInfosClient)
            {
                // Call the VoirProfil function to retrieve the user profile information
                //Dictionary<string, string> userProfile = ORMVVA.VoirProfil(Session.Instance.Username);

                // Set the values of the textboxes
                
            }
            else { }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Se déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                ORMVVA.DeconnexionUtilisateur();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBoxPanier.Items.Clear();
            listBoxPanier.Items.AddRange(ORMVVA.GetTousLesPaniers(txtSearch.Text).ToArray());
        }

        private void btnSearchCommande_Click(object sender, EventArgs e)
        {
            listBoxPanierCommande.Items.Clear();
            listBoxPanierCommande.Items.AddRange(ORMVVA.GetPanierCommander(txtSearchCommande.Text,comboBoxEtatCommande.SelectedIndex).ToArray());
        }




        private void btnCommander_Click(object sender, EventArgs e)
        {
            Panier panier = (Panier)listBoxPanier.SelectedItem;
            if (panier != null)
            {
                if (ORMVVA.IsCommander(panier))
                {
                    MessageBox.Show("Vous avez déjà commandé ce panier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ORMVVA.Commander(panier);
                    MessageBox.Show("Commande effectuée","Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                




            }
            btnCommander.Enabled = false;
        }

        private void btnAnnulerCommande_Click(object sender, EventArgs e)
        {
            Commande panier = (Commande)listBoxPanierCommande.SelectedItem;
            if (panier != null)
            {
                ORMVVA.AnnulerCommande(panier);
                MessageBox.Show("Commande annulée", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxPanierCommande.Items.Clear();
                listBoxPanierCommande.Items.AddRange(ORMVVA.GetPanierCommander(txtSearch.Text,comboBoxEtatCommande.SelectedIndex).ToArray());

            }
            btnAnnulerCommande.Enabled = false;
        }

        private void btnPayerCommande_Click(object sender, EventArgs e)
        {
            Commande panier = (Commande)listBoxPanierCommande.SelectedItem;
            if (panier != null)
            {
                ORMVVA.PayerCommande(panier);
                MessageBox.Show("Commande payée", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxPanierCommande.Items.Clear();
                listBoxPanierCommande.Items.AddRange(ORMVVA.GetPanierCommander(txtSearch.Text,comboBoxEtatCommande.SelectedIndex).ToArray());
            }
            
        }


        private void listBoxPanier_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCommander.Enabled = true;
        }

        private void listBoxPanierCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            Commande panier = (Commande)listBoxPanierCommande.SelectedItem;
            if (panier != null)
            {
                lblDateCommande.Text = panier.GetDateCommande().ToString("dd-MM-yyyy");
                //lblEtatCommande.Text = panier.GetEtatCommande().ToString() ;
                int EtatCommande = panier.GetEtatCommande();
                if (panier.GetEtatCommande() == 1)
                {
                    btnPayerCommande.Enabled = true;
                    btnAnnulerCommande.Enabled = true;
                }
                else
                {
                    btnPayerCommande.Enabled = false;
                    btnAnnulerCommande.Enabled = false;
                }

                switch (EtatCommande)
                {
                    case 1:
                        lblEtatCommande.Text = "Passée";
                        break;
                    case 2:
                        lblEtatCommande.Text = "Payée";
                        break;
                    case 3:
                        lblEtatCommande.Text = "Livrable";
                        break;
                    default:
                        lblEtatCommande.Text = "Inconnu";
                        break;
                }

            }
            
        }

        private void txtTelProfil_TextChanged(object sender, EventArgs e)
        {
            // Check if the textbox contains exactly 10 digits
            if (txtTelProfil.Text.Length == 10 && txtTelProfil.Text.All(char.IsDigit))
            {
                // The input is valid - do something with the input
            }
            else
            {
                // The input is not valid - show an error message and clear the textbox
                MessageBox.Show("The input must contain exactly 10 digits.", "Error");
                txtTelProfil.Text = "";
            }
        }

        private void btnUpdateProfil_Click(object sender, EventArgs e)
        {
            if (txtTelProfil.Text.Length != 10 || !txtTelProfil.Text.All(char.IsDigit))
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide (10 chiffres sans espaces).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!txtMailProfil.Text.Contains("@"))
                {
                    MessageBox.Show("Veuillez entrer une adresse mail valide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ORMVVA.ModifierProfil(Session.Instance.Username, txtNomProfil.Text, txtPrenomProfil.Text, Convert.ToDateTime(txtNaissanceProfil.Text), txtMailProfil.Text, txtTelProfil.Text);
                    MessageBox.Show("Profil mis à jour.", "Modification de profil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            

        }

        private void btnCancelUpdateProfil_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> userProfile = ORMVVA.VoirProfil(Session.Instance.Username);
            txtNomProfil.Text = userProfile["NomUtilisateur"];
            txtPrenomProfil.Text = userProfile["PrenomUtilisateur"];
            txtNaissanceProfil.Text = userProfile["DateNaissanceUtilisateur"];
            txtMailProfil.Text = userProfile["MailUtilisateur"];
            txtTelProfil.Text = userProfile["TelUtilisateur"];
        }

        #endregion

        
    }
}
