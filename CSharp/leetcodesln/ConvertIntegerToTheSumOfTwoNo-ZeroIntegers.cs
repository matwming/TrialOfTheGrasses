using System;

namespace leetcodesln
{
    public class ConvertIntegerToTheSumOfTwoNo_ZeroIntegers
    {
        public int[] GetNoZeroIntegers(int n)
        {
            var ans = new int[2];

            for (int i = 0; i < n; i++)
            {
                if (!i.ToString().Contains("0"))
                {
                    var comp = n - i;
                    if (!comp.ToString().Contains("0"))
                    {
                        ans[0] = i;
                        ans[1] = comp;
                        return ans;
                    }
                }
            }
            throw new Exception();
        }
    }
}
