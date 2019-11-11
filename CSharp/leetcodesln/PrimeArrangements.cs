namespace leetcodesln
{
    public class PrimeArrangements
    {
        const int MOD = (int)(1e9 + 7);

        public int NumPrimeArrangements(int n)
        {
            long ans = 1;

            int primes = 0;

            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    primes++;
                }
            }

            int notPrimes = n - primes;

            for (int i = primes; i > 0; i--)
            {
                ans = ans * i % MOD;
            }
            for (int i = notPrimes; i > 0; i--)
            {
                ans = ans * i % MOD;
            }
            return (int)ans;
        }

        bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
