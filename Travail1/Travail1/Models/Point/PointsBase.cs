using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail1.Models.Point
{
    public class PointsBase : Points
    {
        public PointsBase(int valeur) : base(valeur)
        {
            valeur++;
        }
    }
}
