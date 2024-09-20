using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier_Demo
{
     class Employee
    {
        public static void Main() { 
        Person obj = new Person();
            obj.set(101, "Shubham", "Pune");
            obj.desplay();  
        }
    }
}
