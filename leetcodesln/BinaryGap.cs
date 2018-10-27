using System;
using System.Collections;
using System.Text;

namespace leetcodesln
{
    public class BinaryGap
    {
        public int FindLongestBinaryGap(int N)
        {
            Stack stack = new Stack();

            while(N > 0)
            {
                stack.Push((char)N%2);
                N = N/2;
            }

            char[] binary = new char[stack.Count];
            for (int i = 0; i < binary.Length; i++)
            {
                binary[i] = (char)stack.Pop();
            }
            
            return 0;
        }
    }
}