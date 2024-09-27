using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    class Shape1
    {
        public string Color { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($"Shape color: {Color}");
        }
    }
    class Circle1 : Shape1
    {
        public override void Display()
        {
            Console.WriteLine($"Circle color: {Color}");
        }
    }
    class Rectangle1 : Shape1
    {
        public override void Display()
        {
            Console.WriteLine($"Rectangle color: {Color}");
        }
    }

    internal class HierarchicalInheritance
    {
        static void Main()
        {
            Circle1 circle = new Circle1();
            circle.Color = "Red";
            circle.Display();

            Rectangle1 rectangle = new Rectangle1();
            rectangle.Color = "White";
            rectangle.Display();
        }
    }
}
