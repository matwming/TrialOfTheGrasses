using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class KthLargestElementInAnArrayUnitTest
    {
        public KthLargestElementInAnArray KthLargestElementInAnArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            KthLargestElementInAnArray = new KthLargestElementInAnArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new[] { 3, 2, 1, 5, 6, 4 };
            var k = 2;
            var expected = 5;
            var actual = KthLargestElementInAnArray.FindKthLargest(input, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            var k = 4;
            var expected = 4;
            var actual = KthLargestElementInAnArray.FindKthLargest(input, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
