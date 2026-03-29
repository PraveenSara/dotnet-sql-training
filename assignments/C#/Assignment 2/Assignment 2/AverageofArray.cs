using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class AverageofArray
    {
        public int[] arr = new int[5] { 4, 5, 3, 4, 2 };
        public void Average()
        {
          
            int sum = 0;
            
            for (int digit = 0; digit < arr.Length; digit++)
            {
                sum += arr[digit];
            }
            double average = (double)sum / arr.Length;
            Console.WriteLine($"The average is : {average}");
        }

        public void FindMinMax()
        {
            Array.Sort(arr);
            Console.WriteLine("The minimun value is {0}", arr[0]);
            Console.WriteLine("The maximum value is {0}", arr[arr.Length - 1]);
        }
    }
}
