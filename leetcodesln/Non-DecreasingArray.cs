namespace leetcodesln
{
    public class Non_DecreasingArray
    {
        public bool CheckPossibility(int[] nums)
        {
            var modification = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (modification > 1) return false;

                if (CanFit(nums, i)) modification++;
                else return false;
            }
            return modification <= 1;
        }

        private bool CanFit(int[] nums, int i)
        {
            var pre = i - 1 >= 0 ? nums[i - 1] : int.MinValue;
            var next = i + 1 < nums.Length ? nums[i + 1] : int.MaxValue;
            return next - pre >= 2;
        }
    }
}
