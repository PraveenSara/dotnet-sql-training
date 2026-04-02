using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Accounts
    {
        protected int accNo;
        protected string customerName;
        protected string accType;
        protected char transactionType;
        protected double amount;
        protected double balance;

        public Accounts(int a, string name, string type, double bal)
        {
            accNo = a;
            customerName = name;
            accType = type;
            balance = bal;
        }

        public void Credit(double amt)
        {
            balance = balance + amt;
            Console.WriteLine("Amount Deposited: " + amt);
        }

        public void Debit(double amt)
        {
            if (amt <= balance)
            {
                balance = balance - amt;
                Console.WriteLine("Amount Withdrawn: " + amt);
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }

        public void UpdateTransaction(char tType, double amt)
        {
            transactionType = tType;
            amount = amt;

            if (transactionType == 'D' || transactionType == 'd')
            {
                Credit(amount);
            }
            else if (transactionType == 'W' || transactionType == 'w')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid Transaction Type!");
            }
        }

        public void ShowData()
        {
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine("Account Number: " + accNo);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Account Type: " + accType);
            Console.WriteLine("Balance: " + balance);
        }
    }

    class SavingsAccount : Accounts
    {
        public SavingsAccount(int a, string name, string type, double bal)
            : base(a, name, type, bal)
        {
        }
    }
}
