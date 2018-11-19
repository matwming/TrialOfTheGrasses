using System;

namespace leetcodesln
{
    public class PoorPigs
    {
        public int PoorPigsSln(int buckets, int minutesToDie, int minutesToTest)
        {
            var n = minutesToTest / minutesToDie +1;
            return (int)Math.Ceiling(Math.Log(buckets,n));
        }
    }
}