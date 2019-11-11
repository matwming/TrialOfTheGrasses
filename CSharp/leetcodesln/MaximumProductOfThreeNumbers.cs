using System;
using System.Collections.Generic;
using System.Linq;
namespace leetcodesln
{
    public class MaximumProductOfThreeNumbers
    {
        public int MaximumProduct(int[] nums)
        {
            if(nums.Length ==3) return nums[0] * nums[1] * nums[2];

            var list = nums.ToList();
            list.Sort();
            var sorted = list.ToArray();
            
            var tmp1 = sorted[0] * sorted[1] * sorted[sorted.Length -1];
            var tmp2 = sorted[sorted.Length -1] * sorted[sorted.Length-2] * sorted[sorted.Length-3];
            return tmp1 > tmp2? tmp1 : tmp2;
        }
    }
}