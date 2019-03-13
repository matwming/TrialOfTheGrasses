using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PerfectNumberUnitTest
    {
        public PerfectNumber PerfectNumber { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            PerfectNumber = new PerfectNumber();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = 28;
            var expected = true;
            var actual = PerfectNumber.CheckPerfectNumber(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = 0;
            var expected = false;
            var actual = PerfectNumber.CheckPerfectNumber(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
