using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class BestTimeToBuyAndSellStockUnitTest
    {
        [TestMethod]
        public void BestTimeToBuyAndSellStockTestMethod()
        {
            var bestTimeToBuyAndSellStock = new BestTimeToBuyAndSellStock();
            var input1 = new int[] {7,1,5,3,6,4};
            var expected1 = 5;
            var actual1 = bestTimeToBuyAndSellStock.MaxProfit(input1);
            Assert.AreEqual(expected1, actual1);

            var input2 = new int[] {7,6,4,3,1};
            var expected2 = 0;
            var actual2 = bestTimeToBuyAndSellStock.MaxProfit(input2);
            Assert.AreEqual(expected2, actual2);
        }
    }
}