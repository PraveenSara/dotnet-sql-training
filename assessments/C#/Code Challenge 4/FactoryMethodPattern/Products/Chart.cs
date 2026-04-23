using FactoryMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Products
{
    public class ChartReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating CHART Report...");
        }
    }
}
