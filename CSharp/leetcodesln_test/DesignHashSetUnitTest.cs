using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class DesignHashSetUnitTest
    {
        [TestMethod]
        public void DesignHashSetTestMethod()
        {
            var myHashSet = new DesignHashSet();
            myHashSet.Add(1);
            myHashSet.Add(2);
            var expected1 = myHashSet.Contains(1);
            Assert.AreEqual(true, expected1);
            var expected2 = myHashSet.Contains(3);
            Assert.AreEqual(false, expected2);
            myHashSet.Add(2);
            var expected3 = myHashSet.Contains(2);
            Assert.AreEqual(true, expected3);
            myHashSet.Remove(2);
            var expected4 = myHashSet.Contains(2);
            Assert.AreEqual(false, expected4);
        }
    }
}
