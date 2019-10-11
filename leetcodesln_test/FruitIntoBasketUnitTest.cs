using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FruitIntoBasketUnitTest
    {
        public FruitIntoBaskets FruitIntoBaskets { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FruitIntoBaskets = new FruitIntoBaskets();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new[] { 1, 0, 3, 4, 3 };
            var expected = 3;
            var actual = FruitIntoBaskets.TotalFruit(nums);
            Assert.AreEqual(expected, actual);
        }

    }
}
