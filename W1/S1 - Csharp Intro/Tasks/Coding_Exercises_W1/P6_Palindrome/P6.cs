/*•	Problem 6 - palindrome

Write an algorithm to find a palindrome
•input: madam, output: Palindrome
•input: step on no pets, output: Palindrome
•input: book, output: Not Palindrome
*/

using System;

namespace P6_Palindrome
{
    class P6
    {
        static void Main(string[] args)
        {
            string word = "";
            string reverse = "";

            Console.Write("Enter a word: ");
            word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--) //Loop through characters from end of word
            {
                reverse += word[i]; //Add character to reverse string
            }

            if(reverse == word)
            {
                Console.WriteLine("{0} is a palindrome.", word);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome.", word);
            }

            Console.ReadLine();
        }
    }
}
