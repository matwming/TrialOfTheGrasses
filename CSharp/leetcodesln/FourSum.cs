using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class FourSum
    {
        public IList<IList<int>> FourSumSln(int[] nums, int target)
        {
            var ans = new List<IList<int>>();
            if (nums.Length < 4) return ans;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 3; ++i)
            {
                for (int j = i + 1; j < nums.Length - 2; ++j)
                {
                    int l = j + 1, r = nums.Length - 1;
                    var comp = target - nums[i] - nums[j];
                    while (l < r)
                    {
                        if (nums[l] + nums[r] == comp)
                        {
                            ans.Add(new List<int> { nums[i], nums[j], nums[l], nums[r] });
                            while (l + 1 < r && nums[l + 1] == nums[l]) ++l;
                            while (r - 1 > l && nums[r - 1] == nums[r]) --r;
                            ++l;
                            --r;
                        }
                        else if (nums[l] + nums[r] > comp)
                        {
                            while (r - 1 > l && nums[r - 1] == nums[r]) --r;
                            --r;
                        }
                        else
                        {
                            while (l + 1 < r && nums[l + 1] == nums[l]) ++l;
                            ++l;
                        }
                    }
                    while (j + 1 < nums.Length - 2 && nums[j + 1] == nums[j]) ++j;
                }
                while (i + 1 < nums.Length - 3 && nums[i + 1] == nums[i]) ++i;
            }
            return ans;
        }
    }
}
