using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MaxAreaOfIslandUnitTest {
        [TestMethod]
        public void MaxAreaOfIslandSlnTestMethod() {
            MaxAreaOfIsland maxAreaOfIsland = new MaxAreaOfIsland();
            Assert.AreEqual(0,maxAreaOfIsland.MaxAreaOfIslandSln(new int[,] {{0,0,0,0,0,0,0,0}}));
        }
    }
       
    
}