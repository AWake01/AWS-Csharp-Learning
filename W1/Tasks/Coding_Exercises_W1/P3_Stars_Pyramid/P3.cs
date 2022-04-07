/*•	Problem 4 Star - Diamond

Produce the following pattern on screen, using Arrays, ArrayList or StringBuilder

Star Diamond pattern
*/

using System;

namespace P3_Stars_Pyramid
{
    class P3
    {
        static void Main(string[] args)
        {
            int height = 0;
            int width = 0;
            string line = "";
            int stars = 1;
            int blanks = 0;

            Console.Write("Enter the height: ");
            height = Convert.ToInt32(Console.ReadLine());

            width = (height * 2) - 1;

            int count = 0;

            for(int x = 0; x < height; x++) //For each row...
            {
                blanks = (width - stars) / 2;


                for (int b = 0; b < blanks; b++) //print blanks
                {                
                    Console.Write(' ');
                }
                for (int s = 0; s < stars; s++) // Print stars
                {
                    Console.Write('*');
                }
                for (int b = 0; b < blanks; b++) // print blanks
                {
                    Console.Write(' ');
                }

                stars += 2; 
                blanks = 0;

                Console.WriteLine();
            }
        }
    }
}
