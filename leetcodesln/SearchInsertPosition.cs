namespace leetcodesln
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            var mid = (start + end) / 2;

            while (start <= end)
            {
                mid = (start + end) / 2;
                if (nums[mid] == target)
                {
                    break;
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            if (nums[mid] == target) return mid;
            else if (nums[mid] > target) return mid;
            else return mid + 1;
        }

        //private int BinarySearch(int[] nums, int target, int start, int end)
        //{
        //    if (nums[(end - start) / 2] == target) return (end - start) / 2;
        //    if ((end - start) / 2 > target) return BinarySearch(nums, target, start, (end - start) / 2);
        //    if ((end - start) / 2 < target) return BinarySearch(nums, target, (end - start) / 2, end);
        //    else return -1;
        //}
    }
}
