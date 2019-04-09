using System.Collections.Generic;

namespace leetcodesln
{
    public class FindAllNumbersDisappearedInAnArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var ans = new List<int>();

            for (int i = 0; i < nums.Length; i++) nums[(nums[i] - 1) % nums.Length] += nums.Length;
            for (int i = 0; i < nums.Length; i++) if (nums[i] <= nums.Length) ans.Add(i + 1);
            return ans;
        }
    }
}
