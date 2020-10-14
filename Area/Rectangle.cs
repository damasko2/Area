using Area_H;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Rectangle : Figure
    {
        double _side1;
        double _side2;

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public override double Area()
        {
            return _side1 * _side2;
        }

        public override string ToString()
        {
            return $"Прямоугольник \n S = {_side1} * {_side2} -> {Area()}";
        }
    }
}
