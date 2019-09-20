using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        // sliding window solution, time complexity O(n)
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            var set = new HashSet<int>();
            int l = 0;
            int r = 0;
            while (l < s.Length && r < s.Length)
            {
                if (!set.Contains(s[r]))
                {
                    set.Add(s[r++]);
                    max = max > r - l ? max : r - l;
                }
                else
                {
                    set.Remove(s[l++]);
                }
            }
            return max;
        }

        // sliding window optimized, having a hashtable to keep track with the characters most recent position, if duplicate is found, jump to the position +1
        public int OptimizedSolution(string s)
        {
            var dict = new Dictionary<char, int>();

            int max = 0;

            for (int l = 0, r = 0; l < s.Length; l++)
            {
                if (dict.ContainsKey(s[r]))
                {
                    l = Math.Max(l, dict[s[r]] + 1);
                    dict[s[r]] = r;
                }
                else
                {
                    dict[s[r]] = r;
                }
                max = Math.Max(max, r - l + 1);
            }
            return max;
        }
    }
}
