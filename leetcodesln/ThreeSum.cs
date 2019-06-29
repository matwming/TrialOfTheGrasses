using System.Collections.Generic;

namespace leetcodesln
{
    public class ThreeSum
    {
        public IList<IList<int>> ThreeSumSln(int[] nums)
        {
            var ans = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                var complement = -current;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i) continue;

                    var cur = nums[j];
                    var comp = complement - cur;
                    for (int s = 0; s < nums.Length; s++)
                    {
                        if (nums[s] == comp && s != j && s != i)
                        {
                            ans.Add(new List<int> { nums[i], nums[j], nums[s] });
                        }
                    }
                }
            }
            return ans;
        }
    }
}
