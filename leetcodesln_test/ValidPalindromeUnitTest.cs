using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ValidPalindromeUnitTest
    {
        public ValidPalindrome validPalindrome { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            validPalindrome = new ValidPalindrome();
        }

        [TestMethod]
        public void ValidPalindromeTestMethod1()
        {
            var input = "A man, a plan, a canal: Panama";
            var expected = true;
            var actual = validPalindrome.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidPalindromeTestMethod2()
        {
            var input = "race a car";
            var expected = false;
            var actual = validPalindrome.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidPalindromeTestMethod3()
        {
            var input = string.Empty;
            var expected = true;
            var actual = validPalindrome.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidPalindromeTestMethod4()
        {
            var input = "A!!!!!";
            var expected = true;
            var actual = validPalindrome.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidPalindromeTestMethod5()
        {
            var input = ".,";
            var expected = true;
            var actual = validPalindrome.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidPalindromeTestMethod6()
        {
            var input = "0P";
            var expected = false;
            var actual = validPalindrome.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
