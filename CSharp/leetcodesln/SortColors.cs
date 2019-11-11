namespace leetcodesln
{
    public class SortColors
    {
        public void SortColorsSln(int[] nums)
        {
            int low = 0, high = nums.Length - 1;
            for (int i = 0; i <= high; i++)
            {
                if (nums[i] == 0)
                {
                    var temp = nums[low];
                    nums[low++] = nums[i];
                    nums[i] = temp;
                }
                else if (nums[i] == 2)
                {
                    var temp = nums[high];
                    nums[high--] = nums[i];
                    nums[i--] = temp;
                }
            }
        }
    }
}
