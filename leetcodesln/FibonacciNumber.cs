namespace leetcodesln
{
    public class FibonacciNumber
    {

        // recursive o(logn)
        // public int Fib(int n)
        // {
        //     if(n ==0) return 0;
        //     if(n == 1 || n == 2) return 1;

        //     return Fib(n-1) + Fib(n-2);
        // }

        // dp
        public int Fib(int N)
        {
            if(N == 0) return 0;
            if(N==1 || N == 2) return 1;

            var dp = new int[N];

            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i < N; i++)
            {
                dp[i] = dp[i-1] + dp[i-2];
            }
            return dp[N-1];
        }
    }
}