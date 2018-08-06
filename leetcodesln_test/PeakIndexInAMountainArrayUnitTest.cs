using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class PeakIndexInAMountainArrayUnitTest
    {
        [TestMethod]
        public void PeakIndexInAMountainArrayTestMethod()
        {
            PeakIndexInAMountainArray peakIndexInAMountainArray = new PeakIndexInAMountainArray();
            var input1 = new int[] { 0, 1, 0 };
            var expected1 = 1;
            Assert.AreEqual(expected1, peakIndexInAMountainArray.PeakIndexInMountainArray(input1));

            var input2 = new int[] { 0, 2, 1, 0 };
            var expected2 = 1;
            Assert.AreEqual(expected2, peakIndexInAMountainArray.PeakIndexInMountainArray(input2));
        }
    }
}
