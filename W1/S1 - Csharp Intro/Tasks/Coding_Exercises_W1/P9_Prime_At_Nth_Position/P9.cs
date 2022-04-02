/*•	Problem 9 - Prime at Nth Position

Write an algorithm to return the prime number at Nth position from the sequence of prime numbers.

sequence of first 100 prime numbers: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 
*/

using System;
using System.Collections.Generic;

namespace P9_Prime_At_Nth_Position
{
    class P9
    {
        static void Main(string[] args)
        {
            //int[] seq = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            List<int> seq = new List<int>(); 
            int len = 0;
            int pos = 0;
            int num = 0;
            int nxt = 0;

            Console.Write("Enter a sequence length: ");
            len = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a position: ");
            pos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for(int i = 0; i < len; i++)
            {
                if (IsPrime(i))
                {
                    seq.Add(i);
                }
            }

            foreach (int n in seq)
            {
                Console.Write($"{n} ");
            }

            Console.WriteLine("\n\nThe prime number at {0} is {1}", pos, seq[pos - 1]);
            Console.WriteLine($"The next prime number after {num} is {nxt}");

            //for(int n = 0; n < 100; n++)
            //{           
            /*if(IsPrime(n))
            {
                Console.Write($"{n} ");
            }*/
            //}

            Console.ReadLine();
            Environment.Exit(1);
        }

        static bool IsPrime(int num) //Function to check for prime number
        {
            if (num <= 1)  //One is not a prime
            {
                return false;
            }

            for (int i = 2; i < num - 1; i++)
            {              
                if (num % i == 0) //Number is divisible by i, so is not a prime number
                {
                    return false;
                }
            }

            return true;
        }
    }
}
