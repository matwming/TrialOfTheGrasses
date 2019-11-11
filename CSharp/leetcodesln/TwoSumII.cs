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

        public int[] TwoSumOptimal(int[] numbers, int target)
        {
            int l = 0, r = numbers.Length - 1;
            while (l < r)
            {
                if (numbers[l] + numbers[r] == target)
                {
                    return new[] { l + 1, r + 1 };
                }
                else if (numbers[l] + numbers[r] > target)
                {
                    while (l < r && numbers[r] == numbers[r - 1]) r--;  // skip duplicates
                    r--;
                }
                else
                {
                    while (l < r && numbers[l] == numbers[l + 1]) l++;
                    l++;
                }
            }
            throw new Exception();
        }
    }
}
