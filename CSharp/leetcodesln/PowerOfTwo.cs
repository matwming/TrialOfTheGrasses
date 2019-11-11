using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;
            var poss = new int[] { 1, 2, 4, 8 };
            var list = new List<int>();
            uint un = (uint)n;

            while (un != 0)
            {
                if (poss.Contains((int)(un & 15))) list.Add(1);
                else if ((un & 15) == 0)
                {

                }
                else
                {
                    return false;
                }
                un = un >> 4;
            }
            return list.Count == 1;
        }


        // concise solution
        //public bool IsPowerOfTwo(int n)
        //{
        //    return (n > 0) && ((n & (n - 1)) == 0);
        //}
    }
}
