using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class ThreeSum
    {
        public IList<IList<int>> ThreeSumSln(int[] nums)
        {
            Array.Sort(nums);

            var ans = new List<IList<int>>();

            for (int i = 0; i < nums.Length -2; i++)
            {
                var target = 0 - nums[i];

                var low = i + 1;
                var high = nums.Length - 1;
                while(low < high)
                {
                    if (nums[low] + nums[high] == target)
                    {
                        ans.Add(new List<int> { nums[i], nums[low], nums[high] });
                        while (low + 1 < high && nums[low + 1] == nums[low]) low++;
                        while (high - 1 > low && nums[high - 1] == nums[high]) high--;
                        low++;
                        high--;
                    }
                    else if (nums[low] + nums[high] > target) high--;
                    else low++;
                }
            }
            return ans;
        }
    }
}
