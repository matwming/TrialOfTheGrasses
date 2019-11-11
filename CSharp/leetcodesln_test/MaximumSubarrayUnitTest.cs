using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class MaximumSubarrayUnitTest
    {
        public MaximumSubarray maximumSubarray { get; set; }
        [TestInitialize]
        public void BeforeEach()
        {
           maximumSubarray = new MaximumSubarray();
        }



        [TestMethod, Timeout(10_000)]
        public void MaximumSubarrayTestMethod1()
        {
            var input = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var expected = 6;
            var actual = maximumSubarray.MaxSubArray(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(10_000)]
        public void MaximumSubarrayTestMethod2()
        {
            var input = new int[] { -2, -1 };
            var expected = -1;
            var actual = maximumSubarray.MaxSubArray(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(10_000)]
        public void MaximumSubarrayTestMethod3()
        {
            var input = new int[] { -1, -2 };
            var expected = -1;
            var actual = maximumSubarray.MaxSubArray(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
