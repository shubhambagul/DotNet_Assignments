using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class DictionaryExample
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Rahul", 23);
            dict.Add("Tushar", 25);
            dict.Add("Prajwal", 15);
            dict.Add("Dipak", 27);
            dict.Add("Mayur", 19);
            dict.Add("Darshan", 21);
            dict.Add("Dhiraj", 22);
            dict.Add("Siddharth", 26);
            dict.Add("Kalpesh", 27);
            dict.Add("Prasad", 26);
            Console.WriteLine("Total Elements from Dictionary");
            foreach(KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"Key is : {kvp.Key}, Value is : {kvp.Value}");
            }
            dict["Tushar"] = 32;
            dict["Mayur"] = 33;
            Console.WriteLine();
            Console.WriteLine("After Modified Elements from Dictionary");
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"Key is : {kvp.Key}, Value is : {kvp.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Removed the specific Elements from Dictionary");
            dict.Remove("Prajwal");
            dict.Remove("Darshan");
            dict.Remove("Kalpesh");
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"Key is : {kvp.Key}, Value is : {kvp.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Filter the  Elements from Dictionary");
            if (dict.ContainsKey("Dhiraj")){
                Console.WriteLine("Name is exist in dictionary");
            }
            dict.Clear();
            Console.WriteLine("Total count of elements : "+dict.Count);
        }
    }
}
