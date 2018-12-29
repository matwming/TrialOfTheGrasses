using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PalindromeNumberUnitTest
    {
        public PalindromeNumber palindromeNumber { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            palindromeNumber = new PalindromeNumber();
        }

        [TestMethod, Timeout(20_000)]
        public void PalindromeNumberTestMethod1()
        {
            var input = 121;
            var expected = true;
            var actual = palindromeNumber.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void PalindromeNumberTestMethod2()
        {
            var input = 0;
            var expected = true;
            var actual = palindromeNumber.IsPalindrome(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
