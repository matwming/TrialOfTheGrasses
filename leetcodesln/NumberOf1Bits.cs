using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            var countOf1s = 0;

            while(n !=0)
            {
                uint x = (n & 15);
                switch (x)
                {
                    case 1:
                    case 2:
                    case 4:
                    case 8:
                        countOf1s++;
                        n = (n >> 4);
                        break;
                    case 3:
                    case 5:
                    case 6:
                    case 9:
                    case 10:
                    case 12:
                        countOf1s += 2;
                        n = (n >> 4);
                        break;
                    case 7:
                    case 11:
                    case 13:
                    case 14:
                        countOf1s += 3;
                        n = (n >> 4);
                        break;
                    case 15:
                        countOf1s += 4;
                        n = (n >> 4);
                        break;
                    default:
                        n = (n >> 4);
                        break;
                }
            }
            return countOf1s;
        }
    }
}
