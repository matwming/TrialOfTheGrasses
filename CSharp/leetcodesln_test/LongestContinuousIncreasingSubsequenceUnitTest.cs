using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class LongestContinuousIncreasingSubsequenceUnitTest
    {
        [TestMethod]
        public void LongestContinuousIncreasingSubsequenceTestMethod()
        {
            var longestContinuousIncreasingSubsequence = new LongestContinuousIncreasingSubsequence();
            var input1 = new int[] { 1, 3, 5, 4, 7 };
            var expected1 = 3;
            var actual1 = longestContinuousIncreasingSubsequence.FindLengthOfLCIS(input1);
            Assert.AreEqual(expected1, actual1);

            var input2 = new int[] { 2,2,2,2,2 };
            var expected2 = 1;
            var actual2 = longestContinuousIncreasingSubsequence.FindLengthOfLCIS(input2);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
