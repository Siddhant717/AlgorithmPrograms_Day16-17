using System;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 22, 45, 10, 50, 16 };
            Console.WriteLine("Given Array is ");
            AlgorithmProblems.printArray(arr);
           AlgorithmProblems.BubbleSorting(arr);
        }
    }
}
