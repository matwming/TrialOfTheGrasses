using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FlowerPlantingWithNoAdjacentUnitTest
    {
        public FlowerPlantingWithNoAdjacent FlowerPlantingWithNoAdjacent { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FlowerPlantingWithNoAdjacent = new FlowerPlantingWithNoAdjacent();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            int N = 3;
            int[][] paths = new int[3][];
            paths[0] = new int[] { 1, 2 };
            paths[1] = new int[] { 2, 3 };
            paths[2] = new int[] { 3, 1 };
            var expected = new int[] { 1, 2, 3 };
            var actual = FlowerPlantingWithNoAdjacent.GardenNoAdj(N, paths);
            Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected, actual));
        }

    }
}
