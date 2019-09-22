using System;

namespace leetcodesln
{
    public class ThreeSumClosest
    {
        public int ThreeSumClosestSln(int[] nums, int target)
        {

            Array.Sort(nums);

            int sum = 0;

            int? diff = null;

            for (int i = 0; i < nums.Length; ++i)
            {
                var t = target - nums[i];

                var low = i + 1;
                var high = nums.Length - 1;

                while (low < high)
                {
                    if (diff == null || diff > Math.Abs(t - nums[low] - nums[high]))
                    {
                        diff = Math.Abs(t - nums[low] - nums[high]);
                        sum = nums[i] + nums[low] + nums[high];
                        high--;
                    }
                    else if (diff == null || diff < Math.Abs(t - nums[low] - nums[high]))
                    {
                        diff = Math.Abs(t - nums[low] - nums[high]);
                        sum = nums[i] + nums[low] + nums[high];
                        low++;
                    }
                    else
                    {
                        low++;
                        high--;
                    }
                }
            }
            return sum;
        }
    }
}
