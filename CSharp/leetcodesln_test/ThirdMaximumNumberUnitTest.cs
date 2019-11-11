using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ThirdMaximumNumberUnitTest
    {
        public ThirdMaximumNumber ThirdMaximumNumber { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ThirdMaximumNumber = new ThirdMaximumNumber();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 3, 2, 1 };
            var expected = 1;
            var actual = ThirdMaximumNumber.ThirdMax(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1, 2 };
            var expected = 2;
            var actual = ThirdMaximumNumber.ThirdMax(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 2, 2, 3, 1 };
            var expected = 1;
            var actual = ThirdMaximumNumber.ThirdMax(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new int[] { 5, 2, 2 };
            var expected = 5;
            var actual = ThirdMaximumNumber.ThirdMax(input);
            Assert.AreEqual(expected, actual);
        }
    }
}