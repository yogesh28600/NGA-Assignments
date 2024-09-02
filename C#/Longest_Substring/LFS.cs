namespace Longest_Substring
{
    public class LFS
    {
        int[,] dp_table;
        public void LFS_algorithm(string A, string B)
        {
            int m = A.Length;
            int n = B.Length;
            dp_table = new int[m+1,n+1];
            for(int i = 1; i <= A.Length ; i++)
            {
                for(int j = 1; j <= B.Length; j++)
                {
                    if (A[i-1] == B[j - 1])
                    {
                        dp_table[i, j] = dp_table[i - 1, j - 1] + 1;

                    }
                    else
                    {
                        dp_table[i, j] = Math.Max(dp_table[i, j - 1], dp_table[i - 1, j]);
                    }
                }
            }
            int idx = dp_table[m, n];
            char[] result = new char[idx];
            while(m>0 && n > 0)
            {
                if (A[m-1] == B[n - 1])
                {
                    result[idx - 1] = A[m - 1];
                    m--;
                    n--;
                    idx--;
                }
                else if (dp_table[m-1,n] > dp_table[m,n-1])
                {
                    m--;
                }
                else
                {
                    n--;
                }
            }
            //Dispaly Output
            Console.WriteLine($"The length of Longest subsequence is: {dp_table[m,n]}");
            Console.WriteLine($"The longest subsequence is:");
            foreach (char c in result) Console.Write(c);
        }
    }
}
