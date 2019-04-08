using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SortArrayByParityUnitTest
    {
        [TestMethod]
        public void SortArrayByParityTestMethod()
        {
            var sortArrayByParity = new SortArrayByParity();
            var input = new int[] { 3, 1, 2, 4 };
            var expected = new int[] { 2, 4, 1, 3 };
            var actual = sortArrayByParity.SortArrayByParitySln(input);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoArray(expected, actual));
        }
    }
}
