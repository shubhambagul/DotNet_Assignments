using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier_Demo
{
      class Person
    {
        protected int employeeId;
        protected string employeeName = "";
        protected string address = "";

        public void set(int employeeId, string employeeName, string address) { 
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.address = address;
        }
        public void desplay() {
            Console.WriteLine("Employee Id "+employeeId);
            Console.WriteLine("Employee Name "+employeeName);
            Console.WriteLine("Address "+address);
        }
    }
}
