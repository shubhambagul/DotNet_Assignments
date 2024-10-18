using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    class CalculateBaseClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    sealed class CalculateDerivedClass : CalculateBaseClass
    {
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    internal class SealedClass
    {
        public static void Main()
        {
            CalculateDerivedClass obj = new CalculateDerivedClass();
            int addition = obj.Add(10, 20);
            Console.WriteLine(addition);
            int substraction = obj.Sub(40, 20);
            Console.WriteLine(substraction);

        }
    }
}
