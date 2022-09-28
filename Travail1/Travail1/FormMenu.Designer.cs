namespace Travail1
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.btn_CommencerPartie = new System.Windows.Forms.Button();
            this.lbl_TitreJeu = new System.Windows.Forms.Label();
            this.lbl_Joueur2 = new System.Windows.Forms.Label();
            this.lbl_Joueur1 = new System.Windows.Forms.Label();
            this.txt_Joueur2 = new System.Windows.Forms.TextBox();
            this.txt_Joueur1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CommencerPartie
            // 
            this.btn_CommencerPartie.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CommencerPartie.Location = new System.Drawing.Point(341, 250);
            this.btn_CommencerPartie.Name = "btn_CommencerPartie";
            this.btn_CommencerPartie.Size = new System.Drawing.Size(174, 59);
            this.btn_CommencerPartie.TabIndex = 11;
            this.btn_CommencerPartie.Text = "Commencer";
            this.btn_CommencerPartie.UseVisualStyleBackColor = true;
            this.btn_CommencerPartie.Click += new System.EventHandler(this.btn_CommencerPartie_Click);
            // 
            // lbl_TitreJeu
            // 
            this.lbl_TitreJeu.AutoSize = true;
            this.lbl_TitreJeu.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TitreJeu.Location = new System.Drawing.Point(69, 9);
            this.lbl_TitreJeu.Name = "lbl_TitreJeu";
            this.lbl_TitreJeu.Size = new System.Drawing.Size(446, 65);
            this.lbl_TitreJeu.TabIndex = 10;
            this.lbl_TitreJeu.Text = "Serpents et Échelles";
            // 
            // lbl_Joueur2
            // 
            this.lbl_Joueur2.AutoSize = true;
            this.lbl_Joueur2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Joueur2.Location = new System.Drawing.Point(67, 201);
            this.lbl_Joueur2.Name = "lbl_Joueur2";
            this.lbl_Joueur2.Size = new System.Drawing.Size(118, 32);
            this.lbl_Joueur2.TabIndex = 9;
            this.lbl_Joueur2.Text = "Joueur 2 :";
            // 
            // lbl_Joueur1
            // 
            this.lbl_Joueur1.AutoSize = true;
            this.lbl_Joueur1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Joueur1.Location = new System.Drawing.Point(67, 123);
            this.lbl_Joueur1.Name = "lbl_Joueur1";
            this.lbl_Joueur1.Size = new System.Drawing.Size(118, 32);
            this.lbl_Joueur1.TabIndex = 8;
            this.lbl_Joueur1.Text = "Joueur 1 :";
            // 
            // txt_Joueur2
            // 
            this.txt_Joueur2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Joueur2.Location = new System.Drawing.Point(191, 205);
            this.txt_Joueur2.Name = "txt_Joueur2";
            this.txt_Joueur2.Size = new System.Drawing.Size(324, 39);
            this.txt_Joueur2.TabIndex = 7;
            // 
            // txt_Joueur1
            // 
            this.txt_Joueur1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Joueur1.Location = new System.Drawing.Point(191, 123);
            this.txt_Joueur1.Name = "txt_Joueur1";
            this.txt_Joueur1.Size = new System.Drawing.Size(324, 39);
            this.txt_Joueur1.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 320);
            this.Controls.Add(this.btn_CommencerPartie);
            this.Controls.Add(this.lbl_TitreJeu);
            this.Controls.Add(this.lbl_Joueur2);
            this.Controls.Add(this.lbl_Joueur1);
            this.Controls.Add(this.txt_Joueur2);
            this.Controls.Add(this.txt_Joueur1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_CommencerPartie;
        private Label lbl_TitreJeu;
        private Label lbl_Joueur2;
        private Label lbl_Joueur1;
        private TextBox txt_Joueur2;
        private TextBox txt_Joueur1;
        private ErrorProvider errorProvider1;
    }
}