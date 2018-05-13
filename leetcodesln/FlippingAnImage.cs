using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class FlippingAnImage
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Array.Reverse(A[i]);
                for (int j = 0; j < A[i].Length; j++)
                {
                    A[i][j] = 1 - A[i][j];
                }
            }
            return A;
        }
    }
}
