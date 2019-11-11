using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MinimumWindowSubstringUnitTest
    {
        public MinimumWindowSubstring MinimumWindowSubstring { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MinimumWindowSubstring = new MinimumWindowSubstring();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var S = "ADOBECODEBANC";
            var T = "ABC";
            var expected = "BANC";
            var actual = MinimumWindowSubstring.MinWindow(S, T);
            Assert.AreEqual(expected, actual);
        }

    }
}
