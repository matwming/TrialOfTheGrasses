using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MaxConsecutiveOnesIIIUnitTest
    {
        public MaxConsecutiveOnesIII MaxConsecutiveOnesIII { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MaxConsecutiveOnesIII = new MaxConsecutiveOnesIII();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var a = new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            var k = 2;
            var expected = 6;
            var actual = MaxConsecutiveOnesIII.LongestOnes(a, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var a = new[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
            var k = 3;
            var expected = 10;
            var actual = MaxConsecutiveOnesIII.LongestOnes(a, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
