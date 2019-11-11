using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FindAllDuplicatesInAnArrayUnitTes
    {
        public FindAllDuplicatesInAnArray FindAllDuplicatesInAnArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FindAllDuplicatesInAnArray = new FindAllDuplicatesInAnArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var expected = new[] { 2, 3 };
            var actual = FindAllDuplicatesInAnArray.FindDuplicates(input);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new[] { 10, 2, 5, 10, 9, 1, 1, 4, 3, 7 };
            var expected = new[] { 10, 1 };
            var actual = FindAllDuplicatesInAnArray.FindDuplicates(input);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new[] { 2, 2 };
            var expected = new[] { 2 };
            var actual = FindAllDuplicatesInAnArray.FindDuplicates(input);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

    }
}
