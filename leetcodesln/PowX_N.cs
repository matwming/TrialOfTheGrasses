namespace leetcodesln
{
    public class PowX_N
    {
        public double MyPow(double x, int n)
        {
            if (n == 0) return 1d;
            if (n < 0)
            {
                n = -n;
                x = 1 / x;
            }

            var ans = n % 2 == 0 ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
            return double.IsInfinity(ans) ? 0 : ans;
        }
    }
}
