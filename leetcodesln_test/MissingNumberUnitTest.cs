using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class MissingNumberUnitTest
    {
        [TestMethod]
        public void MissingNumberTestMethod()
        {
            MissingNumber missingNumber = new MissingNumber();
            var input1 = new int[] {3,0,1};
            var expected1 = 2;
            Assert.AreEqual(expected1, missingNumber.FindMissingNumber(input1));
        }
    }
}
