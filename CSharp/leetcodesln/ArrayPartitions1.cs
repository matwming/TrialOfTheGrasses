using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ArrayPartitions1
    {
       public int ArrayPairSum(int[] nums)
        {
            int sum = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                list.Add(nums[i]);
            }
            list.Sort();
            for (int i = 0; i < list.Count; i+=2)
            {
                sum += list[i];
            }
            return sum;
        }
    }
}
