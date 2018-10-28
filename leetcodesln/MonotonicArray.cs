using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class MonotonicArray
    {
        public bool IsMonotonic(int[] A)
        {
            if (A.Length <= 1) return true;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] - A[i]-1 ==0)
                {
                    continue;
                }
                else
                {
                    if (A[i] - A[i - 1] > 0)
                    {
                        for (int j = i + 1; j < A.Length; j++)
                        {
                            if (A[j] - A[j - 1] < 0)
                            {
                                return false;
                            }
                        }

                    }
                    else if (A[i] - A[i - 1] < 0)
                    {
                        for (int k = i + 1; k < A.Length; k++)
                        {
                            if (A[k] - A[k - 1] > 0)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
