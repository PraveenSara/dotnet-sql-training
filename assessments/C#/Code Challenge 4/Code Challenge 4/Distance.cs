using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_4
{
    internal class Distance
    {
        public int Kilometer;

        public void Add(Distance d1, Distance d2)
        {
            Kilometer = d1.Kilometer + d2.Kilometer;
        }
        public void Display()
        {
            Console.WriteLine($"Total Distance: {Kilometer} km");
        }
    }

    internal class Test
    {
        static void Main(string[] args)
        {
            Distance d1 = new Distance();
            Distance d2 = new Distance();
            Distance d3 = new Distance();

            Console.Write("Enter first distance (km): ");
            d1.Kilometer = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second distance (km): ");
            d2.Kilometer = Convert.ToInt32(Console.ReadLine());

            d3.Add(d1, d2);
            d3.Display();

            Console.ReadLine();
        }
    }
}
