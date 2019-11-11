using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodesln
{
    public class SmallestRangeI
    {
        public int FindSmallestRangeI(int[] A, int K)
        {

            int[] nondup = A.Distinct().ToArray();
            Array.Sort(nondup);
            if (nondup.Length<=1 || nondup[nondup.Length - 1] - nondup[0] <= K * 2)
            {
                return 0;
            }
            return (nondup[nondup.Length - 1] - nondup[0]) - K * 2; 
        }
    }
}
