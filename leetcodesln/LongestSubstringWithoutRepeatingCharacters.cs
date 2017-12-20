using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int maxCount = 0;
            int count = 0;
            Queue<char> queue = new Queue<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!queue.Contains(s[i]))
                {
                    queue.Enqueue(s[i]);
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    if (queue.Peek() == s[i])
                    {
                        queue.Dequeue();
                        queue.Enqueue(s[i]);
                    }
                    else
                    {
                        while (queue.Peek() != s[i])
                        {
                            queue.Dequeue();
                            count--;
                        }
                        queue.Dequeue();
                        queue.Enqueue(s[i]);
                    }
                }
            }
            return maxCount;
        }
    }
}
