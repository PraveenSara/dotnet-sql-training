using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Accounts
    {
        public int AccountNo, Amount, Balance;
        string CustomerName, AccountType, TransactionType;
        public void UpdateBalance()
        {
            if (TransactionType == "Deposite")
            {
                Balance += Amount;
            }
            else if (TransactionType == "Withdraw")
            {
                Balance -= Amount;
            }
            else
            {
                Console.WriteLine("Enter the Transaction type correct. (Deposite, Withdraw)");
            }
        }
    }
}
