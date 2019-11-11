namespace leetcodesln
{
    public class RemoveElement
    {
        public int RemoveElementSln(int[] nums, int val)
        {
            // two pointer high low switch

            int l = 0, r = nums.Length - 1;

            while (l <= r)
            {
                if (nums[l] == val)
                {
                    var temp = nums[r];
                    nums[r] = nums[l];
                    nums[l] = temp;
                    --r;
                }
                else
                {
                    l++;
                }
            }
            return r + 1;
        }
    }
}
