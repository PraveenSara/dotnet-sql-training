using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class DescendStack
    {
        internal void SortDescending()
        {
            Stack<int> stack = new Stack<int>();
            List<int> list = new List<int>();

            Console.WriteLine("Enter number of elements:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                int num = int.Parse(Console.ReadLine());
                stack.Push(num);
            }

            while (stack.Count > 0)
            {
                list.Add(stack.Pop());
            }

            list.Sort();
            list.Reverse();

            foreach (int item in list)
            {
                stack.Push(item);
            }

            Console.WriteLine("Stack elements in descending order:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
