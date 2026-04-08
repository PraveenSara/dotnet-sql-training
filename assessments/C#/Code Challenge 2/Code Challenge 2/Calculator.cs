using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    public delegate int CalcDelegate(int a, int b);
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a+b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public void perform(int num1, int num2)
        {

            CalcDelegate addDel = Add;
            CalcDelegate subDel = Subtract;
            CalcDelegate mulDel = Multiply;

            Console.WriteLine("Addition: "+ addDel(num1,num2));
            Console.WriteLine("Subtraction: " + subDel(num1, num2));
            Console.WriteLine("Multiplication: " + mulDel(num1, num2));

        }
    }
}
