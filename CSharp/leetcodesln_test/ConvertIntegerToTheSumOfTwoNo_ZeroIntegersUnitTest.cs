using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ConvertIntegerToTheSumOfTwoNo_ZeroIntegersUnitTest
    {
        public ConvertIntegerToTheSumOfTwoNo_ZeroIntegers ConvertIntegerToTheSumOfTwoNo_ZeroIntegers { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ConvertIntegerToTheSumOfTwoNo_ZeroIntegers = new ConvertIntegerToTheSumOfTwoNo_ZeroIntegers();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = 2;
            var expected = new[] { 1, 1 };
            var actual = ConvertIntegerToTheSumOfTwoNo_ZeroIntegers.GetNoZeroIntegers(input);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = 11;
            var expected = new[] { 2, 9 };
            var actual = ConvertIntegerToTheSumOfTwoNo_ZeroIntegers.GetNoZeroIntegers(input);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = 1010;
            var expected = new[] { 11, 999 };
            var actual = ConvertIntegerToTheSumOfTwoNo_ZeroIntegers.GetNoZeroIntegers(input);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }
    }
}
