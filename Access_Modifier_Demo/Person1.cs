using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier_Demo
{
    class Person1
    {
        public string firstName;
        public string lastName;
        public int mono;
        public void set(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
    class Employee1 : Person1
    {
        public void display()
        {
            Console.WriteLine("First Name - " + firstName);
            Console.WriteLine("Last Name - " + lastName);
        }
        static void Main()
        {
            Employee1 employee1 = new Employee1();
            employee1.set("Shubham", "Bagul");
            employee1.display();
        }
    }
}
