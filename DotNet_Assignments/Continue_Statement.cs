using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class Continue_Statement
    {
        static void Main()
        {
            int num = 20;
            Console.WriteLine("Print only those numbers to divided by 3");
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 != 0)
                {
                    continue;
                }


                Console.WriteLine(i);
            }
        }
    }
}
