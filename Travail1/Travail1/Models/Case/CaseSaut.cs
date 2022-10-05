using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    public class CaseSaut : Case
    {
        Random random;
        int nombreCase;
        public CaseSaut(PointsDouble points, int position) : base(points, position)
        {
            position = position + ActionCase();
        }

        public int ActionCase()
        {
            random = new Random();
            nombreCase = random.Next(1, 4);
            return nombreCase;
        }
    }
}
