using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier_Demo
{
    internal class Array
    {
        static void Main()
        {
        //Print alternate elements of array
            int[] array = { 10, 2, 31, 7, 8, 4, 9, 8, 11, 12 };
            Console.Write("Print alternate elements of array = ");
            for (int i = 0; i < array.Length; i += 2)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        //Find length of array
            Console.WriteLine("Number of elements in the array: " + array.Length);

        //Minimum value in the array
            int[] arrays = { 10, 2, 3, 7, 8, 4, 9, 8, 11, 12 };
            int min = arrays[0];

            for (int i = 1; i < arrays.Length; i++)
            {
                if (arrays[i] < min)
                {
                    min = arrays[i];
                }
            }
            Console.WriteLine("Minimum value of array is " + min);

        //Maximum value in the array
            int[] arraymax = { 10, 2, 31, 7, 8, 4, 9, 8, 11, 12 };
            int max = arrays[0];

            for (int i = 1; i < arraymax.Length; i++)
            {
                if (arraymax[i] > max)
                {
                    max = arraymax[i];
                }
            }
            Console.WriteLine("Maximum value of array is " + max);
        }
    }
}
