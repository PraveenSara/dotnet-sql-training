using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var empList = EmployeeData.GetData();

            // 1
            var q1 = empList.Where(e => e.DOJ < Convert.ToDateTime("2015/1/1"));

            // 2
            var q2 = empList.Where(e => e.DOB > Convert.ToDateTime("1990/1/1"));

            // 3
            var q3 = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");

            // 4
            var q4 = empList.Count();

            // 5
            var q5 = empList.Count(e => e.City == "Chennai");

            // 6
            var q6 = empList.Max(e => e.EmployeeID);

            // 7
            var q7 = empList.Count(e => e.DOJ > Convert.ToDateTime("2015/1/1"));

            // 8
            var q8 = empList.Count(e => e.Title != "Associate");

            // 9
            var q9 = empList.GroupBy(e => e.City).Select(g => new {City = g.Key, Count = g.Count()});

            // 10
            var q10 = empList.GroupBy(e => new { e.City, e.Title }).Select(g => new {g.Key.City, g.Key.Title, Count = g.Count()});

            // 11
            var youngestDOB = empList.Max(e => e.DOB);

            var q11 = empList.Where(e => e.DOB == youngestDOB);

            // --- Outputs

            Console.WriteLine("1. Joined before 1/1/2015");
            foreach (var e in q1)
                Console.WriteLine($"{e.FirstName} {e.LastName}");

            Console.WriteLine("\n2. DOB after 1/1/1990");
            foreach (var e in q2)
                Console.WriteLine($"{e.FirstName} {e.LastName}");

            Console.WriteLine("\n3. Consultant and Associate");
            foreach (var e in q3)
                Console.WriteLine($"{e.FirstName} - {e.Title}");

            Console.WriteLine($"\n4. Total Employees : {q4}");

            Console.WriteLine($"\n5. Chennai Employees : {q5}");

            Console.WriteLine($"\n6. Highest Employee ID : {q6}");

            Console.WriteLine($"\n7. Joined after 1/1/2015 : {q7}");

            Console.WriteLine($"\n8. Not Associate : {q8}");

            Console.WriteLine("\n9. Employee Count by City");
            foreach (var item in q9)
                Console.WriteLine($"{item.City} : {item.Count}");

            Console.WriteLine("\n10. Employee Count by City and Title");
            foreach (var item in q10)
                Console.WriteLine($"{item.City} - {item.Title} : {item.Count}");

            Console.WriteLine("\n11. Youngest Employee");
            foreach (var e in q11)
                Console.WriteLine($"{e.FirstName} {e.LastName}");

            Console.ReadLine();
        }
    }
}
