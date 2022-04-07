using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CalcForm
{
    public class Triangle : IShape
    {
        public double s1 { get; set; }
        public double s2 { get; set; }

        public double s3 { get; set; }       

        public double heronsArea()    //Herons Formula
        {
            double s = 0.0; //Parameter for semi perimeter
            double result = 0.0;

            s = (s1 + s2 + s3) / 2;     //Calcualte semi perimeter
            result = Math.Sqrt(s*(s - s1) * (s - s2) * (s - s3)); //Use herons formula when given three sides
            return result;
        }

        public double Area()
        {
            return 0.0;
        }

        public double Perimiter()
        {
            return s1 + s2 + s3;
        }
    }
}
