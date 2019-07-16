using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodesln
{
    public class RelativeSortArray
    {
        public int[] RelativeSortArraySln(int[] arr1, int[] arr2)
        {
            var ans = new int[arr1.Length];

            var sortedDict = new SortedDictionary<int, int>();

            foreach (var num in arr1)
            {
                if (sortedDict.ContainsKey(num))
                {
                    sortedDict[num]++;
                }
                else { sortedDict.Add(num, 1); }
            }
            var idx = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                var count = sortedDict[arr2[i]];
                for (int j = 0; j < count; j++)
                {
                    ans[idx++] = arr2[i];
                }
                sortedDict.Remove(arr2[i]);
            }
            while(sortedDict.Count!=0)
            { 
                var kv = sortedDict.FirstOrDefault();
                var count = kv.Value;
                for (int j = 0; j < count; j++)
                {
                    ans[idx++] = kv.Key;
                }
                sortedDict.Remove(kv.Key);
            }
            return ans;
        }
    }
}
