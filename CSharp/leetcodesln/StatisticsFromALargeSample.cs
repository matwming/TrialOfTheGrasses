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


            for (int i = 0; i < 255; i++)
            {
                if (count[i] != 0)
                {
                    min = min == null ? i : (min < i ? min : i);
                    max = max == null ? i : (max > i ? max : i);
                    totalCount += count[i];
                    totalSum += i * count[i];
                    if (currentMostAppearTimes < count[i])
                    {
                        mode = i;
                        currentMostAppearTimes = count[i];
                    }
                }
            }

            var curCount = 0;
            if (totalCount % 2 == 0)
            {
                for (int i = 0; i < count.Length; i++)
                {
                    for (int j = 0; j < count[i]; j++)
                    {
                        curCount += 1;
                        if (curCount == totalCount / 2) mIdxL = i;
                        if (curCount == totalCount / 2+1)
                        {
                            mIdxR = i;
                            break;
                        }
                    }

                }
            }
            else
            {
                for (int i = 0; i < count.Length; i++)
                {
                    for (int j = 0; j < count[i]; j++)
                    {
                        curCount += 1;
                        if (curCount == totalCount / 2)
                        {
                            mIdxL = mIdxR = i;
                            break;
                        }
                    }
                }
            }

            double? mean = Math.Round((double)totalSum / totalCount, 5);
            double? median = Math.Round((double)(mIdxL + mIdxR) / 2, 5);

            return new double[] { min.Value, max.Value, mean.Value, median.Value, mode.Value };
        }
    }
}
