using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FindShortestSubArrayUnitTest
    {
        [TestMethod]
        public void FindShortestSubArrayTestMethod()
        {
            DegreeOfAnArray degreeOfAnArray = new DegreeOfAnArray();
            Assert.AreEqual(2, degreeOfAnArray.FindShortestSubArray(new int[] { 1, 2, 2, 3, 1 }));
            Assert.AreEqual(6, degreeOfAnArray.FindShortestSubArray(new int[] { 1,2,2,3,1,4,2}));
        }
    }
}