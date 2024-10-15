using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    internal class Exesting_Extension
    {
        public int a = 10, b = 20, c = 30;

        public void Addition()
        {
            int sum = a + b + c;
            Console.WriteLine("Sum of three number = " + sum);
        }
    }
}
