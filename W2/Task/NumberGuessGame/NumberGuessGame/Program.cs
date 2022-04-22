using System;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 50;
            int guess = 0;
            int count = 1;

            while(count <= 6)
            {
                Console.Write("Guess {0}: ", count);             
                guess = Convert.ToInt32(Console.ReadLine());

                if(guess == number)
                {
                    Console.WriteLine("You win!");
                    Console.WriteLine("You took {0} guesses", count);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if(guess > number)
                {
                    Console.WriteLine("Number is lower than {0}\n", guess);
                }
                else
                {
                    Console.WriteLine("Number is higher than {0}\n", guess);
                }

                count++;
            }

            Console.WriteLine("You loose!");
            Console.WriteLine("The number is {0}\n", guess);
            Console.ReadLine();
        }
    }
}
