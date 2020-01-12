namespace leetcodesln
{
    public class MinimumFilpsToMakeAORBEqualToC
    {
        public int MinFlips(int a, int b, int c)
        {
            var ans = 0;

            while (c != 0 || a != 0 || b != 0)
            {
                var clast = GetLastBit(c);
                var alast = GetLastBit(a);
                var blast = GetLastBit(b);
                if (clast == 0)
                {
                    if ((alast | blast) != clast)
                    {
                        if (alast != 0) ans++;
                        if (blast != 0) ans++;
                    }
                }
                else
                {
                    if ((alast | blast) != clast) ans += 1;
                }
                c >>= 1;
                b >>= 1;
                a >>= 1;
            }
            return ans;
        }

        private int GetLastBit(int k)
        {
            return k % 2;
        }
    }
}
