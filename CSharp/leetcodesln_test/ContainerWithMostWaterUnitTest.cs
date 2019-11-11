using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ContainerWithMostWaterUnitTest
    {
        public ContainerWithMostWater ContainerWithMostWater { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ContainerWithMostWater = new ContainerWithMostWater();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var expected = 49;
            var actual = ContainerWithMostWater.MaxArea(input);
            Assert.AreEqual(expected, actual);
        }

    }
}
