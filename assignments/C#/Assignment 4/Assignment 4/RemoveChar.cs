using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class RemoveChar
    {
        string word;
        int position;
        internal void Remove()
        {
            Console.Write("Enter the word : ");
            word = Console.ReadLine();

            Console.Write("Enter the position : ");
            position = int.Parse(Console.ReadLine());

            Console.WriteLine(word.Remove(position));
        }
    }
}
