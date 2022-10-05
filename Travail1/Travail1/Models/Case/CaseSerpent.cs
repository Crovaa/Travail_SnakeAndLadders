using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail1.Models.Point;

namespace Travail1.Models.Case
{
    public class CaseSerpent : Case
    {
        Random random;
        int nombreCase;
        public CaseSerpent(Points points, int position) : base(points, position)
        {
            position = position - ActionCase();
        }

        public int ActionCase()
        {
            random = new Random();
            nombreCase = random.Next(5, 11);
            return nombreCase;
        }
    }
}
