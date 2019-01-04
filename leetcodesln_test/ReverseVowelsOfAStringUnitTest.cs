using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ReverseVowelsOfAStringUnitTest
    {
        public ReverseVowelsOfAString reverseVowelsOfAString { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            reverseVowelsOfAString = new ReverseVowelsOfAString();
        }

        [TestMethod, Timeout(20_000)]
        public void ReverseVowelsOfAStringTestMethod1()
        {
            var input = "hello";
            var expected = "holle";
            var actual = reverseVowelsOfAString.ReverseVowels(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void ReverseVowelsOfAStringTestMethod2()
        {
            var input = "leetcode";
            var expected = "leotcede";
            var actual = reverseVowelsOfAString.ReverseVowels(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void ReverseVowelsOfAStringTestMethod3()
        {
            var input = "a";
            var expected = "a";
            var actual = reverseVowelsOfAString.ReverseVowels(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void ReverseVowelsOfAStringTestMethod4()
        {
            var input = "a.";
            var expected = "a.";
            var actual = reverseVowelsOfAString.ReverseVowels(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void ReverseVowelsOfAStringTestMethod5()
        {
            var input = "aA";
            var expected = "Aa";
            var actual = reverseVowelsOfAString.ReverseVowels(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
