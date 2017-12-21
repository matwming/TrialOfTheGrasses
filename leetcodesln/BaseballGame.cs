using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class BaseballGame
    {
        public int CalPoints(string[] ops)
        {
            Stack<int> pointStack = new Stack<int>();
            foreach (var item in ops)
            {
                int n;
                if (int.TryParse(item, out n))
                {
                    pointStack.Push(n);
                }
                else if ("+".Equals(item))
                {
                    int lastElementPushedInStack = Convert.ToInt32(pointStack.Pop());
                    int previousElementPushedInStack = Convert.ToInt32(pointStack.Pop());
                    int newElementInStack = lastElementPushedInStack + previousElementPushedInStack;
                    pointStack.Push(previousElementPushedInStack);
                    pointStack.Push(lastElementPushedInStack);
                    pointStack.Push(newElementInStack);
                }
                else if ("D".Equals(item))
                {
                    pointStack.Push(pointStack.Peek()*2);
                }
                else if ("C".Equals(item))
                {
                    pointStack.Pop();
                }
                else
                {
                    throw new InvalidOperationException("the operation or number is invalid");
                }
            }
            int result = 0; ;
            while (pointStack.Count!=0)
            {
                result += pointStack.Pop();
            }

            return result;
        }
    }
}
