using System.Collections.Generic;

namespace leetcodesln
{
    public class ValidateStackSequences
    {
        public bool ValidateStackSequencesSln(int[] pushed, int[] popped)
        {
            var stack = new Stack<int>();
            var i = 0;
            var j = 0;

            while (j < popped.Length)
            {
                while (!stack.Contains(popped[j]) && i < pushed.Length)
                {
                    stack.Push(pushed[i++]);
                }
                if (stack.Peek() == popped[j])
                {
                    j++;
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return j == popped.Length;
        }
    }
}
