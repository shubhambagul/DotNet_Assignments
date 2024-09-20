using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class goto_Statement
    {
        static void Main()
        {
        validAge:
            Console.WriteLine("Insert your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (120 > age && 0 < age)
            {
                goto validAge;
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("Age is not valid");
            }

        }
    }
}
