using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_3
{
    internal class CricketTeam
    {
        public void PointCalculator(int NoOfMatch)
        {
            
            int sum = 0;
            for (int i = 1; i <= NoOfMatch; i++)
            {
                Console.Write($"Enter the score of match {i} :");
                int score = int.Parse(Console.ReadLine());
                sum += score;
            }
            double average = (double)sum / NoOfMatch;

            Console.WriteLine("\nNo of matches : " + NoOfMatch);
            Console.WriteLine("Total score : " + sum);
            Console.WriteLine("Average score : " + average);
        }
    }
}
