using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    if(Math.Abs(i-dict[nums[i]]) <= k) return true;
                    dict[nums[i]] = i;
                }
                else dict.Add(nums[i],i);
            }
            return false;
        }
    }
}