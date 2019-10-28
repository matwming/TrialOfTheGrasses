using System.Collections.Generic;

namespace leetcodesln
{
    public class PlusOne
    {
        public int[] PlusOneSln(int[] digits)
        {
            int a = 1;
            var s = new Stack<int>();
            for (int i = digits.Length - 1; i >= 0; --i)
            {
                var sum = a + digits[i];
                if (sum >= 10)
                {
                    s.Push(sum - 10);
                    a = 1;
                }
                else
                {
                    s.Push(sum);
                    a = 0;
                }
            }

            if (a == 1) s.Push(a);

            var ans = new int[s.Count];

            for (int i = 0; i < ans.Length; ++i)
            {
                ans[i] = s.Pop();
            }
            return ans;
        }

        // optimal solution
        public int[] PlusOneOptimal(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; --i)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            var ans = new int[digits.Length + 1];
            ans[0] = 1;
            return ans;
        }
    }
}
