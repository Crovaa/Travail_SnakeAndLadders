using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models.Point
{
    public class PointsDouble : Points
    {
        Random random;
        int nombreGenerer;
        public PointsDouble(int valeur) : base(valeur)
        {
            DoublerPoints(valeur);
        }

        public int DoublerPoints(int valeur)
        {
            random = new Random();
            nombreGenerer = random.Next(0, 2);
            if (nombreGenerer == 0)
            {
                valeur = valeur + nombreGenerer;
            }
            else
            {
                valeur = valeur * 2;
            }
            return valeur;
        }

          

    }
}
