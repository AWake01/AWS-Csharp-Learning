using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Rectangle : Shape
    {
        double height;
        double width;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public double Area()
        {
            return width * height;
        }

        public double Perimiter()
        {
            return width*2 + height*2;
        }
    }
}
