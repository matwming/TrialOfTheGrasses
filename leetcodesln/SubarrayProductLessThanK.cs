namespace leetcodesln
{
    public class SubarrayProductLessThanK
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            int l = 0, r = 0, prod = 1, ans = 0;
            while (r < nums.Length)
            {
                if (nums[r] < k) ans++;
                prod *= nums[r];
                if (prod < k)
                {
                    if (l != r) ans++;
                    r++;
                }
                else
                {
                    if (l <= r) prod /= nums[l++];
                }
            }
            return ans;
        }
    }
}
