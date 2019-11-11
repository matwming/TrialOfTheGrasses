using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class SortArrayByParityIIUnitTest
    {
        [TestMethod]
        public void SortArrayByParityIITestMethod()
        {
            SortArrayByParityII sortArrayByParityII = new SortArrayByParityII();
            var input = new int[] { 4,2,5,7};
            var expected = new int[] {4,5,2,7};
            var actual = sortArrayByParityII.SortArrayByParityIISln(input);
            for (int i = 0; i < input.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
