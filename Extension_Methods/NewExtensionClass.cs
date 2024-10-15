using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    static class NewExtensionClass
    {
        public static void Substraction (this Exesting_Extension o, int a, int b)
        {
            int sub = a - b;
            Console.WriteLine ("Substraction of two digit = "+sub);
        }
        public static void Multiplication(this Exesting_Extension o, int a, int b)
        {
            int multi = a * b;
            Console.WriteLine("Multiplication of two digit = " + multi);
        }
        public static void Division(this Exesting_Extension o, int a, int b)
        {
            int div = a / b;
            Console.WriteLine("Division of two digit = " + div);
        }
    }
}
