using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class HeightCheckerUnitTest
    {
        public HeightChecker HeightChecker { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            HeightChecker = new HeightChecker();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 1, 1, 4, 2, 1, 3 };
            var expected = 3;
            var actual = HeightChecker.HeightCheckerSln(input);
            Assert.AreEqual(expected, actual);
        }

    }
}
