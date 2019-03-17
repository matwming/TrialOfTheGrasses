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
    }
}
