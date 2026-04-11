using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class SquareList
    {
        public void FindSquare()
        {
            int[] numbers = { 12, 2, 4, 5, 8, 25 };

            var result = from n in numbers
                         where n > 4
                         select n;
            foreach (var num in result)
            {
                Console.Write($"{num} - {num * num} , " );
            }
        }
    }
}
