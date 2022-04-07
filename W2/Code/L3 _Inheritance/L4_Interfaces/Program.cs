using System;

namespace L4_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();

            double a = 10;
            double b = 20;
            double c = 1.0;
            double area = 0.0;
            double perimeter = 0.0;

            rectangle.height = a;
            rectangle.width = b;
            area = rectangle.Area();
            Console.WriteLine("Rectange area and perimeter");
            Console.WriteLine("Area of rectange is: {0:F}", area);
            perimeter = rectangle.Perimiter();
            Console.WriteLine("Perimiter of rectange is: {0:F}", perimeter);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Circle area and perimeter");
            circle.radius = c;
            Console.WriteLine("Area of circle is : {0:F}", area);
            perimeter = circle.Perimiter();
            Console.WriteLine("Perimeter of circle is : {0:F}", perimeter);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Triangle area");
            triangle.height = a;
            triangle.width = b;
            area = triangle.Area();
            Console.WriteLine("Area of triangle is : {0:F}", area);

            Console.ReadLine();
        }
    }
}
