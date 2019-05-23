using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class RevealCardsInIncreasingOrderUnitTest
    {
        public RevealCardsInIncreasingOrder RevealCardsInIncreasingOrder { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            RevealCardsInIncreasingOrder = new RevealCardsInIncreasingOrder();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 17, 13, 11, 2, 3, 5, 7 };
            var expected = new int[] { 2, 13, 3, 11, 5, 17, 7 };
            var actual = RevealCardsInIncreasingOrder.DeckRevealedIncreasing(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

    }
}
