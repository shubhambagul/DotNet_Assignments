using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DotNet_Assignments
{
    internal class LoopingStatements
    {
        static void Main()
        {
            int i = 1;
            Console.WriteLine("While loop");
            while (10 >= i)
            {
                Console.WriteLine(i++);
            }

            Console.WriteLine("Do While loop");
            int number = 1;
            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number <= 10);

            Console.WriteLine("For loop");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
