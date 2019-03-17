using System.Collections.Generic;

namespace leetcodesln
{
    public class PairsOfSongsWithTotalDurationsDivisibleBy60
    {
        public int NumPairsDivisbleBy60(int[] time)
        {
            var modTable = new int[60];
            var count = 0;

            for (int i = 0; i < time.Length; i++)
            {
                modTable[time[i] % 60]++;
            }

            for (int j = 1; j < 30; j++)
            {
                count += modTable[j] * modTable[60 - j];
            }

            count += modTable[0] * (modTable[0] - 1) / 2;
            count += modTable[30] * (modTable[30] - 1) / 2;
            return count;
        }
    }
}