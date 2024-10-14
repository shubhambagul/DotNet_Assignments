using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    internal class GenericDelegates_Predicate
    {
        public static bool checkStringStartWithSpecificChar(string str)
        {
            if (str.ToUpper().StartsWith('S') || str.ToLower().StartsWith('s') == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            Predicate<string> obj = checkStringStartWithSpecificChar;
            bool result = obj.Invoke("shubham");
            Console.WriteLine(result);
        }
    }
}
