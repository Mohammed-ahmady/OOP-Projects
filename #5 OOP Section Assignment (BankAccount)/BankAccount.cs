using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP_Section_Assignment__BankAccount_
{
    internal class BankAccount
    {
        private int accountNum;
        private double balance;
        private string customerName;

        public DateTime Opendate { get; set; }


        public int AccountNum
        {
            get { return accountNum; }
            set { accountNum = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public BankAccount(int accountNum, double balance, string customerName, DateTime opendate)
        {
            this.AccountNum = accountNum;
            this.Balance = balance;
            this.CustomerName = customerName;
            this.Opendate = opendate;
            
        }

        public virtual void Display()
        {
            Console.WriteLine($"\nAccount Number: {AccountNum}\nBalance: {Balance}\nCustomer Name: {CustomerName}\nTime: {Opendate}");
            Console.WriteLine();
        }

        public virtual void Withdraw(double amount)
        {
            if (balance == 0)
            {
                Console.WriteLine("There is no Money To Withdraw !");
                return;
            }
            else
            {

                balance -= amount;
                Console.WriteLine($"-- There is {amount}$ Withdrawed From Your Account At {Opendate}\n## Your Current Balance is {balance}");
            }
        }
        public void Deposite(double amount)
        {
            balance += amount;
            Console.WriteLine($"++ There is {amount}$ Deposited To Your Account At {Opendate}\n## Your Current Balance is {balance}");

        }

    }
}
