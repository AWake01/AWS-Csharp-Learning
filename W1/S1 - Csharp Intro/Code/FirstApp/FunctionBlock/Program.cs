using System;

namespace FunctionBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            //Functuion to add two numbers
            int a = 5;
            int b = 4;
            int sum = 0;
            int square = 0;

            sum = Add(a, b);
            square = Sqr(a);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("Square = {0}", square);
            Console.ReadLine();
        }

        //Function to add two numbers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        //Function to return square
        public static int Sqr(int a)
        {
            return a *= a;
        }
    }
}
