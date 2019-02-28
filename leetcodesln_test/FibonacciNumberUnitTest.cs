using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FibonacciNumberUnitTest
    {
        public FibonacciNumber FibonacciNumber { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FibonacciNumber = new FibonacciNumber();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var n = 2;
            var expected = 1;
            var actual = FibonacciNumber.Fib(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var n = 4;
            var expected = 3;
            var actual = FibonacciNumber.Fib(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var n = 1;
            var expected = 1;
            var actual = FibonacciNumber.Fib(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var n = 0;
            var expected = 0;
            var actual = FibonacciNumber.Fib(n);
            Assert.AreEqual(expected, actual);
        }
    }
}