using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class LengthOfLastWordUnitTest
    {
        public LengthOfLastWord LengthOfLastWord { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            LengthOfLastWord = new LengthOfLastWord();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = "Hello world";
            var expected = 5;
            var actual = LengthOfLastWord.LengthOfLastWordSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = "";
            var expected = 0;
            var actual = LengthOfLastWord.LengthOfLastWordSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = "a";
            var expected = 1;
            var actual = LengthOfLastWord.LengthOfLastWordSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = "hello world   ";
            var expected = 5;
            var actual = LengthOfLastWord.LengthOfLastWordSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var input = "  hello world";
            var expected = 5;
            var actual = LengthOfLastWord.LengthOfLastWordSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod6()
        {
            var input = "hello   world";
            var expected = 5;
            var actual = LengthOfLastWord.LengthOfLastWordSln(input);
            Assert.AreEqual(expected, actual);
        }
    }
}