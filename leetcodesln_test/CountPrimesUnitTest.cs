using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class CountPrimesUnitTest
    {
        public CountPrimes countPrimes { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            countPrimes = new CountPrimes();
        }

        [TestMethod, Timeout(20_000)]
        public void CountPrimesTestMethod1()
        {
            var input = 10;
            var expected = 4;
            var actual = countPrimes.CountPrimesSln(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
