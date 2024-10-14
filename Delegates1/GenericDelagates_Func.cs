using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    internal class GenericDelagates_Func
    {
        public static string Concatenates(string s1, string s2, string s3)
        {
            string str = s1.ToString() + s2.ToString() + s3.ToString();
            return str;
        }
        static void Main()
        {

            Func<string, string, string, string> obj = Concatenates;
            string strConcatenation = obj.Invoke("Hello", " ", "World");
            Console.WriteLine(strConcatenation);
        }
    }
}
