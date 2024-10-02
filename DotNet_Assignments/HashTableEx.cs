using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class HashTableEx
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(101, "Hello");
            ht.Add(102, 10.5);
            ht.Add(103, 'S');
            ht.Add(104, false);
            ht.Add(105, 1000);
            Console.WriteLine("Before Removing Elements Of Hashtable ");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            }
            ht.Remove(102);
            ht.Remove(104);
            Console.WriteLine("After Removing Elements Of Hashtable ");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            }

        }
    }
}
