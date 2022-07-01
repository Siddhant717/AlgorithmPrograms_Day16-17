using System;

namespace AlgorithmPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 11, 13, 5, 6, 7 };

            Console.WriteLine("Given Array");
            AlgorithmProblems.printArray(array);

            AlgorithmProblems ob = new AlgorithmProblems();
            ob.sort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted array");
            AlgorithmProblems.printArray(array);
        }
    }
}