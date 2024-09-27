using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    class Person1
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    class Teacher1 : Person1
    {
        public string Subject { get; set; }
        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Subject: {Subject}");
        }
    }
    class Principal : Teacher1
    {
        public int Experience { get; set; }

        public void DisplayPrincipalInfo()
        {
         
            Console.WriteLine($"Experience: {Experience} years");
        }
    }
    internal class MultilevelInheritance
    {
        static void Main()
        {
            Principal principal = new Principal();
            principal.Name = "Shubham";
            principal.Age = 25;
            principal.DisplayPersonInfo();
            principal.Subject = "Dot Net";
            principal.DisplayTeacherInfo();
            principal.Experience = 5;
            principal.DisplayPrincipalInfo();
        }
    }
}
