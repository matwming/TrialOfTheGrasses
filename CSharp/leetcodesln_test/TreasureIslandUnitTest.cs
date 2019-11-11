using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class TreasureIslandUnitTest
    {
        public TreasureIsland TreasureIsland { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            TreasureIsland = new TreasureIsland();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var map = new char[4][];
            map[0] = new[] { 'O', 'O', 'O', 'O' };
            map[1] = new[] { 'D', 'O', 'D', 'O' };
            map[2] = new[] { 'O', 'O', 'O', 'O' };
            map[3] = new[] { 'X', 'D', 'D', 'O' };
            var expected = 5;
            var actual = TreasureIsland.ShortestPath(map);
            Assert.AreEqual(expected, actual);
        }
    }
}