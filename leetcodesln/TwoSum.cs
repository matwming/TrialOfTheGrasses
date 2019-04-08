using System.Collections.Generic;

namespace leetcodesln
{
    public class TwoSum
    {
        /// <summary>
        /// This question we can use linear scan approach with two pointers, the time complexity will be O(N^2),
        /// we can also use a hashmap and find if the current value's complement exists in the array, the time complexity will be O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumSln(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>(); // to store value-index pair
            for (int i = 0; i < nums.Length; ++i)
            {
                var complement = target - nums[i];

                if (dict.ContainsKey(complement)) return new int[] { i, dict[complement] };
                dict[nums[i]] = i;
            }

            throw new KeyNotFoundException();
        }
    }
}
