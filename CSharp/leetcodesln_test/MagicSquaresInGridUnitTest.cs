using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MagicSquaresInGridUnitTest
    {
        public MagicSquaresInGrid MagicSquaresInGrid { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MagicSquaresInGrid = new MagicSquaresInGrid();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[3][];
            input[0] = new int[] { 4, 3, 8, 4 };
            input[1] = new int[] { 9, 5, 1, 9 };
            input[2] = new int[] { 2, 7, 6, 2 };
            var expected = 1;
            int actual = MagicSquaresInGrid.NumMagicSquaresInside(input);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[3][];
            input[0] = new int[] { 5, 5, 5 };
            input[1] = new int[] { 5, 5, 5 };
            input[2] = new int[] { 5, 5, 5 };
            var expected = 0;
            int actual = MagicSquaresInGrid.NumMagicSquaresInside(input);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[3][];
            input[0] = new int[] { 10, 3, 5 };
            input[1] = new int[] { 1, 6, 11 };
            input[2] = new int[] { 7, 9, 2 };
            var expected = 0;
            int actual = MagicSquaresInGrid.NumMagicSquaresInside(input);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new int[3][];
            input[0] = new int[] { 1, 8, 6 };
            input[1] = new int[] { 10, 5, 0 };
            input[2] = new int[] { 4, 2, 9 };
            var expected = 0;
            int actual = MagicSquaresInGrid.NumMagicSquaresInside(input);
            Assert.AreEqual(expected, actual);

        }
    }
}
