using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AlgorithmProblems
    {
        public static void InsertionSortInt(int[] ar)
        {
            for (int i = 1; i < ar.Length; i++)                                                                                                                                                 
            {

                int t = ar[i];                                                                                                                                         
                int j = i - 1;                                                                                                                                                   
                while (j >= 0 && ar[j] > t)          
                {
                    ar[j + 1] = ar[j];                                                      
                    j--;                                                                                                                                  
                }
                ar[j + 1] = t;                                                                                                                                                 

            }

        }
        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

    }
}
