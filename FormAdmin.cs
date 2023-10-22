using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VVA
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            listBoxPanier.Items.AddRange(ORMVVA.GetTousLesPaniers(txtSearch.Text).ToArray());

            List<object> etats = ORMVVA.GetEtats();
            comboBoxEtatCommande.Items.Add(new { Id = 0, Nom = "Toutes les commandes" });
            foreach (object etat in etats)
            {
                comboBoxEtatCommande.Items.Add(etat);
            }
            comboBoxEtatCommande.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEtatCommande.DisplayMember = "Nom";
            comboBoxEtatCommande.SelectedIndex = 0;

            List<string> listeClient = ORMVVA.GetClientsCommande();
            comboBoxClient.Items.Add("");
            foreach (string client in listeClient)
            {
                comboBoxClient.Items.Add(client);
            }
            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;

            //Dictionary<string, string> userProfile = ORMVVA.VoirProfil(Session.Instance.Username);
            //txtNomProfil.Text = userProfile["NomUtilisateur"];
            //txtPrenomProfil.Text = userProfile["PrenomUtilisateur"];
            //txtNaissanceProfil.Text = userProfile["DateNaissanceUtilisateur"];
            //txtMailProfil.Text = userProfile["MailUtilisateur"];
            //txtTelProfil.Text = userProfile["TelUtilisateur"];
            //lblBonjour.Text = "Bonjour " + userProfile["PrenomUtilisateur"] + " " + userProfile["NomUtilisateur"];
            //this.Text = "VVA - Client - " + userProfile["PrenomUtilisateur"] + " " + userProfile["NomUtilisateur"];

            this.AcceptButton = btnSearch;
            btnModifPanier.Enabled = false;
            btnAnnulerCommande.Enabled = false;
            btnPreparerCommande.Enabled = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Se déconnecter?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                ORMVVA.DeconnexionUtilisateur();
            }
        }

        private void tabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAnnulerCommande.Enabled = false;
            listBoxPanierCommande.Items.Clear();
            listBoxPanierCommande.Items.AddRange(ORMVVA.GetPanierCommanderAdmin("", 0, "").ToArray());
            txtSearchCommande.Text = "";

            btnModifPanier.Enabled = false;
            listBoxPanier.Items.Clear();
            listBoxPanier.Items.AddRange(ORMVVA.GetTousLesPaniers("").ToArray());
            txtSearch.Text = "";

            listBoxClient.Items.Clear();
            listBoxClient.Items.AddRange(ORMVVA.GetListUser().ToArray());



            TabPage selectedTabPage = tabControlAdmin.SelectedTab;

            if (selectedTabPage == tabListCommandes) { this.AcceptButton = btnSearchCommande; }
            else if (selectedTabPage == tabListPanier) { this.AcceptButton = btnSearch; }
            else if (selectedTabPage == tabCreatePanier)
            {
                // Call the VoirProfil function to retrieve the user profile information
                //Dictionary<string, string> userProfile = ORMVVA.VoirProfil(Session.Instance.Username);

                // Set the values of the textboxes

            }
            else { }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBoxPanier.Items.Clear();
            listBoxPanier.Items.AddRange(ORMVVA.GetTousLesPaniers(txtSearch.Text).ToArray());
        }

        private void btnSearchCommande_Click(object sender, EventArgs e)
        {
            listBoxPanierCommande.Items.Clear();
            listBoxPanierCommande.Items.AddRange(ORMVVA.GetPanierCommanderAdmin(txtSearchCommande.Text, comboBoxEtatCommande.SelectedIndex, comboBoxClient.Text).ToArray());
        }

        private void listBoxPanier_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnModifPanier.Enabled = true;
            Panier panier = (Panier)listBoxPanier.SelectedItem;
            if (panier != null)
            {

                //= panier.GetNomPanier();
                //= panier.GetPrixPanier();
                //= panier.GetDescriptionPanier();

            }
        }

        private void btnAjoutPanierForm_Click(object sender, EventArgs e)
        {
            AjoutPanier ajoutPanierForm = new AjoutPanier();
            ajoutPanierForm.FormClosed += ajoutPanierForm_FormClosed;
            ajoutPanierForm.ShowDialog();
        }

        private void ajoutPanierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBoxPanier.Items.Clear();
            listBoxPanier.Items.AddRange(ORMVVA.GetTousLesPaniers(txtSearch.Text).ToArray());
        }

        private void ModifPanierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBoxPanier.Items.Clear();
            listBoxPanier.Items.AddRange(ORMVVA.GetTousLesPaniers(txtSearch.Text).ToArray());
        }


        private void listBoxPanierCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            Commande panier = (Commande)listBoxPanierCommande.SelectedItem;
            if (panier != null)
            {
                lblClientCommande.Text = panier.GetId_Utilisateur();
                lblDateCommande.Text = panier.GetDateCommande().ToString("dd-MM-yyyy");
                lblEtatCommande.Text = ORMVVA.GetEtatCommandeLabel(panier.GetEtatCommande());
                if (panier.GetEtatCommande() == 2)
                {
                    btnPreparerCommande.Enabled = true;
                }
                else
                {
                    btnPreparerCommande.Enabled = false;
                }
                if(panier.GetEtatCommande() == 1)
                {
                    btnAnnulerCommande.Enabled = true;
                }
                else
                {
                    btnAnnulerCommande.Enabled = false;
                }
            }
        }

        private void btnPreparerCommande_Click(object sender, EventArgs e)
        {
            Commande panier = (Commande)listBoxPanierCommande.SelectedItem;
            if (panier != null)
            {

                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir modifier l'état de la commande ? Cette action est définitive", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ORMVVA.PreparerCommande(panier);
                    listBoxPanierCommande.Items.Clear();
                    listBoxPanierCommande.Items.AddRange(ORMVVA.GetPanierCommanderAdmin(txtSearchCommande.Text, comboBoxEtatCommande.SelectedIndex, comboBoxClient.Text).ToArray());
                    MessageBox.Show("L'état de la commande à bien été modifié", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblClientCommande.Text = "";
                    lblDateCommande.Text = "";
                    lblEtatCommande.Text = "";
                }
                else
                {
                    
                }
                
                
            }
        }

        private void btnAnnulerCommande_Click(object sender, EventArgs e)
        {
            Commande panier = (Commande)listBoxPanierCommande.SelectedItem;
            if (panier != null)
            {
                ORMVVA.AnnulerCommande(panier);
                MessageBox.Show("Commande annulée", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxPanierCommande.Items.Clear();
                listBoxPanierCommande.Items.AddRange(ORMVVA.GetPanierCommanderAdmin(txtSearchCommande.Text, comboBoxEtatCommande.SelectedIndex, comboBoxClient.Text).ToArray());
            }
            btnAnnulerCommande.Enabled = false;
        }

        private void btnModifPanier_Click(object sender, EventArgs e)
        {
            Panier panier = (Panier)listBoxPanier.SelectedItem;
            if (panier != null)
            {
                ModifPanier modifPanier = new ModifPanier(panier.GetId_Panier());
                modifPanier.FormClosed += ModifPanierForm_FormClosed;
                modifPanier.ShowDialog();
            }
            
        }
    }
}
