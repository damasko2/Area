using Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_H
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figure = { new Rectangle(2, 6), 
                                new Circle(2),
                                new Triangle(3, 4),
                                new RightTriangle(3, 4),
                                new Trapezoid(2, 4, 6)};

            for (int i = 0; i < figure.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(figure[i].ToString());
            }
            Console.WriteLine();
        }
    }
}
