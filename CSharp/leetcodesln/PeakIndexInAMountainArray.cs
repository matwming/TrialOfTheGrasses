using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class PeakIndexInAMountainArray
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            if (A.Length ==1)
            {
                return 0;
            }
            for (int i = 0; i < A.Length -1; i++)
            {
                
                if (A[i] - A[i+1]>0)
                {
                    return i;
                }
            }
            throw new Exception("not a mountain array");
        }
    }
}
