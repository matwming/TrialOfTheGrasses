using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class XOfAKindInADeckOfCardsUnitTest
    {
        public XOfAKindInADeckOfCards XOfAKindInADeckOfCards { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            XOfAKindInADeckOfCards = new XOfAKindInADeckOfCards();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 1, 2, 3, 4, 4, 3, 2, 1 };
            var expected = true;
            var actual = XOfAKindInADeckOfCards.HasGroupSizeX(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1, 1, 1, 2, 2, 2, 3, 3 };
            var expected = false;
            var actual = XOfAKindInADeckOfCards.HasGroupSizeX(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 1 };
            var expected = false;
            var actual = XOfAKindInADeckOfCards.HasGroupSizeX(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new int[] { 1, 1 };
            var expected = true;
            var actual = XOfAKindInADeckOfCards.HasGroupSizeX(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod5()
        {
            var input = new int[] { 1, 1, 2, 2, 2, 2 };
            var expected = true;
            var actual = XOfAKindInADeckOfCards.HasGroupSizeX(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
