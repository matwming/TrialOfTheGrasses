using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class KthLargestElementInAStream
    {
        public MinHeap<int> minHeap { get; set; }
        public KthLargestElementInAStream(int k, int[] nums)
        {

        }

        //public int Add(int val)
        //{

        //}
    }

    public class MinHeap<T> where T:IComparable<T>
    {
        private int heapSize = 0;

        private int heapCapacity = 0;

        private List<T> heap = null;

        private Dictionary<T, HashSet<int>> map = new Dictionary<T, HashSet<int>>();

        public MinHeap():this(1)
        {
        }

        public MinHeap(int size)
        {
            heap = new List<T>(1);
        }

        public MinHeap(T[] elements)
        {
            heapSize = heapCapacity = elements.Length;
            heap = new List<T>(heapCapacity);
        }
    }
}
