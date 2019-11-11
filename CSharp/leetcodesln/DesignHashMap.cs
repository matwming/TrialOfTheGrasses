using System.Collections.Generic;

namespace leetcodesln
{
    public class MyHashMap
    {
        private List<int> storage { get; set; }
        /** Initialize your data structure here. */
        public MyHashMap()
        {
            storage = new List<int>(0);
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            for (int i = 0; i < storage.Count; i += 2)
            {
                if (storage[i] == key)
                {
                    storage[i + 1] = value;
                    return;
                }
            }
            storage.Add(key);
            storage.Add(value);
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            for (int i = 0; i < storage.Count; i += 2)
            {
                if (storage[i] == key)
                {
                    return storage[i + 1];
                }
            }
            return -1;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            for (int i = 0; i < storage.Count; i += 2)
            {
                if (storage[i] == key)
                {
                    storage.RemoveAt(i);
                    storage.RemoveAt(i);
                }
            }
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
