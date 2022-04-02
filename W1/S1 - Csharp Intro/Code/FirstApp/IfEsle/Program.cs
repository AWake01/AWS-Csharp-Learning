using System;

namespace IfEsle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;

            while (true)
            { 

                Console.Write("Enter first number: ");
                firstNumber = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter second number: ");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (firstNumber > secondNumber)
                {
                    Console.WriteLine("First number is larger than the second number");
                }
                else if (firstNumber == secondNumber)
                {
                    Console.WriteLine("First number equals the second number");
                }
                else
                {
                    Console.WriteLine("Second number is greater than the first number");
                }

                Console.WriteLine();
            }
        }
    }
}
