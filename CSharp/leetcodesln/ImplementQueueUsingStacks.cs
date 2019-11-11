using System.Collections.Generic;

namespace leetcodesln
{
    public class ImplementQueueUsingStacks
    {
        private Stack<int> StackIn { get; set; }

        private int Count { get; set; } = 0;

        public ImplementQueueUsingStacks()
        {
            StackIn = new Stack<int>();
        }

        public void Push(int x)
        {
            StackIn.Push(x);
            Count++;
        }

        public int Pop()
        {
            var stack = new Stack<int>();
            int res = default(int);
            while (StackIn.Count != 0 && StackIn.TryPop(out res))
            {
                stack.Push(res);
            }
            stack.Pop();
            while (stack.TryPop(out int temp))
            {
                StackIn.Push(temp);
            }
            Count--;
            return res;

        }

        public int Peek()
        {
            var stack = new Stack<int>();
            int res = default(int);
            while (StackIn.Count!=0 && StackIn.TryPop(out res))
            {
                stack.Push(res);
            }
            while (stack.TryPop(out int temp))
            {
                StackIn.Push(temp);
            }
            return res;
        }

        public bool Empty()
        {
            return Count == 0;
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
