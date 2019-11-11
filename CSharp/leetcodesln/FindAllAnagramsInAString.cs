using System.Collections.Generic;

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

        // template for solving all substring search problem with sliding window
        public IList<int> FindAnagramsTwoPointerSlidingWindow(string s, string t)
        {
            // init a collection for result
            var ans = new List<int>();

            // create a hashtable to save the chars of the target string
            // K,V -> (char, frequence of the char)
            var dict = new Dictionary<char, int>();

            foreach (var chr in t)
            {
                if (dict.ContainsKey(chr)) dict[chr]++;
                else dict.Add(chr, 1);
            }

            // maintain a counter to check whether match the target string
            int counter = dict.Count;

            // two pointers: left and right of the window
            int l = 0, r = 0;

            while (r < s.Length)
            {
                if (dict.ContainsKey(s[r]))
                {
                    dict[s[r]]--;
                    if (dict[s[r]] == 0) counter--;
                }
                r++;

                while (counter == 0)
                {
                    if (dict.ContainsKey(s[l]))
                    {
                        dict[s[l]]++;
                        if (dict[s[l]] > 0) counter++;
                    }
                    if (r - l == t.Length) ans.Add(l);
                    l++;
                }
            }
            return ans;
        }
    }
}
