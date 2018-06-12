using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class Base7UnitTest
    {
        [TestMethod]
        public void Base7TestMethod()
        {
            Base7 base7 = new Base7();
            string expected = "202";
            string actual = base7.ConvertToBase7(100);
            Assert.AreEqual(expected, actual);
            string expected2 = "-10";
            string actual2 = base7.ConvertToBase7(-7);
            Assert.AreEqual(expected2, actual2);
            string expected3 = "150666342";
            string actual3 = base7.ConvertToBase7(9999999);
            Assert.AreEqual(expected3, actual3);
        }
    }
}
