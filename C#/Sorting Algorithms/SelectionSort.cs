using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_SortingAlgo
{
    public class SelectionSort
    {
        public void selection_sort(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0;j<arr.Length-i; j++)
                {
                    max = Math.Max(max, arr[j]);

                }
                

            }
        }
    }
}
