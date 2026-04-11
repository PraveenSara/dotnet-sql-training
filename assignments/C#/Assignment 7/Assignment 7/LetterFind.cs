using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class LetterFind
    {
        public void FindLetter()
        {
            string[] Names = { "America", "Afganistan", "Adam", "Atom", "Aluminum", "Apple" };

            var result = from name in Names
                         where name.StartsWith("A") && name.EndsWith("m")
                         select name;

            foreach (string n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}
