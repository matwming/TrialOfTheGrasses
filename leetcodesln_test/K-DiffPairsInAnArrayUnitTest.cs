using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class K_DiffPairsInAnArrayUnitTest
    {
        public K_DiffPairsInAnArray K_DiffPairsInAnArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            K_DiffPairsInAnArray = new K_DiffPairsInAnArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 3, 1, 3, 1, 5 };
            var k = 2;
            var expected = 2;
            var actual = K_DiffPairsInAnArray.FindPairs(input, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            var k = 1;
            var expected = 4;
            var actual = K_DiffPairsInAnArray.FindPairs(input, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 1, 3, 1, 5, 4 };
            var k = 0;
            var expected = 1;
            var actual = K_DiffPairsInAnArray.FindPairs(input, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new int[] { 1, 1, 1, 1, 1 };
            var k = 0;
            var expected = 1;
            var actual = K_DiffPairsInAnArray.FindPairs(input, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
