using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class ToLowerCaseUnitTest
    {
        [TestMethod]
        public void ToLowerCaseTestMethod()
        {
            ToLowerCase toLowerCase = new ToLowerCase();
            var expected1 = "hello";
            var input1 = "Hello";
            Assert.AreEqual(expected1, toLowerCase.ToLower(input1));

            var expected2 = "here";
            var input2 = "here";
            Assert.AreEqual(expected2, toLowerCase.ToLower(input2));

            var expected3 = "lovely";
            var input3 = "LOVELY";
            Assert.AreEqual(expected3, toLowerCase.ToLower(input3));
        }
    }
}
