using Area_H;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Triangle :Figure
    {
        double _baseT;
        double _heightT;

        public Triangle(double baseT, double heightT)
        {
            _baseT = baseT;
            _heightT = heightT;
        }

        public override double Area()
        {
            return 0.5 * _baseT * _heightT;
        }

        public override string ToString()
        {
            return $"Треугольник \n S = 0.5 * {_baseT} * {_heightT} -> {Area()}";
        }
    }
}
