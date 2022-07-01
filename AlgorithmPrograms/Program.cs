using System;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String array which has different strings
            String[] arr = { "Aman", "Siddhant", "Riya", "Shreya", };

            // Searching "Siddhant" string in the given array
            String x = "Siddhant";
            int result = AlgorithmProblems.binarySearch(arr, x);

            if (result == -1)
            {
                Console.WriteLine("Element is not present");
            }

            else
            {
                Console.WriteLine("Element found at index : " + result);
            }
        }
    }
}
