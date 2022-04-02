using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instatiate class and create an object
            Calculator calc = new Calculator();
            //Create a local varible to hold the answer
            int x = 3;
            int y = 5;
            int num = 0;

            num = calc.Add(x, y);
            Console.WriteLine("{0} + {1} = {2}", x, y, num);
            num = calc.Sub(x, y);
            Console.WriteLine("{0} - {1} = {2}", x, y, num);
            num = calc.Mul(x, y);
            Console.WriteLine("{0} * {1} = {2}", x, y, num);
            num = calc.Div(x, y);
            Console.WriteLine("{0} / {1} = {2}", x, y, num);
            Console.ReadLine();
        }
    }
}
