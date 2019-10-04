using System.Collections.Generic;

namespace leetcodesln
{
    public class LongestWordInDictionaryThroughDeleting
    {
        public string FindLongestWord(string s, IList<string> d)
        {
            string ans = string.Empty;

            foreach (var str in d)
            {
                if (IsSubstring(s, str))
                {
                    if (ans.Length < str.Length || (ans.Length == str.Length && ans.CompareTo(str) > 0))
                    {
                        ans = str;
                    }
                }
            }
            return ans;
        }

        bool IsSubstring(string s, string d)
        {
            int sptr = 0, dptr = 0;

            while (sptr < s.Length && dptr < d.Length)
            {
                if (s[sptr++] == d[dptr]) dptr++;
            }
            return dptr == d.Length;
        }
    }
}
