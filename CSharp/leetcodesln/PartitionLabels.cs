using System.Collections.Generic;

namespace leetcodesln
{
    public class PartitionLabels
    {
        public IList<int> PartitionLabelsSln(string s)
        {
            var ans = new List<int>();
            var lastSeen = new int[26];

            for (int i = 0; i < s.Length; ++i)
            {
                lastSeen[s[i] - 'a'] = i;
            }

            int r = 0;
            while (r < s.Length)
            {
                int l = r, start = l;
                while (l <= r)
                {
                    if (lastSeen[s[l] - 'a'] >= lastSeen[s[r] - 'a']) r = lastSeen[s[l] - 'a'];
                    l++;
                }
                ans.Add(r - start + 1);
                r++;
            }
            return ans;
        }
    }
}
