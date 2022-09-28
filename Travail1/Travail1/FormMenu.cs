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

namespace Travail1
{
    public partial class FormMenu : Form
    {
        FormJeu formJeu;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_CommencerPartie_Click(object sender, EventArgs e)
        {
            if (DeuxNomDeJoueurEntre() == true)
            {
                this.Hide();
                formJeu = new FormJeu(txt_Joueur1.Text, txt_Joueur2.Text);
                formJeu.Closed += (s, args) => this.Close();
                formJeu.Show();
            }

        }

        private bool DeuxNomDeJoueurEntre()
        {
            bool verifierTextBox = false;
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                if (txt_Joueur1.Text == "" || txt_Joueur2.Text == "")
                {
                    errorProvider1.SetError(txt, "Entrer un nom de joueur");
                    verifierTextBox = false;
                }
                else
                {
                    errorProvider1.SetError(txt, String.Empty);
                    verifierTextBox = true;
                }
            }
            return verifierTextBox;

        }
    }
}
