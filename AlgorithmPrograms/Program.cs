using System;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "STAR";
            int len = str.Length;
            Console.WriteLine("All the permutations of the string are: ");
            AlgorithmProblems.generatePermutation(str, 0, len);
        }
    }
}
