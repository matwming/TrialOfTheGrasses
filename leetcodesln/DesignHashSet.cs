using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    private class Node
    {
        public int Value { get; set; }
        public Node Previous { get; set; }
        public Node Next { get; set; }
    }

    public class DesignHashSet
    {
        public List<KeyValuePair<int, Node>> Bucket { get; set; }
        /** Initialize your data structure here. */
        public DesignHashSet()
        {
            Bucket = new List<KeyValuePair<int, Node>>();
        }

        public void Add(int key)
        {
            var hash = Hash(key);
            foreach (var item in Bucket)
            {
                if(item.Key == hash)
                {
                    while(item.Value.val != key)
                    {
                        //item.Value = item.Value.Next;
                    }
                }
            }
        }

        public void Remove(int key)
        {

        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            throw new NotImplementedException();
        }

        private int Hash(int value) => value / 10000;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
