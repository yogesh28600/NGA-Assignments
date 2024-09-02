
namespace Longest_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = "aabcdefghij";
            string B = "ecdgi";
            LFS lfs = new LFS();
            lfs.LFS_algorithm(A, B);
        }
    }
}
