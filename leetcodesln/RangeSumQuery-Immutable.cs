using System;

namespace leetcodesln
{
    public class RangeSumQuery_Immutable
    {
        private int[] _nums;

        public RangeSumQuery_Immutable(int[] nums)
        {
            _nums = new int[nums.Length + 1];
            _nums[0] = 0;
            for (int i = 1; i <= nums.Length; i++)
            {
                _nums[i] = _nums[i - 1] + nums[i - 1];
            }
        }

        public int SumRange(int i, int j)
        {
            return _nums[j + 1] - _nums[i];
        }


    }
}
