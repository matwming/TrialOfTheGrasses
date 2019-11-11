using System.Collections.Generic;

namespace leetcodesln
{
    public class MajorityElementII
    {
        public IList<int> MajorityElement(int[] nums)
        {
            var ans = new List<int>();

            if (nums.Length == 0) return ans;

            int? maj1 = null, maj2 = null;
            int cnt1 = 0, cnt2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == maj1) cnt1++;
                else if (nums[2] == maj2) cnt2++;
                else if (cnt1 == 0)
                {
                    maj1 = nums[i];
                    cnt1 = 1;
                }
                else if (cnt2 == 0)
                {
                    maj2 = nums[i];
                    cnt2 = 1;
                }
                else
                {
                    cnt1--;
                    cnt2--;
                }
            }

            cnt1 = cnt2 = 0;

            foreach (var n in nums)
            {
                if (n == maj1) cnt1++;
                else if (n == maj2) cnt2++;
            }

            if (cnt1 > nums.Length / 3) ans.Add(maj1.Value);
            if (cnt2 > nums.Length / 3) ans.Add(maj2.Value);
            return ans;
        }
    }
}
