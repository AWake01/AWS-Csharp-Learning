using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course
{
    class Book
    {
       public Book(string name)
       {
            grades = new List<double>();
            this.name = name;
       }

       public List<double> grades;
       private string name;

       public void AddGrade(double g)
       {
           this.grades.Add(g); 
       }

       public void Calcstatistics()
       {

            double grade = 0.0;
            double result = 0.0;
            double highGrade = 0.0;
            double lowGrade = 0.0;

            foreach (double g in grades)
            {
                Console.WriteLine(g);
                highGrade = Math.Max(g, highGrade);
                lowGrade = Math.Min(g, lowGrade);
                result += grade;
            }

            Console.WriteLine($"\nThe average grade is {result:N1}");
            Console.WriteLine($"\nThe highest grade is {highGrade:N1}");
            Console.WriteLine($"\nThe lowest grade is {lowGrade:N1}");
        }
    }
}
