using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcodesln
{
    public class RotatedDigits
    {
        public static readonly char[] INVALIDNUMBERS = { '0', '1', '8'};

        public int RotatedDigitsSln(int N)
        {
            int count = 0;
            for (int i = 0; i <= N; i++)
            {
                var tmp = i.ToString().ToCharArray();
                if (Array.Exists(tmp, element => element == '3' || element == '4' || element == '7'))
                {
                    continue;
                }
                if (!tmp.Distinct().ToHashSet().Except(INVALIDNUMBERS).Any())
                {
                    continue;
                }
                else count++;
            }
            return count;
        }
    }
}
