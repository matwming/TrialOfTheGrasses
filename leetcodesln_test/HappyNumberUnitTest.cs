using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class HappyNumberUnitTest
    {
        [TestMethod]
        public void HappyNumberTestMethod()
        {
            var happyNumber = new HappyNumber();
            var input1 = 19;
            var expected1 = true;
            var actual1 = happyNumber.IsHappy(input1);
            Assert.AreEqual(expected1, actual1);
        }
    }
}
