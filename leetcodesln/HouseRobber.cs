using System;

namespace leetcodesln
{
    public class HouseRobber
    {
        private int[] dp { get; set; }

        public int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int prepre = nums[0];
            int pre = Math.Max(nums[0], nums[1]);


            for (int i = 2; i < nums.Length; i++)
            {
                var curMax = Math.Max(prepre + nums[i], pre);
                prepre = pre;
                pre = curMax;
            }
            return pre;
        }


    }
}
