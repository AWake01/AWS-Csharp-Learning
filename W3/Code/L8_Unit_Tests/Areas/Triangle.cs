using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Triangle
    {
        double side1;
        double side2;
        double side3;

        public Triangle(double s1, double s2, double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public double Area()
        {
            double s = (side1 + side2 + side3) / 2;

            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public double Perimiter()
        {
            return side1 + side2 + side3;
        }
    }
}
