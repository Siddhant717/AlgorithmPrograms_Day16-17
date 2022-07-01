using System;

namespace AlgorithmPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number : "); int k = Convert.ToInt32(Console.ReadLine());
            int limit = (int)Math.Pow(2, k);
            Console.WriteLine("Imagine a number between 0 and " + limit + " in your mind:");
            int num = AlgorithmProblems.search(0, limit);
            Console.WriteLine("Your number is " + num);


        }
    }
}