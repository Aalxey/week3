using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
    internal class Operator
    {
        int a = 10;
        int b = 5;

        public void add()
        {
            Console.WriteLine(a + b);
        }

        public void subtract()
        {
            Console.WriteLine(a - b);
        }

        public void multiply()
        {
            Console.WriteLine(a * b);
        }

        public void divide()
        {
            Console.WriteLine(a / b);
        }

        public void OddEvenFinder(int number)
        {
            String output = (number % 2 == 0) ? "Even number" : "Odd number";
            Console.WriteLine(output);
        }
    }
}
