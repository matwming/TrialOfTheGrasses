using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class Sqrt_x_UnitTest
    {
        public Sqrt_x_ sqrt_x_ { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            sqrt_x_ = new Sqrt_x_();
        }

        [TestMethod, Timeout(20_000)]
        public void Sqrt_x_TestMethod1()
        {
            var input = 4;
            var expected = 2;
            var actual = sqrt_x_.MySqrt(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void Sqrt_x_TestMethod2()
        {
            var input = 8;
            var expected = 2;
            var actual = sqrt_x_.MySqrt(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void Sqrt_x_TestMethod3()
        {
            var input = 1;
            var expected = 1;
            var actual = sqrt_x_.MySqrt(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void Sqrt_x_TestMethod4()
        {
            var input = 0;
            var expected = 0;
            var actual = sqrt_x_.MySqrt(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
