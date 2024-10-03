using System;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class StackExample
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Hello");
            stack.Push(123456789);
            stack.Push(false);
            stack.Push(5.5);
            Console.WriteLine("Total elements from stack");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Removed elements from stack");
            object firstElement = stack.Pop();
            object secondtElement = stack.Pop();
            object thirdtElement = stack.Pop();
            object fourthElement = stack.Pop();
            object fifthElement = stack.Pop();

            Console.WriteLine(firstElement);
            Console.WriteLine(secondtElement);
            Console.WriteLine(thirdtElement);
            Console.WriteLine(fourthElement);
            Console.WriteLine(fifthElement);

            Console.WriteLine("Is stack empty : " + (stack.Count == 0));

        }
    }
}
