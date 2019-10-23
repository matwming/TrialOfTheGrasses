using System.Collections.Generic;

namespace leetcodesln
{
    public class MinimumWindowSubstring
    {
        public string MinWindow(string s, string t)
        {
            if (t.Length > s.Length) return "";

            var ans = string.Empty;
            var min = int.MaxValue;

            var dict = new Dictionary<char, int>();
            foreach (var chr in t)
            {
                if (dict.ContainsKey(chr)) dict[chr]++;
                else dict.Add(chr, 1);
            }

            int count = dict.Count;

            int l = 0, r = 0;

            while (r < s.Length)
            {
                if (dict.ContainsKey(s[r]))
                {
                    dict[s[r]]--;
                    if (dict[s[r]] == 0) count--;
                }

                r++;
                while (count == 0)
                {
                    if (dict.ContainsKey(s[l]))
                    {
                        dict[s[l]]++;
                        if (dict[s[l]] > 0) count++;
                    }
                    if (min > (r - l))
                    {
                        ans = s.Substring(l, r - l);
                        min = r - l;
                    }
                    l++;
                }
            }
            return ans;
        }
    }
}
