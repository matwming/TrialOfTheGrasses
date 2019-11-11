using System;

namespace leetcodesln
{
    public class DietPlanPerformance
    {
        public int DietPlanPerform(int[] calories, int k, int lower, int upper)
        {
            int totalPoints = 0;

            if (k > calories.Length)
            {
                throw new Exception();
            }

            int currentWindow = 0;
            for (int i = 0; i < k; i++)
            {
                currentWindow += calories[i];
            }

            if (currentWindow < lower)
            {
                totalPoints--;
            }
            if (currentWindow > upper)
            {
                totalPoints++;
            }

            for (int i = k, j = 0; i < calories.Length; i++)
            {
                currentWindow -= calories[j++];
                currentWindow += calories[i];
                if (currentWindow < lower)
                {
                    totalPoints--;
                }
                if (currentWindow > upper)
                {
                    totalPoints++;
                }
            }
            return totalPoints;
        }
    }
}
