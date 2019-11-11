using System.Collections.Generic;

namespace leetcodesln
{
    public class SetMismatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            var sum = (1 + nums.Length) * nums.Length / 2;
            var table = new Dictionary<int, int>();


            for (int i = 0; i < nums.Length; i++)
            {

                if (table.ContainsKey(nums[i])) table[nums[i]]++;
                else
                {
                    table.Add(nums[i], 1);
                }
            }

            var duplicate = -1;
            var sum2 = 0;

            foreach (var t in table)
            {
                sum2 += t.Key;
                if (t.Value == 2)
                {
                    duplicate = t.Key;
                }
            }
            return new int[] { duplicate, sum - sum2 };
        }
    }
}
