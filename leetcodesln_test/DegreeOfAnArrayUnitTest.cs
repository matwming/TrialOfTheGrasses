using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class DegreeOfAnArrayUnitTest
    {
        [TestMethod]
        public void DegreeOfAnArrayTestMethod()
        {
            DegreeOfAnArray degreeOfAnArray = new DegreeOfAnArray();
            Assert.AreEqual(12,degreeOfAnArray.FindShortestSubArray(new int[] {12,23}));
        }
    }
}