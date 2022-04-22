using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayList
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age{ get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            Random r = new Random();

            for(int i = 0; i < 10; i++)
            {
                int num = r.Next(0,100);
                numbers.Add(num);
            }
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Average of random numbers is: {0}", numbers.Average());
            numbers.Insert(10, 0);
            var index = numbers.IndexOf(0);
            Console.WriteLine("Index of position 0 is {0}", index);

            var count = numbers.Count();
            Console.WriteLine("count is: {0}", count);
            Console.WriteLine("-----------------"); 
            Console.WriteLine("Collections using List of objects");

            var student = new List<Person>
            {
                new Person(){FirstName="Joe",LastName="Bloggs",age=23},
                new Person(){FirstName="Steve",LastName="May",age=23},
                new Person(){FirstName="Jack",LastName="Jones",age=23},
                new Person(){FirstName="Tom",LastName="Jones",age=23}
            };
            Console.WriteLine("number of objects is: {0}", student.Count());

            foreach (var s in student)    
            {
                Console.WriteLine(s.FirstName);
                Console.WriteLine(s.LastName); 
                Console.WriteLine(s.age);
                Console.WriteLine("--------------------");
            }
            Console.ReadLine();
        }
    }
}
