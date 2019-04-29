using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test.utils
{
    [TestClass]
    public class HelperUnitTest
    {
        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var arr1 = new int[] { 1, 1, 0 };
            var arr2 = new int[] { 1, 0, 0 };
            Assert.IsFalse(Helper<int>.HaveSameElementsForTwoCollections(arr1, arr2));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var arr1 = new int[] { 1, 1, 0 };
            var arr2 = new int[] { };
            Assert.IsFalse(Helper<int>.HaveSameElementsForTwoCollections(arr1, arr2));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var arr1 = new int[] { };
            var arr2 = new int[] { };
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(arr1, arr2));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var arr1 = new int[] { 7, 7, 2, 1, 4, 5, 9 };
            var arr2 = new int[] { 7, 2, 4, 9, 7, 1, 5 };
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(arr1, arr2));
        }

    }
}
