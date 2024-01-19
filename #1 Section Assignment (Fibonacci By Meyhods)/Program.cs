using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Section_Assignment__Fibonacci_By_Meyhods_
{
    internal class Program
    {
        public static int Fibonacci(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(x - 1) + Fibonacci(x - 2);
            }
        }

        static void Main(string[] args)
        {
              for (int i = 0; i < 20; i++)
              {
                  Console.WriteLine(Fibonacci(i));
              }

            
            
            
        }
        
    }
}
