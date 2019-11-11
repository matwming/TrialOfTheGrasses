namespace leetcodesln
{
    public class CircularArrayLoop
    {
        public bool CircularArrayLoopSln(int[] nums)
        {
            var size = nums.Length;

            for (int i = 0; i < size; i++)
            {
                if (nums[i] == 0) continue;

                int slow = i, fast = GetIndex(nums, i);

                while (nums[fast] * nums[i] > 0 && nums[GetIndex(nums, fast)] * nums[i] > 0)
                {
                    if (slow == fast)
                    {
                        if (slow == GetIndex(nums, slow)) break;
                        return true;
                    }
                    slow = GetIndex(nums, slow);
                    fast = GetIndex(nums, GetIndex(nums, fast));
                }
                int j = i;
                int val = nums[i];
                while (nums[j] * val > 0)
                {
                    int next = GetIndex(nums, j);
                    nums[j] = 0;
                    j = next;
                }
            }
            return false;
        }


        int GetIndex(int[] arr, int i)
        {
            int n = arr.Length;
            return (i + arr[i] % n + n) % n;
        }
    }
}
