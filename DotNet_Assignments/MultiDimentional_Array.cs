using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class MultiDimentional_Array
    {
        static void Main()
        {
            int[,] array = new int[,]
            {
            { 1,2,3},
            { 4,5,6},
            { 7,8,9}
            };
            Console.WriteLine("Element at (0,1)" + array[0, 1]);
            Console.WriteLine("Element at (1,2)" + array[1, 2]);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
