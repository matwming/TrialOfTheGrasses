namespace leetcodesln
{
    public class ThirdMaximumNumber
    {
        public int ThirdMax(int[] nums)
        {
            int? first = null;
            int? second = null;
            int? third = null;

            for (int i = 0; i < nums.Length; i++)
            {
                if (first == nums[i] || second == nums[i] || third == nums[i]) continue;

                if (first == null || nums[i] > first)
                {
                    third = second;
                    second = first;
                    first = nums[i];
                }
                else if (second == null || nums[i] > second)
                {
                    third = second;
                    second = nums[i];
                }
                else if (third == null || nums[i] > third)
                {
                    third = nums[i];
                }
            }
            return third == null ? first.GetValueOrDefault() : third.GetValueOrDefault();
        }
    }
}