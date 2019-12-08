namespace leetcodesln
{
    public class SubtractTheProductAndSumOfDigitOfAnInteger
    {
        public int SubtractProductAndSum(int n)
        {
            var sum = 0;
            var prod = 1;

            while (n != 0)
            {
                var digit = n % 10;
                sum += digit;
                prod *= digit;
                n /= 10;
            }
            return prod - sum;
        }
    }
}
