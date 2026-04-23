using FactoryMethodPattern.Interfaces;
using FactoryMethodPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factories
{
    public class SummaryFactory : ReporterFactory
    {
        public override IReport CreateReport()
        {
            return new SummaryReport();
        }
    }
}
