using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    internal class MainExtentionClass
    {
        static void Main() {
            Exesting_Extension obj = new Exesting_Extension();
            obj.Addition(10,20,30);
            obj.Substraction(100, 50);
            obj.Multiplication(10, 5);
            obj.Division(100, 5);
        }
    }
}
