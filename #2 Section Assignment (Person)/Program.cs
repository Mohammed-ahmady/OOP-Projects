using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Section_Assignment__Person_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Mohammed Ahmady", 20);
            p1.display_Info();


            Student s1 = new Student("Mohammed Mohsen", 21, "323232391", 769.2);
            s1.display_Info();

            Employee e1 = new Employee("Ahmed AbdelRazeq",48,"254786396", "HR Team Manger");
            e1.display_Info();
        }
    }
}
