using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new int[numRows][];
            for (int i = 0; i < numRows; i++)
            {
                result[i] = new int[i + 1];
                result[i][0] = 1;
                result[i][result[i].Length - 1] = 1;
            }

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    if(result[i][j]==0)
                    {
                        result[i][j] = result[i - 1][j - 1] + result[i - 1][j];
                    }
                }
            }

            return result;
        }
    }
}
