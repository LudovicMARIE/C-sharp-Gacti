using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VVA.Session;

namespace VVA
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            ORMVVA.Connexion();
            this.AcceptButton = btn_login;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string Utilisateur = ORMVVA.ConnexionUtilisateur(txt_login.Text, txt_password.Text);
            if (Utilisateur == "Unknown")
            {
                MessageBox.Show("Login ou mot de passe incorrect", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if(Utilisateur == "0")
            {
                FormAdmin formadmin = new FormAdmin();
                formadmin.FormClosed += FormClosedHandler;
                formadmin.Show();
                this.Hide();

            }
            else if(Utilisateur == "1")
            {
                FormClient formclient = new FormClient();
                formclient.FormClosed += FormClosedHandler;
                formclient.Show();
                this.Hide();
            }


        }

        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            txt_login.Text = "";
            txt_password.Text = "";
            this.Show();
        }
    }
}
