using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    public enum MonthsOfYear
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        Augast,
        September,
        October,
        November,
        December
    }
    internal class Enum
    {

        static void Main()
        {
            MonthsOfYear month = MonthsOfYear.June;
            switch (month)
            {
                case MonthsOfYear.January:
                    Console.WriteLine("You are selected January month");
                    break;
                case MonthsOfYear.February:
                    Console.WriteLine("You are selected February month");
                    break;
                case MonthsOfYear.March:
                    Console.WriteLine("You are selected March month");
                    break;
                case MonthsOfYear.April:
                    Console.WriteLine("You are selected April month");
                    break;
                case MonthsOfYear.May:
                    Console.WriteLine("You are selected May month");
                    break;
                case MonthsOfYear.June:
                    Console.WriteLine("You are selected June month");
                    break;
                case MonthsOfYear.July:
                    Console.WriteLine("You are selected July month");
                    break;
                case MonthsOfYear.Augast:
                    Console.WriteLine("You are selected Augast month");
                    break;
                case MonthsOfYear.September:
                    Console.WriteLine("You are selected September month");
                    break;
                case MonthsOfYear.October:
                    Console.WriteLine("You are selected October month");
                    break;
                case MonthsOfYear.November:
                    Console.WriteLine("You are selected November month");
                    break;
                case MonthsOfYear.December:
                    Console.WriteLine("You are selected December month");
                    break;
            }


        }
    }
}
