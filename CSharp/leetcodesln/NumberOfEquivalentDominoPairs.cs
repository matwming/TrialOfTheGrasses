using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class NumberOfEquivalentDominoPairs
    {
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            int ans = 0;
            var dict = new Dictionary<int, List<int[]>>();

            for (int i = 0; i < dominoes.Length; i++)
            {
                var domino = dominoes[i];
                var sum = domino[0] + domino[1];
                if (dict.ContainsKey(sum))
                {
                    foreach (var item in dict[sum].ToList())
                    {
                        if (item[0] == domino[0] || item[1] == domino[0])
                        {
                            ans++;
                        }
                    }
                    dict[sum].Add(new[] { domino[0], domino[1] });

                }
                else
                {
                    dict.Add(sum, new List<int[]> { new[] { domino[0], domino[1] } });
                }
            }
            return ans;
        }
    }
}
