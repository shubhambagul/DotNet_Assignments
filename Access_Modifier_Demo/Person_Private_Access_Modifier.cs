using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier_Demo
{
     class Person_Private_Access_Modifier
    {
        private string firstName = "";
        private string lastName = "";
        public void setName(string firstName, string lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void display() {
            Console.WriteLine("First Name :" + firstName);
            Console.WriteLine("Last Name :" + lastName);
        }
        public static void Main() {
            Person_Private_Access_Modifier obj1 = new Person_Private_Access_Modifier();
            obj1.setName("Shubham", "Bagul");
            obj1.display();
        }
    }
}
