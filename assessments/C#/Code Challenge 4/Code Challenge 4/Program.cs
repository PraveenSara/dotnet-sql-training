using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeData data = new EmployeeData();
            var empList = data.GetEmployees();

            Console.WriteLine("ALL EMPLOYEES:\n");
            foreach (var e in empList)
                Console.WriteLine(e.FirstName + " " + e.LastName);

            Console.WriteLine("---------------------------");
            Console.WriteLine("\nNOT IN MUMBAI:\n");
            var notMumbai = empList.Where(e => e.City != "Mumbai");
            foreach (var e in notMumbai)
                Console.WriteLine(e.FirstName + " " + e.City);

            Console.WriteLine("---------------------------");
            Console.WriteLine("\nASST MANAGER:");
            var asst = from e in empList
                       where e.Title == "AsstManager"
                       select e;

            foreach (var e in asst)
                Console.WriteLine(e.FirstName + " " + e.Title);

            Console.WriteLine("---------------------------");
            Console.WriteLine("\nLAST NAME STARTS WITH S:\n");
            var lname = from e in empList
                        where e.LastName.StartsWith("S")
                        select e;

            foreach (var e in lname)
                Console.WriteLine(e.FirstName + " " + e.LastName);

            Console.Read();
        }
    }
}
