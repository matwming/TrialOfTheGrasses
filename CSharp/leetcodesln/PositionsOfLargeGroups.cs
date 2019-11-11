using System.Collections.Generic;

namespace leetcodesln
{
    public class PositionsOfLargeGroups
    {
        public IList<IList<int>> LargeGroupPosition(string S)
        {
            var result = new List<IList<int>>();
            for (int i = 0; i < S.Length; i++)
            {
                Aux(i, S, out int end);
                if(end - i>=2)
                {
                    result.Add(new List<int>{i, end});
                    i = end;
                    continue;
                }
            }
            return result;
        }

        private void Aux(int pos, string S, out int end)
        {
            end = 0;
            var current = S[pos];
            for (int i = pos; i < S.Length; i++)
            {
                if(S[i]==current)
                {
                    end = i;
                }
                else
                {
                    break;
                }
            }
        }
    }

    
}