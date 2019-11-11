namespace leetcodesln
{
    public class CountNumberOfNiceSubarrays
    {
        public int NumberOfSubarrays(int[] nums, int k)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                int odd = 0;

                for (int j = i; j < nums.Length; ++j)
                {
                    if (nums[j] % 2 == 0) odd++;
                    if (odd == k) count++;
                }
            }

            return count;
        }
    }
}
