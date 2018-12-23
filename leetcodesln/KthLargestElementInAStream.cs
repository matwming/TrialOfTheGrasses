using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class KthLargestElementInAStream
    {
        public MinHeap<int> minHeap { get; set; }

        public int K { get; set; }
        public KthLargestElementInAStream(int k, int[] nums)
        {
            K = k;
            minHeap = new MinHeap<int>(k);
            if (nums == null) return;
            foreach (var num in nums)
            {
                if(minHeap.GetSize() >= k)
                {
                        minHeap.Add(num);
                        minHeap.Poll();
                }
                else
                {
                    minHeap.Add(num);
                }
            }
        }

        public int Add(int val)
        {
            if (minHeap.GetSize() >= K)
            {
                minHeap.Add(val);
                minHeap.Poll();
            }
            else
            {
                minHeap.Add(val);
            }
            return minHeap.Peek();
        }
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

        public T Peek()
        {
            return IsEmpty() ? default(T) : heap[0];
        }

        public MinHeap(int size)
        {
            heap = new List<T>();
            heapCapacity = size;
        }

        public int GetSize()
        {
            return heapSize;
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
                Sink(i);
            }
        }

        public T Poll()
        {
            return RemoveAt(0);
        }

        private T RemoveAt(int v)
        {
            if (IsEmpty()) return default(T);

            heapSize--;
            T removed_data = heap[v];
            Swap(v, heapSize);

            heap.RemoveAt(heapSize);
            MapRemove(removed_data, heapSize);

            if (v == heapSize) return removed_data;

            T element = heap[v];

            Sink(v);

            if (heap[v].CompareTo(element) == 0) Swim(v);

            return removed_data;
        }

        private void MapRemove(T removed_data, int index)
        {
            var set = map.GetValueOrDefault(removed_data);

            set.Remove(index);
            if (set.Count == 0) map.Remove(removed_data);
        }

        private bool IsEmpty()
        {
            return heapSize == 0;
        }

        public void Add(T element)
        {
            if (element == null) return;

            heap.Add(element);

            MapAdd(element, heapSize);

            Swim(heapSize);
            heapSize++;
        }

        private void Swim(int k)
        {
            int parent = (k - 1) / 2;

            while (k>0 && Less(k, parent))
            {
                Swap(parent, k);
                k = parent;

                parent = (k - 1) / 2;
            }
        }

        private void Sink(int i)
        {
            while (true)
            {
                var left = 2 * i + 1;
                var right = 2 * i + 2;
                var smallest = left;

                //check left and right which is smaller
                if (right < heapSize && Less(right, left)) smallest = right;

                // if current node is leaf or current node is smaller than smallest, we don't sink
                if (left >= heapSize || Less(i, smallest)) break;

                Swap(i, smallest);
                i = smallest;
            }
        }

        private void Swap(int i, int smallest)
        {
            T i_element = heap[i];
            T smallest_element = heap[smallest];

            heap[i] = smallest_element;
            heap[smallest] = i_element;

            MapSwap(i_element, smallest_element, i, smallest);
        }

        private void MapSwap(T i_element, T smallest_element, int i, int smallest)
        {
            var set1 = map.GetValueOrDefault(i_element);
            var set2 = map.GetValueOrDefault(smallest_element);

            set1.Remove(i);
            set2.Remove(smallest);

            set1.Add(smallest);
            set1.Add(i);
        }

        private bool Less(int right, int left)
        {
            return heap[right].CompareTo(heap[left]) < 0;
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
