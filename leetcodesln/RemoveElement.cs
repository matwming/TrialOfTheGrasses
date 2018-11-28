using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodesln
{
    public class RemoveElement
    {
        public int RemoveElementSln(int[] nums, int val)
        {
            var totalLen = 0;
            for (int s = 0, e = nums.Length-1; s <= e; s++)
            {
                if(nums[s] == val)
                {
                    while(nums[e] == val && e > s)
                    {
                        e--;
                    }
                    if (s == e) break;
                    nums[s] = nums[e];
                    nums[e] = val;
                    totalLen++;
                }
                else
                {
                    totalLen++;
                }
            }
            return totalLen;
        }
    }
}
