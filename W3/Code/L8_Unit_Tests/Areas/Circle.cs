using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Circle : Shape
    {
        double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Perimiter()
        {
            return Math.PI * (radius * 2);
        }
    }
}
