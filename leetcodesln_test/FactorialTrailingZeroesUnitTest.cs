using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FactorialTrailingZeroesUnitTest
    {
        public FactorialTrailingZeroes FactorialTrailingZeroes { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FactorialTrailingZeroes = new FactorialTrailingZeroes();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var n = 3;
            var expected = 0;
            var actual = FactorialTrailingZeroes.TrailingZeroes(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var n = 5;
            var expected = 1;
            var actual = FactorialTrailingZeroes.TrailingZeroes(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var n = 10;
            var expected = 2;
            var actual = FactorialTrailingZeroes.TrailingZeroes(n);
            Assert.AreEqual(expected, actual);
        }
    }
}