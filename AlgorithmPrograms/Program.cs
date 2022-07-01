using System;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 44, 12, 50, 20, 62 };
            Console.WriteLine("Given Array is ");
            AlgorithmProblems.printArray(array);
            AlgorithmProblems.InsertionSortInt(array);
            Console.WriteLine("After sorted is ");
            AlgorithmProblems.printArray(array);
        }
    }
}
