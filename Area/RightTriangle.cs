using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class RightTriangle : Triangle
    {
        public RightTriangle(double baseT, double heightT) : base(baseT, heightT)
        {
        }

        public override double Area()
        {
            return base.Area();
        }

        public override string ToString()
        {
            return $"Прямоугольный { base.ToString()}";
        }
    }
}
