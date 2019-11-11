using System;

namespace leetcodesln
{
    public class PrimeNumberOfSetBitsInBinaryRepresentation
    {
        public int CountPrimeSetBits(int L, int R)
        {
            int count = 0;
            for (int i = L; i <= R; i++)
            {
                char[] charArr =  Convert.ToString(i, 2).ToCharArray();
                int primeCount = 0;
                foreach (var character in charArr)
                {
                    if (character == '1')
                    {
                        primeCount++;
                    }
                }
                if (IsPrime(primeCount))
                {
                    count++;
                }
            }
            return count;
        }

        private bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(candidate); i++)
            {
                if (candidate % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
