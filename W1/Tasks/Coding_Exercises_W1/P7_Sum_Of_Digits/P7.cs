/*•	Problem 7 - Sum of digits

Write an algorithm to sum the digits of a number:
Input 12: output 3
Input 123 : output 6
Input 5000: output 5
*/

using System;

namespace P7_Sum_Of_Digits
{
    class P7
    {
        static void Main(string[] args)
        {
            int number = 0;
            string ns = "";
            int sum = 0;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            ns = number.ToString();

            foreach(char i in ns)
            {
                sum += (int)Char.GetNumericValue(i);
            }

            Console.WriteLine($"The sum is {sum}");
            Console.ReadLine();
        }
    }
}
