using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class LongestHarmoniousSubsequenceUnitTest
    {
        [TestMethod]
        public void LongestHarmoniousSubsequenceTestMethod()
        {
            var longestHarmoniousSubsequence = new LongestHarmoniousSubsequence();
            var input1 = new int[] { 1, 3, 2, 2, 5, 2, 3, 7 };
            var expected1 = 5;
            var actual1 = longestHarmoniousSubsequence.FindLHS(input1);
            Assert.AreEqual(expected1, actual1);

            var input2 = new int[] { 1, 1, 1, 1 };
            var expected2 = 0;
            var actual2 = longestHarmoniousSubsequence.FindLHS(input2);
            Assert.AreEqual(expected2, actual2);

            var input3 = new int[] {2, 2, 2, 2, 2, 2, 2, 3, 1, 0, 0, 0, 3, 1, -1, 0, 1, 1, 0, 0, 1, 1, 2, 2, 2, 0, 1, 2, 2, 3, 2 };
            var expected3 = 20;
            var actual3 = longestHarmoniousSubsequence.FindLHS(input3);
            Assert.AreEqual(expected3, actual3);

            var input4 = new int[] { 1, 2, 1, 3, 0, 0, 2, 2, 1, 3, 3 };
            var expected4 = 6;
            var actual4 = longestHarmoniousSubsequence.FindLHS(input4);
            Assert.AreEqual(expected4, actual4);
        }
    }
}
