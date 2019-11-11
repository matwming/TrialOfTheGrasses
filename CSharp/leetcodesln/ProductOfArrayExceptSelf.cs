namespace leetcodesln
{
    public class ProductOfArrayExceptSelf
    {
        // create two arrays left and right, store the product to the right except self and product to the left except self respectively
        // Time Complexity O(n), space complexity O(2n)
        public int[] ProductExceptSelf(int[] nums)
        {
            var left = new int[nums.Length];
            var right = new int[nums.Length];

            left[0] = 1;
            right[right.Length - 1] = 1;
            for (int i = 1; i < left.Length; ++i)
            {
                left[i] = left[i - 1] * nums[i - 1];
            }
            for (int i = right.Length - 2; i >= 0; --i)
            {
                right[i] = right[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < nums.Length; ++i)
            {
                nums[i] = left[i] * right[i];
            }
            return nums;
        }

        // similar to above solution, but we only keep a left array, we use a variable R to keep product to right on the fly
        public int[] ProductExceptSelfOptimal(int[] nums)
        {
            int len = nums.Length;

            int[] left = new int[len];

            left[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                left[i] = left[i - 1] * nums[i - 1];
            }

            int R = 1;

            for (int i = len - 1; i >= 0; i--)
            {
                left[i] = left[i] * R;
                R *= nums[i];
            }
            return left;
        }
    }
}
