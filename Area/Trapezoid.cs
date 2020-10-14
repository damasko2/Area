using Area_H;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Trapezoid : Figure
    {
        double _baseT1;
        double _baseT2;
        double _height;

        public Trapezoid(double base1, double base2, double height)
        {
            _baseT1 = base1;
            _baseT2 = base2;
            _height = height;
        }

        public override double Area()
        {
            return (_baseT1 + _baseT2) / 2 * _height;
        }

        public override string ToString()
        {
            return $"Трапеция \n S = ({_baseT1} + {_baseT2}) / 2 * {_height} -> {Area()}";
        }
    }
}
