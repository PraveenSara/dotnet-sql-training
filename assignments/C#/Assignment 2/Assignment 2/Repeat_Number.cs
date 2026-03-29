using System;


namespace Assignment_2
{
    internal class Repeat_Number
    {
        public static void Num_repeat()
        {
            int num;
            Console.Write("Enter the number : ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine("{0}{0}{0}{0}", num);
                }
                else
                {
                    Console.WriteLine("{0} {0} {0} {0}", num);
                }
            }



        }
    }
}
