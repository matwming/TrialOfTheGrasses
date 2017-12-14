using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class SelfDividingNumbersUnitTest
    {
        [TestMethod]
        public void SelfDividingNumbersTestMethod()
        {
            SelfDividingNumbers selfDividingNumbers = new SelfDividingNumbers();
            IList<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 };
            //AreEqual method only check equality of the reference, not the contents
            Assert.AreEqual(expected.Count, selfDividingNumbers.SelfDividingNumbersSolution(1,22).Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], selfDividingNumbers.SelfDividingNumbersSolution(1, 22)[i]);
            }
        }
    }
}
