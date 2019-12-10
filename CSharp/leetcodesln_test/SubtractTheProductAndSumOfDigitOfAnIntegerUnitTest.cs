using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SubtractTheProductAndSumOfDigitOfAnIntegerUnitTest
    {
        public SubtractTheProductAndSumOfDigitOfAnInteger SubtractTheProductAndSumOfDigitOfAnInteger { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SubtractTheProductAndSumOfDigitOfAnInteger = new SubtractTheProductAndSumOfDigitOfAnInteger();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var n = 234;
            var expected = 15;
            var actual = SubtractTheProductAndSumOfDigitOfAnInteger.SubtractProductAndSum(n);
            Assert.AreEqual(expected, actual);
        }

    }
}
