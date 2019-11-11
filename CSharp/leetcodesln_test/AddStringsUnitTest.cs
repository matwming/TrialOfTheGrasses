using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class AddStringsUnitTest
    {
        [TestMethod]
        public void AddStringsTestMethod()
        {
            AddStrings addStrings = new AddStrings();
            Assert.AreEqual("23", addStrings.AddStringsSln("11", "12"));
            Assert.AreEqual("108", addStrings.AddStringsSln("9", "99"));
        }
    }
}
