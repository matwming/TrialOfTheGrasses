using System;
using System.Collections.Generic;

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

    public class MinHeap<T> where T : IComparable<T>
    {
        private int heapSize = 0;

        private int heapCapacity = 0;

        private List<T> heap = null;

        private Dictionary<T, HashSet<int>> map = new Dictionary<T, HashSet<int>>();

        public MinHeap() : this(1)
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

            for (int i = 0; i < heapSize; i++)
            {
                MapAdd(elements[i], i);
                heap.Add(elements[i]);
            }

            //sort it as a minHeap
            for (int i = Math.Max(0, (heapSize / 2) - 1); i >= 0; i--)
            {

            }
        }

        private void MapAdd(T value, int index)
        {
            HashSet<int> set = map.GetValueOrDefault(value);

            if (set == null)
            {
                set = new HashSet<int>();
                set.Add(index);
                map.Add(value, set);
            }
            else
            {
                set.Add(index);
            }
        }
    }
}
