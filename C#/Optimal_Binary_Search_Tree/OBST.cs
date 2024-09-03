using System;

namespace Optimal_Binary_Search_Tree
{
    public class OBST
    {
        private int[,] cost_table;
        private int[,] root_table;

        public int optimal_BST(int[] keys, int[] frequencies)
        {
            int len = keys.Length;
            cost_table = new int[len + 1, len + 1];
            root_table = new int[len + 1, len + 1];
            for (int i = 0; i <= len; i++)
            {
                cost_table[i, i] = 0;
                root_table[i, i] = -1;
            }
            for (int length = 1; length <= len; length++)
            {
                for (int i = 0; i <= len - length; i++)
                {
                    int j = i + length - 1;
                    cost_table[i, j] = int.MaxValue;

                    int sum = helper(frequencies, i, j);

                    for (int r = i; r <= j; r++)
                    {
                        int cost = ((r > i) ? cost_table[i, r - 1] : 0) +  ((r < j) ? cost_table[r + 1, j] : 0) +
                                   sum;

                        if (cost < cost_table[i, j])
                        {
                            cost_table[i, j] = cost;
                            root_table[i, j] = r;
                        }
                    }
                }
            }

            return cost_table[0, len - 1];
        }
        private int helper(int[] frequencies, int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += frequencies[i];
            }
            return sum;
        }

    }
}
