using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class K_DiffPairsInAnArray
    {
        //public int FindPairs(int[] nums, int k)
        //{
        //    var count = 0;

        //    if (k == 0)
        //    {
        //        var set = new HashSet<int>();
        //        for (int i = 0; i < nums.Length; i++)
        //        {
        //            if (set.Contains(nums[i])) continue;
        //            for (int j = i + 1; j < nums.Length; j++)
        //            {
        //                if (nums[i] == nums[j])
        //                {
        //                    count++;
        //                    set.Add(nums[i]);
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        var set = new HashSet<int>();
        //        for (int i = 0; i < nums.Length; i++)
        //        {
        //            set.Add(nums[i]);
        //        }
        //        var noDupArray = new int[set.Count];
        //        set.CopyTo(noDupArray);

        //        for (int i = 0; i < noDupArray.Length; i++)
        //        {
        //            for (int j = i + 1; j < noDupArray.Length; j++)
        //            {
        //                if (Math.Abs(noDupArray[j] - noDupArray[i]) == k) count++;
        //            }
        //        }
        //    }
        //    return count;
        //}

        public int FindPairs(int[] nums, int k)
        {
            if (nums.Length == 0 || k < 0) return 0;

            var dict = new Dictionary<int, int>();
            int count = 0;

            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, dict.GetValueOrDefault(num, 0) + 1);
                }
                else
                {
                    dict[num] = dict.GetValueOrDefault(num, 0) + 1;
                }
            }

            foreach (var entry in dict)
            {
                if (k == 0)
                {
                    if (entry.Value >= 2) count++;
                }
                else
                {
                    if (dict.ContainsKey(entry.Key + k)) count++;
                }
            }
            return count;
        }

        public int FindPairsBinarySearch(int[] nums, int k)
        {
            Array.Sort(nums);
            int ans = 0;
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                int l = i + 1, r = nums.Length - 1;
                while (l <= r)
                {
                    var mid = (r + l) / 2;
                    if (nums[mid] - nums[i] == k)
                    {
                        ans++;
                        break;
                    }
                    else if (nums[mid] - nums[i] > k) r = mid - 1;
                    else l = mid + 1;
                }
                while (i < nums.Length - 2 && nums[i + 1] == nums[i]) i++;
            }
            return ans;
        }
    }
}
