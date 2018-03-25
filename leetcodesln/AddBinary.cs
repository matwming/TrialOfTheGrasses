using System;
using System.Text;

namespace leetcodesln
{
    public class AddBinary
    {
        public string AddBinarysln(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            for (int i = 1; i <= (a.Length > b.Length? a.Length: b.Length); i++)
            {

                int aa = 0;
                int bb = 0;
                if (a.Length - i >= 0)
                {
                    aa = (int)(a[a.Length - i] - '0');
                }
               
                if (b.Length - i >= 0)
                {
                    bb = (int)(b[b.Length - i] - '0');
                }
                if (aa + bb + carry > 2)
                {
                    sb.Append(1);
                    carry = 1;
                }
                else if (aa + bb + carry == 2)
                {
                    sb.Append(0);
                    carry = 1;
                }
                else
                {
                    sb.Append(aa + bb + carry);
                    carry = 0;
                }
            }
            if (carry == 1)
            {
                sb.Append(1);
            }
            char[] chars = sb.ToString().ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}

/* good solution on leetcode
 * 
 * public string AddBinary(string a, string b)
 * {
 *      StringBuilder sb = new StringBuilder();
 *      int i = a.Length - 1; j = b.Length - 1; carry = 0;
 *      while(i >= 0 || j >= 0)
 *      {
 *          int sum = carry;
 *          if(j >= 0) sum += b[j--];
 *          if(i >= 0) sum += a[i--];
 *          sb.Append(sum % 2);
 *          carry = sum / 2;
 *      }
 *      if (carry != 0) sb.Append(carry);
 *      return sb.ToString().Reverse();
 * }
 
 */