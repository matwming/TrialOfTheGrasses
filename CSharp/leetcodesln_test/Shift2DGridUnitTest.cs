using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class Shift2DGridUnitTest
    {
        public Shift2DGrid Shift2DGrid { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            Shift2DGrid = new Shift2DGrid();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var grid = new int[3][];
            var k = 1;
            grid[0] = new int[] { 1, 2, 3 };
            grid[1] = new int[] { 4, 5, 6 };
            grid[2] = new int[] { 7, 8, 9 };

            var expected = new int[3][];
            expected[0] = new int[] { 9, 1, 2 };
            expected[1] = new int[] { 3, 4, 5 };
            expected[2] = new int[] { 6, 7, 8 };
            var actual = Shift2DGrid.ShiftGrid(grid, k);
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
