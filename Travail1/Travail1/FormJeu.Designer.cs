namespace Travail1
{
    partial class FormJeu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPlancheJeu = new System.Windows.Forms.PictureBox();
            this.affichageInfoJoueur1 = new Travail1.Controls.AffichageInfoJoueur();
            this.affichageInfoJoueur2 = new Travail1.Controls.AffichageInfoJoueur();
            this.lbl_JoueurCourant = new System.Windows.Forms.Label();
            this.btn_LancerDe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlancheJeu)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlancheJeu
            // 
            this.picPlancheJeu.BackColor = System.Drawing.SystemColors.Control;
            this.picPlancheJeu.Location = new System.Drawing.Point(525, 15);
            this.picPlancheJeu.Margin = new System.Windows.Forms.Padding(6);
            this.picPlancheJeu.Name = "picPlancheJeu";
            this.picPlancheJeu.Size = new System.Drawing.Size(801, 801);
            this.picPlancheJeu.TabIndex = 0;
            this.picPlancheJeu.TabStop = false;
            // 
            // affichageInfoJoueur1
            // 
            this.affichageInfoJoueur1.Joueur = null;
            this.affichageInfoJoueur1.Location = new System.Drawing.Point(15, 141);
            this.affichageInfoJoueur1.Margin = new System.Windows.Forms.Padding(6);
            this.affichageInfoJoueur1.Name = "affichageInfoJoueur1";
            this.affichageInfoJoueur1.Size = new System.Drawing.Size(322, 141);
            this.affichageInfoJoueur1.TabIndex = 1;
            // 
            // affichageInfoJoueur2
            // 
            this.affichageInfoJoueur2.Joueur = null;
            this.affichageInfoJoueur2.Location = new System.Drawing.Point(15, 301);
            this.affichageInfoJoueur2.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.affichageInfoJoueur2.Name = "affichageInfoJoueur2";
            this.affichageInfoJoueur2.Size = new System.Drawing.Size(322, 141);
            this.affichageInfoJoueur2.TabIndex = 2;
            // 
            // lbl_JoueurCourant
            // 
            this.lbl_JoueurCourant.AutoSize = true;
            this.lbl_JoueurCourant.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_JoueurCourant.Location = new System.Drawing.Point(60, 51);
            this.lbl_JoueurCourant.Name = "lbl_JoueurCourant";
            this.lbl_JoueurCourant.Size = new System.Drawing.Size(263, 50);
            this.lbl_JoueurCourant.TabIndex = 3;
            this.lbl_JoueurCourant.Text = "JoueurCourant";
            // 
            // btn_LancerDe
            // 
            this.btn_LancerDe.Location = new System.Drawing.Point(60, 458);
            this.btn_LancerDe.Name = "btn_LancerDe";
            this.btn_LancerDe.Size = new System.Drawing.Size(251, 114);
            this.btn_LancerDe.TabIndex = 4;
            this.btn_LancerDe.Text = "Lancer Dé";
            this.btn_LancerDe.UseVisualStyleBackColor = true;
            this.btn_LancerDe.Click += new System.EventHandler(this.btn_LancerDe_Click);
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 836);
            this.Controls.Add(this.btn_LancerDe);
            this.Controls.Add(this.lbl_JoueurCourant);
            this.Controls.Add(this.affichageInfoJoueur2);
            this.Controls.Add(this.affichageInfoJoueur1);
            this.Controls.Add(this.picPlancheJeu);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormJeu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPlancheJeu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picPlancheJeu;
        private Controls.AffichageInfoJoueur affichageInfoJoueur1;
        private Controls.AffichageInfoJoueur affichageInfoJoueur2;
        private Label lbl_JoueurCourant;
        private Button btn_LancerDe;
    }
}