using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_6
{
    internal class FileArray
    {
        public void Array()
        {
            string[] todo = new string[3] { "Wakeup", "C# Assignment", "Eat fruits" };


            string Path = @"C:\praveen-dotnet-sql-training\assignments\C#\Assignment 6\Assignment 6\todo_Array.txt";
            File.WriteAllLines(Path, todo);

            Console.WriteLine("File created successfully..  ");

            string[] ReadData = File.ReadAllLines(Path);

            Console.WriteLine("Reading from file\n");
            foreach (string line in ReadData)
            {
                Console.WriteLine(line);
            }
        }
    }
}
