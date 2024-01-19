using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Section_Assignment__Person_
{
    internal class Student : Person
    {
        private string studentID { get; set; }
        private double grade { get; set; }
        
        public Student(string name , int age, string studentID, double grade) : base (name, age)
        {
            this.name = name;
            this.age = age;
            this.studentID = studentID;
            this.grade = grade;
        }
        public override void display_Info()
        {
            Console.WriteLine($"The Name is {name}, and the Age is {age}, ID = {studentID}, Grades : {grade}");
        }
    }
}
