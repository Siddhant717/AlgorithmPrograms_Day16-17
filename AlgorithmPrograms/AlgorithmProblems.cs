using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AlgorithmProblems
    {
       public static int search(int lo, int hi)
        {
            if ((hi - lo) == 1)
                return lo;
            int mid = lo + (hi - lo) / 2;
            Console.Write("is your number less than " + mid + " : ");
            bool flag = bool.Parse(Console.ReadLine());
            if (flag)
                return search(lo, mid);
            else return search(mid, hi);
        }
    }
}

