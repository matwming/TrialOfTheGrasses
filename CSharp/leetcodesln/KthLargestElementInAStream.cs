using leetcodesln.common;
using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class KthLargestElementInAStream
    {
        public MinHeap<int> MinHeap { get; set; }

        public int K { get; set; }
        public KthLargestElementInAStream(int k, int[] nums)
        {
            K = k;
            MinHeap = new MinHeap<int>(k);
            if (nums == null) return;
            foreach (var num in nums)
            {
                if(MinHeap.GetSize() >= k)
                {
                        MinHeap.Add(num);
                        MinHeap.Poll();
                }
                else
                {
                    MinHeap.Add(num);
                }
            }
        }

        public int Add(int val)
        {
            if (MinHeap.GetSize() >= K)
            {
                MinHeap.Add(val);
                MinHeap.Poll();
            }
            else
            {
                MinHeap.Add(val);
            }
            return MinHeap.Peek();
        }
    }

   
}
