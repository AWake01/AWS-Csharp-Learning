using System;
using System.Collections.Generic;

namespace L1_Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            int highest = 0;
            int number = 0;
            int total = 0;
            Random r = new Random();

            List<int> grades = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                number = r.Next(0,100);
                grades.Add(number);
            }
            for (int i = 0; i< grades.Count; i++)
            {
                int grade = grades[i];
                Console.WriteLine("Grade [{0}] = {1}", i, grade);
                if(grade > highest)
                {
                    highest = grade;
                }

                total += grade;
            }

            double average = total / grades.Count;
            Console.WriteLine("\nMaximum grade is: " + highest);
            Console.WriteLine("Average grade is: {0}", average);
        }
    }
}
