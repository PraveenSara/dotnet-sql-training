using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_4
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    public class EmployeeData
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(){ EmployeeID=1001, FirstName="Malcolm", LastName="Daruwalla", Title="Manager", City="Mumbai"},
                new Employee(){ EmployeeID=1002, FirstName="Asdin", LastName="Dhalla", Title="AsstManager", City="Mumbai"},
                new Employee(){ EmployeeID=1003, FirstName="Madhavi", LastName="Oza", Title="Consultant", City="Pune"},
                new Employee(){ EmployeeID=1004, FirstName="Saba", LastName="Shaikh", Title="SE", City="Pune"},
                new Employee(){ EmployeeID=1005, FirstName="Nazia", LastName="Shaikh", Title="SE", City="Mumbai"},
                new Employee(){ EmployeeID=1006, FirstName="Amit", LastName="Pathak", Title="Consultant", City="Chennai"},
                new Employee(){ EmployeeID=1007, FirstName="Vijay", LastName="Natrajan", Title="Consultant", City="Mumbai"},
                new Employee(){ EmployeeID=1008, FirstName="Rahul", LastName="Dubey", Title="Associate", City="Chennai"},
                new Employee(){ EmployeeID=1009, FirstName="Suresh", LastName="Mistry", Title="Associate", City="Chennai"},
                new Employee(){ EmployeeID=1010, FirstName="Sumit", LastName="Shah", Title="Manager", City="Pune"}
            };
        }
    }
}
