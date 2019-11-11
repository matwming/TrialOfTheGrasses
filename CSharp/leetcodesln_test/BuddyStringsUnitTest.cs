using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class BuddyStringsUnitTest
    {
        public BuddyStrings BuddyStrings { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            BuddyStrings = new BuddyStrings();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var A = "ab";
            var B = "ba";
            var expected = true;
            var actual = BuddyStrings.BuddyStringsSln(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var A = "ab";
            var B = "ab";
            var expected = false;
            var actual = BuddyStrings.BuddyStringsSln(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var A = "aa";
            var B = "aa";
            var expected = true;
            var actual = BuddyStrings.BuddyStringsSln(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var A = "aaaaaaabc";
            var B = "aaaaaaacb";
            var expected = true;
            var actual = BuddyStrings.BuddyStringsSln(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var A = "";
            var B = "aa";
            var expected = false;
            var actual = BuddyStrings.BuddyStringsSln(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod6()
        {
            var A = "abcd";
            var B = "badc";
            var expected = false;
            var actual = BuddyStrings.BuddyStringsSln(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod7()
        {
            var A = "abcaa";
            var B = "abcbb";
            var expected = false;
            var actual = BuddyStrings.BuddyStringsSln(A, B);
            Assert.AreEqual(expected, actual);
        }
    }
}