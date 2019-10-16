namespace leetcodesln
{
    public class MoveZeroes
    {

        // brute force method
        // when there is a zero, shuffle all the way to the end
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

        public void MoveZeroesTwoPointersSln(int[] nums)
        {
            int l = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] != 0)
                {
                    var temp = nums[l];
                    nums[l] = nums[r];
                    nums[r] = temp;
                    ++l;
                }
            }
        }
    }
}
