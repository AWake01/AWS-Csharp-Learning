using System;

namespace OOP_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = 0.0;
            Random r = new Random();
            Book b1 = new Book("joe");

            for (int i = 0; i < 10; i++)
            {
                grade = r.NextDouble() * (100 - 0);
                b1.AddGrade(Math.Round(grade, 2));   
            }

            b1.Calcstatistics();
        }
    }
}

