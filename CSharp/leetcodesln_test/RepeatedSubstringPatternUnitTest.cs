using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class RepeatedSubstringPatternUnitTest
    {
        public RepeatedSubstringPattern repeatedSubstringPattern { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            repeatedSubstringPattern = new RepeatedSubstringPattern();
        }

        [TestMethod, Timeout(20_000)]
        public void RepeatedSubstringPatternTestMethod1()
        {
            var input = "abab";
            var expected = true;
            var actual = repeatedSubstringPattern.RepeatedSubstringPatternSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void RepeatedSubstringPatternTestMethod2()
        {
            var input = "aba";
            var expected = false;
            var actual = repeatedSubstringPattern.RepeatedSubstringPatternSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void RepeatedSubstringPatternTestMethod3()
        {
            var input = "abcabcabcabc";
            var expected = true;
            var actual = repeatedSubstringPattern.RepeatedSubstringPatternSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void RepeatedSubstringPatternTestMethod4()
        {
            var input = "bb";
            var expected = true;
            var actual = repeatedSubstringPattern.RepeatedSubstringPatternSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void RepeatedSubstringPatternTestMethod5()
        {
            var input = "abac";
            var expected = false;
            var actual = repeatedSubstringPattern.RepeatedSubstringPatternSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void RepeatedSubstringPatternTestMethod6()
        {
            var input = "ababab";
            var expected = true;
            var actual = repeatedSubstringPattern.RepeatedSubstringPatternSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void RepeatedSubstringPatternTestMethod7()
        {
            var input = "babbabbabbabbab";
            var expected = true;
            var actual = repeatedSubstringPattern.RepeatedSubstringPatternSln(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
