using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MinimumFilpsToMakeAORBEqualToCUnitTest
    {
        public MinimumFilpsToMakeAORBEqualToC MinimumFilpsToMakeAORBEqualToC { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MinimumFilpsToMakeAORBEqualToC = new MinimumFilpsToMakeAORBEqualToC();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            int a = 8, b = 3, c = 5;
            var expected = 3;
            var actual = MinimumFilpsToMakeAORBEqualToC.MinFlips(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            int a = 2, b = 6, c = 5;
            var expected = 3;
            var actual = MinimumFilpsToMakeAORBEqualToC.MinFlips(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            int a = 4, b = 2, c = 7;
            var expected = 1;
            var actual = MinimumFilpsToMakeAORBEqualToC.MinFlips(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            int a = 1, b = 2, c = 3;
            var expected = 0;
            var actual = MinimumFilpsToMakeAORBEqualToC.MinFlips(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
