namespace leetcodesln
{
    public class SingleNumber
    {
        public int SingleNum(int[] nums)
        {
            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                ans ^= nums[i];
            }
            return ans;
        }
    }
}