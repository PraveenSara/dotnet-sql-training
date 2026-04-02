using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_challenge_1
{
    struct DateOfBirth
    {
        public int day, month, year;

    }

    struct EmployeeStruct
    {
        public string name;
        public DateOfBirth dob;

    }
    internal class StoreEmpData
    {
        public void EmpData()
        {
            EmployeeStruct[] emp = new EmployeeStruct[2];

            for (int i = 0; i < 2;  i++)
            {
                Console.WriteLine("Enter details for employee " + (i + 1));

                Console.Write("Name of the employee: ");
                emp[i].name = Console.ReadLine();

                Console.Write("Input day of the birth: ");
                emp[i].dob.day = int.Parse(Console.ReadLine());

                Console.Write("Input month of the birth: ");
                emp[i].dob.month = int.Parse(Console.ReadLine());

                Console.Write("Input year of the birth: ");
                emp[i].dob.year = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("-------------------------");

            for (int i = 0;i < 2; i++)
            {
                Console.WriteLine("Name: " + emp[i].name);
                Console.WriteLine("DOB: " + emp[i].dob.day + "/" + emp[i].dob.month + "/" + emp[i].dob.year);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
