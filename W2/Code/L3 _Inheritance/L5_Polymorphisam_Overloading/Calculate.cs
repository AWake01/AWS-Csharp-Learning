using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Polymorphisam_Overloading
{
    class Calculate : Arithmetic
    {
        public float Add(float a, float b)
        {
            Console.WriteLine("Add floats called");
            return a + b;
        }
        public string Add(string a, string b)
        {
            Console.WriteLine("Add string called");
            return a + b;
        }
    }
}
