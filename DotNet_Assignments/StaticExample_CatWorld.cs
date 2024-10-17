using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    static class Catworld
    {
        public static int NumberOfCats { get; private set; }
        public static int TotalCatNaps { get; private set; }

        static Catworld()
        {
            NumberOfCats = 10;
        }
        public static void AddCat()
        {
            NumberOfCats++;
            Console.WriteLine($"New cat is joined, Available cats are {NumberOfCats}");
        }
        public static void AddCatNaps(int naps)
        {
            TotalCatNaps += naps;
            Console.WriteLine($"Added {naps} cat naps, Total cat naps available now {TotalCatNaps}");
        }

    }
    class StaticExample_CatWorld
    {
        public static void Main()
        {
            Catworld.AddCat();
            Catworld.AddCat();
            Catworld.AddCatNaps(10);
            Catworld.AddCatNaps(5);

        }
    }
}
