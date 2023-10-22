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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
            this.Click += new EventHandler(listItem_Click);
        }
        public void Update(Panier panier)
        {
            // Update the control with the values from the Panier object
            lblTitreListItem.Text = panier.GetNomPanier();
            lblPrixListItem.Text = panier.GetPrixPanier().ToString();
            lblDescListItem.Text = panier.GetDescriptionPanier();
        }

        public void listItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;
        }
    }
}
