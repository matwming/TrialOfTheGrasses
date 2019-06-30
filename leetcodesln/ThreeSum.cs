using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class ThreeSum
    {
        public IList<IList<int>> ThreeSumSln(int[] nums)
        {
            var ans = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1] || nums[i] > 0) continue;
                Find(ref ans, ref nums, -nums[i], i + 1, nums.Length - 1);
            }
            return ans;
        }

        private void Find(ref List<IList<int>> ans, ref int[] nums, int complement, int left, int right)
        {
            while (left < right)
            {
                if (nums[left] + nums[right] == complement)
                {
                    var local = new List<int>();
                    local.Add(-complement);
                    local.Add(nums[left]);
                    local.Add(nums[right]);
                    ans.Add(local);
                    while (left < right && nums[left] == nums[left + 1]) { left++; }
                    while (left < right && nums[right] == nums[right - 1]) { right--; }
                    left++;
                    right--;
                }
                else if (nums[left] + nums[right] > complement) { right--; }
                else { left++; }
            }
        }
    }
}
