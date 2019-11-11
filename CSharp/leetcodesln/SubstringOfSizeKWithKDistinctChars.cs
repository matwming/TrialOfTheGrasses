using System.Collections.Generic;

namespace leetcodesln
{
    public class SubstringOfSizeKWithKDistinctChars
    {
        public ICollection<string> GetSubstrs(string str, int k)
        {
            var ans = new HashSet<string>();
            var cur = new HashSet<char>();
            int curIdx = 0;
            for (int i = 0; i < str.Length; i++)
            {
                while (cur.Contains(str[i]))
                {
                    cur.Remove(str[curIdx++]);
                }

                cur.Add(str[i]);
                if (cur.Count == k)
                {
                    ans.Add(str.Substring(curIdx, k));
                    cur.Remove(str[curIdx]);
                    curIdx++;
                }

            }
            return ans;
        }
    }
}
