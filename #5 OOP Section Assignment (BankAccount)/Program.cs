using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP_Section_Assignment__BankAccount_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime opendate = DateTime.Now;


            BankAccount b1 = new BankAccount(54865623, 1500, "mohammed", opendate);
            b1.Withdraw(500);
            b1.Deposite(1000);
            b1.Deposite(20000000);
            b1.Display();

            SpecialAccount s1 = new SpecialAccount(456465454,258000,"ahmed",opendate,20000);
            s1.Withdraw(2000);
            s1.Display();

        }
    }
}
