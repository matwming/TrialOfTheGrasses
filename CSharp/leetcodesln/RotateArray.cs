namespace leetcodesln
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;

            var arr2 = new int[nums.Length * 2];

            for (int i = 0; i < arr2.Length; i++)
            {
                if (i < nums.Length) arr2[i] = nums[i];

                else arr2[i] = nums[i - nums.Length]; ;
            }
            for (int i = 0; i < nums.Length; i++) nums[i] = arr2[nums.Length - k + i];
        }

        public void RotateOptimal(int[] nums, int k)
        {
            var n = k % nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, n - 1);
            Reverse(nums, n, nums.Length - 1);
        }

        private void Reverse(int[] nums, int l, int r)
        {
            while (l < r)
            {
                var temp = nums[l];
                nums[l] = nums[r];
                nums[r] = temp;
                l++;
                r--;
            }
        }
    }
}
