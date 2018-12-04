using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodesln
{
    public class ConvertANumberToHexdecimal
    {
        public string ToHex(int num)
        {
            if (num == 0) return "0";
            uint unum = (uint)num;
            var map = new char[] {'0', '1','2', '3','4','5','6','7','8','9','a','b','c','d','e','f'};
            var s = string.Empty;
            while(unum!=0)
            {
                s = map[unum & 15] + s;
                unum = (unum >> 4);
            }
            return s;
        }
    }
}
