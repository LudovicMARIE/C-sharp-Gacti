namespace VVA
{
    partial class ModifPanier
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
            this.btnModifPanier = new System.Windows.Forms.Button();
            this.comboBoxCategoriePanier = new System.Windows.Forms.ComboBox();
            this.txtDescPanier = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrixPanier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomPanier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifPanier
            // 
            this.btnModifPanier.Location = new System.Drawing.Point(12, 116);
            this.btnModifPanier.Name = "btnModifPanier";
            this.btnModifPanier.Size = new System.Drawing.Size(122, 23);
            this.btnModifPanier.TabIndex = 13;
            this.btnModifPanier.Text = "Modifier le panier";
            this.btnModifPanier.UseVisualStyleBackColor = true;
            this.btnModifPanier.Click += new System.EventHandler(this.btnModifPanier_Click);
            // 
            // comboBoxCategoriePanier
            // 
            this.comboBoxCategoriePanier.FormattingEnabled = true;
            this.comboBoxCategoriePanier.Location = new System.Drawing.Point(180, 29);
            this.comboBoxCategoriePanier.Name = "comboBoxCategoriePanier";
            this.comboBoxCategoriePanier.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoriePanier.TabIndex = 11;
            // 
            // txtDescPanier
            // 
            this.txtDescPanier.Location = new System.Drawing.Point(180, 82);
            this.txtDescPanier.Name = "txtDescPanier";
            this.txtDescPanier.Size = new System.Drawing.Size(122, 58);
            this.txtDescPanier.TabIndex = 12;
            this.txtDescPanier.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description du panier :";
            // 
            // txtPrixPanier
            // 
            this.txtPrixPanier.Location = new System.Drawing.Point(12, 82);
            this.txtPrixPanier.Name = "txtPrixPanier";
            this.txtPrixPanier.Size = new System.Drawing.Size(122, 20);
            this.txtPrixPanier.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prix du panier :";
            // 
            // txtNomPanier
            // 
            this.txtNomPanier.Location = new System.Drawing.Point(12, 28);
            this.txtNomPanier.Name = "txtNomPanier";
            this.txtNomPanier.Size = new System.Drawing.Size(122, 20);
            this.txtNomPanier.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Catégorie :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom du panier :";
            // 
            // ModifPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 164);
            this.Controls.Add(this.btnModifPanier);
            this.Controls.Add(this.comboBoxCategoriePanier);
            this.Controls.Add(this.txtDescPanier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrixPanier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomPanier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ModifPanier";
            this.Text = "ModifPanier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifPanier;
        private System.Windows.Forms.ComboBox comboBoxCategoriePanier;
        private System.Windows.Forms.RichTextBox txtDescPanier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrixPanier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomPanier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}