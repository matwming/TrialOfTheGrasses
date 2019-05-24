using System.Collections.Generic;

namespace leetcodesln
{
    public class FindAllDuplicatesInAnArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var ans = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int index;
                if (nums[i] > nums.Length)
                {
                    index = nums[i] % nums.Length == 0 ? nums.Length - 1 : nums[i] % nums.Length - 1;
                    nums[index] += nums.Length;

                }
                else
                {
                    index = nums[i] - 1;
                    nums[index] += nums.Length;
                }
                if (nums[index] > nums.Length * 2) ans.Add(index + 1);
            }
            return ans;
        }
    }
}
