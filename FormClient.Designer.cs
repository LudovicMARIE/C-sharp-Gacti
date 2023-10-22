using System.Windows.Forms;
using System;

namespace VVA
{
    partial class FormClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabListPanier = new System.Windows.Forms.TabPage();
            this.btnCommander = new System.Windows.Forms.Button();
            this.listBoxPanier = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabListCommandes = new System.Windows.Forms.TabPage();
            this.comboBoxEtatCommande = new System.Windows.Forms.ComboBox();
            this.lblDateCommande = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPayerCommande = new System.Windows.Forms.Button();
            this.lblEtatCommande = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnulerCommande = new System.Windows.Forms.Button();
            this.btnSearchCommande = new System.Windows.Forms.Button();
            this.txtSearchCommande = new System.Windows.Forms.TextBox();
            this.listBoxPanierCommande = new System.Windows.Forms.ListBox();
            this.tabInfosClient = new System.Windows.Forms.TabPage();
            this.btnCancelUpdateProfil = new System.Windows.Forms.Button();
            this.btnUpdateProfil = new System.Windows.Forms.Button();
            this.lblTel = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.lblNaissance = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtTelProfil = new System.Windows.Forms.TextBox();
            this.txtMailProfil = new System.Windows.Forms.TextBox();
            this.txtNaissanceProfil = new System.Windows.Forms.TextBox();
            this.txtPrenomProfil = new System.Windows.Forms.TextBox();
            this.txtNomProfil = new System.Windows.Forms.TextBox();
            this.lblBonjour = new System.Windows.Forms.Label();
            this.tabControlClient.SuspendLayout();
            this.tabListPanier.SuspendLayout();
            this.tabListCommandes.SuspendLayout();
            this.tabInfosClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Controls.Add(this.tabListPanier);
            this.tabControlClient.Controls.Add(this.tabListCommandes);
            this.tabControlClient.Controls.Add(this.tabInfosClient);
            this.tabControlClient.Location = new System.Drawing.Point(12, 45);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(776, 393);
            this.tabControlClient.TabIndex = 0;
            this.tabControlClient.SelectedIndexChanged += new System.EventHandler(this.tabControlClient_SelectedIndexChanged);
            // 
            // tabListPanier
            // 
            this.tabListPanier.Controls.Add(this.btnCommander);
            this.tabListPanier.Controls.Add(this.listBoxPanier);
            this.tabListPanier.Controls.Add(this.btnSearch);
            this.tabListPanier.Controls.Add(this.txtSearch);
            this.tabListPanier.Location = new System.Drawing.Point(4, 22);
            this.tabListPanier.Name = "tabListPanier";
            this.tabListPanier.Padding = new System.Windows.Forms.Padding(3);
            this.tabListPanier.Size = new System.Drawing.Size(768, 367);
            this.tabListPanier.TabIndex = 0;
            this.tabListPanier.Text = "Liste des paniers";
            this.tabListPanier.UseVisualStyleBackColor = true;
            // 
            // btnCommander
            // 
            this.btnCommander.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommander.Location = new System.Drawing.Point(574, 105);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(188, 23);
            this.btnCommander.TabIndex = 3;
            this.btnCommander.Text = "Commander";
            this.btnCommander.UseVisualStyleBackColor = true;
            this.btnCommander.Click += new System.EventHandler(this.btnCommander_Click);
            // 
            // listBoxPanier
            // 
            this.listBoxPanier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxPanier.FormattingEnabled = true;
            this.listBoxPanier.Location = new System.Drawing.Point(6, 29);
            this.listBoxPanier.Name = "listBoxPanier";
            this.listBoxPanier.Size = new System.Drawing.Size(562, 303);
            this.listBoxPanier.TabIndex = 2;
            this.listBoxPanier.SelectedIndexChanged += new System.EventHandler(this.listBoxPanier_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(680, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(574, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // tabListCommandes
            // 
            this.tabListCommandes.Controls.Add(this.comboBoxEtatCommande);
            this.tabListCommandes.Controls.Add(this.lblDateCommande);
            this.tabListCommandes.Controls.Add(this.label2);
            this.tabListCommandes.Controls.Add(this.btnPayerCommande);
            this.tabListCommandes.Controls.Add(this.lblEtatCommande);
            this.tabListCommandes.Controls.Add(this.label1);
            this.tabListCommandes.Controls.Add(this.btnAnnulerCommande);
            this.tabListCommandes.Controls.Add(this.btnSearchCommande);
            this.tabListCommandes.Controls.Add(this.txtSearchCommande);
            this.tabListCommandes.Controls.Add(this.listBoxPanierCommande);
            this.tabListCommandes.Location = new System.Drawing.Point(4, 22);
            this.tabListCommandes.Name = "tabListCommandes";
            this.tabListCommandes.Padding = new System.Windows.Forms.Padding(3);
            this.tabListCommandes.Size = new System.Drawing.Size(768, 367);
            this.tabListCommandes.TabIndex = 1;
            this.tabListCommandes.Text = "Mes commandes";
            this.tabListCommandes.UseVisualStyleBackColor = true;
            // 
            // comboBoxEtatCommande
            // 
            this.comboBoxEtatCommande.FormattingEnabled = true;
            this.comboBoxEtatCommande.Location = new System.Drawing.Point(574, 56);
            this.comboBoxEtatCommande.Name = "comboBoxEtatCommande";
            this.comboBoxEtatCommande.Size = new System.Drawing.Size(188, 21);
            this.comboBoxEtatCommande.TabIndex = 12;
            // 
            // lblDateCommande
            // 
            this.lblDateCommande.AutoSize = true;
            this.lblDateCommande.Location = new System.Drawing.Point(690, 120);
            this.lblDateCommande.Name = "lblDateCommande";
            this.lblDateCommande.Size = new System.Drawing.Size(0, 13);
            this.lblDateCommande.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date de la commande : ";
            // 
            // btnPayerCommande
            // 
            this.btnPayerCommande.Location = new System.Drawing.Point(680, 187);
            this.btnPayerCommande.Name = "btnPayerCommande";
            this.btnPayerCommande.Size = new System.Drawing.Size(75, 23);
            this.btnPayerCommande.TabIndex = 9;
            this.btnPayerCommande.Text = "Payer";
            this.btnPayerCommande.UseVisualStyleBackColor = true;
            this.btnPayerCommande.Click += new System.EventHandler(this.btnPayerCommande_Click);
            // 
            // lblEtatCommande
            // 
            this.lblEtatCommande.AutoSize = true;
            this.lblEtatCommande.Location = new System.Drawing.Point(690, 171);
            this.lblEtatCommande.Name = "lblEtatCommande";
            this.lblEtatCommande.Size = new System.Drawing.Size(0, 13);
            this.lblEtatCommande.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "État de la commande : ";
            // 
            // btnAnnulerCommande
            // 
            this.btnAnnulerCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnulerCommande.Location = new System.Drawing.Point(577, 187);
            this.btnAnnulerCommande.Name = "btnAnnulerCommande";
            this.btnAnnulerCommande.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerCommande.TabIndex = 6;
            this.btnAnnulerCommande.Text = "Annuler";
            this.btnAnnulerCommande.UseVisualStyleBackColor = true;
            this.btnAnnulerCommande.Click += new System.EventHandler(this.btnAnnulerCommande_Click);
            // 
            // btnSearchCommande
            // 
            this.btnSearchCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCommande.Location = new System.Drawing.Point(680, 27);
            this.btnSearchCommande.Name = "btnSearchCommande";
            this.btnSearchCommande.Size = new System.Drawing.Size(82, 23);
            this.btnSearchCommande.TabIndex = 5;
            this.btnSearchCommande.Text = "Rechercher";
            this.btnSearchCommande.UseVisualStyleBackColor = true;
            this.btnSearchCommande.Click += new System.EventHandler(this.btnSearchCommande_Click);
            // 
            // txtSearchCommande
            // 
            this.txtSearchCommande.Location = new System.Drawing.Point(574, 29);
            this.txtSearchCommande.Name = "txtSearchCommande";
            this.txtSearchCommande.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCommande.TabIndex = 4;
            // 
            // listBoxPanierCommande
            // 
            this.listBoxPanierCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxPanierCommande.FormattingEnabled = true;
            this.listBoxPanierCommande.Location = new System.Drawing.Point(6, 29);
            this.listBoxPanierCommande.Name = "listBoxPanierCommande";
            this.listBoxPanierCommande.Size = new System.Drawing.Size(562, 303);
            this.listBoxPanierCommande.TabIndex = 3;
            this.listBoxPanierCommande.SelectedIndexChanged += new System.EventHandler(this.listBoxPanierCommande_SelectedIndexChanged);
            // 
            // tabInfosClient
            // 
            this.tabInfosClient.Controls.Add(this.btnCancelUpdateProfil);
            this.tabInfosClient.Controls.Add(this.btnUpdateProfil);
            this.tabInfosClient.Controls.Add(this.lblTel);
            this.tabInfosClient.Controls.Add(this.LblMail);
            this.tabInfosClient.Controls.Add(this.lblNaissance);
            this.tabInfosClient.Controls.Add(this.LblPrenom);
            this.tabInfosClient.Controls.Add(this.lblNom);
            this.tabInfosClient.Controls.Add(this.txtTelProfil);
            this.tabInfosClient.Controls.Add(this.txtMailProfil);
            this.tabInfosClient.Controls.Add(this.txtNaissanceProfil);
            this.tabInfosClient.Controls.Add(this.txtPrenomProfil);
            this.tabInfosClient.Controls.Add(this.txtNomProfil);
            this.tabInfosClient.Location = new System.Drawing.Point(4, 22);
            this.tabInfosClient.Name = "tabInfosClient";
            this.tabInfosClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfosClient.Size = new System.Drawing.Size(768, 367);
            this.tabInfosClient.TabIndex = 2;
            this.tabInfosClient.Text = "Mon compte";
            this.tabInfosClient.UseVisualStyleBackColor = true;
            // 
            // btnCancelUpdateProfil
            // 
            this.btnCancelUpdateProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelUpdateProfil.Location = new System.Drawing.Point(463, 148);
            this.btnCancelUpdateProfil.Name = "btnCancelUpdateProfil";
            this.btnCancelUpdateProfil.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdateProfil.TabIndex = 7;
            this.btnCancelUpdateProfil.Text = "Annuler";
            this.btnCancelUpdateProfil.UseVisualStyleBackColor = true;
            this.btnCancelUpdateProfil.Click += new System.EventHandler(this.btnCancelUpdateProfil_Click);
            // 
            // btnUpdateProfil
            // 
            this.btnUpdateProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProfil.Location = new System.Drawing.Point(386, 148);
            this.btnUpdateProfil.Name = "btnUpdateProfil";
            this.btnUpdateProfil.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProfil.TabIndex = 6;
            this.btnUpdateProfil.Text = "Modifier";
            this.btnUpdateProfil.UseVisualStyleBackColor = true;
            this.btnUpdateProfil.Click += new System.EventHandler(this.btnUpdateProfil_Click);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(211, 132);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(58, 13);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Téléphone";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(386, 83);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(66, 13);
            this.LblMail.TabIndex = 4;
            this.LblMail.Text = "Adresse mail";
            // 
            // lblNaissance
            // 
            this.lblNaissance.AutoSize = true;
            this.lblNaissance.Location = new System.Drawing.Point(386, 36);
            this.lblNaissance.Name = "lblNaissance";
            this.lblNaissance.Size = new System.Drawing.Size(96, 13);
            this.lblNaissance.TabIndex = 3;
            this.lblNaissance.Text = "Date de naissance";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(208, 83);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(43, 13);
            this.LblPrenom.TabIndex = 2;
            this.LblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(208, 37);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // txtTelProfil
            // 
            this.txtTelProfil.Location = new System.Drawing.Point(211, 148);
            this.txtTelProfil.Name = "txtTelProfil";
            this.txtTelProfil.Size = new System.Drawing.Size(152, 20);
            this.txtTelProfil.TabIndex = 3;
            // 
            // txtMailProfil
            // 
            this.txtMailProfil.Location = new System.Drawing.Point(386, 99);
            this.txtMailProfil.Name = "txtMailProfil";
            this.txtMailProfil.Size = new System.Drawing.Size(152, 20);
            this.txtMailProfil.TabIndex = 5;
            // 
            // txtNaissanceProfil
            // 
            this.txtNaissanceProfil.Location = new System.Drawing.Point(386, 53);
            this.txtNaissanceProfil.Name = "txtNaissanceProfil";
            this.txtNaissanceProfil.Size = new System.Drawing.Size(152, 20);
            this.txtNaissanceProfil.TabIndex = 4;
            // 
            // txtPrenomProfil
            // 
            this.txtPrenomProfil.Location = new System.Drawing.Point(211, 99);
            this.txtPrenomProfil.Name = "txtPrenomProfil";
            this.txtPrenomProfil.Size = new System.Drawing.Size(152, 20);
            this.txtPrenomProfil.TabIndex = 1;
            // 
            // txtNomProfil
            // 
            this.txtNomProfil.Location = new System.Drawing.Point(211, 53);
            this.txtNomProfil.Name = "txtNomProfil";
            this.txtNomProfil.Size = new System.Drawing.Size(152, 20);
            this.txtNomProfil.TabIndex = 0;
            // 
            // lblBonjour
            // 
            this.lblBonjour.AutoSize = true;
            this.lblBonjour.Location = new System.Drawing.Point(16, 12);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(122, 13);
            this.lblBonjour.TabIndex = 1;
            this.lblBonjour.Text = "Bonjour prenom prenom ";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBonjour);
            this.Controls.Add(this.tabControlClient);
            this.Name = "FormClient";
            this.Text = "VVA - Client";
            this.tabControlClient.ResumeLayout(false);
            this.tabListPanier.ResumeLayout(false);
            this.tabListPanier.PerformLayout();
            this.tabListCommandes.ResumeLayout(false);
            this.tabListCommandes.PerformLayout();
            this.tabInfosClient.ResumeLayout(false);
            this.tabInfosClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabListPanier;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabListCommandes;
        private System.Windows.Forms.ListBox listBoxPanier;
        private System.Windows.Forms.TabPage tabInfosClient;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.Button btnSearchCommande;
        private System.Windows.Forms.TextBox txtSearchCommande;
        private System.Windows.Forms.ListBox listBoxPanierCommande;
        private Button btnAnnulerCommande;
        private Button btnCancelUpdateProfil;
        private Button btnUpdateProfil;
        private Label lblTel;
        private Label LblMail;
        private Label lblNaissance;
        private Label LblPrenom;
        private Label lblNom;
        private TextBox txtTelProfil;
        private TextBox txtMailProfil;
        private TextBox txtNaissanceProfil;
        private TextBox txtPrenomProfil;
        private TextBox txtNomProfil;
        private Label lblBonjour;
        private Button btnPayerCommande;
        private Label lblEtatCommande;
        private Label label1;
        private Label lblDateCommande;
        private Label label2;
        private ComboBox comboBoxEtatCommande;
    }
}