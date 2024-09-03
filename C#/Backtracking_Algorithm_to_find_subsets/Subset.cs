using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking_Algorithm_to_find_subsets
{
    internal class Subset
    {
        public void FindSubsetsWithSum(int[] weights, int m)
        {
            List<int> current_subset = new List<int>();
            List<List<int>> result = new List<List<int>>();
            helper(weights, m, 0, current_subset, result);
            foreach (var subset in result)
            {
                Console.Write("[ ");
                foreach(int x in  subset)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine(" ]");
            }
        }

        private void helper(int[] weights, int m, int start, List<int> currentSubset, List<List<int>> result)
        {
            if (m == 0)
            {
                result.Add(new List<int>(currentSubset));
                return;
            }

            for (int i = start; i < weights.Length; i++)
            {
                if (i > start && weights[i] == weights[i - 1])
                    continue;

                if (weights[i] <= m)
                {
                    currentSubset.Add(weights[i]);
                    helper(weights, m - weights[i], i + 1, currentSubset, result);
                    currentSubset.RemoveAt(currentSubset.Count - 1);
                }
            }
        }
    }
}
