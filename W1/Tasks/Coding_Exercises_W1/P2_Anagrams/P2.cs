/*•	Problem 2 - Anagrams
From the following dictionary of words
"parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray"
return all words that are an anagram of star (no leftover letters allowed).
*/

using System;

namespace P2_Anagrams
{
    class P2
    {      
        static void Main(string[] args)
        {
            string word = "traps";
            string[] words = new string[] { "parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray" };

            foreach (string w in words)
            {
                string temp = word;

                if (w.Length > word.Length) //Check if word is longer than target word
                {
                    continue;
                }
                else
                {
                    int count = 0; 

                    foreach (char c in w) //Check each letter in current word
                    {
                        if (temp.Contains(c)) //If present in target word
                        {
                            temp = temp.Replace(c.ToString(), String.Empty); //Remove c from temp word
                            count++; 
                        }
                    }

                    if(count == word.Length) //If all characters in target word have been used the current is an anagram
                    {
                        Console.WriteLine($"{w} is an anagram of {word}");
                        count = 0;
                    }
                }
            }

            Console.ReadLine();
        }
    }   
}
