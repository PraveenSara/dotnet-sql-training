using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    internal class NegativeException : ApplicationException
    {
        public NegativeException(string msg) : base(msg){ }
       
    }
    class CheckNumber
    {
        int number;

        public void AcceptNumber()
        {
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                throw new NegativeException("Number cannot be negative!");
            }
            else
            {
                Console.WriteLine("You entered: " + number);
            }
        }
    }
}
