using System;

namespace P10_Next_Prime_number
{
    class P10
    {
        static void Main(string[] args)
        {
            int num = 0;
            int nxt = 0;
            bool res = false;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            nxt = num + 1; 

            while(!IsPrime(nxt))    //Loop till firs tprime found
            {
                nxt++;
            }

            Console.WriteLine($"\nThe next prime number after {num} is {nxt}");
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
