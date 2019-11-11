using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class UncrossedLinesUnitTest
    {
        public UncrossedLines UncrossedLines { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            UncrossedLines = new UncrossedLines();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var A = new int[] { 1, 4, 2 };
            var B = new int[] { 1, 2, 4 };
            var expected = 2;
            var actual = UncrossedLines.MaxUncrossedLines(A, B);
            Assert.AreEqual(expected, actual);
        }

    }
}
