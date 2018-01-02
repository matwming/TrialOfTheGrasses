using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class BinaryNumberWithAlternatingBits
    {
        public bool HasAlternatingBits(int n)
        {
            string binary = Convert.ToString(n, 2);

            char previous = binary[0];
            for (int i = 1; i < binary.Length; i++)
            {
                if (previous == binary[i])
                {
                    return false;
                }
                else
                {
                    previous = binary[i];
                }
            }
            return true;
        }
    }
}