namespace leetcodesln
{
    public class DivisorGame
    {
        public bool?[] Dp { get; set; } = new bool?[1001];


        public bool DivisorGameSln(int N)
        {
            return AliceWin(N);
        }

        private bool AliceWin(int n)
        {
            if (n == 1) return false;
            if (Dp[n] != null) return Dp[n].Value;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    if (!BobWin(n - i))
                    {
                        Dp[i] = true;
                        return true;
                    }
                    else Dp[i] = false;
                }
            }
            Dp[n] = false;
            return Dp[n].Value;
        }

        private bool BobWin(int n)
        {
            if (n == 1) return false;
            if (Dp[n] != null) return Dp[n].Value;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    if (!AliceWin(n - i))
                    {
                        Dp[i] = true;
                        return true;
                    }
                    else Dp[i] = false;
                }
            }
            Dp[n] = false;
            return Dp[n].Value;
        }
    }
}
