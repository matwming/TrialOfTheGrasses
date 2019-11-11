using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class ClimbingStairsUnitTest
    {
        [TestMethod]
        public void ClimbingStairsTestMethod()
        {
            var climbingStairs = new ClimbingStairs();
            var input1 = 2;
            var expected1 = 2;
            var actual1 = climbingStairs.ClimbStairs(input1);
            Assert.AreEqual(expected1, actual1);

            var input2 = 3;
            var expected2 = 3;
            var actual2 = climbingStairs.ClimbStairs(input2);
            Assert.AreEqual(expected2, actual2);

            var input3 = 4;
            var expected3 = 5;
            var actual3 = climbingStairs.ClimbStairs(input3);
            Assert.AreEqual(expected3, actual3);
        }
    }
}
