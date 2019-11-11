namespace leetcodesln
{
    public class SubarrayProductLessThanK
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            int ans = 0, prod = 1;

            for (int l = 0, r = 0; r < nums.Length; r++)
            {
                prod *= nums[r];
                while (prod >= k && l <= r)
                {
                    prod /= nums[l++];
                }
                // Each step introduces x new subarrays, where x is the size of the current window (j + 1 - i);
                // ex: {1,2,3}, add {4}
                // the continues subarray which includes 4 is:
                // { 4}, { 3,4}, { 2,3,4}, { 1,2,3,4} = num of element
                ans += (r - l + 1);
            }
            return ans;
        }
    }
}
