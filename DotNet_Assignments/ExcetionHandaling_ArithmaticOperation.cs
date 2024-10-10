using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class ExcetionHandaling_ArithmaticOperation
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Last number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Addition of Two Digit = {num1 + num2}");
                Console.WriteLine($"Substraction of Two Digit = {num1 - num2}");
                Console.WriteLine($"Multiplication of Two Digit = {num1 + num2}");
                Console.WriteLine($"Divided of Two Digit = {num1 / num2}");


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
