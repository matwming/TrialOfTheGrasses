using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class FindAllAnagramsInAString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var resList = new List<int>();

            int[] hash = new int[256];
            foreach (var chr in p)
            {
                hash[chr]++;
            }

            int left = 0, right = 0, count = p.Length;


            while (right < s.Length)
            {
                if (hash[s[right++]]-- >= 1) count--;

                if (count == 0) resList.Add(left);

                if (right - left == p.Length && hash[s[left++]]++ >= 0) count++;
            }

            return resList;
        }
    }
}
