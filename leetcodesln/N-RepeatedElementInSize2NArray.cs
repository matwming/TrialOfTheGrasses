using System.Collections.Generic;

namespace leetcodesln
{
    public class N_RepeatedElementInSize2NArray
    {
        public int RepeatedNTimes(int[] A)
        {
            var N = A.Length / 2;

            var dict = new Dictionary<int, int>();

            foreach (var num in A)
            {
                if (dict.ContainsKey(num))
                {
                    ++dict[num];
                    if (dict[num] > 1) return num;

                }
                else dict.Add(num, 1);
            }
            throw null;
        }
    }
}
