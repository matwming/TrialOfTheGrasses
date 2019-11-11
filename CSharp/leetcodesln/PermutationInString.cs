using System.Collections.Generic;

namespace leetcodesln
{
    public class PermutationInString
    {
        public bool CheckInclusion(string s2, string s1)
        {
            if (s2.Length > s1.Length) return false;

            var dict = new Dictionary<char, int>();

            foreach (var chr in s2)
            {
                if (dict.ContainsKey(chr)) dict[chr]++;
                else dict.Add(chr, 1);
            }

            int counter = dict.Count;
            int l = 0, r = 0;

            while (r < s1.Length)
            {
                if (dict.ContainsKey(s1[r]))
                {
                    dict[s1[r]]--;
                    if (dict[s1[r]] == 0) counter--;
                }
                r++;

                while (counter == 0)
                {
                    if (dict.ContainsKey(s1[l]))
                    {
                        dict[s1[l]]++;
                        if (dict[s1[l]] > 0) counter++;
                    }
                    if (r - l == s2.Length) return true;
                    l++;
                }
            }
            return false;
        }
    }
}
