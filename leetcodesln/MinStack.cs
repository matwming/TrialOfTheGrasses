using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcodesln
{
    public class MinStack
    {
        private Stack<int> _stack;
        private List<int> _minList;

        // ** Initialize your data structure here. */
        public MinStack()
        {
            _stack = new Stack<int>();
            _minList = new List<int>();
        }

        public void Push(int x)
        {
            _stack.Push(x);

            _minList.Add(x);

            for (int i = _minList.Count - 1; i > 0; i--)
            {
                if (_minList[i] < _minList[i - 1])
                {
                    var temp = _minList[i - 1];
                    _minList[i - 1] = _minList[i];
                    _minList[i] = temp;
                }
            }
        }

        public void Pop()
        {
            if (!_stack.TryPop(out int res)) throw new Exception("the stack is empty");

            _minList.Remove(res);
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _minList.FirstOrDefault();
        }
    }
}
