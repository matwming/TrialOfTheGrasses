using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class AddToArray_FormOfInteger
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            var result = new List<int>();
            uint arrValue = 0;
            for (int i = A.Length-1, j = 0; i >= 0; i--)
            {
                arrValue += (uint)(A[i] * Math.Pow(10,j));
                j++;
            }
            arrValue = (uint)(arrValue + K);
            while(arrValue!=0)
            {
                result.Add((int)arrValue%10);
                arrValue/=10;
            }
            result.Reverse();
            return result;
        }
    }
}