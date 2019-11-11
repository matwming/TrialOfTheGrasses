using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class RotatedDigitsUnitTest
    {
        [TestMethod]
        public void RotatedDigitsTestMethod()
        {
            RotatedDigits rotatedDigits = new RotatedDigits();
            int expected = 4;
            int actual = rotatedDigits.RotatedDigitsSln(10);
            Assert.AreEqual(expected, actual);

            int expected2 = 0;
            int actual2 = rotatedDigits.RotatedDigitsSln(1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
