using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class UglyNumberUnitTest
    {
        public UglyNumber uglyNumber { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            uglyNumber = new UglyNumber();
        }

        [TestMethod, Timeout(20_000)]
        public void UglyNumberTestMethod1()
        {
            var input = 6;
            var expected = true;
            var actual = uglyNumber.IsUgly(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void UglyNumberTestMethod2()
        {
            var input = 8;
            var expected = true;
            var actual = uglyNumber.IsUgly(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void UglyNumberTestMethod3()
        {
            var input = 14;
            var expected = false;
            var actual = uglyNumber.IsUgly(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void UglyNumberTestMethod4()
        {
            var input = 0;
            var expected = false;
            var actual = uglyNumber.IsUgly(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
