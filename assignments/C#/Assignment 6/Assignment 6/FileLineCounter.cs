using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_6
{
    internal class FileLineCounter
    {
        internal void LineCount()
        {
            string path = @"C:\praveen-dotnet-sql-training\assignments\C#\Assignment 6\Assignment 6\todo_Array.txt";

            if (File.Exists(path))
            {
                int Lines = File.ReadLines(path).Count();
                Console.WriteLine("Number of lines in this file : "+ Lines);
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
