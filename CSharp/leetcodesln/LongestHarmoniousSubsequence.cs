using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodesln
{
    public class LongestHarmoniousSubsequence
    {
        public int FindLHS(int[] nums)
        {
            var max = 0;
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if(dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            foreach (var d in dict)
            {
                if(dict.ContainsKey(d.Key+1))
                {
                    max = max > (d.Value + dict[d.Key + 1]) ? max : (d.Value + dict[d.Key + 1]);
                }
            }
            return max;
        }
    }
}
