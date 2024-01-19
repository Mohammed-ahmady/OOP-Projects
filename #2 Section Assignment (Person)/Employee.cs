using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Section_Assignment__Person_
{
    internal class Employee : Person
    {
        private string employeeID { get; set; }
        private string position { get; set; }

        public Employee(string name, int age, string employeeID, string position) : base (name, age)
        {
            this.name = name;
            this.age = age;
            this.employeeID = employeeID;
            this.position = position;

        }
        public override void display_Info()
        {
            Console.WriteLine($"The Name is {name}, and the Age is {age}, ID = {employeeID}, While it's Position is : {position}");
        }
    }
}
