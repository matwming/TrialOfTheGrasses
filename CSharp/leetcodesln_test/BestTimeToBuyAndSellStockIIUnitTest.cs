using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class BestTimeToBuyAndSellStockIIUnitTest
    {
        public BestTimeToBuyAndSellStockII BestTimeToBuyAndSellStockII { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            BestTimeToBuyAndSellStockII = new BestTimeToBuyAndSellStockII();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 7, 1, 5, 3, 6, 4 };
            var expected = 7;
            var actual = BestTimeToBuyAndSellStockII.MaxProfit(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            var expected = 4;
            var actual = BestTimeToBuyAndSellStockII.MaxProfit(input);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 7, 6, 4, 3, 1 };
            var expected = 0;
            var actual = BestTimeToBuyAndSellStockII.MaxProfit(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
