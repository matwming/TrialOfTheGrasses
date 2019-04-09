namespace leetcodesln
{
    public class MoveZeroes
    {
        public void MoveZeroesSln(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length - counter;)
            {
                if (nums[i] == 0)
                {
                    for (int j = i + 1; j < nums.Length - counter; j++)
                    {
                        nums[j - 1] = nums[j];
                    }
                    nums[nums.Length - counter - 1] = 0;
                    counter++;

                }
                else ++i;
            }
        }
    }
}
