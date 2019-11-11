using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class CircularArrayLoopUnitTest
    {
        public CircularArrayLoop CircularArrayLoop { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            CircularArrayLoop = new CircularArrayLoop();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new[] { -1, 2 };
            var expected = false;
            var actual = CircularArrayLoop.CircularArrayLoopSln(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var nums = new[] { -2, -3, -9 };
            var expected = false;
            var actual = CircularArrayLoop.CircularArrayLoopSln(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var nums = new[] { -2, -17, -1, -2, -2 };
            var expected = true;
            var actual = CircularArrayLoop.CircularArrayLoopSln(nums);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var nums = new[] { -1 };
            var expected = false;
            var actual = CircularArrayLoop.CircularArrayLoopSln(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
