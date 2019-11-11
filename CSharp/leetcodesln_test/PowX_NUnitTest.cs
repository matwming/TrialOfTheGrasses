using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class PowX_NUnitTest
    {
        public PowX_N PowX_N { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            PowX_N = new PowX_N();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            double input = 2d;
            var n = 10;
            var expected = 1024d;
            var actual = PowX_N.MyPow(input, n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            double input = 2d;
            var n = -2147483648;
            var expected = 0d;
            var actual = PowX_N.MyPow(input, n);
            Assert.AreEqual(expected, actual);
        }
    }
}
