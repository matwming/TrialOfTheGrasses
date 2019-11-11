using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FourSumIIUnitTest
    {
        public FourSumII FourSumII { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FourSumII = new FourSumII();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var A = new[] { 1, 2 };
            var B = new[] { -2, -1 };
            var C = new[] { -1, 2 };
            var D = new[] { 0, 2 };
            var expected = 2;
            var actual = FourSumII.FourSumCount(A, B, C, D);
            Assert.AreEqual(expected, actual);
        }

    }
}
