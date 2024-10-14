using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    internal class GenericDelegates_Actions
    {
        public static void DisplayMessage(string str)
        {
            Console.WriteLine(str);
        }
        static void Main()
        {
            Action<string> obj = DisplayMessage;
            obj.Invoke("Codemind Technology");
        }
    }
}
