using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class EqualCheck
    {
        public static void Is_equal()
        {
            int num1, num2;

            Console.Write("Enter Number 1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal.");
            }
            else { Console.WriteLine($"{num1} and {num2} are not equal."); }
        }
    }
}
