using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class Jagged_Array
    {
        static void Main()
        {
            int[][] arr = new int[][]
            {
            new int []{1,2 },
            new int[]{3,4,5,6 },
            new int[]{7,8,9 }
            };
            Console.WriteLine(arr[1][2]);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i] [j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
