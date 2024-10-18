using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class Out_Keyword_Assignment
    {
        public static void InitializeValues(out int number, out string name)
        {
            number = 10;
            name = "hello";
        }
        public static void Main()
        {
            int value;
            string text;
            InitializeValues(out value, out text);
            Console.WriteLine(text);
            Console.WriteLine(value);
        }
    }
}
