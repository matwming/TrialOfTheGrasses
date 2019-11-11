using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ColoringABorderUnitTest
    {
        public ColoringABorder ColoringABorder { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ColoringABorder = new ColoringABorder();
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod1()
        {
            var grid = new int[2][];
            grid[0] = new int[] { 1, 2, 2 };
            grid[1] = new int[] { 2, 3, 2 };
            int r0 = 0;
            int c0 = 1;
            int color = 3;
            var expected = new int[2][];
            expected[0] = new int[] { 1, 3, 3 };
            expected[1] = new int[] { 2, 3, 3 };
            var actual = ColoringABorder.ColorBorder(grid, r0, c0, color);
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod2()
        {
            var grid = new int[3][];
            grid[0] = new int[] { 1, 1, 1 };
            grid[1] = new int[] { 1, 1, 1 };
            grid[2] = new int[] { 1, 1, 1 };

            int r0 = 1;
            int c0 = 1;
            int color = 2;
            var expected = new int[3][];
            expected[0] = new int[] { 2, 2, 2 };
            expected[1] = new int[] { 2, 1, 2 };
            expected[2] = new int[] { 2, 2, 2 };
            var actual = ColoringABorder.ColorBorder(grid, r0, c0, color);
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod3()
        {
            var grid = new int[2][];
            grid[0] = new int[] { 1, 1 };
            grid[1] = new int[] { 1, 2 };

            int r0 = 0;
            int c0 = 0;
            int color = 3;
            var expected = new int[2][];
            expected[0] = new int[] { 3, 3 };
            expected[1] = new int[] { 3, 2 };
            var actual = ColoringABorder.ColorBorder(grid, r0, c0, color);
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod, Timeout(2_000)]
        public void TestMethod4()
        {
            var grid = new int[3][];
            grid[0] = new int[] { 1, 1, 1, 2, 2 };
            grid[1] = new int[] { 2, 1, 2, 2, 2 };
            grid[2] = new int[] { 1, 1, 2, 2, 1 };

            int r0 = 1;
            int c0 = 0;
            int color = 1;
            var expected = new int[3][];
            expected[0] = new int[] { 1, 1, 1, 2, 2 };
            expected[1] = new int[] { 1, 1, 2, 2, 2 };
            expected[2] = new int[] { 1, 1, 2, 2, 1 };

            var actual = ColoringABorder.ColorBorder(grid, r0, c0, color);
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

        [TestMethod, Timeout(8_000)]
        public void TestMethod5()
        {
            var grid = new int[5][];
            grid[0] = new int[] { 2, 1, 3, 2, 1, 1, 2 };
            grid[1] = new int[] { 1, 2, 3, 1, 2, 1, 2 };
            grid[2] = new int[] { 1, 2, 1, 2, 2, 2, 2 };
            grid[3] = new int[] { 2, 1, 2, 2, 2, 2, 2 };
            grid[4] = new int[] { 2, 3, 3, 3, 2, 1, 2 };

            int r0 = 4;
            int c0 = 4;
            int color = 3;
            var expected = new int[5][];
            expected[0] = new int[] { 2, 1, 3, 2, 1, 1, 3 };
            expected[1] = new int[] { 1, 2, 3, 1, 3, 1, 3 };
            expected[2] = new int[] { 1, 2, 1, 3, 2, 3, 3 };
            expected[3] = new int[] { 2, 1, 3, 3, 2, 3, 3 };
            expected[4] = new int[] { 2, 3, 3, 3, 3, 1, 3 };

            var actual = ColoringABorder.ColorBorder(grid, r0, c0, color);
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }
    }
}