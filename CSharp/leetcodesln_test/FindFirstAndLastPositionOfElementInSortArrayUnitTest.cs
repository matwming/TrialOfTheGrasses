using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class FindFirstAndLastPositionOfElementInSortArrayUnitTest
    {
        public FindFirstAndLastPositionOfElementInSortArray FindFirstAndLastPositionOfElementInSortArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FindFirstAndLastPositionOfElementInSortArray = new FindFirstAndLastPositionOfElementInSortArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new[] { 5, 7, 7, 8, 8, 10 };
            var target = 8;
            var expected = new[] { 3, 4 };
            var actual = FindFirstAndLastPositionOfElementInSortArray.SearchRange(nums, target);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }

    }
}
