using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class RelativeSortArrayUnitTest
    {
        public RelativeSortArray RelativeSortArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            RelativeSortArray = new RelativeSortArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var arr1 = new[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
            var arr2 = new[] { 2, 1, 4, 3, 9, 6 };
            var expected = new[] { 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19 };
            var actual = RelativeSortArray.RelativeSortArraySln(arr1, arr2);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

    }
}
