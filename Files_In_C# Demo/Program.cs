 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_In_C__Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello");
            File.AppendAllText("Demo.txt", $" Hello ");
            File.AppendAllText("Demo.txt", $" Welcome ");
            File.AppendAllText("Demo.txt", $" Back ");
            File.ReadAllLines("Demo.txt");

        }
    }
}
