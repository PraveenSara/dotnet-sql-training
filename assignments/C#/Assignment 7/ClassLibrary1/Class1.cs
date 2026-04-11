using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ticket
    {
        public string CalculateConcession(int Age, double totalFare)
        {
            if (Age <= 5)
            {
                return "Little champ - Ticket Free";
            }
            else if (Age > 60)
            {
                double DiscountFare = totalFare - (totalFare * 0.30);
                return "Senior citizen -  Fare : " + DiscountFare;
            }
            else
            {
                return "Ticket Fare : " + totalFare;
            }
        }
    }
}
