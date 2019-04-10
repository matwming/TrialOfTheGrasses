namespace leetcodesln
{
    public class MajorityElement
    {
        //using dictionary to count each element, when counter > half of the array size, return the number, O(n)
        //public int MajorityElementSln(int[] nums)
        //{
        //    var half = nums.Length / 2;

        //    var dict = new Dictionary<int, int>();

        //    foreach (var num in nums)
        //    {
        //        if (dict.ContainsKey(num))
        //        {
        //            ++dict[num];
        //        }
        //        else dict[num] = 1;
        //        if (dict[num] > half) return num;
        //    }
        //    throw new Exception();
        //}


        // boyer-moore majority voting algorithm
        public int MajorityElementSln(int[] nums)
        {
            var majority = nums[0];
            var count = 1;

            for (int i = 1; i < nums.Length; ++i)
            {
                if (count == 0)
                {
                    majority = nums[i];
                    count = 1;
                }
                else if (majority != nums[i])
                {
                    --count;
                }
                else ++count;
            }
            return majority;
        }
    }
}
