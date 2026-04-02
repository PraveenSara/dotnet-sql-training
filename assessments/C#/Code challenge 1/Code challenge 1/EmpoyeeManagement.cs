using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Code_challenge_1
{
    internal class Employee
    {
        public int id;
        public string name, dept;
        public double salary;
    }
    internal class EmpoyeeManagement
    {
        public void Management()
        {
            List<Employee> emplist = new List<Employee>();
            int choice;

            do
            {
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Update Employee Details");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Exit");
                Console.WriteLine("====================================");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Employee emp = new Employee();
                        Console.Write("Enter Employee Id : ");
                        emp.id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        emp.name = Console.ReadLine();

                        Console.Write("Enter Department: ");
                        emp.dept = Console.ReadLine();

                        Console.Write("Enter Salary: ");
                        emp.salary = Convert.ToDouble(Console.ReadLine());

                        emplist.Add(emp);
                        Console.WriteLine("Employee added successfully!");
                        break;

                    case 2:
                        if (emplist.Count == 0)
                        {
                            Console.WriteLine("Employee not found");
                        }
                        else
                        {
                            foreach (Employee employee in emplist)
                            {
                                Console.WriteLine("Id: " + employee.id);
                                Console.WriteLine("Name: " + employee.name);
                                Console.WriteLine("Department: " + employee.dept);
                                Console.WriteLine("Salary: " + employee.salary);
                                Console.WriteLine("----------------------");
                            }
                        }
                        break;

                    case 3:
                        Console.Write("Enter Id to search employee : ");
                        int searchId = int.Parse(Console.ReadLine());
                        bool found = false;

                        foreach (Employee employee in emplist)
                        {
                            if (employee.id == searchId)
                            {
                                Console.WriteLine("Employee Found:");
                                Console.WriteLine("Name: " + employee.name);
                                Console.WriteLine("Department: " + employee.dept);
                                Console.WriteLine("Salary: " + employee.salary);
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Id to update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        bool updated = false;

                        foreach (Employee employee in emplist)
                        {
                            if (employee.id == updateId)
                            {
                                Console.Write("Enter new Name: ");
                                employee.name = Console.ReadLine();

                                Console.Write("Enter new Department: ");
                                employee.dept = Console.ReadLine();

                                Console.Write("Enter new Salary: ");
                                employee.salary = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Employee updated successfully..");
                                updated = true;
                                break;
                            }
                        }
                        if (!updated)
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;

                    case 5:
                        Console.Write("Enter Id to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        Employee toRemove = null;

                        foreach (Employee employee in emplist)
                        {
                            if (employee.id == deleteId)
                            {
                                toRemove = employee;
                                break;
                            }
                        }
                        if (toRemove != null)
                        {
                            emplist.Remove(toRemove);
                            Console.WriteLine("Employee deleted successfully..");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Exits....");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Enter anyone from this 1,2,3,4,5,6");
                        break;


                }

            }
            while (choice != 6);
        }
        

    }

    
}
