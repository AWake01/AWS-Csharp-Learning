//Alexander Wake
//22-04-2022
//Hangman game
//--------------

using System;

namespace Hangman
{
    class Program
    {
        //Declare word to find
        public static string secret = "hangman";
        public static char[] cSecret = secret.ToCharArray();

        //Store current users word with ? for missing letters
        public static string curWord = new string('?', secret.Length);
        public static char[] cWord = curWord.ToCharArray();

        public static string input = "";

        public static int guesses = 0;
        public static int maxGuesses = 8;

        //method to draw the word as a line of boxes
        public static void drawWord(char[] w)
        {
            for (int i = 0; i < secret.Length; i++)
            {
                char letter = w[i];

                Console.Write("[{0}]", letter);
            }

            Console.WriteLine("\n");
        }

        //Method to handle win condition
        public static void hasWon(bool win)
        {
            if (win)  
            {
                drawWord(cSecret);
                Console.WriteLine("\nYou win. You took {0} / {1} guesses.", guesses, maxGuesses);
            }
            else
            {
                Console.WriteLine("\nYou loose", guesses, maxGuesses);
                Console.WriteLine("The word was...");
                drawWord(cSecret);
            }

            //End of game
            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();
            Environment.Exit(0);
        }



        static void Main(string[] args)
        {     
            while (true)    //Main program loop
            {
                guesses += 1;   //Update guesses

                //Take guess input
                Console.Write("Guess {0} > Guess a letter or word: ", guesses);     
                input = Console.ReadLine();
                Console.WriteLine("\n");

                input = input.ToLower();    //Convert input to lowercase

                if (input != secret)    //Check if correct guess
                {
                    if (input.Length == 1 & secret.Contains(input))     //Check if secret contains the input
                    {
                        for (int c = 0; c < secret.Length; c++)  //Check for mathcing letters in secret
                        {
                            if (secret[c] == char.Parse(input)) //If letter matches, add to cWord
                            {
                                cWord[c] = char.Parse(input);
                            }
                        }                      
                    }
                    else  //Incorrect guess made
                    {
                        Console.WriteLine("Incorrect guess.");
                    }

                    if (secret == new string(cWord))     //Letter guess revealed word
                    {
                        hasWon(true);
                    }
                }
                else  //Triggered if last letter guess completed the word
                {
                    hasWon(true);   //Game is won    
                }

                if (guesses >= maxGuesses)  //Loose if out of guesses
                {
                    hasWon(false);
                }

                drawWord(cWord);    //Draw curent word
            }            
        }     
    }
}
