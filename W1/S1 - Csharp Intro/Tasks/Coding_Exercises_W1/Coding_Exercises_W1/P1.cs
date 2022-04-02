/*•	Problem 1 - Longest Sequence
The following string contains number of sales made per day in a month:
"1,2,1,1,0,3,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0"
How long is the longest sequence of days without a sale? (in this example it's 4).
*/

using System;


namespace Coding_Exercises_W1
{
    class P1
    {       
        static void Main(string[] args)
        {
            int[] days = new int[] { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0 , 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };
            int longest = 0;
            int count = 0;

            foreach (int d in days) //Iterate days
            {
                if (d == 0) //If day has no sales increase count
                {
                    count++;   
                }
                else 
                {
                    if (count > longest)  //Check current count against longest, if higher update longest  
                    {
                        longest = count;
                        count = 0;
                    }
                }
            }

            Console.WriteLine("The longest no-sale period is: {0}", longest);
            Console.ReadLine();
        }
    }
}
