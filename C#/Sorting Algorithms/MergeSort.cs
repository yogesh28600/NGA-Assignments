using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_SortingAlgo
{
    public class MergeSort
    {
        public void merge_sort(int[] arr,int start,int end)
        {
            if (start >= end)
            {
                return;
            }
            int mid = (start+end)/2;
            merge_sort(arr,start,mid);
            merge_sort(arr,mid+1,end);
            merge(arr,start,mid,end);

        }
        private void merge(int[] arr,int start,int mid,int end)
        {
            int left = mid - start + 1;
            int right = end - mid;
            int[] leftarr = new int[left];
            int[] rightarr = new int[right];
            Array.Copy(arr, start, leftarr, 0, left);
            Array.Copy(arr, mid + 1, rightarr, 0, right);
            int p1 = 0, p2 = 0, k = start;
            while (p1 < left && p2 < right)
            {
                if (leftarr[p1] <= rightarr[p2])
                {
                    arr[k++] = leftarr[p1++];   
                }
                else
                {
                    arr[k++] = rightarr[p2++];
                }
               
            }
            while (p1 < left)
            {
                arr[k++] = leftarr[p1++];
            }
            while (p2 < right)
            {
                arr[k++] = rightarr[p2++];  
            }
        }
    
    }
}
