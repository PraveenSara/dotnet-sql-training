using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Interfaces;
using FactoryMethodPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose report type : ");
            string choice = Console.ReadLine().ToLower();

            IReport report = null;

            if (choice == "chart")
                report = new ChartFactory().CreateReport();
            else if (choice == "tabular")
                report = new TabularFactory().CreateReport();
            else if (choice == "summary")
                report = new SummaryFactory().CreateReport();
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            if (report != null)
            {
                report.Generate();
            }

            Console.Read();
        }
    }
}
