using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class WordPatternUnitTest
    {
        public WordPattern WordPattern { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            WordPattern = new WordPattern();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var pattern = "abba";
            var str = "dog cat cat dog";
            Assert.IsTrue(WordPattern.WordPatternSln(pattern, str));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var pattern = "abba";
            var str = "dog cat cat fish";
            Assert.IsFalse(WordPattern.WordPatternSln(pattern, str));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var pattern = "aaaa";
            var str = "dog cat cat dog";
            Assert.IsFalse(WordPattern.WordPatternSln(pattern, str));
        }


        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var pattern = "abba";
            var str = "dog dog dog dog";
            Assert.IsFalse(WordPattern.WordPatternSln(pattern, str));
        }
    }
}
