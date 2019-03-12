using System;

namespace leetcodesln
{
    public class ShortestUnsortedContinuousSubarray
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            var count = 0;
            var deepCopy = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                deepCopy[i] = nums[i];
            }
            Array.Sort(deepCopy);
            for (int i = 0; i < nums.Length; i++)
            {
                if (deepCopy[i] == nums[i])
                {
                    var isPreMoved = i - 1 >= 0 ? deepCopy[i - 1] != nums[i - 1] : false;
                    var isNextMoved = i + 1 < nums.Length ? deepCopy[i + 1] != nums[i + 1] : false;
                    if (!isPreMoved && !isNextMoved) count++;
                    if (!isPreMoved && isNextMoved) count++;
                    if (isPreMoved && !isNextMoved) count++;
                }
            }
            return nums.Length - count;
        }
    }
}
