using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class Break_Statement
    {
        static void Main()
        {
            int rem = 0;
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter the number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    break;
                }
                sum = sum + num;

            }
            Console.WriteLine("Addition of positive numbers " + sum);
        }
    }
}
