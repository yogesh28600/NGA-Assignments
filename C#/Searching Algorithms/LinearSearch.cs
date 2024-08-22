using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_SearchingAlgo
{
    public class LinearSearch
    {
        public int linear_search(int[] arr, int target)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
