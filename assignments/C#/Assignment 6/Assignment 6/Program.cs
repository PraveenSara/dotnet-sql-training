using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookShelf bs = new BookShelf();
            bs[0] = new Books("Psychology of money", "Morgen Housel");
            bs[1] = new Books("Atomic habits", "James clear");
            bs[2] = new Books("How to win friends and influence people", "Dale carnegie");
            bs[3] = new Books("Can we be strangers again", "Sreejit shandalia");
            bs[4] = new Books("Rich dad poor dad", "Robert Kyotsaki");

            for (int i = 0; i < 5; i++)
            {
                bs[i].Display();
            }

            //2nd program

            FileArray fa = new FileArray();
            fa.Array();

            //3rd task

            FileLineCounter fl = new FileLineCounter();
            fl.LineCount();
            Console.Read();
        }
    }
}
