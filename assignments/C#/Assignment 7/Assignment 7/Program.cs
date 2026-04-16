using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.

            SquareList sl = new SquareList();
            sl.FindSquare();

            //2.

            LetterFind lf = new LetterFind();
            lf.FindLetter();

            //3.

            Employee e = new Employee();
            e.DisplayEmployee();

            //4. 

            TicketProgram tp = new TicketProgram();
            tp.TicketRate();


            Console.Read();
        }
    }
}
