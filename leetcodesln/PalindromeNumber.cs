using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || x % 10 == 0) return false;

            var queue = new Queue<uint>();
            var original = x;
            var reversed = 0;
            uint ux = (uint)x;
            while (ux != 0)
            {
                var cur = (ux & 15);
                queue.Enqueue(cur);
                ux = ux >> 4;
            }

            while (queue.Count != 0)
            {
                reversed += (int)Math.Pow(queue.Count - 1, 10) * (int)queue.Dequeue();
            }
            return reversed == original;
        }
    }
}
