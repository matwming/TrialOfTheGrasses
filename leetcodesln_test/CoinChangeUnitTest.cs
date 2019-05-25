using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class CoinChangeUnitTest
    {
        public CoinChange CoinChange { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            CoinChange = new CoinChange();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var amount = 11;
            var coins = new int[] { 1, 2, 5 };
            var expected = 3;
            var actual = CoinChange.Change(amount, coins);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var amount = 3;
            var coins = new int[] { 2};
            var expected = -1;
            var actual = CoinChange.Change(amount, coins);
            Assert.AreEqual(expected, actual);
        }

    }
}
