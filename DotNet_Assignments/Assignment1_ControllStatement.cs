using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class Assignment1_ControllStatement
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("The number is possitive");
            }
            else if (num < 0) {
                Console.WriteLine("The number is negative");

            }
            else {
                Console.WriteLine("The number is zero");
            }
        }
    }
}
