using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class NumberComplement
    {
        public int FindComplement(int num)
        {
            var num_bin = Convert.ToString(num, 2);
            char[] array = new char[num_bin.Length];
            int i = 0;
            Array.ForEach(num_bin.ToCharArray(),x=>array[i++] =('0'.Equals(x)?'1':'0'));
            return Convert.ToInt32(new string(array),2);
        }
    }
}
