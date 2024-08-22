
namespace Assignments_SearchingAlgo
{
    public class JumpSearch
    {
        private int linear_search(int[] arr, int target,int start,int end)
        {
            for(int i = start; i <= end; i++)
            {
                if (arr[i] == target) 
                { 
                    return i;
                }
            }
            return -1;
        }
        public int jump_search(int[] arr, int target)
        {
            int len = arr.Length;
            int sqrt = (int) Math.Sqrt(len);
            int start = 0, end = sqrt;
            while(start <= len && end <= len)
            {
                if(target >= arr[start] && target <= arr[end])
                {
                    return linear_search(arr, target,start,end);
                }
                else
                {
                    start += sqrt;
                    end += sqrt;
                }
            }
            return -1;
        }
    }
}
