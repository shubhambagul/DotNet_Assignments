using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class Switch_Statement
    {
        static void Main()
        {
            Console.WriteLine("*************Menu***************");
            Console.WriteLine("1-Burger, 2-Pizza, 3-Salad");
            Console.WriteLine("Enter your choise");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("You choose burger and price is 180");
                    break;
                case 2:
                    Console.WriteLine("You choose pizza and price is 350");
                    break;
                case 3:
                    Console.WriteLine("You choose salad and price is 250");
                    break;

                default: Console.WriteLine("Your choice are not available");
                    break;
            }
        }
    }
}
