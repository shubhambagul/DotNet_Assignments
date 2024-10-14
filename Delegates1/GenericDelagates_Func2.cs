using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    internal class GenericDelagates_Func2
    {
        public static string CheckNumber(int num)
        {
            if (num > 0)
            {
                return "Number is possitive";
            }
            else if (num < 0)
            {
                return "Number is Negative";
            }
            else
            {
                return "Number is zero";
            }
        }
        static void Main()
        {
            Func<int, string> obj = CheckNumber;
            string result = obj.Invoke(0);
            Console.WriteLine(result);

        }
    }
}
