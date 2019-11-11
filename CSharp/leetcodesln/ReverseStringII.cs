using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ReverseStringII
    {
        public string ReverseStr(string s, int k)
        {
            if (string.IsNullOrEmpty(s) || s.Length <= 1 || k <= 1) return s;
            return Reverse(s, k).ToString();
        } 

        private StringBuilder Reverse(string substring, int k)
        {
            var sb = new StringBuilder();
            if (substring.Length <= k)
            {
                for (int i = substring.Length - 1; i >= 0; i--)
                {
                    sb.Append(substring[i]);
                }
                return sb;
            }
            else if(substring.Length <= 2*k)
            {
                var pt1 = substring.Substring(0, k);
                var pt2 = substring.Substring(k, substring.Length -k);
                sb.Append(Reverse(pt1, k)).Append(pt2);
                return sb;
            }
            else
            {
                var groups = substring.Length / (2 * k);
                for (int i = 0; i <= groups; i++)
                {
                    if(2*k*(i+1)< substring.Length)
                    {
                        var pt = substring.Substring(2 * k * i, 2 * k);
                        sb.Append(Reverse(pt, k));
                    }
                    else
                    {
                        var pt = substring.Substring(2 * k * i, substring.Length - 2*k*i);
                        sb.Append(Reverse(pt,k));
                    }
                }
                return sb;
            }
        }
    }
}
