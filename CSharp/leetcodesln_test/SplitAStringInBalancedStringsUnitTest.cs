using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class SplitAStringInBalancedStringsUnitTest
    {
        public SplitAStringInBalancedStrings SplitAStringInBalancedStrings { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SplitAStringInBalancedStrings = new SplitAStringInBalancedStrings();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var s = "RLRRLLRLRL";
            var expected = 4;
            var actual = SplitAStringInBalancedStrings.BalancedStringSplit(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var s = "RLLLLRRRLR";
            var expected = 3;
            var actual = SplitAStringInBalancedStrings.BalancedStringSplit(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var s = "LLLLRRRR";
            var expected = 1;
            var actual = SplitAStringInBalancedStrings.BalancedStringSplit(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
