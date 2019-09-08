using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class SortCharactersByFrequency
    {
        public string FrequencySort(string s)
        {
            var ans = new StringBuilder();
            var maxCount = 0;
            var dict = new Dictionary<char, int>();
            foreach (var chr in s)
            {
                var count = dict.ContainsKey(chr) ? dict[chr] + 1 : 1;
                dict[chr] = count;
                maxCount = maxCount > count ? maxCount : count;
            }

            // k-char v - count
            var bucket = new List<char>[maxCount + 1];

            foreach (var d in dict)
            {
                if (bucket[d.Value] == null)
                {
                    bucket[d.Value] = new List<char>();
                    for (int i = 0; i < d.Value; i++)
                    {
                        bucket[d.Value].Add(d.Key);
                    }
                }
                else
                {
                    for (int i = 0; i < d.Value; i++)
                    {
                        bucket[d.Value].Add(d.Key);
                    }
                }
            }

            for (int i = bucket.Length - 1; i >= 0; i--)
            {
                if (bucket[i] != null)
                {
                    foreach (var item in bucket[i])
                    {
                        ans.Append(item);
                    }
                }
            }
            return ans.ToString();
        }
    }
}
