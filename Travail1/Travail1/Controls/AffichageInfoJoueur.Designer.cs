namespace Travail1.Controls
{
    partial class AffichageInfoJoueur
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
            this.lbl_Joueur = new System.Windows.Forms.Label();
            this.lbl_PointJoueur = new System.Windows.Forms.Label();
            this.lbl_NomJoueur = new System.Windows.Forms.Label();
            this.lbl_PointTotalJoueur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Joueur
            // 
            this.lbl_Joueur.AutoSize = true;
            this.lbl_Joueur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Joueur.Location = new System.Drawing.Point(28, 21);
            this.lbl_Joueur.Name = "lbl_Joueur";
            this.lbl_Joueur.Size = new System.Drawing.Size(64, 21);
            this.lbl_Joueur.TabIndex = 0;
            this.lbl_Joueur.Text = "Joueur :";
            // 
            // lbl_PointJoueur
            // 
            this.lbl_PointJoueur.AutoSize = true;
            this.lbl_PointJoueur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PointJoueur.Location = new System.Drawing.Point(28, 42);
            this.lbl_PointJoueur.Name = "lbl_PointJoueur";
            this.lbl_PointJoueur.Size = new System.Drawing.Size(52, 21);
            this.lbl_PointJoueur.TabIndex = 1;
            this.lbl_PointJoueur.Text = "Point :";
            // 
            // lbl_NomJoueur
            // 
            this.lbl_NomJoueur.AutoSize = true;
            this.lbl_NomJoueur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NomJoueur.Location = new System.Drawing.Point(98, 21);
            this.lbl_NomJoueur.Name = "lbl_NomJoueur";
            this.lbl_NomJoueur.Size = new System.Drawing.Size(96, 21);
            this.lbl_NomJoueur.TabIndex = 4;
            this.lbl_NomJoueur.Text = "Nom Joueur";
            // 
            // lbl_PointTotalJoueur
            // 
            this.lbl_PointTotalJoueur.AutoSize = true;
            this.lbl_PointTotalJoueur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PointTotalJoueur.Location = new System.Drawing.Point(76, 42);
            this.lbl_PointTotalJoueur.Name = "lbl_PointTotalJoueur";
            this.lbl_PointTotalJoueur.Size = new System.Drawing.Size(81, 21);
            this.lbl_PointTotalJoueur.TabIndex = 5;
            this.lbl_PointTotalJoueur.Text = "Point Total";
            // 
            // AffichageInfoJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_PointTotalJoueur);
            this.Controls.Add(this.lbl_NomJoueur);
            this.Controls.Add(this.lbl_PointJoueur);
            this.Controls.Add(this.lbl_Joueur);
            this.Name = "AffichageInfoJoueur";
            this.Size = new System.Drawing.Size(322, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Joueur;
        private Label lbl_PointJoueur;
        private Label lbl_NomJoueur;
        private Label lbl_PointTotalJoueur;
    }
}
