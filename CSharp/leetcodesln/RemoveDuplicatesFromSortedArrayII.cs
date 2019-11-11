namespace leetcodesln
{
    public class RemoveDuplicatesFromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;

            int ans = 1, fast = 1, cnt = 1;

            while (fast < nums.Length)
            {
                if (nums[fast] != nums[fast - 1])
                {
                    cnt = 1;
                    nums[ans++] = nums[fast];
                }
                else
                {
                    if (cnt < 2)
                    {
                        cnt++;
                        nums[ans++] = nums[fast];
                    }
                }
                fast++;
            }
            return ans;
        }
    }
}
