namespace leetcodesln
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int high = nums.Length - 1;
            int low = 0;

            while (low <= high)
            {
                var mid = (high + low) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) high = mid - 1;
                else low = mid + 1;
            }
            return -1;
        }
    }
}
