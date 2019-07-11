using System;

namespace leetcodesln
{
    public class CorporateFlightBookings
    {
        public int[] CorpFlightBookings(int[][] bookings, int n)
        {
            var ans = new int[n];

            for (int i = 0; i < bookings.Length; i++)
            {
                var start = bookings[i][0];
                var end = bookings[i][1];
                var tickets = bookings[i][2];
                for (int j = start - 1; j < end; j++)
                {
                    ans[j] += tickets;
                }
            }

            return ans;
        }
    }

}

