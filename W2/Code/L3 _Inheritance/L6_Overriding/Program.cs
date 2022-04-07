using System;

namespace L6_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaOfShapes areaSquare = new AreaOfShapes();
            double a = 10.00;
            double b = 10.00;
            double area = 0.0;
            area = areaSquare.Square(a, b);
            Console.WriteLine("Area of square : {0}", area);
            Console.ReadLine();
        }
    }
}
