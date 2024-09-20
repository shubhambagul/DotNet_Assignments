using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class Find_Grade
    {
        static void Main()
        {
            Console.WriteLine("Enter the number  between 0 to 100");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 75)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (grade >= 50)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (grade >= 40)
            {
                Console.WriteLine("Your grade is D");
            }
            else if (grade >= 35)
            {
                Console.WriteLine("Your grade is E");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
