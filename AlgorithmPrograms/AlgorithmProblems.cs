using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AlgorithmProblems
    {
		public void merge(int[] arr, int l, int m, int r)
		{
			int n1 = m - l + 1;
			int n2 = r - m;

			int[] L = new int[n1];
			int[] R = new int[n2];

			for (int f = 0; f < n1; ++f)
				L[f] = arr[l + f];
			for (int d = 0; d < n2; ++d)
				R[d] = arr[m + 1 + d];



			int i = 0, j = 0;

			int k = l;
			while (i < n1 && j < n2)
			{
				if (L[i] <= R[j])
				{
					arr[k] = L[i];
					i++;
				}
				else
				{
					arr[k] = R[j];
					j++;
				}
				k++;
			}

			while (i < n1)
			{
				arr[k] = L[i];
				i++;
				k++;
			}

			while (j < n2)
			{
				arr[k] = R[j];
				j++;
				k++;
			}
		}

		public void sort(int[] arr, int l, int r)        
		{
			if (l < r)                                     
			{
				int m = (l + r) / 2;                     

				sort(arr, l, m);                        
				sort(arr, m + 1, r);

				merge(arr, l, m, r);
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
