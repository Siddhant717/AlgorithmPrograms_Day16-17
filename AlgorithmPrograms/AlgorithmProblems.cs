using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AlgorithmProblems
    {
        public static String swapString(String a, int i, int j)
        {
            char[] c = a.ToCharArray();
            char ch;
            ch = c[i];
            c[i] = c[j];
            c[j] = ch;

            //Converting characters from array into single string  
            return string.Join("", c);
        }

        //Function for generating permutations
        public static void generatePermutation(String str, int start, int end)
        {
            //Prints the permutations  
            if (start == end - 1)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i < end; i++)
                {
                    //Swapping the string 
                    str = swapString(str, start, i);

                    generatePermutation(str, start + 1, end);

                    str = swapString(str, start, i);
                }
            }
        }
    }
}
