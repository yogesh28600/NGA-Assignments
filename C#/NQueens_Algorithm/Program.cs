namespace NQueens_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NQueens nq = new NQueens(8);
            nq.place_NQueens();
        }
    }
}
