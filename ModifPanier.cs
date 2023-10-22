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
    public partial class ModifPanier : Form
    {
        public ModifPanier(int IdPanier)
        {
            InitializeComponent();
            List<object> categories = ORMVVA.GetCategories();
            foreach (object categorie in categories)
            {
                comboBoxCategoriePanier.Items.Add(categorie);
            }
            comboBoxCategoriePanier.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoriePanier.DisplayMember = "Nom";
            comboBoxCategoriePanier.SelectedIndex = 0;

            Panier panier = ORMVVA.GetPanierModif(IdPanier);
            txtNomPanier.Text = panier.GetNomPanier();
            txtDescPanier.Text = panier.GetDescriptionPanier();
            txtPrixPanier.Text = panier.GetPrixPanier().ToString();
            comboBoxCategoriePanier.SelectedIndex = panier.GetId_Categorie();
            this.Text = IdPanier.ToString();
        }

        private void btnModifPanier_Click(object sender, EventArgs e)
        {
            ORMVVA.ModifierPanier(Convert.ToInt32(this.Text), txtNomPanier.Text, Convert.ToDouble(txtPrixPanier.Text), txtDescPanier.Text, comboBoxCategoriePanier.SelectedIndex);
            this.Close();
            MessageBox.Show("Panier modifié", "Panier", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
