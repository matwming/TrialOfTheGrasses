using System;
using System.Collections.Generic;
using System.Linq;
namespace leetcodesln
{
    public class IntersectionOfTwoArraysII
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var nums1_list = nums1.ToList();
            var nums2_list = nums2.ToList();
            var result = new List<int>();
            nums1_list.ForEach(e => { if (nums2_list.Contains(e)) { nums2_list.Remove(e); result.Add(e); } });
            return result.ToArray();
        }

        public int[] IntersectTwoPointers(int[] nums1, int[] nums2)
        {
            var ans = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);
            int n1 = 0, n2 = 0;

            while (n1 < nums1.Length && n2 < nums2.Length)
            {
                if (nums1[n1] == nums2[n2])
                {
                    ans.Add(nums1[n1]);
                    n1++;
                    n2++;
                }
                else if (nums1[n1] > nums2[n2])
                {
                    n2++;
                }
                else
                {
                    n1++;
                }
            }
            return ans.ToArray();
        }
    }
}
