using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            var ans = 0;
            var jewels = new HashSet<char>();
            foreach (var chr in J)
            {
                jewels.Add(chr);
            }
            foreach (var chr in S)
            {
                if (jewels.Contains(chr))
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}
