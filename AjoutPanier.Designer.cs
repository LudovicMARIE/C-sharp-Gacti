namespace VVA
{
    partial class AjoutPanier
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomPanier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrixPanier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescPanier = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCategoriePanier = new System.Windows.Forms.ComboBox();
            this.btnAjoutPanier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du panier :";
            // 
            // txtNomPanier
            // 
            this.txtNomPanier.Location = new System.Drawing.Point(15, 42);
            this.txtNomPanier.Name = "txtNomPanier";
            this.txtNomPanier.Size = new System.Drawing.Size(122, 20);
            this.txtNomPanier.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prix du panier :";
            // 
            // txtPrixPanier
            // 
            this.txtPrixPanier.Location = new System.Drawing.Point(15, 96);
            this.txtPrixPanier.Name = "txtPrixPanier";
            this.txtPrixPanier.Size = new System.Drawing.Size(122, 20);
            this.txtPrixPanier.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description du panier :";
            // 
            // txtDescPanier
            // 
            this.txtDescPanier.Location = new System.Drawing.Point(183, 96);
            this.txtDescPanier.Name = "txtDescPanier";
            this.txtDescPanier.Size = new System.Drawing.Size(122, 58);
            this.txtDescPanier.TabIndex = 3;
            this.txtDescPanier.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Catégorie :";
            // 
            // comboBoxCategoriePanier
            // 
            this.comboBoxCategoriePanier.FormattingEnabled = true;
            this.comboBoxCategoriePanier.Location = new System.Drawing.Point(183, 43);
            this.comboBoxCategoriePanier.Name = "comboBoxCategoriePanier";
            this.comboBoxCategoriePanier.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoriePanier.TabIndex = 3;
            // 
            // btnAjoutPanier
            // 
            this.btnAjoutPanier.Location = new System.Drawing.Point(15, 130);
            this.btnAjoutPanier.Name = "btnAjoutPanier";
            this.btnAjoutPanier.Size = new System.Drawing.Size(122, 23);
            this.btnAjoutPanier.TabIndex = 4;
            this.btnAjoutPanier.Text = "Ajouter un panier";
            this.btnAjoutPanier.UseVisualStyleBackColor = true;
            this.btnAjoutPanier.Click += new System.EventHandler(this.btnAjoutPanier_Click);
            // 
            // AjoutPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 172);
            this.Controls.Add(this.btnAjoutPanier);
            this.Controls.Add(this.comboBoxCategoriePanier);
            this.Controls.Add(this.txtDescPanier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrixPanier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomPanier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "AjoutPanier";
            this.Text = "AjoutPanier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomPanier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrixPanier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDescPanier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCategoriePanier;
        private System.Windows.Forms.Button btnAjoutPanier;
    }
}