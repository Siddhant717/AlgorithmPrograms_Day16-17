using System;

namespace AlgorithmPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {

            AlgorithmProblems anagram = new AlgorithmProblems();

            Console.WriteLine("Enter 1 string ");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter 2 string ");
            string string2 = Console.ReadLine();

            anagram.CheckAnagram(string1, string2);

         

        }
    }
}