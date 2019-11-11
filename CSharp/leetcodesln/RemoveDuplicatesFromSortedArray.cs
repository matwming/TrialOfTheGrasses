namespace leetcodesln
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums.Length <= 1) return nums.Length == 1? 1: 0;

            var currentPtr = 1;
            var sortedPtr = 0;
            while(currentPtr < nums.Length)
            {
                if(nums[sortedPtr]== nums[currentPtr])
                {
                    currentPtr++;
                }
                else
                {
                    nums[sortedPtr+1] = nums[currentPtr];
                    sortedPtr++;
                    currentPtr++;
                }
            }
            return sortedPtr+1;
        }
    }
}