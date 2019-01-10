namespace leetcodesln
{
    public class FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            if (nums.Length == 0) return -1;

            var pivot = 0;
            var left = 0;
            var right = 0;

            for (int i = 0; i < pivot; i++)
            {
                left += nums[i];
            }

            for (int i = nums.Length - 1; i > pivot; i--)
            {
                right += nums[i];
            }

            while (pivot < nums.Length)
            {
                if (left == right) return pivot;

                if (pivot + 1 < nums.Length)
                {
                    left += nums[pivot];
                    right -= nums[pivot + 1];
                    pivot++;
                }
                else return -1;
            }
            return -1;
        }
    }
}
