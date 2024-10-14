using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    internal class GenericDelegates_Action2
    {
        public static void ErrorMsgWithTime(string msg)
        {
            string str = $"Error Message is {msg} : by date {DateTime.Now}";
            Console.WriteLine(str);
        }
        static void Main()
        {
            Action<string> obj = ErrorMsgWithTime;
            obj.Invoke("An unexpected error occured");
        }
    }
}
