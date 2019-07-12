using System;

namespace leetcodesln
{
    public class CorporateFlightBookings
    {
        public int[] CorpFlightBookings(int[][] bookings, int n)
        {
            var ans = new int[n];

            foreach (var booking in bookings)
            {
                ans[booking[0] - 1] += booking[2];
                if (booking[1] < n) ans[booking[1]] -= booking[2];
            }
            for (int i = 1; i < n; i++)
            {
                ans[i] += ans[i - 1];
            }

            return ans;
        }
    }

}

