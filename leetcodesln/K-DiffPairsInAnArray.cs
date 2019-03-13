using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class K_DiffPairsInAnArray
    {
        public int FindPairs(int[] nums, int k)
        {
            var count = 0;

            if (k == 0)
            {
                var set = new HashSet<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (set.Contains(nums[i])) continue;
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            count++;
                            set.Add(nums[i]);
                            break;
                        }
                    }
                }
            }
            else
            {
                var set = new HashSet<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    set.Add(nums[i]);
                }
                var noDupArray = new int[set.Count];
                set.CopyTo(noDupArray);

                for (int i = 0; i < noDupArray.Length; i++)
                {
                    for (int j = i + 1; j < noDupArray.Length; j++)
                    {
                        if (Math.Abs(noDupArray[j] - noDupArray[i]) == k) count++;
                    }
                }
            }
            return count;
        }
    }
}
