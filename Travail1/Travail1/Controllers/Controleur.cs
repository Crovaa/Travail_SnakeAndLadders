using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models;
using Travail1.Models.Case;
using Travail1.Models.Point;

namespace Travail1.Controllers
{
    public class Controleur
    {
        private Case[] cases;
        private Joueur[] joueurs;
        private Joueur joueur;

        public Joueur[] Joueurs { get => joueurs; }
        public Joueur Joueur { get => joueur; }
        public string nomJoueur1;
        public string nomJoueur2;

        public EventHandler<Joueur> ChangementJoueurEvent;

        public Controleur(string nomJoueur1, string nomJoueur2)
        {
            
            InitialiserCases();
            InitialiserJoueurs(nomJoueur1,nomJoueur2);
        }

        private void InitialiserCases()
        {
            cases = new Case[64];
            for (int i = 0; i < cases.Length; i++)
            {
                cases[i] = new Case(new Points(0), i);
            }
        }

        private void InitialiserJoueurs(string nomJoueur1, string nomJoueur2)
        {
            joueurs = new Joueur[2];
            joueurs[0] = new Joueur(0, nomJoueur1, Color.Blue);
            joueurs[1] = new Joueur(1, nomJoueur2, Color.Red);
        }

        public void InitialiserInfoJoueurs()
        { 
            ChangementJoueurEvent?.Invoke(this,joueur);
        }
        public Bitmap DessinerPlancheJeu()
        {
            Bitmap bitmap = new Bitmap(801, 801);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                foreach (var uneCase in cases)
                {
                    uneCase.Dessiner(graphics);
                }
            }
            return bitmap;
        }
    }
}
