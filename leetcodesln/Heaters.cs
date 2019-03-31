using System;

namespace leetcodesln
{
    public class Heaters
    {
        public int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(heaters);

            var minimumRadius = 0;

            for (int i = 0; i < houses.Length; i++)
            {
                var min = GetMinimumRadius(heaters, houses[i]);
                minimumRadius = minimumRadius > min ? minimumRadius : min;
            }
            return minimumRadius;
        }

        private int GetMinimumRadius(int[] heaters, int house)
        {
            int low = 0, high = heaters.Length - 1;

            if (house < heaters[low]) return heaters[low] - house;
            if (house > heaters[high]) return house - heaters[high];

            while (low <= high)
            {
                var mid = (low + high) / 2;
                if (heaters[mid] == house) return 0;
                else if (heaters[mid] > house) high = mid - 1;
                else low = mid + 1;
            }
            return heaters[low] - house < house - heaters[high] ? heaters[low] - house : house - heaters[high];
        }
    }
}