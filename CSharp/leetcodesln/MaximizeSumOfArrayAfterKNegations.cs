using leetcodesln.common;
using System;

namespace leetcodesln
{
    public class MaximizeSumOfArrayAfterKNegations
    {
        public int LargestSumAfterKNegations(int[] A, int K)
        {
            var minheap = new MinHeap<int>();
            int sum = 0;

            foreach (var num in A)
            {
                sum += num;
                minheap.Add(num);
            }

            int counter = 0;
            while (counter < K)
            {
                if (minheap.Peek() <= 0)
                {
                    var newVal = Math.Abs(minheap.Poll());
                    sum += newVal*2;
                    minheap.Add(newVal);
                }
                else
                {
                    var newVal = minheap.Poll();
                    sum -= newVal*2;
                    minheap.Add(-newVal);
                }
                ++counter;
            }
            return sum;
        }
    }
}
