using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class CombinationSum
    {
        public IList<IList<int>> CombinationSumSln(int[] candidates, int target)
        {
            var results = new List<IList<int>>();
            var result = new List<int>();
            Array.Sort(candidates);
            Dfs(ref results, result, candidates, target, 0);
            return results;
        }

        void Dfs(ref List<IList<int>> results, List<int> result, int[] candidates, int target, int position)
        {
            if (target == 0)
            {
                results.Add(new List<int>(result));
                return;
            }

            for (int i = position; i < candidates.Length && target - candidates[i] >= 0; ++i)
            {
                result.Add(candidates[i]);
                Dfs(ref results, result, candidates, target - candidates[i], i);
                result.RemoveAt(result.Count - 1);
            }
        }
    }
}
