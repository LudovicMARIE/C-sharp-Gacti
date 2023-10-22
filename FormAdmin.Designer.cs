namespace VVA
{
    partial class FormAdmin
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabListPanier = new System.Windows.Forms.TabPage();
            this.btnAjoutPanierForm = new System.Windows.Forms.Button();
            this.btnModifPanier = new System.Windows.Forms.Button();
            this.listBoxPanier = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabListCommandes = new System.Windows.Forms.TabPage();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxEtatCommande = new System.Windows.Forms.ComboBox();
            this.lblClientCommande = new System.Windows.Forms.Label();
            this.lblDateCommande = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPreparerCommande = new System.Windows.Forms.Button();
            this.lblEtatCommande = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnulerCommande = new System.Windows.Forms.Button();
            this.btnSearchCommande = new System.Windows.Forms.Button();
            this.txtSearchCommande = new System.Windows.Forms.TextBox();
            this.listBoxPanierCommande = new System.Windows.Forms.ListBox();
            this.tabCreatePanier = new System.Windows.Forms.TabPage();
            this.lblBonjour = new System.Windows.Forms.Label();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.tabControlAdmin.SuspendLayout();
            this.tabListPanier.SuspendLayout();
            this.tabListCommandes.SuspendLayout();
            this.tabCreatePanier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabListPanier);
            this.tabControlAdmin.Controls.Add(this.tabListCommandes);
            this.tabControlAdmin.Controls.Add(this.tabCreatePanier);
            this.tabControlAdmin.Location = new System.Drawing.Point(12, 45);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(776, 393);
            this.tabControlAdmin.TabIndex = 1;
            this.tabControlAdmin.SelectedIndexChanged += new System.EventHandler(this.tabControlAdmin_SelectedIndexChanged);
            // 
            // tabListPanier
            // 
            this.tabListPanier.Controls.Add(this.btnAjoutPanierForm);
            this.tabListPanier.Controls.Add(this.btnModifPanier);
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
            // btnAjoutPanierForm
            // 
            this.btnAjoutPanierForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjoutPanierForm.Location = new System.Drawing.Point(574, 309);
            this.btnAjoutPanierForm.Name = "btnAjoutPanierForm";
            this.btnAjoutPanierForm.Size = new System.Drawing.Size(188, 23);
            this.btnAjoutPanierForm.TabIndex = 4;
            this.btnAjoutPanierForm.Text = "Ajouter un nouveau panier";
            this.btnAjoutPanierForm.UseVisualStyleBackColor = true;
            this.btnAjoutPanierForm.Click += new System.EventHandler(this.btnAjoutPanierForm_Click);
            // 
            // btnModifPanier
            // 
            this.btnModifPanier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifPanier.Location = new System.Drawing.Point(574, 280);
            this.btnModifPanier.Name = "btnModifPanier";
            this.btnModifPanier.Size = new System.Drawing.Size(188, 23);
            this.btnModifPanier.TabIndex = 3;
            this.btnModifPanier.Text = "Modifier le panier";
            this.btnModifPanier.UseVisualStyleBackColor = true;
            this.btnModifPanier.Click += new System.EventHandler(this.btnModifPanier_Click);
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
            this.tabListCommandes.Controls.Add(this.comboBoxClient);
            this.tabListCommandes.Controls.Add(this.comboBoxEtatCommande);
            this.tabListCommandes.Controls.Add(this.lblClientCommande);
            this.tabListCommandes.Controls.Add(this.lblDateCommande);
            this.tabListCommandes.Controls.Add(this.label3);
            this.tabListCommandes.Controls.Add(this.label2);
            this.tabListCommandes.Controls.Add(this.btnPreparerCommande);
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
            this.tabListCommandes.Text = "Liste des commandes";
            this.tabListCommandes.UseVisualStyleBackColor = true;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(574, 83);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(188, 21);
            this.comboBoxClient.TabIndex = 12;
            // 
            // comboBoxEtatCommande
            // 
            this.comboBoxEtatCommande.FormattingEnabled = true;
            this.comboBoxEtatCommande.Location = new System.Drawing.Point(574, 56);
            this.comboBoxEtatCommande.Name = "comboBoxEtatCommande";
            this.comboBoxEtatCommande.Size = new System.Drawing.Size(188, 21);
            this.comboBoxEtatCommande.TabIndex = 12;
            // 
            // lblClientCommande
            // 
            this.lblClientCommande.AutoSize = true;
            this.lblClientCommande.Location = new System.Drawing.Point(616, 144);
            this.lblClientCommande.Name = "lblClientCommande";
            this.lblClientCommande.Size = new System.Drawing.Size(0, 13);
            this.lblClientCommande.TabIndex = 11;
            // 
            // lblDateCommande
            // 
            this.lblDateCommande.AutoSize = true;
            this.lblDateCommande.Location = new System.Drawing.Point(690, 120);
            this.lblDateCommande.Name = "lblDateCommande";
            this.lblDateCommande.Size = new System.Drawing.Size(0, 13);
            this.lblDateCommande.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Client : ";
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
            // btnPreparerCommande
            // 
            this.btnPreparerCommande.Location = new System.Drawing.Point(680, 187);
            this.btnPreparerCommande.Name = "btnPreparerCommande";
            this.btnPreparerCommande.Size = new System.Drawing.Size(75, 23);
            this.btnPreparerCommande.TabIndex = 9;
            this.btnPreparerCommande.Text = "Préparer";
            this.btnPreparerCommande.UseVisualStyleBackColor = true;
            this.btnPreparerCommande.Click += new System.EventHandler(this.btnPreparerCommande_Click);
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
            // tabCreatePanier
            // 
            this.tabCreatePanier.Controls.Add(this.listBoxClient);
            this.tabCreatePanier.Location = new System.Drawing.Point(4, 22);
            this.tabCreatePanier.Name = "tabCreatePanier";
            this.tabCreatePanier.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreatePanier.Size = new System.Drawing.Size(768, 367);
            this.tabCreatePanier.TabIndex = 2;
            this.tabCreatePanier.Text = "///";
            this.tabCreatePanier.UseVisualStyleBackColor = true;
            // 
            // lblBonjour
            // 
            this.lblBonjour.AutoSize = true;
            this.lblBonjour.Location = new System.Drawing.Point(19, 9);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(122, 13);
            this.lblBonjour.TabIndex = 2;
            this.lblBonjour.Text = "Bonjour prenom prenom ";
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.Location = new System.Drawing.Point(6, 6);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(253, 355);
            this.listBoxClient.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBonjour);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "FormAdmin";
            this.Text = "VVA - Admin";
            this.tabControlAdmin.ResumeLayout(false);
            this.tabListPanier.ResumeLayout(false);
            this.tabListPanier.PerformLayout();
            this.tabListCommandes.ResumeLayout(false);
            this.tabListCommandes.PerformLayout();
            this.tabCreatePanier.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabListPanier;
        private System.Windows.Forms.Button btnModifPanier;
        private System.Windows.Forms.ListBox listBoxPanier;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabListCommandes;
        private System.Windows.Forms.ComboBox comboBoxEtatCommande;
        private System.Windows.Forms.Label lblDateCommande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPreparerCommande;
        private System.Windows.Forms.Label lblEtatCommande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnulerCommande;
        private System.Windows.Forms.Button btnSearchCommande;
        private System.Windows.Forms.TextBox txtSearchCommande;
        private System.Windows.Forms.ListBox listBoxPanierCommande;
        private System.Windows.Forms.TabPage tabCreatePanier;
        private System.Windows.Forms.Label lblBonjour;
        private System.Windows.Forms.Button btnAjoutPanierForm;
        private System.Windows.Forms.Label lblClientCommande;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ListBox listBoxClient;
    }
}