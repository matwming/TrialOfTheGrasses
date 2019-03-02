using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class LargestPerimeterTriangleUnitTest
    {
        public LargestPerimeterTriangle LargestPerimeterTriangle { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            LargestPerimeterTriangle = new LargestPerimeterTriangle();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 2, 1, 2 };
            var expected = 5;
            var actual = LargestPerimeterTriangle.LargestPerimeter(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1, 2, 1 };
            var expected = 0;
            var actual = LargestPerimeterTriangle.LargestPerimeter(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 3, 2, 3, 4 };
            var expected = 10;
            var actual = LargestPerimeterTriangle.LargestPerimeter(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new int[] { 3, 6, 2, 3 };
            var expected = 8;
            var actual = LargestPerimeterTriangle.LargestPerimeter(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
