namespace leetcodesln
{
    public class Non_DecreasingArray
    {
        public bool CheckPossibility(int[] nums)
        {
            var modification = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (modification > 1) return false;

                var (att1, att2) = (true, true);
                if (!CanFit(nums, i))
                {
                    modification++;
                    if (i - 1 > 0)
                    {
                        var temp = nums[i - 1];
                        nums[i - 1] = nums[i];
                        if (!CanFit(nums, i - 1))
                        {
                            att1 = false;
                            nums[i - 1] = temp; // restore to its orginal value
                            nums[i] = nums[i - 1];
                            if (!CanFit(nums, i)) att2 = false;
                        }

                        if (!att1 && !att2) return false;
                    }
                }
            }
            return modification <= 1;
        }

        private bool CanFit(int[] nums, int i)
        {
            var pre = i - 1 >= 0 ? nums[i - 1] : int.MinValue;
            return nums[i] >= pre;
        }
    }
}
