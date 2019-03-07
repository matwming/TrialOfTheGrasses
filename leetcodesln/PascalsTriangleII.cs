using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            var result = new int[rowIndex + 1];
            Array.Fill(result, 1);
            for (int i = 1; i < result.Length - 1; i++)
            {
                if (result[i] == 1)
                {
                    result[i] = GetValue(rowIndex-1, i);
                }
            }

            return result;
        }

        private int GetValue(int rowIndex, int i)
        {
            if (rowIndex == i - 1 || i == 0) return 1;

            return GetValue(rowIndex - 1, i - 1) + GetValue(rowIndex - 1, i);
        }
    }
}
