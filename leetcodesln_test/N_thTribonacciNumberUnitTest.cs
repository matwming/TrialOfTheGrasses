using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class N_thTribonacciNumberUnitTest
    {
        public N_thTribonacciNumber N_thTribonacciNumber { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            N_thTribonacciNumber = new N_thTribonacciNumber();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = 4;
            var expected = 4;
            var actual = N_thTribonacciNumber.Tribonacci(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = 25;
            var expected = 1389537;
            var actual = N_thTribonacciNumber.Tribonacci(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
