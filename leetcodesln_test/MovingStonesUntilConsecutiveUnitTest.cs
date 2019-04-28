using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MovingStonesUntilConsecutiveUnitTest
    {
        public MovingStonesUntilConsecutive MovingStonesUntilConsecutive { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MovingStonesUntilConsecutive = new MovingStonesUntilConsecutive();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            int a = 4, b = 3, c = 2;
            var expected = new int[] { 0, 0 };
            var actual = MovingStonesUntilConsecutive.NumMovesStones(a, b, c);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            int a = 3, b = 5, c = 1;
            var expected = new int[] { 1, 2 };
            var actual = MovingStonesUntilConsecutive.NumMovesStones(a, b, c);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }
    }
}
