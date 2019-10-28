using System.Collections.Generic;

namespace leetcodesln
{
    public class SummaryRanges
    {
        public IList<string> SummaryRangesSln(int[] nums)
        {
            var ans = new List<string>();

            int l = 0, r = 0;
            while (r < nums.Length)
            {
                if (r + 1 < nums.Length && nums[r] + 1 == nums[r + 1]) r++;
                else
                {
                    if (l == r)
                    {
                        ans.Add(nums[r].ToString());
                        r++;
                        l = r;
                    }
                    else
                    {
                        var s = nums[l] + "->" + nums[r];
                        ans.Add(s);
                        ++r;
                        l = r;
                    }
                }

            }
            return ans;
        }
    }
}
