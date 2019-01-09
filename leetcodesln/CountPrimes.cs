using System;

namespace leetcodesln
{
    public class CountPrimes
    {
        public int CountPrimesSln(int n)
        {
            var count = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i)) count++;
            }
            return count;
        }

        private bool IsPrime(int num)
        {
            if (num == 2) return true;

            if (num <= 1 || num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num)); // Math.Floor return the largest integral value less than or equal to the specified number

            for (int i = 3; i <= boundary; i += 2) //only check odd numbers
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
