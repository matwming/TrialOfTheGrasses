using System;

namespace leetcodesln
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if(nums2.Length==0) return;

            var temp = new int[n+m];
            for (int i = 0; i < m; i++)
            {
                temp[i] = nums1[i];
            }
            for (int i = m, j = 0; i < m+n && j < nums2.Length; i++, j++)
            {
                temp[i] = nums2[j];    
            }
            Array.Sort(temp);
            for (int v = 0; v < temp.Length; v++)
            {
                nums1[v] = temp[v];
            }
        }

        
    }
}