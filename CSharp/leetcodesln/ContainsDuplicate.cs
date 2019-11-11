using System.Collections.Generic;

namespace leetcodesln
{
    public class ContainsDuplicate
    {
        public bool ContainsDuplicateSln(int[] nums)
        {
            var dict = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dict.ContainsKey(num)) return true;
                else dict[num] = 1;
            }
            return false;
        }
    }
}
