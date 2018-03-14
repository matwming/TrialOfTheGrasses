using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ToeplitzMatrix
    {
        public bool IsToeplitzMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + 1 < matrix.GetLength(0) && j + 1 < matrix.GetLength(1))
                    {
                        if (matrix[i, j] != matrix[i + 1, j + 1])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
