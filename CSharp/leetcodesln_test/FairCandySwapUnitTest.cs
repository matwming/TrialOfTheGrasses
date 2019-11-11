using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class FairCandySwapUnitTest
    {
        [TestMethod]
        public void FairCandySwapTestMethod()
        {
            var fairCandySwap = new FairCandySwap();
            var inputA1 = new int[] { 1, 1 };
            var inputB1 = new int[] { 2, 2 };
            var expected1 = new int[] { 1, 2 };
            var actual1 = fairCandySwap.FairSwap(inputA1, inputB1);
            foreach (var exp in expected1)
            {
                Assert.IsTrue(actual1.Contains(exp));
            }

            var inputA2 = new int[] { 1, 2 };
            var inputB2 = new int[] { 2, 3 };
            var expected2 = new int[] { 1, 2 };
            var actual2 = fairCandySwap.FairSwap(inputA2, inputB2);
            foreach (var exp in expected2)
            {
                Assert.IsTrue(actual2.Contains(exp));
            }
        }
    }
}
