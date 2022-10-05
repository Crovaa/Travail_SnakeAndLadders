using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    public class CaseTrappe : Case
    {
        Random random;
        int nombreCase;
        public CaseTrappe(PointsNegatif points, int position) : base(points, position)
        {
            position = position - ActionCase();
            points.ObtenirPoints();
        }

        public int ActionCase()
        {
            random = new Random();
            nombreCase = random.Next(5, 11);
            return nombreCase;
        }
    }
}
