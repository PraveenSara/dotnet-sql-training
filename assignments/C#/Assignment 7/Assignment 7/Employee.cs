using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public int EmpSalary { get; set; }
        public string EmpName {  get; set; }
        public string EmpCity { get; set; }


        public void DisplayEmployee()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { EmpId = 1, EmpName = "Praveen", EmpCity = "Bangalore", EmpSalary = 50000 },
                new Employee { EmpId = 2, EmpName = "Naveen", EmpCity = "Chennai", EmpSalary = 40000 },
                new Employee { EmpId = 3, EmpName = "Arul", EmpCity = "Bangalore", EmpSalary = 60000 },
                new Employee { EmpId = 4, EmpName = "Bharani", EmpCity = "Hyderabad", EmpSalary = 30000 },
                new Employee { EmpId = 5, EmpName = "Subash", EmpCity = "Bangalore", EmpSalary = 45000 }
            };

            Console.WriteLine("All Employees");
            foreach (var emp in employees)
            {
                PrintEmp(emp);
            }
            Console.WriteLine();

            Console.WriteLine("Employees with Salary > 45000:");
            var highSalary = employees.Where(e => e.EmpSalary > 45000);
            foreach (var emp in highSalary)
            {
                PrintEmp(emp);
            }
            Console.WriteLine();

            Console.WriteLine("Employees from Bangalore:");
            var bangaloreEmp = employees.Where(e => e.EmpCity == "Bangalore");
            foreach (var emp in bangaloreEmp)
            {
                PrintEmp(emp);
            }
            Console.WriteLine();

            Console.WriteLine("Employees sorted by name:");
            var sortedEmp = employees.OrderBy(e => e.EmpName);
            foreach (var emp in sortedEmp)
            {
                PrintEmp(emp);  
            }
        }

        public static void PrintEmp(Employee emp)
        {
        Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
        }
    }
}
