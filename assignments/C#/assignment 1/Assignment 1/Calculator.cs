using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Calculator
    {
        public static void Calc()
        {
            int num1, num2;
            char symbol;

            Console.Write("Enter first number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /) : ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {  
                case '+':
                    Console.WriteLine($"{num1} {symbol} {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} {symbol} {num2} = {num1 - num2}");
                    break;
                case '/':
                    Console.WriteLine($"{num1} {symbol} {num2} = {num1 / num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} {symbol} {num2} = {num1 * num2}");
                    break;
                default:
                    Console.WriteLine("Invalid operator selected");
                    break;
            }
        }
    }
}
