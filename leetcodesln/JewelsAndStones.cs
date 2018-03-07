using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string J , string S)
        {
            int num = 0;
            for (int i = 0; i < J.Length; i++)
            {
                for (int j = 0; j < S.Length; j++)
                {
                    if (J[i] == S[j])
                    {
                        num++;
                    }
                }
            }
            return num;
        }
    }
}
