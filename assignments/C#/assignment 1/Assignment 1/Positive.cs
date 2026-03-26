using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Positive
    {
        public static void Is_positive()
        {
            Console.Write("Enter the number : ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"{num} is Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is Negative");
            }
            else
            {
                Console.WriteLine($"{num} is Zero");
            }
        }
    }
}
