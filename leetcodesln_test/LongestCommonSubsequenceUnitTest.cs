using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class LongestCommonSubsequenceUnitTest
    {
        public LongestCommonSubsequence LongestCommonSubsequence { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            LongestCommonSubsequence = new LongestCommonSubsequence();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var text1 = "abcde";
            var text2 = "ace";
            var expected = 3;
            var actual = LongestCommonSubsequence.LongestCommonSubsequenceSln(text1, text2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var text1 = "abc";
            var text2 = "abc";
            var expected = 3;
            var actual = LongestCommonSubsequence.LongestCommonSubsequenceSln(text1, text2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var text1 = "abc";
            var text2 = "defe";
            var expected = 0;
            var actual = LongestCommonSubsequence.LongestCommonSubsequenceSln(text1, text2);
            Assert.AreEqual(expected, actual);
        }
    }
}
