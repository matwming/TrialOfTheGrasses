using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class Base7
    {
        public static readonly int BASE = 7;

        public string ConvertToBase7(int num)
        {
            //StringBuilder sb = new StringBuilder();
            //int i;
            //int remainder;
            //if (num.ToString()[0]=='-')
            //{
            //    i = num.ToString().ToCharArray().Length -1;
            //    remainder = num * -1;
            //}
            //else
            //{
            //    i = num.ToString().ToCharArray().Length;
            //    remainder = num;
            //}
            //for (int power = i ; power >= 0; power--)
            //{
            //    var val = remainder / (int)Math.Pow(BASE, power) > 0 ? (remainder / (int)Math.Pow(BASE, power)).ToString() : "0";
            //    remainder = remainder % (int)Math.Pow(BASE, power);
            //    sb.Append(val);
            //}
            //if (sb.ToString()[0]=='0')
            //{
            //    sb.Remove(0, 1);
            //}
            //if (num< 0)
            //{
            //    sb.Insert(0, "-");
            //}
            //return sb.ToString();
            if (num == 0) return "0";
            string result = "";
            bool positive = num > 0;
            while (num!=0)
            {
                result = Math.Abs(num % BASE) + result;
                num /= BASE;
            }
            return positive ? result : "-" + result;
        }
    }
}
