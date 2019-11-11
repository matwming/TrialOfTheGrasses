using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class SortArrayByParityII
    {
        public int[] SortArrayByParityIISln(int[] A)
        {
            var result = new int[A.Length];
            int even =0, odd = 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i]%2==0)
                {
                    result[even] = A[i];
                    even += 2;
                }
                else
                {
                    result[odd] = A[i];
                    odd += 2;
                }
            }
            return result;
        }
    }
}
