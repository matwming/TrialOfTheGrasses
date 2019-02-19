namespace leetcodesln
{
    public class ArrangingCoins
    {
        public int ArrangeCoins(int n)
        {
            var i = 0;

            while (n > 0)
            {
                if (n - i >= 0) n -= i;
                i++;
                if (n - i < 0)
                {
                    i--;
                    break;
                }
            }
            return i;
        }
    }
}
