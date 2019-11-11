namespace leetcodesln
{
    public class FindFirstAndLastPositionOfElementInSortArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var ans = new int[] { -1, -1 };

            int l = 0, r = nums.Length - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (nums[mid] == target)
                {
                    int low = mid;
                    while (low - 1 >= 0 && nums[low - 1] == nums[low]) low--;
                    ans[0] = low;
                    while (mid + 1 < nums.Length && nums[mid + 1] == nums[mid]) mid++;
                    ans[1] = mid;
                    break;
                }
                else if (nums[mid] > target) r = mid - 1;
                else l = mid + 1;
            }
            return ans;
        }
    }
}
