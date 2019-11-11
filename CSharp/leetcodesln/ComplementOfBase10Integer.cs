using System;
using System.Text;

namespace leetcodesln
{
    public class ComplementOfBase10Integer
    {
        public int BitwiseComplement(int N)
        {
            if (N == 0) return 1;
            var sb = new StringBuilder();
            var NBinary = Convert.ToString(N, 2).TrimStart('0');
            foreach (var chr in NBinary)
            {
                if (chr == '0') sb.Append('1');
                if (chr == '1') sb.Append('0');
            }
            return Convert.ToInt32(sb.ToString(), 2);
        }
    }
}