using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ShortestDistanceToACharacter
    {
        public int[] ShrtestToChar(String S, char C)
        {
            int[] result = new int[S.Length];
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i]==C)
                {
                    result[i] = 0;
                    continue;
                }
                int count = 0;
                for (int left = i, right = i; left >= 0 || right <= S.Length; left=i-count, right = i+count)
                {
                    if (left >=0 && S[left] == C )
                    {
                        result[i] = count;
                        break;
                    }
                    if (right < S.Length && S[right] == C)
                    {
                        result[i] = count;
                        break;
                    }
                    count++;
                }
            }
            return result;
        }
    }
}
