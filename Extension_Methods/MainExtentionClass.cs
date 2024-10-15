using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    internal class MainExtentionClass
    {
        static void Main()
        {
            Exesting_Extension obj = new Exesting_Extension();
            obj.Addition();
            obj.Substraction();
            obj.Multiplication(10, 5);
            obj.Division(100, 5);
        }
    }
}
