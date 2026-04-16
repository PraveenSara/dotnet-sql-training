using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_3
{
    internal class AppendFile
    {
        FileStream fs;
        public void AppendingFile()
        {
            fs = new FileStream(@"C:\praveen-dotnet-sql-training\assessments\C#\Code Challenge 3\Code Challenge 3\File_For_Appending.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            Console.Write("Enter the text to append : ");
            string text = Console.ReadLine();

            sw.WriteLine(text);

            sw.Flush();
            sw.Close();
            fs.Close();

            Console.WriteLine("Text appended successfully.");
        }
        
    }
}
