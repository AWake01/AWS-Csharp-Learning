using System;
using System.Collections.Generic;

namespace L7_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list of strings
            var names = new List<string>();
            names.Add("Joe");
            names.Add("Bob");
            names.Add("Jack");
            names.Add("Steve");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------------");
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var num in numbers)
            {
                if(num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadLine();
        }
    }
}
