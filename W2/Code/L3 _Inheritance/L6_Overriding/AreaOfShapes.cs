using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_Overriding
{
    class AreaOfShapes : AreaOfSquare
    {
        public double Rectange(double a, double b)
        {
            return a * b;
        }

        //Overides the square method in are of square
        public override double Square(double a, double b)
        {
            //Return area of square with a diffent implementation
            Console.WriteLine("Area of shapes called square a*b");
            return a * b;
        }
    }
}
