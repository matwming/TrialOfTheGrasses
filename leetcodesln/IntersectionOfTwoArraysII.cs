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
            nums1_list.ForEach(e=> {if(nums2_list.Contains(e)) { nums2_list.Remove(e); result.Add(e);}});
            return result.ToArray();
        }
    }
}