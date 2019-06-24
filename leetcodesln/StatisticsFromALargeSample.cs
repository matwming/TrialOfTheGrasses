using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class StatisticsFromALargeSample
    {
        public double[] SampleStats(int[] count)
        {
            double? min = default;
            double? max = default;
            double? mode = default;
            int currentMostAppearTimes = 0;
            int totalSum = 0;

            int totalCount = 0;
            int mIdxL = 0;
            int mIdxR = 0;

            var list = new List<int>();

            for (int i = 0; i < 255; i++)
            {
                if (count[i] != 0)
                {
                    for (int j = 0; j < count[i]; j++)
                    {
                        list.Add(i);
                    }
                    min = min == null ? i : (min < i ? min : i);
                    max = max == null ? i : (max > i ? max : i);
                    totalCount += count[i];
                    totalSum += i * count[i];
                    if (currentMostAppearTimes < count[i])
                    {
                        mode = i;
                        currentMostAppearTimes = count[i];
                    }
                    if (totalCount % 2 == 0)
                    {
                        mIdxL = totalCount / 2 - 1;
                        mIdxR = totalCount / 2;
                    }
                    else
                    {
                        mIdxL = mIdxR = totalCount / 2;
                    }

                }
            }

            double? mean = Math.Round((double)totalSum / totalCount, 5);
            double? median = Math.Round((double)(list[mIdxL] + list[mIdxR]) / 2, 5);

            return new double[] { min.Value, max.Value, mean.Value, median.Value, mode.Value };
        }
    }
}
