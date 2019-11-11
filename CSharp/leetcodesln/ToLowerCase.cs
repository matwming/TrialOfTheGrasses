using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class ToLowerCase
    {
        public string ToLower(string str)
        {
            var sb = new StringBuilder();
            foreach (var chr in str)
            {
                if ('A'<=chr && chr <='Z')
                {
                    sb.Append((char)(chr + 32));
                }
                else
                {
                    sb.Append(chr);
                }
            }
            return sb.ToString();
        }
    }
}
