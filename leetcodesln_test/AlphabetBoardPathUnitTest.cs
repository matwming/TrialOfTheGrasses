using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class AlphabetBoardPathUnitTest
    {
        public AlphabetBoardPath AlphabetBoardPath { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            AlphabetBoardPath = new AlphabetBoardPath();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = "leet";
            var expected = "DDR!UURRR!!DDD!";
            var actual = AlphabetBoardPath.AlphabetBoardPathSln(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = "p";
            var expected = "DDD!";
            var actual = AlphabetBoardPath.AlphabetBoardPathSln(input);
            Assert.AreEqual(expected, actual);
        }


        //the last row has only one char 
        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = "zdz";
            var expected = "DDDDD!UUUUURRR!DDDDLLLD!";
            var actual = AlphabetBoardPath.AlphabetBoardPathSln(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
