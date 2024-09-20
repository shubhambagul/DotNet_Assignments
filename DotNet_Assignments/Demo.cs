using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    class Demo
    {
        static void Main()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            string[] array = { "Alice", "Bob", "Charlie", "David", "Emily" };
            Console.WriteLine("Enter a name: ");

            // Check if the name is present in the array
            bool isPresent = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(name))
                {
                    isPresent = true;
                    break;
                }
            }
            // Output the result
            if (isPresent)
            {
                Console.WriteLine(name + " is present in the array.");
            }
            else
            {
                Console.WriteLine(name + " is not present in the array.");
            }
        }
    }
}
