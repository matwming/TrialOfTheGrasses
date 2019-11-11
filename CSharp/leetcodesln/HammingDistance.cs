using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class HammingDistance
    {
        public int HammingDistanceSolution(int x, int y)
        {
            var xorRes = x ^ y;
            var xorResToBinary = Convert.ToString(xorRes, 2);
            int count = 0;
            foreach (var c in xorResToBinary)
            {
                if('1'.Equals(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
