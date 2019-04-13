using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class RottingOrangesUnitTest
    {
        public RottingOranges RottingOranges { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            RottingOranges = new RottingOranges();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[3][];
            input[0] = new int[] { 2, 1, 1 };
            input[1] = new int[] { 1, 1, 0 };
            input[2] = new int[] { 0, 1, 1 };
            var expected = 4;
            var actual = RottingOranges.OrangesRotting(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[3][];
            input[0] = new int[] { 2, 1, 1 };
            input[1] = new int[] { 0, 1, 1 };
            input[2] = new int[] { 1, 0, 1 };
            var expected = -1;
            var actual = RottingOranges.OrangesRotting(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[1][];
            input[0] = new int[] { 0, 1 };
            var expected = -1;
            var actual = RottingOranges.OrangesRotting(input);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new int[1][];
            input[0] = new int[] { 0 };
            var expected = 0;
            var actual = RottingOranges.OrangesRotting(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var input = new int[1][];
            input[0] = new int[] { 0,2,2 };
            var expected = 0;
            var actual = RottingOranges.OrangesRotting(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod6()
        {
            var input = new int[4][];
            input[0] = new int[] { 1 };
            input[1] = new int[] { 2 };
            input[2] = new int[] { 1 };
            input[3] = new int[] { 2 };

            var expected = 1;
            var actual = RottingOranges.OrangesRotting(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
