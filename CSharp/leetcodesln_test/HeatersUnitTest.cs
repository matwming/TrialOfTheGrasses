using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class HeatersUnitTest
    {
        public Heaters Heaters { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            Heaters = new Heaters();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var houses = new int[] { 1, 2, 3 };
            var heaters = new int[] { 2 };
            var expected = 1;
            var actual = Heaters.FindRadius(houses, heaters);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var houses = new int[] { 1, 2, 3, 4 };
            var heaters = new int[] { 1, 4 };
            var expected = 1;
            var actual = Heaters.FindRadius(houses, heaters);
            Assert.AreEqual(expected, actual);
        }
    }
}