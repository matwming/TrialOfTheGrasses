namespace leetcodesln
{
    /// <summary>
    /// find perfect square using binary search
    /// </summary>
    public class ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            if (num < 0) return false;
            if (num == 1) return true;

            long l = 0, r = num;

            while (l <= r)
            {
                long mid = (l + r) / 2;

                if (num / mid == mid && num % mid == 0) return true;
                else if (num / mid > mid) l = mid + 1;
                else if (num / mid < mid) r = mid - 1;
                else return false;
            }
            return false;
        }
    }
}
