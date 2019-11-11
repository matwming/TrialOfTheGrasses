using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class FindPivotIndexUnitTest
    {
        public FindPivotIndex findPivotIndex { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            findPivotIndex = new FindPivotIndex();
        }

        [TestMethod, Timeout(20_000)]
        public void FindPivotIndexTestMethod1()
        {
            var input = new int[] { 1, 7, 3, 6, 5, 6 };
            var expected = 3;
            var actual = findPivotIndex.PivotIndex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void FindPivotIndexTestMethod2()
        {
            var input = new int[] { 1, 2, 3 };
            var expected = -1;
            var actual = findPivotIndex.PivotIndex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void FindPivotIndexTestMethod3()
        {
            var input = new int[] { -1, -1, -1, -1, -1, -1 };
            var expected = -1;
            var actual = findPivotIndex.PivotIndex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void FindPivotIndexTestMethod4()
        {
            var input = new int[] { -1, -1, -1, 0, 1, 1 };
            var expected = 0;
            var actual = findPivotIndex.PivotIndex(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
