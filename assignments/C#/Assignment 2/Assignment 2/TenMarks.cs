using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class TenMarks
    {
        int[] arr = new int[10];

        public void MarkEval()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter the mark {0} : ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entered marks: " + string.Join(", ", arr));

            int total = 0;
            

            // ---Total--
            for (int i = 0;i < arr.Length; i++)
            {
                total += arr[i];
            }
            Console.WriteLine("The total of ten marks is : {0}", total);


            // ---Average---
            double average = (double)total / arr.Length;
            Console.WriteLine("The average of ten marks is : {0}",average);

            // ---Minimum and Maximum---
            Array.Sort(arr);
            Console.WriteLine("The minimum number is : {0}", arr[0]);
            Console.WriteLine("The minimum number is : {0}", arr[arr.Length - 1]);

            // ---Sorting---
            Console.WriteLine("Ascending : " + string.Join(", ", arr));

            // ---Descending---
            Array.Reverse(arr);
            Console.WriteLine("Descending : " + string.Join(", ", arr));




        }
    }
}
