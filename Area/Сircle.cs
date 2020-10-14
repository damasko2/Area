using Area_H;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area 
{
    class Circle : Figure
    {
        double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return 3.14 * (_radius * _radius);
        }

        public override string ToString()
        {
            return $"Круг \n S = 3.14 * ({_radius} * {_radius}) -> {Area()}";
        }
    }
}
