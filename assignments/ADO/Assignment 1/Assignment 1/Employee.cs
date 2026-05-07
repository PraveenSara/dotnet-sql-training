using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    internal class EmployeeData
    {
        public static List<Employee> GetData()
        {
            return new List<Employee>()
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = Convert.ToDateTime("1984/11/16"), DOJ = Convert.ToDateTime("2011/6/8"), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = Convert.ToDateTime("1984/8/20"), DOJ = Convert.ToDateTime("2012/7/7"), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = Convert.ToDateTime("1987/11/14"), DOJ = Convert.ToDateTime("2015/4/12"), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = Convert.ToDateTime("1990/6/3"), DOJ = Convert.ToDateTime("2016/2/2"), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = Convert.ToDateTime("1991/3/8"), DOJ = Convert.ToDateTime("2016/2/2"), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = Convert.ToDateTime("1989/11/7"), DOJ = Convert.ToDateTime("2014/8/8"), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = Convert.ToDateTime("1989/12/2"), DOJ = Convert.ToDateTime("2015/6/1"), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = Convert.ToDateTime("1993/11/11"), DOJ = Convert.ToDateTime("2014/11/6"), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = Convert.ToDateTime("1992/8/12"), DOJ = Convert.ToDateTime("2014/12/3"), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = Convert.ToDateTime("1991/4/12"), DOJ = Convert.ToDateTime("2016/1/2"), City = "Pune" }
            };
        }
    }
}
