using System;

namespace P4_Diamond
{
    class P4
    {
        static void Main(string[] args)
        {
            int height = 0;
            int dHeight = 0;
            int width = 0;
            string line = "";
            int stars = 1;
            int blanks = 0;

            Console.Write("Enter the height: ");
            height = Convert.ToInt32(Console.ReadLine());

            width = (height * 2) - 1;
            dHeight = height * 2;

            for (int h = 0; h <= dHeight; h++) //For each row...
            {
                blanks = (width - stars) / 2;

                //Construct the new line in a blank > star > blank pattern
                for (int b = 0; b < blanks; b++) //print blanks
                {
                    //Console.Write(' ');
                    line += " ";
                }
                for (int s = 0; s < stars; s++) // Print stars
                {
                    //Console.Write('*');
                    line += '*';
                }
                for (int b = 0; b < blanks; b++) // print blanks
                {
                    //Console.Write(' ');
                    line += " ";
                }

                if(h < height - 1)  //if less than half way down expand
                {
                    stars += 2;
                }
                else //Fi greater than halfway down contract
                {
                    stars -= 2;
                }

                blanks = 0;

                Console.WriteLine(line);
                line = "";
            }

            Console.ReadLine();
        } 
    }
}
