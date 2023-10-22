namespace VVA
{
    partial class ListItem
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitreListItem = new System.Windows.Forms.Label();
            this.lblDescListItem = new System.Windows.Forms.Label();
            this.lblPrixListItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitreListItem
            // 
            this.lblTitreListItem.AutoSize = true;
            this.lblTitreListItem.Location = new System.Drawing.Point(3, 6);
            this.lblTitreListItem.Name = "lblTitreListItem";
            this.lblTitreListItem.Size = new System.Drawing.Size(74, 13);
            this.lblTitreListItem.TabIndex = 0;
            this.lblTitreListItem.Text = "lblTitreListItem";
            // 
            // lblDescListItem
            // 
            this.lblDescListItem.AutoSize = true;
            this.lblDescListItem.Location = new System.Drawing.Point(3, 30);
            this.lblDescListItem.Name = "lblDescListItem";
            this.lblDescListItem.Size = new System.Drawing.Size(78, 13);
            this.lblDescListItem.TabIndex = 0;
            this.lblDescListItem.Text = "lblDescListItem";
            // 
            // lblPrixListItem
            // 
            this.lblPrixListItem.AutoSize = true;
            this.lblPrixListItem.Location = new System.Drawing.Point(402, 22);
            this.lblPrixListItem.Name = "lblPrixListItem";
            this.lblPrixListItem.Size = new System.Drawing.Size(70, 13);
            this.lblPrixListItem.TabIndex = 0;
            this.lblPrixListItem.Text = "lblPrixListItem";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.lblPrixListItem);
            this.Controls.Add(this.lblDescListItem);
            this.Controls.Add(this.lblTitreListItem);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(475, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreListItem;
        private System.Windows.Forms.Label lblDescListItem;
        private System.Windows.Forms.Label lblPrixListItem;
    }
}
