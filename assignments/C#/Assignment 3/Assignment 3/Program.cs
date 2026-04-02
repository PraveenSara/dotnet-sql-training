using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount acc1 = new SavingsAccount(101, "Rahul", "Savings", 5000);
            acc1.UpdateTransaction('D', 2000); 
            acc1.UpdateTransaction('W', 1000); 
            acc1.ShowData();

            Student s1 = new Student(1, "Arun", "BSc", 3, "CS");
            s1.GetMarks();
            s1.DisplayData();
            s1.DisplayResult();

            SaleDetails s2 = new SaleDetails(101, 5001, 200, 3, "02-04-2026");
            s2.Sales();
            SaleDetails.ShowData(s2);
        }
    }
}
