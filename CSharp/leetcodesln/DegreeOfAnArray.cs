using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class DegreeOfAnArray
    {
        public int FindShortestSubArray(int[] nums)
        {
            if (nums.Length==0 || nums==null)
            {
                return 0;
            }

            Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    // int[]: first->count of element, second->index of first time apparence, third-> index of last time apparence
                    dictionary.Add(nums[i], new int[] {1,i,i});
                }
                else
                {
                    dictionary[nums[i]][0]++;
                    dictionary[nums[i]][2] = i;
                }
            }

            int degree = int.MinValue;
            int sub = int.MaxValue;
            foreach (var value in dictionary.Values)
            {
                if (value[0]>degree)
                {
                    degree = value[0];
                    sub = value[2] - value[1] + 1;
                }
                else if (value[0]==degree)
                {
                    sub = Math.Min(sub, value[2]-value[1]+1);
                }
            }
            return sub;
        }
    }
}
