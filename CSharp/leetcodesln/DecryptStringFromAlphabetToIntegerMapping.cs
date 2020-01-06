using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class DecryptStringFromAlphabetToIntegerMapping
    {
        public string FreqAlphabets(string s)
        {
            var ans = new StringBuilder();
            var start = 0;

            while (start < s.Length)
            {
                if(start + 2 < s.Length && s[start+2] == '#')
                {
                    var num = int.Parse(s.Substring(start,2));
                    ans.Append(((char)('a'+num -1)).ToString());
                    start += 3;
                }
                else 
                {
                    ans.Append(((char)('a' + s[start++] - '0'-1)).ToString());
                }
            }
            return ans.ToString();
        }
    }
}
