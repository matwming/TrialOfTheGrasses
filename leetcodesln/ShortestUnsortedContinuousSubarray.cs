using System;

namespace leetcodesln
{
    public class ShortestUnsortedContinuousSubarray
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            var deepCopy = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                deepCopy[i] = nums[i];
            }
            Array.Sort(deepCopy);
            var minIndex = nums.Length + 1;
            var maxIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (deepCopy[i] != nums[i])
                {
                    minIndex = minIndex < i ? minIndex : i;
                    maxIndex = maxIndex > i ? maxIndex : i;
                }
            }
            return Math.Abs(maxIndex - minIndex) > nums.Length ? 0 : maxIndex - minIndex + 1;
        }
    }
}
