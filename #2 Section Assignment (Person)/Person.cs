using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Section_Assignment__Person_
{
    internal class Person
    {
        protected string name;
        protected int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void display_Info()
        {
            Console.WriteLine($"The Name is {name}, and the Age is {age}");
        }
    }
}
