using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        // sliding window solution
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
    }
}
