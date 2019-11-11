namespace leetcodesln
{
    public class Sqrt_x_
    {
        public int MySqrt(int x)
        {
            if (x == 0) return 0;

            int l = 1, r = x;

            var mid = 0;

            while (l + 1 < r)
            {
                mid = (l + r) >> 1;
                if (x / mid < mid)
                {
                    r = mid;
                }
                else if (x / mid > mid)
                {
                    l = mid;
                }
                else return mid;
            }
            return l;
        }
    }
}
