using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNet_Assignments
{
    class Person { 
        public string Name { get; set; }
        public int age {  get; set; }
        public void personDisplay() { 
        Console.WriteLine("Name - "+Name);
        Console.WriteLine("Age - " + age);
        }
    }
    class Student : Person{ 
        public long MoNo { get; set; }
        public string EMial { get; set; }
        public void display()
        {
            Console.WriteLine("Mobile No - " + MoNo);
            Console.WriteLine("E-Mail ID - " + EMial);
        }
    }
    internal class SingleInheritance
    {
        static void Main() { 
            Student student = new Student();
            student.Name = "Shubham";
            student.age = 25;
            student.personDisplay();
            student.EMial = "shubhambagul1234@gmail.com";
            student.MoNo = 9764904458;
            student.display();

        }
    }
}
