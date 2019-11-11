using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ValidPerfectSquareUnitTest
    {
        public ValidPerfectSquare validPerfectSquare { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            validPerfectSquare = new ValidPerfectSquare();
        }

        [TestMethod, Timeout(20_000)]
        public void ValidPerfectSquareTestMethod1()
        {
            var input = 16;
            var expected = true;
            var actual = validPerfectSquare.IsPerfectSquare(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void ValidPerfectSquareTestMethod2()
        {
            var input = 14;
            var expected = false;
            var actual = validPerfectSquare.IsPerfectSquare(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void ValidPerfectSquareTestMethod3()
        {
            var input = 1;
            var expected = true;
            var actual = validPerfectSquare.IsPerfectSquare(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void ValidPerfectSquareTestMethod4()
        {
            var input = 5;
            var expected = false;
            var actual = validPerfectSquare.IsPerfectSquare(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
