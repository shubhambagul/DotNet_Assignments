using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate void AdditionDelegate(int a, int b);
    public delegate int SubstractionDelegate(int x, int y);

    class DelegatesImpl
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine("Addition of Two Number is " + (a + b));
        }
        public int Substraction(int x, int y)
        {
            return x - y;
        }
    }
    internal class SingleCastDelegates
    {
        static void Main()
        {
            DelegatesImpl obj = new DelegatesImpl();
           
            AdditionDelegate ad = new AdditionDelegate(obj.Addition);
            ad(30, 20);

            SubstractionDelegate sd = new SubstractionDelegate(obj.Substraction);
            int subst = sd(40, 10);
            Console.WriteLine("Subtraction of Two Numbers is " + subst);
        }
    }

}
