using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MImimumSizeSubarraySumUnitTest
    {
        public MinimumSizeSubarraySum MinimumSizeSubarraySum { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MinimumSizeSubarraySum = new MinimumSizeSubarraySum();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var s = 11;
            var nums = new[] { 1, 2, 3, 4, 5 };
            var expected = 3;
            var actual = MinimumSizeSubarraySum.MinSubArrayLen(s, nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var s = 5;
            var nums = new[] { 2, 3, 1, 1, 1, 1, 1 };
            var expected = 2;
            var actual = MinimumSizeSubarraySum.MinSubArrayLen(s, nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var s = 4;
            var nums = new[] { 1, 4, 4 };
            var expected = 1;
            var actual = MinimumSizeSubarraySum.MinSubArrayLen(s, nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var s = 100;
            var nums = new[] { 1, 2, 3 };
            var expected = 0;
            var actual = MinimumSizeSubarraySum.MinSubArrayLen(s, nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
