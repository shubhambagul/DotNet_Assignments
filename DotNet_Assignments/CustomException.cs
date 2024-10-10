using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class NegativeNumberException : Exception
    {
        public NegativeNumberException(string? message) : base(message)
        {
        }
    }
    internal class CustomException
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter possitive number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    throw new NegativeNumberException("Negative number are not allowed");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }



}
