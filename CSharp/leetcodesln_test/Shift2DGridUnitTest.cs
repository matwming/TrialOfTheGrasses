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
            var actual = Shift2DGrid.ShiftGrid(grid, k);
        }

    }
}
