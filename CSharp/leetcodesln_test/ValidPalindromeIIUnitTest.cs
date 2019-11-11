using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ValidPalindromeIIUnitTest
    {
        public ValidPalindromeII validPalindromeII { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            validPalindromeII = new ValidPalindromeII();
        }

        [TestMethod]
        public void ValidPalindromeII1()
        {
            var input = "aba";
            var expected = true;
            var actual = validPalindromeII.ValidPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidPalindromeII2()
        {
            var input = "abca";
            var expected = true;
            var actual = validPalindromeII.ValidPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidPalindromeII3()
        {
            var input = "aabdeenddbaagbddeedbaa";
            var expected = false;
            var actual = validPalindromeII.ValidPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidPalindromeII4()
        {
            var input = "eedede";
            var expected = true;
            var actual = validPalindromeII.ValidPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidPalindromeII5()
        {
            var input = "aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga";
            var expected = true;
            var actual = validPalindromeII.ValidPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidPalindromeII6()
        {
            var input = "acjakebdccdeedccdbeaca";
            var expected = false;
            var actual = validPalindromeII.ValidPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
