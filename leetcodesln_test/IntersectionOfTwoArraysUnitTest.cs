using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
     [TestClass]
    public class IntersectionOfTwoArraysUnitTest
    {
        [TestMethod]
        public void IntersectionOfTwoArraysTestMethod()
        {
            IntersectionOfTwoArrays intersectionOfTwoArrays = new IntersectionOfTwoArrays();
            int[] arr = new int[] {2};
            Assert.AreEqual(arr.Length,intersectionOfTwoArrays.Intersection(new int[]{1,2,2,1},new int[]{2,2}).Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.AreEqual(arr[i],intersectionOfTwoArrays.Intersection(new int[]{1,2,2,1},new int[]{2,2})[i]);
            }
        }
}
}