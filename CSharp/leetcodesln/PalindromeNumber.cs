using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            var original = x;

            if (x < 0 || (x % 10 == 0 && x !=0)) return false;

            var queue = new Queue<int>();

            int i = 1;
            while (x != 0)
            {
                var digit = x % Math.Pow(10, i++);
                x = x - (int)digit;
                if (digit < 10)
                {
                    queue.Enqueue((int)digit);
                }
                else
                {
                    digit = digit / Math.Pow(10, i - 2);
                    queue.Enqueue((int)digit);
                }
            }

            var reversed = 0;
            while (queue.Count!=0)
            {
                reversed += (int)(Math.Pow(10, queue.Count - 1) * queue.Dequeue());
            }
            return reversed == original;
        }
    }
}
