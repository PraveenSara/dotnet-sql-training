using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Assignment_7
{
    internal class TicketProgram
    {
        public int TotalFare = 500;
        public void TicketRate()
        {
            Console.Write("Enter Name : ");
            string Name = Console.ReadLine();

            Console.Write("Enter Age : ");
            int age = int.Parse(Console.ReadLine());

            Ticket t = new Ticket();

            string result = t.CalculateConcession(age, TotalFare);
            Console.WriteLine("Name : "+ Name);
            Console.WriteLine(result);
        }
    }
}
