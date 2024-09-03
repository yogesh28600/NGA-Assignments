namespace Optimal_Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = { 10, 20, 30, 40 };
            int[] frequencies = { 4, 2, 6, 3 };
            OBST obst = new OBST();
            Console.WriteLine($"The optimal BST cost: { obst.optimal_BST(keys, frequencies)}");
            

        }
    }
}
