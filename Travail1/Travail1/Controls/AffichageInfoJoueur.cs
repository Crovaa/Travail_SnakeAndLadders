using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travail1.Models;

namespace Travail1.Controls
{
    public partial class AffichageInfoJoueur : UserControl
    {
        public Joueur joueur;

        public Joueur Joueur
        {
            get => joueur;
            set
            {
                joueur = value;
                AfficherInfoJoueur();
            }
        }
        public AffichageInfoJoueur()
        {
            InitializeComponent();
        }

        public void AfficherInfoJoueur()
        {
            if (joueur is null)
            {
                lbl_NomJoueur.Text = "";
                lbl_PointTotalJoueur.Text = "";
                return;
            }
            lbl_NomJoueur.Text = joueur.Nom;
            lbl_PointTotalJoueur.Text = joueur.Points.ToString();
        }
    }
}
