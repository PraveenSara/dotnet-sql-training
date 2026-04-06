using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000);

            account.ShowBalance();

            account.Deposit(500);
            account.ShowBalance();

            account.Withdraw(200);
            account.ShowBalance();

            account.Withdraw(2000);
            Console.WriteLine("---------------");

            // 2 nd program

            Scholarship s = new Scholarship();

            try
            {
                double result = s.Merit(85, 10000);
                Console.WriteLine("Scholarship Amount: " + result);
            }
            catch (InvalidMarksException e)
            {
                Console.WriteLine("Custom Exception: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.WriteLine("---------------");

            // 3rd 
            BookShelf shelf = new BookShelf();

            shelf[0] = new Books("C# Basics", "John");
            shelf[1] = new Books("OOP Concepts", "David");
            shelf[2] = new Books("Data Structures", "Mike");
            shelf[3] = new Books("Algorithms", "Sara");
            shelf[4] = new Books("DotNet Guide", "Alex");

            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }
            Console.ReadLine();
        }
    }
}
