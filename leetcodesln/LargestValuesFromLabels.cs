using System.Collections.Generic;

namespace leetcodesln
{
    public class LargestValuesFromLabels
    {
        public int LargestValsFromLabels(int[] values, int[] labels, int num_wanted, int use_limit)
        {
            var usedLabels = new Dictionary<int, int>();

            var bucket = new SortedDictionary<int, int>();

            foreach (var value in values)
            {
                if (bucket.ContainsKey(value)) bucket[value]++;
            }
            return -1; // TODO wip
        }
    }
}
