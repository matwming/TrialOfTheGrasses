using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class SequentialDigits
    {
        public IList<int> SequentialDigitsSln(int low, int high)
        {
            var ans = new List<int>();
            int nlow = 0, nhigh = 0;
            var l = low;
            var h = high;
            nlow = (int)Math.Log10(low);
            nhigh = (int)Math.Log10(high);

            for (int i = nlow; i <= nhigh; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    var temp = 0;
                    var t = i;
                    var c = j;
                    while (t >= 0 && c <= 9)
                    {
                        temp += c * (int)Math.Pow(10, t--);
                        c++;
                    }
                    if (temp >= low && temp <= high && t == -1) ans.Add(temp);
                }

            }
            return ans;
        }
    }
}
