using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class ImplementStackUsingQueue
    {
        private Queue<int> Storage { get; set; }

        /** Initialize your data structure here */
        public ImplementStackUsingQueue()
        {
            Storage = new Queue<int>();
        }

        /** Push element x onto stack */
        public void Push(int x)
        {
            Storage.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element */
        public int Pop()
        {
            if (Storage.Count <= 0) throw new NullReferenceException("the stack is empty");

            var aux = new Queue<int>();
            while(Storage.Count!=0)
            {
                var current = Storage.Dequeue();
                if (Storage.Count == 0)
                {
                    Storage = aux;
                    return current;
                }
                aux.Enqueue(current);
            }
            throw new Exception();
        }

        /** Get the top element */
        public int Top()
        {
            if (Storage.Count <= 0) throw new NullReferenceException("the stack is empty");

            var aux = new Queue<int>();
            var current = default(int);
            while (Storage.Count != 0)
            {
                current = Storage.Dequeue();
                aux.Enqueue(current);
            }
            Storage = aux;
            return current;

        }

        /** Returns whether the stack is empty */
        public bool Empty()
        {
            return Storage.Count == 0;

        }
    }

    /**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
}
