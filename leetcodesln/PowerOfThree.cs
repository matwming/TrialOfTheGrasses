using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class PowerOfThree
    {
        public bool IsPowerOfThree(int n)
        {
            if (n == 1) return true;
            double dn = (double)n;
            while(dn >= 3)
            {
                if (dn / 3 == 1) return true;
                dn = dn / 3;
            }
            return false;
        }
    }
}
