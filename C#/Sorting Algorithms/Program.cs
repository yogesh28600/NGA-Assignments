namespace Assignments_SortingAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInts = { 5, 8, 4, 3, 0, 1, 7, 6, 10, 50, 40, 60, 20 };
            MergeSort ms = new MergeSort();
            ms.merge_sort(arrayInts,0,arrayInts.Length-1);
            foreach(int i in arrayInts)
            {
                Console.Write(i+" ");
            }
        }
    }
}
