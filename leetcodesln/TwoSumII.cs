using System;

namespace leetcodesln
{
    public class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[left] + numbers[right] > target) --right;
                else if (numbers[left] + numbers[right] < target) ++left;
                else return new int[] { left + 1, right + 1 };
            }

            throw new Exception();
        }
    }
}
