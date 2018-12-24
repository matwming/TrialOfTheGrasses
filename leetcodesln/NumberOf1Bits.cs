using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class NumberOf1Bits
    {
        Dictionary<uint, int> map = new Dictionary<uint, int>
        {
            [0] = 0,
            [1] = 1,
            [2] = 1,
            [3] = 2,
            [4] = 1,
            [5] = 2,
            [6] = 2,
            [7] = 3,
            [8] = 1,
            [9] = 2,
            [10] = 2,
            [11] = 3,
            [12] = 2,
            [13] = 3,
            [14] = 3,
            [15] =4
        };
        public int HammingWeight(uint n)
        {
            var countOf1s = 0;

            while(n !=0)
            {
                var x = (n & 15);
                countOf1s += map[x];
                n = (n >> 4);
            }
            return countOf1s;
        }
    }
}
