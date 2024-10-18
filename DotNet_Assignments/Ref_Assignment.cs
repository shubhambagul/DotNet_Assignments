using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    class Ref_Assignment
    {
        public static void IncreamentValue(ref int value) {
            value++;
        }
        public static void Main() {
            int num = 10;
            Console.WriteLine($"Before increament value : {num}");
            IncreamentValue(ref num);
            Console.WriteLine($"After increament value : {num}");
        } 
    }
}
