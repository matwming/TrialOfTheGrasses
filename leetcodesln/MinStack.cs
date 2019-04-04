using System.Collections.Generic;

namespace leetcodesln
{
    public class MinStack
    {
        //private Stack<int> _stack;
        //private List<int> _minList;

        //// ** Initialize your data structure here. */
        //public MinStack()
        //{
        //    _stack = new Stack<int>();
        //    _minList = new List<int>();
        //}

        //public void Push(int x)
        //{
        //    _stack.Push(x);

        //    _minList.Add(x);

        //    for (int i = _minList.Count - 1; i > 0; i--)
        //    {
        //        if (_minList[i] < _minList[i - 1])
        //        {
        //            var temp = _minList[i - 1];
        //            _minList[i - 1] = _minList[i];
        //            _minList[i] = temp;
        //        }
        //    }
        //}

        //public void Pop()
        //{
        //    if (!_stack.TryPop(out int res)) throw new Exception("the stack is empty");

        //    _minList.Remove(res);
        //}

        //public int Top()
        //{
        //    return _stack.Peek();
        //}

        //public int GetMin()
        //{
        //    return _minList.FirstOrDefault();
        //}



        /** one stack solution */

        private readonly Stack<StackNode> stack;
        private int? CurrentMinimumValue { get; set; }

        public MinStack()
        {
            stack = new Stack<StackNode>();
        }

        public void Push(int x)
        {
            if (x < CurrentMinimumValue || CurrentMinimumValue == null)
            {
                CurrentMinimumValue = x;
                stack.Push(new StackNode(x, CurrentMinimumValue.GetValueOrDefault()));
            }
            else
            {
                stack.Push(new StackNode(x, CurrentMinimumValue.GetValueOrDefault()));
            }
        }

        public void Pop()
        {
            if (stack.Count == 0) return;
            stack.Pop();
            if (stack.Count == 0)
            {
                CurrentMinimumValue = null;
                return;
            }
            CurrentMinimumValue = stack.Peek().Min;

        }

        public int Top()
        {
            return stack.Peek().Val;
        }

        public int GetMin()
        {
            return stack.Peek().Min;
        }
    }

    class StackNode
    {
        public int Val { get; }
        public int Min { get; }
        public StackNode(int value, int min)
        {
            Val = value;
            Min = min;
        }
    }
}
