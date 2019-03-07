using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class PascalsTriangleIIUnitTest
    {
        public PascalsTriangleII PascalsTriangleII { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            PascalsTriangleII = new PascalsTriangleII();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = 3;
            var expected = new int[] { 1, 3, 3, 1 };
            var actual = PascalsTriangleII.GetRow(input);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
