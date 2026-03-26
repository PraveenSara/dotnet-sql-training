using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class MultipicationTable
    {
        public static void Tables()
        {
            int table;
            Console.Write("Enter the number : ");
            table = int.Parse(Console.ReadLine());

            for (int num = 1; num <= 10; num++)
            {
                Console.WriteLine($"{table} X {num} = {table * num}");
            }
        }
    }
}
