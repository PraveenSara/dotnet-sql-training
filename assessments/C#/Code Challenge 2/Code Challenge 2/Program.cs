using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1st

            Undergraduate ug = new Undergraduate();
            ug.Name = "Praveen";
            ug.StudentId = 1;
            ug.Grade = 71;

            Console.WriteLine("Name : " + ug.Name + ", UG, Mark : " + ug.Grade + " Passed : " + ug.IsPassed(ug.Grade));
            Console.WriteLine();

            Graduate g = new Graduate();
            g.Name = "Naveen";
            g.StudentId = 2;
            g.Grade = 79;

            Console.WriteLine("Name : " + g.Name + ", Graduate, Mark : " + g.Grade + " Passed : " + g.IsPassed(g.Grade));
            Console.WriteLine();

            //2nd
            //Product p = new Product();
            //p.ProductList();

            //3rd

            //CheckNumber check = new CheckNumber();
            //try
            //{
            //    check.AcceptNumber();
            //}
            //catch (NegativeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //4th

            //Calculator calc = new Calculator();

            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //calc.perform(num1, num2);

            Console.Read();
        }
    }
}
