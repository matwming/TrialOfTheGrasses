using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MinCostClimbingStairsUnitTest
    {
        [TestMethod]
        public void MinCostClimbingStairsTestMethod()
        {
            MinCostClimbStairs minCostClimbingStairs = new MinCostClimbStairs();
            Assert.AreEqual(15, minCostClimbingStairs.MinCostClimbingStairs(new int[] { 10, 15, 20 }));
            Assert.AreEqual(6, minCostClimbingStairs.MinCostClimbingStairs(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }));
            Assert.AreEqual(2, minCostClimbingStairs.MinCostClimbingStairs(new int[] { 0, 2, 2, 1 }));
        }
    }
}