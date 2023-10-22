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
    public partial class AjoutPanier : Form
    {
        public AjoutPanier()
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
        }

        private void btnAjoutPanier_Click(object sender, EventArgs e)
        {
            if(txtNomPanier.Text != "" && txtPrixPanier.Text != "" && txtDescPanier.Text != "")
            {
                ORMVVA.AjouterPanier(txtNomPanier.Text, Convert.ToDouble(txtPrixPanier.Text), txtDescPanier.Text, comboBoxCategoriePanier.SelectedIndex);
                this.Close();
                MessageBox.Show("Nouveau panier ajouté", "Panier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez renseigner tous les champs","Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
