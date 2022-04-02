using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum of sqaures
            Console.WriteLine("Do While loop");
            double sum = 0;
            double count = 0;
            do
            {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("Count: {0} sum: {1}", count, sum);
                count++;
            } while (count != 10);

            Console.WriteLine("\nWhile loop");
            sum = 0;
            count = 0;
            while (count != 10)
            {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("Count: {0} sum: {1}", count, sum);
                count++;
            }

            Console.WriteLine("\nFor loop");
            for(int i = 0; i <= 100; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nForeach loop");
            int[] number = { 2, 4, 6, 8, 10 };
            foreach(int val in number)
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }
    }
}
