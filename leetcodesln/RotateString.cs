using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class RotateString
    {
        public bool RotateStringSln(string A, string B)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            for (int i = 0; i < A.Length; i++)
            {
                string newString = A.Substring(i) + A.Substring(0,i);
                if (newString == B)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
