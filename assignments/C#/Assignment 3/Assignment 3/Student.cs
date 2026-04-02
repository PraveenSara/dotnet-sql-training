using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Student
    {
        int rollNo;
        string name;
        string studentClass;
        int semester;
        string branch;
        int[] marks = new int[5];

        public Student(int r, string n, string c, int sem, string b)
        {
            rollNo = r;
            name = n;
            studentClass = c;
            semester = sem;
            branch = b;
        }

        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Subject " + (i + 1) + ": ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void DisplayResult()
        {
            int total = 0;
            bool fail = false;

            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    fail = true;
                }
                total = total + marks[i];
            }

            double avg = total / 5.0;

            Console.WriteLine("Average Marks: " + avg);

            if (fail)
            {
                Console.WriteLine("Result: Failed");
            }
            else if (avg < 50)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class: " + studentClass);
            Console.WriteLine("Semester: " + semester);
            Console.WriteLine("Branch: " + branch);

            Console.WriteLine("Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
            }
        }
    }

}