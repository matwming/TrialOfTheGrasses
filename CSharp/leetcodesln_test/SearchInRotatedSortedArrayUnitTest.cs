using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SearchInRotatedSortedArrayUnitTest
    {
        public SearchInRotatedSortedArray SearchInRotatedSortedArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SearchInRotatedSortedArray = new SearchInRotatedSortedArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new[] { 4, 5, 6, 7, 0, 1, 2 };
            var target = 0;
            var expected = 4;
            var actual = SearchInRotatedSortedArray.Search(nums, target);
            Assert.AreEqual(expected, actual);
        }

    }
}
