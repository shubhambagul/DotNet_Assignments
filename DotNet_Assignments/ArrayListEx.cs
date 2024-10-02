using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class ArrayListEx
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add("Hello");
            al.Add(10.5);
            al.Add('S');
            al.Add(30);
            al.Add(9764904458);
            al.Add(40);
            al.Add(false);
            al.Add(50);
            Console.WriteLine("Total Elements of ArrayList");
            foreach (var items in al)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("Removed the Elements Within ArrayList ");

            al.Remove(false);
            al.RemoveAt(3);
            al.Reverse();
            foreach (var items in al)
            {
                Console.WriteLine(items);
            }
        }
    }
}
