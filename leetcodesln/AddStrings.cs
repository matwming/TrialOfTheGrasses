using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodesln
{
    public class AddStrings
    {
        public string AddStringsSln(string num1, string num2)
        {
            int carry = 0;
            StringBuilder sb = new StringBuilder(1024);
            for (int s1 = num1.Length -1, s2 = num2.Length -1; s1 >=0 || s2 >=0 ; s1--, s2--)
            {
                int sum = 0;
                if (s1 >= 0) { sum += num1[s1] - '0'; }
                if (s2 >= 0) { sum += num2[s2] - '0'; }
                if (sum + carry >= 10)
                {
                    sb.Append(sum - 10 + carry);
                    carry = 1;
                }
                else
                {
                    sb.Append(sum + carry);
                    carry = 0;
                }
            }
            if (carry != 0)
            {
                sb.Append(carry);
            }
            char[] arr = sb.ToString().ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
