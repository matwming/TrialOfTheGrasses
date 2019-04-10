using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class MissingNumber
    {
        // public int FindMissingNumber(int[] nums)
        // {
        //     int[] arr = new int[nums.Length + 1];
        //     for (int i = 0; i <nums.Length; i++)
        //     {
        //         arr[nums[i]] -= nums[i];
        //     }
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         if (arr[i]==0 && i!=0)
        //         {
        //             return i;
        //         }
        //     }
        //     return 0;
        // }

        //Gauss formula
        public int FindMissingNumber(int[] nums)
        {
            var sum = (0 + nums.Length + 1) * (nums.Length) / 2;

            foreach (var num in nums)
            {
                sum -= num;
            }
            return sum;
        }
    }
}
