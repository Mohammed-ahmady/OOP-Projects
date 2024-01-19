using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP_Section_Assignment__BankAccount_
{
    internal class SpecialAccount : BankAccount
    {
        private double overlimit;

        public double Overlimit
        {
            get { return overlimit; }
            set { overlimit = value; }
        }

        public SpecialAccount(int accountNum, double balance, string customerName, DateTime opendate, double overlimit) : base (accountNum, balance, customerName, opendate )
        {
            this.Overlimit = overlimit;
            Console.WriteLine("$$$ Hello And Welcome To Your *#Special#* Account");
        }

        public override  void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"Account Number: {AccountNum}\nBalance: {Balance}\nCustomer Name: {CustomerName}\nTime: {Opendate}\nThe Overlimit: {Overlimit}");
            Console.WriteLine();
        }

        public override void Withdraw(double amount)
        {
            if (Balance == 0)
            {
                Console.WriteLine("There is no Money To Withdraw !");
                return;
            }
            else
            {
                if (amount  < Overlimit)
                {
                    Balance -= amount;
                    Console.WriteLine($"-- There is {amount}$ Withdrawed From Your *#Special#* Account At {Opendate}\n## Your Current Balance is {Balance}");

                }
                else
                {
                    Console.WriteLine($"You Have a Withdraw Limit = {overlimit}, You Can't Excced It\n--> Try Withdrawing Fewer Amount");
                }
            }
        }
    }
}

