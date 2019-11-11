using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class ZigZagConversionUnitTest
    {
        public ZigZagConversion ZigZagConversion { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ZigZagConversion = new ZigZagConversion();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var s = "PAYPALISHIRING";
            var numRows = 3;
            var expected = "PAHNAPLSIIGYIR";
            var actual = ZigZagConversion.Convert(s, numRows);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var s = "PAYPALISHIRING";
            var numRows = 3;
            var expected = "PAHNAPLSIIGYIR";
            var actual = ZigZagConversion.Convert2(s, numRows);
            Assert.AreEqual(expected, actual);
        }
    }
}
