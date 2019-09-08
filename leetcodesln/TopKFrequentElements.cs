using System.Collections.Generic;

namespace leetcodesln
{
    public class TopKFrequentElements
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var ans = new List<int>();
            var frequencyTable = new Dictionary<int, int>();
            int maxCount = 0;

            //build frequency table [key:number, value: frequency]
            foreach (var num in nums)
            {
                var f = frequencyTable.ContainsKey(num) ? frequencyTable[num] + 1 : 1;
                frequencyTable[num] = f;
                maxCount = maxCount > f ? maxCount : f;
            }

            // build frequency bucket
            var bucket = new IList<int>[maxCount + 1];
            foreach (var d in frequencyTable)
            {
                int count = d.Value;
                if (bucket[count] == null) bucket[count] = new List<int>();
                bucket[count].Add(d.Key);
            }

            for (int i = bucket.Length - 1; i >= 0 && k > 0; i--)
            {
                if (bucket[i] != null)
                {
                    foreach (var num in bucket[i])
                    {
                        ans.Add(num);
                        k -= bucket[i].Count;
                    }
                }
            }
            return ans;
        }
    }
}
