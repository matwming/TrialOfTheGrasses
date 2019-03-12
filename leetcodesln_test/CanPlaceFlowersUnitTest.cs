using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class CanPlaceFlowersUnitTest
    {
        public CanPlaceFlowers CanPlaceFlowers { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            CanPlaceFlowers = new CanPlaceFlowers();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var flowerbed = new int[] { 1, 0, 0, 0, 1 };
            var n = 1;
            var expected = true;
            var actual = CanPlaceFlowers.CanPlaceFlowersSln(flowerbed, n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var flowerbed = new int[] { 1, 0, 0, 0, 1 };
            var n = 2;
            var expected = false;
            var actual = CanPlaceFlowers.CanPlaceFlowersSln(flowerbed, n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var flowerbed = new int[] { 0, 0, 1, 0, 1 };
            var n = 1;
            var expected = true;
            var actual = CanPlaceFlowers.CanPlaceFlowersSln(flowerbed, n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var flowerbed = new int[] { 0, 1, 0 };
            var n = 1;
            var expected = false;
            var actual = CanPlaceFlowers.CanPlaceFlowersSln(flowerbed, n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var flowerbed = new int[] { 1, 0, 0, 0, 1, 0, 0 };
            var n = 2;
            var expected = true;
            var actual = CanPlaceFlowers.CanPlaceFlowersSln(flowerbed, n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod6()
        {
            var flowerbed = new int[] { 0 };
            var n = 1;
            var expected = true;
            var actual = CanPlaceFlowers.CanPlaceFlowersSln(flowerbed, n);
            Assert.AreEqual(expected, actual);
        }
    }
}
