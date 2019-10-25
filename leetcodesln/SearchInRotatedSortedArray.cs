namespace leetcodesln
{
    public class SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;

            while (l < r)
            {
                var mid = l + (r - l) / 2;
                if (nums[mid] < nums[r]) r = mid;
                else l = mid + 1;
            }

            int shuffle = l;
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                var realmid = (mid + shuffle) % nums.Length;
                if (nums[realmid] == target) return realmid;
                else if (nums[realmid] > target) high = mid - 1;
                else low = mid + 1;
            }
            return -1;
        }
    }
}
