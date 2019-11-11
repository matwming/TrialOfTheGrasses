using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class LastStoneWeightUnitTest
    {
        public LastStoneWeight LastStoneWeight { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            LastStoneWeight = new LastStoneWeight();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 2, 2 };
            var expected = 0;
            var actual = LastStoneWeight.LastStoneWeightSln(input);
            Assert.AreEqual(expected, actual);
        }

    }
}
