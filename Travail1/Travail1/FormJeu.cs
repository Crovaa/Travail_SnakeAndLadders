using Travail1.Controllers;
using Travail1.Controls;
using Travail1.Models;

namespace Travail1
{
    public partial class FormJeu : Form
    {
        private Controleur controleur;
        private AffichageJoueur[] affichageJoueurs;

        public FormJeu(string nomJoueur1, string nomJoueur2)
        {
            InitializeComponent();
            controleur = new Controleur(nomJoueur1,nomJoueur2);
            picPlancheJeu.Image = controleur.DessinerPlancheJeu();
            InitAffichageJoueurs();
            MAJAfficherJoueur(controleur.Joueur);
            InitAffichageInfoJoueur();
            Abonnement();
        }
        private void InitAffichageJoueurs()
        {
            affichageJoueurs = new AffichageJoueur[controleur.Joueurs.Length];
            for (int i = 0; i < controleur.Joueurs.Length; ++i)
            {
                affichageJoueurs[i] = new AffichageJoueur(controleur.Joueurs[i]);
            }
            picPlancheJeu.Controls.Add(affichageJoueurs[0]);
            for (int i = 1; i < affichageJoueurs.Length; ++i)
            {
                affichageJoueurs[i - 1].Controls.Add(affichageJoueurs[i]);
            }
        }

        private void Abonnement()
        {
            controleur.ChangementJoueurEvent += Controleur_ChangementJoueurEvent;
        }

        private void Controleur_ChangementJoueurEvent(object? sender, Joueur joueur)
        {
            MAJAfficherJoueur(joueur);
        }

        private void MAJAfficherJoueur(Joueur joueur)
        {
            affichageInfoJoueur1.Joueur = controleur.Joueurs[0];
            affichageInfoJoueur2.Joueur = controleur.Joueurs[1];
        }

        private void InitAffichageInfoJoueur()
        {
            controleur.InitialiserInfoJoueurs();
            lbl_JoueurCourant.Text = controleur.Joueurs[0].Nom;
        }
    }
}