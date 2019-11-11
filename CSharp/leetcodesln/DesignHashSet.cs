using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{

    public class DesignHashSet
    {

        public int Column { get; set; } = 1000;
        public int Row { get; set; } = 1001;

        public bool[][] Bucket { get; set; }

        /** Initialize your data structure here. */
        public DesignHashSet()
        {
            Bucket = new bool[Column][];    
        }

        public void Add(int key)
        {
            var hashvalue = Hash(key);
           if(Bucket[Hash(key)] == null)
            {
                Bucket[hashvalue] = new bool[Row];
            }
            Bucket[hashvalue][Index(key)] = true;
        }

        public void Remove(int key)
        {
            var hashvalue = Hash(key);
            if (Bucket[hashvalue] != null)
            Bucket[hashvalue][Index(key)] = false;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            var hashvalue = Hash(key);
            return Bucket[hashvalue] != null && Bucket[hashvalue][Index(key)];
        }

        private int Hash(int value) => value % Column;
        private int Index(int value) => value / Column;

    }
}


/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
