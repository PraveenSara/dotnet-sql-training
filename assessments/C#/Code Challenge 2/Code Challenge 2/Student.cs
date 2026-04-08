using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    abstract class Student
    {
        public string Name;
        public int StudentId;
        public double Grade;

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            if (grade > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            if (grade > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
