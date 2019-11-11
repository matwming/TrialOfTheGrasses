using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SumOfSquareNumbersUnitTest
    {
        public SumOfSquareNumbers sumOfSquareNumbers { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            sumOfSquareNumbers = new SumOfSquareNumbers();
        }

        [TestMethod, Timeout(20_000)]
        public void SumOfSquareNumbersTestMethod1()
        {
            var input = 5;
            var expected = true;
            var actual = sumOfSquareNumbers.JudgeSquareSum(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void SumOfSquareNumbersTestMethod2()
        {
            var input = 3;
            var expected = false;
            var actual = sumOfSquareNumbers.JudgeSquareSum(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void SumOfSquareNumbersTestMethod3()
        {
            var input = 10_000_000;
            var expected = true;
            var actual = sumOfSquareNumbers.JudgeSquareSum(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
