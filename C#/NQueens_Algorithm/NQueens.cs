namespace NQueens_Algorithm
{
    public class NQueens
    {
        int N;
        int[] ld;
        int[] rd;
        int[] cl;
        int[,] board;
        List<int[,]> solutions;

        public NQueens(int no_of_queens)
        {
            this.N = no_of_queens;
            board = new int[N, N];
            ld = new int[2 * N - 1];
            rd = new int[2 * N - 1];
            cl = new int[N];
            solutions = new List<int[,]>();
        }

        public void place_NQueens()
        {
            helper(board, 0);
            foreach(var sol in solutions)
            {
                for(int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.Write(sol[i,j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private bool helper(int[,] board, int col)
        {
            if (col >= N)
            {
                // Add a copy of the board to solutions
                int[,] solution = new int[N, N];
                Array.Copy(board, solution, board.Length);
                solutions.Add(solution);
                return true;
            }
            bool foundSolution = false;
            for (int i = 0; i < N; i++)
            {
                if ((ld[i - col + N - 1] != 1 && rd[i + col] != 1) && cl[i] != 1)
                {
                    board[i, col] = 1;
                    ld[i - col + N - 1] = rd[i + col] = cl[i] = 1;
                    if (helper(board, col + 1))
                        foundSolution = true;
                    board[i, col] = 0;
                    ld[i - col + N - 1] = rd[i + col] = cl[i] = 0;
                }
            }
            return foundSolution;
        }
    }
}
