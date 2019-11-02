using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class LongestCommonPrefixUnitTest
    {
        public LongestCommonPrefix LongestCommonPrefix { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            LongestCommonPrefix = new LongestCommonPrefix();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new string[] { "flower", "flow", "flight" };
            var expected = "fl";
            var actual = LongestCommonPrefix.LongestCommonPrefixSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new string[] { "dog", "racecar", "car" };
            var expected = string.Empty;
            var actual = LongestCommonPrefix.LongestCommonPrefixSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new string[] { };
            var expected = string.Empty;
            var actual = LongestCommonPrefix.LongestCommonPrefixSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new string[] { "a" };
            var expected = "a";
            var actual = LongestCommonPrefix.LongestCommonPrefixSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var input = new string[] { "c", "c" };
            var expected = "c";
            var actual = LongestCommonPrefix.LongestCommonPrefixSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod6()
        {
            var input = new string[] { "c", "c" };
            var expected = "c";
            var actual = LongestCommonPrefix.LongestCommonPrefixOptimal(input);
            Assert.AreEqual(expected, actual);
        }
 
    }
}
