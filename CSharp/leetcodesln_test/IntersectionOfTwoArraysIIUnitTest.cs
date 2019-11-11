using System.Linq;
using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class IntersectionOfTwoArraysIIUnitTest
    {
        [TestMethod]
        public void IntersectionOfTwoArraysIITestMethod()
        {
            var intersectionOfTwoArraysII = new IntersectionOfTwoArraysII();
            var input1_nums1 = new int[] {1,2,2,1};
            var input1_nums2 = new int[] {2,2};
            var expected1 = new int[] {2,2};
            var actual1 = intersectionOfTwoArraysII.Intersect(input1_nums1, input1_nums2);
            Assert.AreEqual(expected1.Length, actual1.Length);
            for (int i = 0; i < expected1.Length; i++)
            {
                actual1.Contains(expected1[i]);
            }

            var input2_nums1 = new int[] {4,9,5};
            var input2_nums2 = new int[] {9,4,9,8,4};
            var expected2 = new int[] {4,9};
            var actual2 = intersectionOfTwoArraysII.Intersect(input2_nums1, input2_nums2);
            Assert.AreEqual(expected2.Length, actual2.Length);
            for (int i = 0; i < expected2.Length; i++)
            {
                actual2.Contains(expected2[i]);
            }

        }
    }
}