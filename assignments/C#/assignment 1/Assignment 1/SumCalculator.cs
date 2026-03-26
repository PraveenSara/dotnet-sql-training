using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class SumCalculator
    {
        public static void Sum()
        {
            int num1, num2, sum;

            Console.Write("Enter the first number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number : ");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;

            if (num1 != num2)
            {
                Console.WriteLine($"{num1} and {num2} are not equal and the sum is : {sum}");
            }

            else
            {
                Console.WriteLine($"{num1} and {num2} are equal and the triple of the sum is {sum * 3}");
            }

        }
    }
}
