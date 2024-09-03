namespace Backtracking_Algorithm_to_find_subsets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subset subset = new Subset();
            int[] weights = { 5, 10, 12, 13, 15, 18 };
            subset.FindSubsetsWithSum(weights, 30);
        }
    }
}
