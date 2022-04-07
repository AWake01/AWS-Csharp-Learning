/*•	Problem 8 - TwoSums

Two Sums
Write a function that, when passed a list and a target sum, returns, efficiently with respect to time used, two distinct zero-based indices of any two of the numbers, whose sum is equal to the target sum. If there are no two numbers, the function should return null.

For example, FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10) should return a Tuple<int, int> containing any of the following pairs of indices:
•0 and 3 (or 3 and 0) as 3 + 7 = 10
•1 and 5 (or 5 and 1) as 1 + 9 = 10
•2 and 4 (or 4 and 2) as 5 + 5 = 10
*/

using System;
using System.Collections.Generic;

namespace P8_Two_Sums
{
    class P8
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 1, 5, 7, 5, 9 };
            int target = 16;
            (int, int) result = FindTwoSum(numbers, target); //Run FindTwoSum function

            Console.WriteLine($"\nIndex {result.Item1}({numbers[result.Item1]}) + index {result.Item2}({numbers[result.Item2]}) equals {target}");
            Console.ReadLine();
        }

        static (int, int) FindTwoSum(List<int> numbers, int target) //Declare function to find indexes of the two numbers that make the target sum
        {
            //Caribles to store indexes and numbers
            int i1 = 0;
            int i2 = 0;
            int n1 = 0;
            int n2 = 0;

            (int, int) result = (0, 0); //Store result as a tupple

            for (int i = 0; i < numbers.Count; i++) //Loop through each number
            {
                n1 = numbers[i]; //Store current n1

                for (int n = i + 1; n < numbers.Count; n++) //loop trough each number after current numebr
                {
                    n2 = numbers[n]; //Store current n2

                    if (n1 + n2 == target)  //Check if sum is made
                    {
                        //Store cueent index of n1 and n2
                        i1 = i;
                        i2 = n;

                        result = (i1, i2); 
                        break; 
                    } 
                }

                if(result != (0, 0)) //Check if target numebr has been found (result tupple is not 0,0)
                {
                    break;
                }               
            }

            return result; //Retrun result tupple
        }
    }
}
