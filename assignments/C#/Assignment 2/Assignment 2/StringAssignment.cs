using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class StringAssignment
    {
        public void CheckLength()
        {
            Console.Write("Entera a word : ");
            string Word = Console.ReadLine();

            Console.WriteLine("The length of the word is :{0} ",Word.Length);

            string ReversedString = "";

            for (int i = Word.Length - 1; i >= 0; i--)
            {
                ReversedString += Word[i];
            }
            Console.WriteLine(ReversedString);
        }

        public void IsEqual()
        {
            Console.Write("Enter the first word : ");
            string word1 = Console.ReadLine();
            Console.Write("Enter the second word : ");
            string word2 = Console.ReadLine();

            if (word1.ToLower() == word2.ToLower())
            {
                Console.WriteLine($"{word1} and {word2} are same word");
            }
            else
            {
                Console.WriteLine($"{word1} and {word2} are not same word");
            }
        }
    }
}
