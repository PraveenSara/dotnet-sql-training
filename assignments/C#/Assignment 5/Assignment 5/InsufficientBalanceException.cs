using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }
    public class BankAccount
    {
        private double balance;
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be greater than zero.");
                }

                balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Deposit: " + e.Message);
            }
        }
        public void Withdraw(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdraw amount must be greater than zero.");
                }

                if (amount > balance)
                {
                    throw new InsufficientBalanceException("Not enough balance!");
                }

                balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine("Custom Exception: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Withdraw: " + e.Message);
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine("Current Balance: " + balance);
        }
    }

}
