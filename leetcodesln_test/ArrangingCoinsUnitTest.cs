using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ArrangingCoinsUnitTest
    {
        public ArrangingCoins ArrangingCoins { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ArrangingCoins = new ArrangingCoins();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var n = 5;
            var expected = 2;
            var actual = ArrangingCoins.ArrangeCoins(n);
            Assert.AreEqual(expected, actual);
        }

    }

}