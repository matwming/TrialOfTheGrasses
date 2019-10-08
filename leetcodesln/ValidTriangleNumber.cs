using System;

namespace leetcodesln
{
    public class ValidTriangleNumber
    {
        public int TriangleNumber(int[] nums)
        {
            Array.Sort(nums);

            int ans = 0;

            for (int i = 2; i < nums.Length; i++)
            {
                int left = 0, right = i - 1;
                while (left < right)
                {
                    if (nums[left] + nums[right] > nums[i])
                    {
                        ans += (right - left);
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return ans;
        }
    }
}