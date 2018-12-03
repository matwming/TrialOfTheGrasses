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
            var sb = new StringBuilder();
            if(num >= 0)
            {
                while(num % 16 > 0)
                {
                    var remain = num % 16;
                    num = num / 16;
                    switch (remain)
                    {
                        case 10:
                            sb.Append("a");
                            break;
                        case 11:
                            sb.Append("b");
                            break;
                        case 12:
                            sb.Append("c");
                            break;
                        case 13:
                            sb.Append("d");
                            break;
                        case 14:
                            sb.Append("e");
                            break;
                        case 15:
                            sb.Append("f");
                            break;
                        default:
                            sb.Append(remain);
                            break;
                    }
                }
            }
            else
            {
                num = -num;
                while (num % 16 > 0)
                {
                    var remain = num % 16;
                    num = num / 16;
                    switch (remain)
                    {
                        case 10:
                            sb.Append("a");
                            break;
                        case 11:
                            sb.Append("b");
                            break;
                        case 12:
                            sb.Append("c");
                            break;
                        case 13:
                            sb.Append("d");
                            break;
                        case 14:
                            sb.Append("e");
                            break;
                        case 15:
                            sb.Append("f");
                            break;
                        default:
                            sb.Append(remain);
                            break;
                    }
                }
                var chrarr = sb.ToString().ToCharArray();
                Array.Reverse(chrarr);

                chrarr.Select(c => 15 - c).ToArray();

            }
            var charArr = sb.ToString().ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
}
