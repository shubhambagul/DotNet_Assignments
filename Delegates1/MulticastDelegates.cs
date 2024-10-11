using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate void Notify(int a, int b);

    class Delegates1Impl
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine("Addition = " + (a + b));
        }
        public void Substraction(int a, int b)
        {
            Console.WriteLine("Substraction = " + (a - b));
        }
        public void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication = " + (a * b));
        }
    }
    internal class MulticastDelegates
    {
        static void Main()
        {
            Delegates1Impl dI = new Delegates1Impl();
            Notify notify = dI.Addition;

            notify += dI.Substraction;

            notify += dI.Multiplication;

            notify(20, 5);
        }
    }
}
