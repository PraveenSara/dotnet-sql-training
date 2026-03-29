using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class DayOfWeek
    {
        public enum Days
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
        public static void DayFinder()
        {
            int num;
            Console.Write("Enter the number of the day in week : ");
            num = int.Parse(Console.ReadLine());

            Days day = (Days)num;
            Console.WriteLine(day);
        }

    }
}
