using System;

namespace leetcodesln
{
    public class MergeSortedArray
    {
        /// <summary>
        /// complexity O(n + nlogn)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        //public void Merge(int[] nums1, int m, int[] nums2, int n)
        //{
        //    if (nums2.Length == 0) return;

        //    var temp = new int[n + m];
        //    for (int i = 0; i < m; i++)
        //    {
        //        temp[i] = nums1[i];
        //    }
        //    for (int i = m, j = 0; i < m + n && j < nums2.Length; i++, j++)
        //    {
        //        temp[i] = nums2[j];
        //    }
        //    Array.Sort(temp);
        //    for (int v = 0; v < temp.Length; v++)
        //    {
        //        nums1[v] = temp[v];
        //    }
        //}



        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var m_ptr = m - 1;
            var n_ptr = n - 1;
            var bound = m + n - 1;

            while(m_ptr >= 0 && n_ptr >= 0)
            {
                if (nums1[m_ptr] > nums2[n_ptr]) nums1[bound--] = nums1[m_ptr--];
                else nums1[bound--] = nums2[n_ptr--];
            }

            // ensure all elements in nums2 have been merged
            while(n_ptr>=0)
            {
                nums1[bound--] = nums2[n_ptr--];
            }
        }

    }
}