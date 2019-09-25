namespace leetcodesln
{
    public class MinimumSizeSubarraySum
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            if (nums.Length == 0) return 0;
            int l = 0, r = 0, min = nums.Length, cur = 0;

            while (r < nums.Length)
            {
                cur += nums[r];
                if (cur >= s)
                {
                    min = min < r + 1 - l ? min : r + 1 - l;
                }

                while (cur - s >= nums[l])
                {
                    cur -= nums[l++];
                    min = min < r + 1 - l ? min : r + 1 - l;
                }


                r++;
            }
            return (l == 0 && cur < s) ? 0 : min;
        }
    }
}
