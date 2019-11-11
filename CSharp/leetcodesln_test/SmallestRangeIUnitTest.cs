using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class SmallestRangeIUnitTest
    {
        [TestMethod]
        public void SmallestRangeITestMethod()
        {
            var smallestRangeI = new SmallestRangeI();
            var input1_array = new int[] { 0, 10 };
            var input1_K = 2;
            var expected1 = 6;
            var actual1 = smallestRangeI.FindSmallestRangeI(input1_array, input1_K);
            Assert.AreEqual(expected1, actual1);

            var input2_array = new int[] { 1 };
            var input2_K = 0;
            var expected2 = 0;
            var actual2 = smallestRangeI.FindSmallestRangeI(input2_array, input2_K);
            Assert.AreEqual(expected2, actual2);

            var input3_array = new int[] { 1,3,6 };
            var input3_K = 3;
            var expected3 = 0;
            var actual3 = smallestRangeI.FindSmallestRangeI(input3_array, input3_K);
            Assert.AreEqual(expected3, actual3);

            var input4_array = new int[] { 2,7,2 };
            var input4_K = 1;
            var expected4 = 3;
            var actual4 = smallestRangeI.FindSmallestRangeI(input4_array, input4_K);
            Assert.AreEqual(expected4, actual4);
        }
    }
}
