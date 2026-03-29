using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repeat_Number.Num_repeat();
            DayOfWeek.DayFinder();

            //----- Average and Maximum, minimum -----------
            AverageofArray Avg = new AverageofArray();
            Avg.Average();
            Console.WriteLine("---------------");
            Avg.FindMinMax();

            // ----------Ten Marks--------------
            TenMarks Tm = new TenMarks();
            Tm.MarkEval();

            // --- Array clone ---
            ArrayClone.Copy();

            // ---- String ----
            StringAssignment str = new StringAssignment();
            str.CheckLength();
            str.IsEqual();
            Console.Read();
        }
    }
}
