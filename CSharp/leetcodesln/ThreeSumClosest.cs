using System;

namespace leetcodesln
{
    public class ThreeSumClosest
    {
        public int ThreeSumClosestSln(int[] nums, int target)
        {
            Array.Sort(nums);

            if (nums.Length < 3) throw new Exception();

            var closest = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; ++i)
            {
                int low = i + 1, high = nums.Length - 1;

                while (low < high)
                {
                    int sum = nums[i] + nums[low] + nums[high];
                    if (sum < target)
                    {
                        //跳过相同的值
                        while (low + 1 < high && nums[low + 1] == nums[low]) low++;
                        low++;
                    }
                    else if (sum > target)
                    {
                        //跳过相同的值
                        while (high - 1 > low && nums[high - 1] == nums[high]) high--;
                        high--;
                    }
                    else return sum;
                    if (Math.Abs(target - sum) < Math.Abs(target - closest)) closest = sum;
                }
            }
            return closest;
        }
    }
}
