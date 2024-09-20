using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class For_EachLoop
    {
        static void Main()
        {
            string[] arr = { "Apple", "Samsung", "Xiaomi", "Oppo", "Nokia",
                "Motorola", "Vivo", "OnePlus", "POCO", "Mi", };
            Console.WriteLine("Top 10 mobile brand list");
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
        }
    }
}
