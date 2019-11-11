using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class TwoSumIIUnitTest
    {
        public TwoSumII TwoSumII { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            TwoSumII = new TwoSumII();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var expected = new int[] { 1, 2 };
            var actual = TwoSumII.TwoSum(input, target);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

    }
}
